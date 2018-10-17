Public Class FrmPlayTTT

    ' <=== Defining variables ===>

    Dim GameBoard(,) As Short = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
    Dim PlayerTurn As Boolean = True ' True = O, False = X
    Dim GameInProgress As Boolean = False
    Dim TurnNumber As Integer = 0
    Dim Player1Name As String = "Player 1"
    Dim Player2Name As String = "Player 2"


    Private Sub ParseCommandLineArgs()

        If ModOpeningFiles.LoadedReplayAlready = False Then
            Dim Arguments As String() = Environment.GetCommandLineArgs()
            ModOpeningFiles.LoadedReplayAlready = True

            Try
                ' MsgBox(Arguments(1))
                If Arguments(1).Split(".")(Arguments(1).Split(".").Count() - 1) = "T3Replay" Then
                    MsgBox("Loading replayer...", , "SUCCESS")
                    FrmReplayViewer.Show()
                    FrmReplayViewer.OnStartWithFile(Arguments(1))
                    Me.Close()
                Else
                    MsgBox("Not a '*.T3Replay' file", , "FAILURE")
                End If
            Catch ERR As Exception
                If Not (TypeOf ERR Is IndexOutOfRangeException) Then
                    MsgBox("Something went wrong..." & ERR.ToString(), , "FAILURE")
                    MsgBox("Loading game window for safety", , "FAILURE")
                    If Application.OpenForms().OfType(Of FrmReplayViewer).Any Then
                        Me.Show()
                        FrmReplayViewer.Close()
                    End If
                End If
            End Try
        End If

    End Sub
    '
    Private Sub FrmPlayTTT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ParseCommandLineArgs()


        If My.Settings.SaveFolder = "" Then My.Settings.SaveFolder = Application.StartupPath
        PnlGameControls.Enabled = True
        PnlGameButtons.Enabled = False
        LblLastMove.Text = "Last Move: N/A"
        LblLastMove.ForeColor = Color.Black
        ResetGameGrid()
        PnlInfo.Enabled = False
        BtnEndGame.Enabled = False
        TurnNumber = 0
    End Sub

    ' <=== Control buttons ===>

    ''' <summary>
    ''' Starts the game.
    ''' </summary>
    Private Sub StartGameButtons_Click(sender As Object, e As EventArgs) Handles BtnStartGame.Click, NewGameToolStripMenuItem.Click, CntxtNewGameItem.Click
        ' Check if a game is currently being played
        If GameInProgress = True Then
            Dim Choice As Integer = MsgBox("Are you sure you want to end the game?", MsgBoxStyle.YesNo, "Game in progress!")
            If Choice <> 6 Then
                ' Continue the game
                Exit Sub
            End If
            ' Complain about their life choices
            If PlayerTurn = True Then
                MsgBox("I'm very disappointed in you, " & Player1Name)
            Else
                MsgBox("I'm very disappointed in you, " & Player2Name)
            End If
        End If

        If Player1Name = "Player 1" And Player2Name = "Player 2" Then
            GetPlayerNames()
        End If

        PnlGameButtons.Enabled = True
        PnlInfo.Enabled = True
        BtnEndGame.Enabled = True
        ResetPlayerTurn()
        BtnStartGame.Enabled = False

        GameBoard = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
        ResetGameGrid()
        'CheckGrid()
        ModSavingFiles.ResetFileSettings()
        GameInProgress = True
        TurnNumber = 0

        If My.Settings.CrossesGoFirst = True Then
            MsgBox("Game begun. It's O's turn!")
        Else
            MsgBox("Game begun. It's X's turn!")
        End If
    End Sub

    ''' <summary>
    ''' Allows players to re-enter their names
    ''' </summary>
    Private Sub BtnChangeNames_Click(sender As Object, e As EventArgs) Handles BtnChangeNames.Click, CntxtChangeNamesItem.Click
        GetPlayerNames()
    End Sub

    ''' <summary>
    ''' Memed
    ''' </summary>
    Private Sub GetHelpOnlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpOnlineToolStripMenuItem.Click
        MsgBox("There is no one to help you online. Sorry", MsgBoxStyle.OkOnly, "HAHAHAHAHAHAHAHAHAHA")
    End Sub

    ''' <summary>
    ''' Shows Help
    ''' </summary>
    Private Sub GetHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpToolStripMenuItem.Click, CntxtHelpItem.Click
        FrmHelp.Show()
    End Sub

    ''' <summary>
    ''' Allows for setting changes
    ''' </summary>
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click, CntxtSettingsItem.Click
        FrmSettings.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Ends the game, but isn't happy with it
    ''' </summary>
    Private Sub BtnEndGame_Click(sender As Object, e As EventArgs) Handles BtnEndGame.Click, CntxtEndGameItem.Click
        Dim Choice As Integer = MsgBox("Are you sure you want to end the game?", MsgBoxStyle.YesNo, "Game in progress!")
        If Choice <> 6 Then
            ' Continue the game
            Exit Sub
        End If
        ' Complain!
        If PlayerTurn = True Then
            MsgBox("I'm very disappointed in you, " & Player1Name)
        Else
            MsgBox("I'm very disappointed in you, " & Player2Name)
        End If

        GameBoard = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
        GameInProgress = False

        PnlGameButtons.Enabled = False
        PnlInfo.Enabled = False
        ResetPlayerTurn()
        BtnEndGame.Enabled = False
        BtnStartGame.Enabled = True
        ResetGameGrid()
        ModSavingFiles.ResetFileSettings()
        TurnNumber = 0
    End Sub

    ''' <summary>
    ''' Opens the replay viewer and closes the game
    ''' </summary>
    Private Sub LoadPreviousGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadPreviousGameToolStripMenuItem.Click
        FrmReplayViewer.Show()
        Me.Close()
    End Sub

    ' <=== Non-Button based Subs / Functions ===>

    ''' <summary>
    ''' Asks the players for their names. Is purely for prettiness and doesn't affect gameplay. 10Char limit.
    ''' </summary>
    Private Sub GetPlayerNames()
        ' Player 1's name
        Dim Flag As Boolean = False
        While Flag = False
            Player1Name = InputBox("O's name?", "Player Names", Player1Name)
            If Len(Player1Name) > 10 Then
                MsgBox(Player1Name & " is too long. Please use a name that is 10 characters or less", MsgBoxStyle.OkOnly, "LENGTH TOO GREAT")
                Flag = False
            ElseIf Player1Name = "" Then
                Player1Name = "Player 1"
                Flag = True
            Else
                LblNameO.Text = Player1Name & " - O"
                Flag = True
            End If
        End While
        ' Player 2's name
        Flag = False
        While Flag = False
            Player2Name = InputBox("X's name?", "Player Names", Player2Name)
            If Len(Player2Name) > 10 Then
                MsgBox(Player2Name & " is too long. Please use a name that is 10 characters or less", MsgBoxStyle.OkOnly, "LENGTH TOO GREAT")
                Flag = False
            ElseIf Player2Name = "" Then
                Player2Name = "Player 2"
                Flag = True
            Else
                LblNameX.Text = Player2Name & " - X"
                Flag = True
            End If
        End While
    End Sub

    ''' <summary>
    ''' Checks if anyone has won yet
    ''' </summary>
    Private Sub CheckForVictory()
        ' If a diagonal, row or column add to 3, O wins
        ' If a diagonal, row or column add to 30, X wins
        Dim Total As Integer = 0
        Dim Winner As String = "None"

        ' \/ Checks verticals
        For Looper1 = 0 To 2
            Total = 0
            For Looper2 = 0 To 2
                Total += GameBoard(Looper1, Looper2)
            Next

            If Total = 3 Then ' O wins
                Winner = "O"
            ElseIf Total = 27 Then ' X wins
                Winner = "X"
            End If
        Next

        ' \/ Checks horizontals
        For Looper2 = 0 To 2
            Total = 0
            For Looper1 = 0 To 2
                Total += GameBoard(Looper1, Looper2)
            Next

            If Total = 3 Then ' O wins
                Winner = "O"
            ElseIf Total = 27 Then ' X wins
                Winner = "X"
            End If
        Next

        ' \/ Checks diagonals
        If (GameBoard(0, 0) + GameBoard(1, 1) + GameBoard(2, 2)) = 3 Or _
            (GameBoard(2, 0) + GameBoard(1, 1) + GameBoard(0, 2)) = 3 Then ' O wins
            Winner = "O"

        ElseIf (GameBoard(0, 0) + GameBoard(1, 1) + GameBoard(2, 2)) = 27 Or _
            (GameBoard(2, 0) + GameBoard(1, 1) + GameBoard(0, 2)) = 27 Then ' X wins
            Winner = "X"
        End If


        ' \/ evaluates the result
        If Winner = "O" Then
            'Debug.WriteLine(Player1Name.ToUpper & " WINS")
            LblLastMove.Text = "O Wins!"
            LblLastMove.ForeColor = Color.DarkBlue
            MsgBox(Player1Name & " is the winner!" & Environment.NewLine & "Congratulations!!!", MsgBoxStyle.OkOnly, Player1Name.ToUpper & " WINS")

            EndGameAfterVictoryOrDraw()
        ElseIf Winner = "X" Then
            'Debug.WriteLine(Player2Name.ToUpper & " WINS")
            LblLastMove.Text = "X Wins!"
            LblLastMove.ForeColor = Color.Maroon
            MsgBox(Player2Name & " is the winner!" & Environment.NewLine & "Congratulations!!!", MsgBoxStyle.OkOnly, Player2Name.ToUpper & " WINS")

            EndGameAfterVictoryOrDraw()
        Else
            ' Check for a draw
            If (GameBoard(0, 0) <> 0) And (GameBoard(0, 1) <> 0) And (GameBoard(0, 2) <> 0) And _
                (GameBoard(1, 0) <> 0) And (GameBoard(1, 1) <> 0) And (GameBoard(1, 2) <> 0) And _
                (GameBoard(2, 0) <> 0) And (GameBoard(2, 1) <> 0) And (GameBoard(2, 2) <> 0) Then
                ' It's a draw!
                'Debug.WriteLine("IT'S A DRAW")
                LblLastMove.Text = "It's a draw!"
                LblLastMove.ForeColor = Color.Black
                MsgBox(Player1Name & " and " & Player2Name & " drew.", MsgBoxStyle.OkOnly, "Maybe another time...")

                EndGameAfterVictoryOrDraw()
            Else
                'Debug.WriteLine("Normal move")
            End If
        End If

    End Sub

    ''' <summary>
    ''' Saves the game just played and resets the gameboard after the game is fully completed
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EndGameAfterVictoryOrDraw()
        ModSavingFiles.CreateNewReplaySave()
        ModSavingFiles.ResetFileSettings()
        GameInProgress = False
        PnlGameButtons.Enabled = False
        PnlInfo.Enabled = False
        GameBoard = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
        BtnStartGame.Enabled = True
        BtnEndGame.Enabled = False
        ResetPlayerTurn()
        TurnNumber = 0
    End Sub

    ''' <summary>
    ''' Resets all the buttons to their default states
    ''' </summary>
    Private Sub ResetGameGrid()
        Btn00.Text = ""
        Btn00.ForeColor = Color.Black
        Btn01.Text = ""
        Btn01.ForeColor = Color.Black
        Btn02.Text = ""
        Btn02.ForeColor = Color.Black
        Btn10.Text = ""
        Btn10.ForeColor = Color.Black
        Btn11.Text = ""
        Btn11.ForeColor = Color.Black
        Btn12.Text = ""
        Btn12.ForeColor = Color.Black
        Btn20.Text = ""
        Btn20.ForeColor = Color.Black
        Btn21.Text = ""
        Btn21.ForeColor = Color.Black
        Btn22.Text = ""
        Btn22.ForeColor = Color.Black
    End Sub

    ''' <summary>
    ''' Writes the current values of the game grid to the console for debugging purposes
    ''' </summary>
    'Private Sub CheckGrid()
    '    Debug.WriteLine("_____________")
    '    Debug.WriteLine("|{0,3}|{1,3}|{2,3}|", GameBoard(0, 0), GameBoard(1, 0), GameBoard(2, 0))
    '    Debug.WriteLine("|-----------|")
    '    Debug.WriteLine("|{0,3}|{1,3}|{2,3}|", GameBoard(0, 1), GameBoard(1, 1), GameBoard(2, 1))
    '    Debug.WriteLine("|-----------|")
    '    Debug.WriteLine("|{0,3}|{1,3}|{2,3}|" & Environment.NewLine, GameBoard(0, 2), GameBoard(1, 2), GameBoard(2, 2))
    'End Sub

    ''' <summary>
    ''' Changes the text _colour_ of the button and LblLastMove to reflect which player has chosen what
    ''' </summary>
    ''' <param name="Sender">The object that called the sub</param>
    Private Sub ChangeColour(ByRef Sender As Object)
        If Sender.Text = "O" Then
            ' Make it Blue (0, 0, 139)
            LblLastMove.ForeColor = Color.DarkBlue
            Sender.ForeColor = Color.DarkBlue
            LblPlayerTurn.ForeColor = Color.Maroon
        ElseIf Sender.Text = "X" Then
            ' Make it Red (128, 0, 0)

            LblLastMove.ForeColor = Color.Maroon
            Sender.ForeColor = Color.Maroon
            LblPlayerTurn.ForeColor = Color.DarkBlue
        Else
            LblLastMove.ForeColor = Color.Black
            Sender.ForeColor = Color.Black
            LblPlayerTurn.ForeColor = Color.Black
        End If
    End Sub

    ''' <summary>
    ''' Resets the game to the correct turn
    ''' </summary>
    Private Sub ResetPlayerTurn()
        If My.Settings.CrossesGoFirst Then
            PlayerTurn = True

            LblPlayerTurn.Text = "O's turn"
            LblPlayerTurn.ForeColor = Color.DarkBlue
        Else
            PlayerTurn = False

            LblPlayerTurn.Text = "X's turn"
            LblPlayerTurn.ForeColor = Color.Maroon
        End If
        LblLastMove.Text = "Last Move: N/A"
        LblLastMove.ForeColor = Color.Black
    End Sub

    ' <=== Grid Button Subs ===>
    ' << On Click >>
    ''' <summary>
    ''' Changes the relevant grid square to reflect the move just made, then checks for a winner
    ''' </summary>
    Private Sub Btn00_Click(sender As Object, e As EventArgs) Handles Btn00.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(0, 0) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 0,0"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(0, 0) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 0,0"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn10_Click(sender As Object, e As EventArgs) Handles Btn10.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(1, 0) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 1,0"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(1, 0) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 1,0"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles Btn20.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(2, 0) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 2,0"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(2, 0) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 2,0"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn01_Click(sender As Object, e As EventArgs) Handles Btn01.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(0, 1) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 0,1"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(0, 1) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 0,1"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn11_Click(sender As Object, e As EventArgs) Handles Btn11.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(1, 1) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 1,1"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(1, 1) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 1,1"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn21_Click(sender As Object, e As EventArgs) Handles Btn21.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(2, 1) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 2,1"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(2, 1) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 2,1"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn02_Click(sender As Object, e As EventArgs) Handles Btn02.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(0, 2) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 0,2"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(0, 2) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 0,2"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn12_Click(sender As Object, e As EventArgs) Handles Btn12.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(1, 2) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 1,2"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(1, 2) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 1,2"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub

    Private Sub Btn22_Click(sender As Object, e As EventArgs) Handles Btn22.Click
        If sender.Text = "O" Or sender.Text = "X" Then
            MsgBox("This box has already been filled. You can't re-fill it", MsgBoxStyle.OkOnly, "Already played here")
        Else
            If PlayerTurn = True Then ' O's go
                GameBoard(2, 2) = 1
                sender.Text = "O"
                LblLastMove.Text = "O: 2,2"
                PlayerTurn = False
                LblPlayerTurn.Text = "X's turn"
            Else ' X's go
                GameBoard(2, 2) = 9
                sender.Text = "X"
                LblLastMove.Text = "X: 2,2"
                PlayerTurn = True
                LblPlayerTurn.Text = "O's turn"
            End If
            TurnNumber += 1
            ModSavingFiles.AddNewTurnRecord(GameBoard, TurnNumber, Not (PlayerTurn))
            ChangeColour(sender)
            'CheckGrid()
            CheckForVictory()
        End If
    End Sub


    ' << On Mouse Over >>
    ''' <summary>
    ''' Changes the contents of the button to {X} or {O} when the mouse goes over an empty button
    ''' </summary>
    ''' <param name="sender">The button that called the event</param>
    Private Sub GridButtons_MouseEnter(sender As Object, e As EventArgs) Handles Btn00.MouseEnter, Btn10.MouseEnter, Btn20.MouseEnter, Btn01.MouseEnter, _
        Btn11.MouseEnter, Btn21.MouseEnter, Btn02.MouseEnter, Btn12.MouseEnter, Btn22.MouseEnter
        If GameInProgress = True Then
            If sender.Text = "O" Or sender.Text = "X" Then
            Else
                If PlayerTurn = True Then
                    sender.Text = "{O}"
                    sender.ForeColor = Color.FromArgb(17, 150, 157)
                Else
                    sender.Text = "{X}"
                    sender.ForeColor = Color.Salmon
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Emptys the {X} or {O} from the button that the mouse left
    ''' </summary>
    ''' <param name="sender">The button that called the event</param>
    Private Sub GridButtons_MouseLeave(sender As Object, e As EventArgs) Handles Btn00.MouseLeave, Btn10.MouseLeave, Btn20.MouseLeave, Btn01.MouseLeave, _
        Btn11.MouseLeave, Btn21.MouseLeave, Btn02.MouseLeave, Btn12.MouseLeave, Btn22.MouseLeave
        If GameInProgress = True Then
            If sender.Text = "O" Or sender.Text = "X" Then
            Else
                sender.Text = ""
                sender.ForeColor = Color.Black
            End If
        End If
    End Sub

    ' <=== ===>
    ''' <summary>
    ''' When a key is pressed...
    ''' </summary>
    ''' <param name="E">The details of the key event that called the function</param>
    Private Sub ArrowKey_Press(Sender As Object, E As KeyEventArgs) Handles Me.KeyDown
        Select Case E.KeyCode
            Case Keys.F1
                FrmHelp.Show()

        End Select
    End Sub

    Private Overloads Sub OnDragOver(Sender As Object, DragDetails As DragEventArgs) Handles Me.DragOver
        If DragDetails.Data.GetDataPresent(DataFormats.FileDrop) Then
            DragDetails.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Overloads Sub OnDragDrop(Sender As Object, Details As DragEventArgs) Handles Me.DragDrop
        FrmReplayViewer.Show()
        FrmReplayViewer.OnDragDrop(Sender, Details)
        Me.Close()
    End Sub

    Private Sub OnRightClick(Sender As Object, Details As MouseEventArgs) Handles Me.MouseClick
        ' Right click
        If Details.Button = Windows.Forms.MouseButtons.Right Then
            CntxtMenuPlayGame.AutoClose = True
            CntxtMenuPlayGame.Show(Control.MousePosition)
        End If
    End Sub

End Class
