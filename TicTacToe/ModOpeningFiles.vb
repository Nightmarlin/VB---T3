''' <summary>
''' A nice easy way of accessing the gamedata for each turn
''' </summary>
Public Class GameBoardState
    Implements IEquatable(Of GameBoardState)

    ' <== A line in the .T3Replay file ==>
    Private GameBoardContent As String = ""
    ''' <summary>
    ''' Allows for the setting and getting of the gameboard value
    ''' </summary>
    ''' <value>POTATOES</value>
    ''' <returns>The raw game board state</returns>
    Public Property GameBoardLine As String
        Get
            If GameBoardContent = "" Then
                Return "EMPTY"
            Else
                Return GameBoardContent
            End If
        End Get

        Set(value As String)
            If Len(value) <> 16 And Len(value) <> 17 Then GameBoardContent = "ERROR" : Exit Property
            If Len(value.Split("|")(0)) <> 9 Then GameBoardContent = "ERROR" : Exit Property
            If Len(value.Split("|")(1)) <> 1 Then GameBoardContent = "ERROR" : Exit Property
            Dim Failed As Boolean = True
            For Looper = 1 To 9
                If value.Split("|")(1) = CStr(Looper) Then Failed = False
            Next
            If Failed = True Then GameBoardContent = "ERROR" : Exit Property
            If value.Split("|")(2) <> "True" And value.Split("|")(2) <> "False" Then GameBoardContent = "ERROR" : Exit Property
            GameBoardContent = value
        End Set
    End Property
    ' <==  ==>

    ' <== The contents of the board after the turn ==>
    ''' <summary>
    ''' Finds and returns the board after the turn
    ''' </summary>
    ''' <value>The contents of the board in form "111999000"</value>
    ''' <returns>The contents of the board in form "111999000"</returns>
    Public ReadOnly Property BoardArray As String
        Get
            If GameBoardContent = "ERROR" Then
                Return "ERROR"
            End If
            Dim TempGameBoard As String = GameBoardContent
            Dim FoundBoard As String() = TempGameBoard.Split("|")
            Dim PenultiBoard As String = FoundBoard(0)
            Dim FinalBoard As String = ""
            For X = 0 To (Len(PenultiBoard) - 1) Step 1
                FinalBoard &= CStr(PenultiBoard(X))
            Next
            Return FinalBoard
        End Get
    End Property
    ' <==  ==>

    ' <==  ==>
    ''' <summary>
    ''' Gets the turn number for the latest move
    ''' </summary>
    ''' <value>Turn number as integer [logical minimum: 5, logical maximum: 9]</value>
    ''' <returns>Turn number as integer</returns>
    Public ReadOnly Property TurnNumber As Integer
        Get
            If GameBoardContent = "ERROR" Then
                Return "ERROR"
            End If
            Dim TempGameBoard As String = GameBoardContent
            Dim FinalBoard As String() = TempGameBoard.Split("|")
            Return Val(FinalBoard(1))
        End Get
    End Property
    ' <==  ==>

    ''' <summary>
    ''' Finds the player who made the move
    ''' </summary>
    ''' <value>The player who's turn it was</value>
    ''' <returns>The player who made the move this turn</returns>
    Public ReadOnly Property PlayerTurn As Boolean
        Get
            If GameBoardContent = "ERROR" Then
                Return "ERROR"
            End If
            Dim TempGameBoard As String = GameBoardContent
            Dim FinalBoard As String() = TempGameBoard.Split("|")
            If FinalBoard(2) = "True" Then
                Return True
            Else : Return False
            End If
        End Get
    End Property
    ' <==  ==>

    ''' <summary>
    ''' Compares the primary content of two GameBoardState objects in a GameBoardState [= / !=] GameBoardState logic situation
    ''' </summary>
    ''' <param name="other">Another GameBoardState object</param>
    ''' <returns>Whether the two game board states are equal</returns>
    Public Overloads Function Equals(other As TicTacToe.GameBoardState) As Boolean Implements IEquatable(Of GameBoardState).Equals
        If other Is Nothing Then
            Return False
        End If
        Return (Me.GameBoardContent.Equals(other.GameBoardContent))
    End Function
    ' <==  ==>
End Class

Module ModOpeningFiles

    Public LoadedReplayAlready As Boolean = False ' Prevent loading replay after loading from cmdline already

    ' <=== Loading a replay ===>

    ''' <summary>
    ''' Allows the user to select a replay file
    ''' </summary>
    ''' <returns>The file path or an error code</returns>
    Public Function OpenReplayFilePath()
        Dim FileDialogue As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        FileDialogue.Title = "Open Replay"
        FileDialogue.InitialDirectory = My.Settings.SaveFolder
        FileDialogue.Filter = "Replay files (*.T3Replay)|*.T3Replay"
        FileDialogue.FilterIndex = 1
        FileDialogue.RestoreDirectory = False
        FileDialogue.CheckPathExists = True
        FileDialogue.CheckFileExists = True
        FileDialogue.Multiselect = False

        If FileDialogue.ShowDialog() = DialogResult.OK Then
            strFileName = FileDialogue.FileName
            FrmReplayViewer.TxtFilePath.Text = strFileName

            ' Check if file is right version
            Dim StreamReader As New IO.StreamReader(strFileName)
            If StreamReader.ReadLine() = "T3Replay - " & Application.ProductVersion Then
                StreamReader.Close()
                Return strFileName
            Else
                StreamReader.Close()
                FrmReplayViewer.TxtFilePath.Text = ""
                Return "ERROR: File version out of date"
            End If
        End If

        FrmReplayViewer.TxtFilePath.Text = ""
        Return "ERROR: No file chosen"
    End Function

    ''' <summary>
    ''' Runs through a .T3Replay file and appends the gameboardstate for each turn to the list
    ''' </summary>
    ''' <param name="FilePath">The file path of the .T3Replay file</param>
    Public Function ParseTextFile(FilePath As String)

        Dim ReplayDetails As New List(Of GameBoardState)()

        Dim StreamReader As New IO.StreamReader(FilePath)
        Dim FirstLineDataBecauseINeededToAdvanceTheReaderByOneLineForReasons As String = StreamReader.ReadLine()
        While StreamReader.Peek() <> -1
            Dim Line As New GameBoardState() With {.GameBoardLine = StreamReader.ReadLine()}

            ReplayDetails.Add(Line)
        End While
        StreamReader.Close()
        Return ReplayDetails
    End Function

End Module
