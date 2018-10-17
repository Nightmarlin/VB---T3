Public Class FrmReplayViewer

    Dim ReplayDetails As List(Of GameBoardState) = Nothing
    Dim ActiveTurn As Short = 1

    ''' <summary>
    ''' Prepares for user input
    ''' </summary>
    Private Sub FrmReplayViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeWindow(False)
        PnlGameButtons.Enabled = False
        PnlGameBoard.BackColor = Color.FromKnownColor(KnownColor.Control)
        TxtFilePath.Text = ""
    End Sub

    ''' <summary>
    ''' Get gaming
    ''' </summary>
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        FrmPlayTTT.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Allows for setting changing
    ''' </summary>
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        FrmSettings.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Memed
    ''' </summary>
    Private Sub GetHelpOnlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpOnlineToolStripMenuItem.Click
        MsgBox("There is no one to help you online. Sorry", MsgBoxStyle.OkOnly, "HAHAHAHAHAHAHAHAHAHA")
    End Sub

    ''' <summary>
    ''' Gives help
    ''' </summary>
    Private Sub GetHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpToolStripMenuItem.Click
        FrmHelp.Show()
    End Sub

    ''' <summary>
    ''' Loads a replay from a [x].T3Replay file
    ''' </summary>
    ''' <param name="sender">The object that called the sub</param>
    ''' <param name="e">The event that the sub was called with</param>
    Private Sub LoadPreviousGame_Click(sender As Object, e As EventArgs) Handles BtnLoadPreviousReplay.Click, LoadPreviousGameToolStripMenuItem.Click
        Dim FilePath As String = ModOpeningFiles.OpenReplayFilePath()
        If FilePath = "ERROR: No file chosen" Then
            MsgBox(FilePath, MsgBoxStyle.OkOnly, "FAILURE")
            FileChosen(False)
            PnlGameButtons.Enabled = False
        ElseIf FilePath = "ERROR: File version out of date" Then
            MsgBox(FilePath, MsgBoxStyle.OkOnly, "FAILURE")
            FileChosen(False)
            PnlGameButtons.Enabled = False
        Else
            ReplayDetails = ModOpeningFiles.ParseTextFile(FilePath)
            Dim Failed As Boolean = False
            For Each Element In ReplayDetails
                If Element.GameBoardLine = "ERROR" Then
                    MsgBox("ERROR: Corrupted file")
                    FileChosen(False)
                    Failed = True
                End If
            Next
            If Failed = False Then
                FileChosen(True)
                PnlGameButtons.Enabled = True
                BtnNextMove.Enabled = True
                BtnToLastMove.Enabled = True
                ActiveTurn = 1
                EvaluateBoard()
            End If
            End If
            BtnPrevMove.Enabled = False
            BtnToFirstMove.Enabled = False
    End Sub

    ''' <summary>
    ''' Prepares the game board for replays
    ''' </summary>
    ''' <param name="ReadyOrNot">Whether or not we are ready to look at a replay</param>
    Public Sub FileChosen(ByVal ReadyOrNot As Boolean)
        ResizeWindow(ReadyOrNot)
        If ReadyOrNot = True Then
            PnlGameButtons.Enabled = True
            PnlGameBoard.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption)
            TrBrMoves.Maximum = ReplayDetails.Count - 1
            TrBrMoves.Value = 0
            TrBrMoves.Refresh()
            PnlGameBoard.Refresh()
            DrawGridLines()
        Else
            ReplayDetails = Nothing
            LblTotalTurns.Text = 0
            TxtFilePath.Text = ""
            PnlGameBoard.BackColor = Color.FromKnownColor(KnownColor.Control)
            PnlGameButtons.Enabled = False
            PnlGameBoard.Refresh()
        End If

    End Sub

    ''' <summary>
    ''' Draws the lines onto the blank grid
    ''' </summary>
    Private Sub DrawGridLines()
        Dim PanelGraphics As Graphics = PnlGameBoard.CreateGraphics()
        Dim Pen As System.Drawing.Pen = Pens.Black

        ' Vericals
        Dim XLine1 As Integer = 86
        Dim XLine2 As Integer = 173
        Dim XLine3 As Integer = 0
        Dim XLine4 As Integer = 260

        Dim Y1Verts As Integer = 0
        Dim Y2Verts As Integer = 260

        PanelGraphics.DrawLine(Pen, XLine1, Y1Verts, XLine1, Y2Verts)
        PanelGraphics.DrawLine(Pen, XLine2, Y1Verts, XLine2, Y2Verts)
        PanelGraphics.DrawLine(Pen, XLine3, Y1Verts, XLine3, Y2Verts)
        PanelGraphics.DrawLine(Pen, XLine4, Y1Verts, XLine4, Y2Verts)

        ' Horizontals
        Dim YLine1 As Integer = 86
        Dim YLine2 As Integer = 173
        Dim YLine3 As Integer = 0
        Dim YLine4 As Integer = 260

        Dim X1Horis As Integer = 0
        Dim X2Horis As Integer = 260

        PanelGraphics.DrawLine(Pen, X1Horis, YLine1, X2Horis, YLine1)
        PanelGraphics.DrawLine(Pen, X1Horis, YLine2, X2Horis, YLine2)
        PanelGraphics.DrawLine(Pen, X1Horis, YLine3, X2Horis, YLine3)
        PanelGraphics.DrawLine(Pen, X1Horis, YLine4, X2Horis, YLine4)


        PanelGraphics.Dispose()
    End Sub

    ''' <summary>
    ''' Resizes the window cos prettiness
    ''' </summary>
    ''' <param name="ReadyOrNot">Whether or not a file has been successfully selected</param>
    Private Sub ResizeWindow(ByVal ReadyOrNot As Boolean)
        If ReadyOrNot = True Then
            Me.MaximumSize = New System.Drawing.Size(300, 476)
            Me.Size = Me.MaximumSize
            Me.MinimumSize = Me.MaximumSize
        Else
            Me.MinimumSize = New System.Drawing.Size(300, 95)
            Me.Size = Me.MinimumSize
            Me.MaximumSize = Me.MinimumSize
        End If
    End Sub

    ' <=== ===>
    ''' <summary>
    ''' Changes the current turn being viewed
    ''' </summary>
    Private Sub BtnToFirstMove_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles BtnToFirstMove.Click
        ActiveTurn = 1
        BtnToFirstMove.Enabled = False
        BtnPrevMove.Enabled = False
        BtnNextMove.Enabled = True
        BtnToLastMove.Enabled = True
        EvaluateBoard()
    End Sub

    ''' <summary>
    ''' Changes the current turn being viewed
    ''' </summary>
    Private Sub BtnPrevMove_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles BtnPrevMove.Click
        ActiveTurn -= 1
        If ActiveTurn = 1 Then
            BtnToFirstMove.Enabled = False
            BtnPrevMove.Enabled = False
        End If

        If ActiveTurn < ReplayDetails.Count Then
            BtnNextMove.Enabled = True
            BtnToLastMove.Enabled = True
        End If
        EvaluateBoard()
    End Sub

    ''' <summary>
    ''' Changes the current turn being viewed
    ''' </summary>
    Private Sub BtnNextMove_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles BtnNextMove.Click
        ActiveTurn += 1
        If ActiveTurn = ReplayDetails.Count Then
            BtnNextMove.Enabled = False
            BtnToLastMove.Enabled = False
        End If

        If ActiveTurn > 1 Then
            BtnToFirstMove.Enabled = True
            BtnPrevMove.Enabled = True
        End If
        EvaluateBoard()
    End Sub

    ''' <summary>
    ''' Changes the current turn being viewed
    ''' </summary>
    Private Sub BtnToLastMove_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles BtnToLastMove.Click
        ActiveTurn = ReplayDetails.Count
        BtnToLastMove.Enabled = False
        BtnNextMove.Enabled = False
        BtnToFirstMove.Enabled = True
        BtnPrevMove.Enabled = True
        EvaluateBoard()
    End Sub

    ' <=== ===>
    ''' <summary>
    ''' Loop through the replaydetails array and evaluate which postion should go where
    ''' </summary>
    Private Sub EvaluateBoard()
        LblTurnNumber.Text = CStr(ActiveTurn)
        TrBrMoves.Value = ActiveTurn - 1
        PnlGameBoard.Refresh()
        DrawGridLines()

        For Looper = 0 To 8
            Dim X As Integer
            Dim Y As Integer
            ' <=======
            Select Case Looper
                Case 0
                    ' 0, 0
                    X = 2
                    Y = 2

                Case 1
                    ' 0, 1
                    X = 2
                    Y = 88
                Case 2
                    ' 0, 2
                    X = 2
                    Y = 175
                Case 3
                    ' 1, 0
                    X = 88
                    Y = 2
                Case 4
                    ' 1, 1
                    X = 88
                    Y = 88
                Case 5
                    ' 1, 2
                    X = 88
                    Y = 175
                Case 6
                    ' 2, 0
                    X = 175
                    Y = 2
                Case 7
                    ' 2, 1
                    X = 175
                    Y = 88
                Case Else
                    ' 2, 2
                    X = 175
                    Y = 175
            End Select
            ' <=======

            LblTotalTurns.Text = ReplayDetails.Count
            If ReplayDetails(ActiveTurn - 1).BoardArray(Looper) = "1" Then
                DrawNought(X, Y)
            ElseIf ReplayDetails(ActiveTurn - 1).BoardArray(Looper) = "9" Then
                DrawCross(X, Y)
            End If



        Next
    End Sub

    ''' <summary>
    ''' Draw a nought at the given coordinates
    ''' </summary>
    ''' <param name="X">The X Coordinate</param>
    ''' <param name="Y">The Y coordinate</param>
    Private Sub DrawNought(ByVal X As Integer, ByVal Y As Integer)
        Dim PanelGraphics As Graphics = PnlGameBoard.CreateGraphics()
        Dim Pen As New System.Drawing.Pen(Brushes.DarkBlue)
        Pen.Color = Color.DarkBlue
        Pen.Width = 3

        PanelGraphics.DrawEllipse(Pen, New Rectangle(X, Y, 83, 83))


        PanelGraphics.Dispose()
    End Sub

    ''' <summary>
    ''' Draw a cross at the given coordinates
    ''' </summary>
    ''' <param name="X">the X coordinate</param>
    ''' <param name="Y">The Y coordinate</param>
    Private Sub DrawCross(ByVal X As Integer, ByVal Y As Integer)
        Dim PanelGraphics As Graphics = PnlGameBoard.CreateGraphics()
        Dim Pen As New System.Drawing.Pen(Brushes.Maroon)
        Pen.Color = Color.Maroon
        Pen.Width = 3

        PanelGraphics.DrawLine(Pen, X, Y, (X + 82), (Y + 82))
        PanelGraphics.DrawLine(Pen, (X + 82), Y, X, (Y + 82))

        PanelGraphics.Dispose()
    End Sub

    ''' <summary>
    ''' When keys are pressed, do stuff
    ''' </summary>
    ''' <param name="Sender">The object that sent the key references</param>
    ''' <param name="E">the details of the keypress</param>
    Private Sub ArrowKey_Press(Sender As Object, E As KeyEventArgs) Handles Me.KeyDown
        Select Case E.KeyCode
            Case Keys.F1
                FrmHelp.Show()
            Case Keys.F5
                Try
                    Dim EmptyBoard As New GameBoardState With {.GameBoardLine = ""}
                    If ReplayDetails(3).BoardArray = EmptyBoard.BoardArray Then
                    Else
                        PnlGameBoard.Refresh()
                        EvaluateBoard()
                    End If
                Catch ERR As Exception
                    ' Do nothing
                End Try

            Case Keys.D
                If BtnNextMove.Enabled = True Then
                    BtnNextMove_Click()
                End If
            Case Keys.A
                If BtnPrevMove.Enabled = True Then
                    BtnPrevMove_Click()
                End If
            Case Keys.S
                If BtnToFirstMove.Enabled = True Then
                    BtnToFirstMove_Click()
                End If
            Case Keys.W
                If BtnToLastMove.Enabled = True Then
                    BtnToLastMove_Click()
                End If

            Case Keys.D1
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 1) Then
                        ActiveTurn = 1
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = False
                        BtnToFirstMove.Enabled = False
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If
            Case Keys.D2
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 2) Then
                        ActiveTurn = 2
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If
            Case Keys.D3
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 3) Then
                        ActiveTurn = 3
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If
            Case Keys.D4
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 4) Then
                        ActiveTurn = 4
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If
            Case Keys.D5
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 5) Then
                        ActiveTurn = 5
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 5 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                        EvaluateBoard()
                    End If
                End If
            Case Keys.D6
                    If (ReplayDetails IsNot Nothing) Then
                        If (ReplayDetails.Count >= 6) Then
                        ActiveTurn = 6
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 6 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                            EvaluateBoard()
                        End If
                    End If
            Case Keys.D7
                    If (ReplayDetails IsNot Nothing) Then
                        If (ReplayDetails.Count >= 7) Then
                        ActiveTurn = 7
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 7 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                            EvaluateBoard()
                        End If
                    End If
            Case Keys.D8
                    If (ReplayDetails IsNot Nothing) Then
                        If (ReplayDetails.Count >= 8) Then
                        ActiveTurn = 8
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 8 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                            EvaluateBoard()
                        End If
                    End If
            Case Keys.D9
                    If (ReplayDetails IsNot Nothing) Then
                        If (ReplayDetails.Count >= 9) Then
                        ActiveTurn = 9
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 9 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                            EvaluateBoard()
                        End If
                    End If

        End Select
    End Sub

    ''' <summary>
    ''' Change the mouse icon when files are dragged over so people know they can be released here
    ''' </summary>
    ''' <param name="Sender">The object that sent the data</param>
    ''' <param name="DragDetails">The information about the drag</param>
    Private Overloads Sub OnDragOver(Sender As Object, DragDetails As DragEventArgs) Handles Me.DragEnter
        If DragDetails.Data.GetDataPresent(DataFormats.FileDrop) Then
            DragDetails.Effect = DragDropEffects.Copy
        End If
    End Sub

    ''' <summary>
    ''' When a file is dragged over the form
    ''' </summary>
    ''' <param name="Sender">The object that sent the data</param>
    ''' <param name="DragDetails">The deets of teh drag ting</param>
    Public Overloads Sub OnDragDrop(Sender As Object, DragDetails As DragEventArgs) Handles Me.DragDrop
        Dim FilePaths() As String = DragDetails.Data.GetData(DataFormats.FileDrop)
        If FilePaths(0).Split(".")(FilePaths.Count) = "T3Replay" Then
            FileChosen(True)
            ReplayDetails = ModOpeningFiles.ParseTextFile(FilePaths(0))
            Dim Failed As Boolean = False
            For Each Element In ReplayDetails
                If Element.GameBoardLine = "ERROR" Then
                    FileChosen(False)
                    MsgBox("ERROR: Corrupted file")
                    Failed = True
                    Exit Sub
                End If
            Next
            If Failed = False Then
                PnlGameButtons.Enabled = True
                BtnNextMove.Enabled = True
                BtnToLastMove.Enabled = True
                ActiveTurn = 1
                BtnPrevMove.Enabled = False
                BtnToFirstMove.Enabled = False
                TxtFilePath.Text = FilePaths(0)
                EvaluateBoard()
            End If
        Else
            MsgBox("Not Accepted: File type not supported. Please use a '*.T3Replay' file")
        End If
    End Sub

    ''' <summary>
    ''' When a file is dragged onto the "T3.exe" file, prepare to replay it
    ''' </summary>
    ''' <param name="FilePath">The file path of the [first] file dragged onto the "T3.exe" file</param>
    Public Sub OnStartWithFile(FilePath)
        ReplayDetails = ModOpeningFiles.ParseTextFile(FilePath)
        FileChosen(True)
        For Each Element In ReplayDetails
            If Element.GameBoardLine = "ERROR" Then
                FileChosen(False)
                MsgBox("ERROR: Corrupted file")
                Exit Sub
            End If
        Next
        PnlGameButtons.Enabled = True
        BtnNextMove.Enabled = True
        BtnToLastMove.Enabled = True
        ActiveTurn = 1
        BtnPrevMove.Enabled = False
        BtnToFirstMove.Enabled = False
        TxtFilePath.Text = FilePath
        EvaluateBoard()
    End Sub

    Private Sub TrBrMoves_Scroll(sender As Object, e As EventArgs) Handles TrBrMoves.Scroll
        Select Case TrBrMoves.Value
            Case 0
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 1) Then
                        ActiveTurn = 1
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = False
                        BtnToFirstMove.Enabled = False
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If

            Case 1
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 2) Then
                        ActiveTurn = 2
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If
            Case 2
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 3) Then
                        ActiveTurn = 3
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If
            Case 3
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 4) Then
                        ActiveTurn = 4
                        BtnNextMove.Enabled = True
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        BtnToLastMove.Enabled = True
                        EvaluateBoard()
                    End If
                End If
            Case 4
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 5) Then
                        ActiveTurn = 5
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 5 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                        EvaluateBoard()
                    End If
                End If
            Case 5
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 6) Then
                        ActiveTurn = 6
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 6 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                        EvaluateBoard()
                    End If
                End If
            Case 6
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 7) Then
                        ActiveTurn = 7
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 7 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                        EvaluateBoard()
                    End If
                End If
            Case 7
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 8) Then
                        ActiveTurn = 8
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 8 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                        EvaluateBoard()
                    End If
                End If
            Case 8
                If (ReplayDetails IsNot Nothing) Then
                    If (ReplayDetails.Count >= 9) Then
                        ActiveTurn = 9
                        BtnPrevMove.Enabled = True
                        BtnToFirstMove.Enabled = True
                        If ReplayDetails.Count = 9 Then
                            BtnNextMove.Enabled = False
                            BtnToLastMove.Enabled = False
                        Else : BtnNextMove.Enabled = True : BtnToLastMove.Enabled = True
                        End If
                        EvaluateBoard()
                    End If
                End If

        End Select
    End Sub
End Class