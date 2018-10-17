Imports System.IO
Imports System.Text

Module ModSavingFiles

    ' <=== Saving a game ===>
    Dim SaveFilePath As String = Application.StartupPath & "\"
    Dim ToWriteToFile As String = "T3Replay - " & Application.ProductVersion

    ''' <summary>
    ''' Emptys the string to write to the file and resets the save file path
    ''' </summary>
    Public Sub ResetFileSettings()
        SaveFilePath = My.Settings.SaveFolder & "\"
        ToWriteToFile = "T3Replay - " & Application.ProductVersion
    End Sub

    ''' <summary>
    ''' Generates a new save file name to prevent overwriting previous saves
    ''' </summary>
    Private Sub NewSaveFilePath()
        Dim Flag As Boolean = False
        Dim FileNumber As Integer = 0
        SaveFilePath = My.Settings.SaveFolder & "\"

        While Flag = False
            If File.Exists(SaveFilePath & CStr(FileNumber) & ".T3Replay") Then
                FileNumber += 1
            Else
                Flag = True
                SaveFilePath &= CStr(FileNumber) & ".T3Replay"
            End If
        End While
        'Debug.WriteLine(SaveFilePath)
    End Sub

    ''' <summary>
    ''' Adds the details of the move made to the turn record
    ''' </summary>
    ''' <param name="GameBoard">The current image of the game board</param>
    ''' <param name="TurnNumber">The turn number</param>
    ''' <param name="PlayerTurn">Whose turn it is (True = O, False = X)</param>
    Public Sub AddNewTurnRecord(ByVal GameBoard As Short(,), TurnNumber As Integer, PlayerTurn As Boolean)
        Dim Appendment As String = Environment.NewLine

        For Looper = 0 To 2
            For Looper2 = 0 To 2
                Appendment &= CStr(GameBoard(Looper, Looper2))
            Next
        Next
        Appendment &= "|" & CStr(TurnNumber) & "|" & CStr(PlayerTurn)

        'Debug.WriteLine(Appendment)
        ToWriteToFile &= Appendment
    End Sub

    ''' <summary>
    ''' Write to the chosen file
    ''' </summary>
    ''' <returns>Whether or not the save was successful</returns>
    Private Function SaveNewReplay()
        Try
            If File.Exists(SaveFilePath) = False Then ' If the file exists, don't write to it
                Dim StreamWriter As New IO.StreamWriter(SaveFilePath, False)
                StreamWriter.Write(CStr(ToWriteToFile))
                StreamWriter.Close()

                ' Open the file to read from - debugging
                'Dim StreamReader As New IO.StreamReader(SaveFilePath)
                'Dim readText As String = StreamReader.ReadToEnd()
                'StreamReader.Close()
                'Debug.WriteLine(readText)
                ' end debugging

                Return "Success"
            Else
                Return "Failure: File (" & SaveFilePath & ") already exists"
            End If
        Catch Err As Exception
            Return "Failure: " & CStr(Err.Message)
        End Try
    End Function

    ''' <summary>
    ''' Concatenates all data into a file and saves it
    ''' </summary>
    Public Sub CreateNewReplaySave()
        If My.Settings.AutomaticallySaveReplays = True Then
            NewSaveFilePath() ' Generate a new savefile path
            Dim SaveStatus As String = SaveNewReplay() ' Write all data to new savefile and return what happened
            MsgBox(SaveStatus, MsgBoxStyle.OkOnly, "Save status...")
            ResetFileSettings() ' Empty the variables
        Else
            Dim Choice As Integer = MsgBox("Would you like to save the replay", MsgBoxStyle.YesNo, "Save your replay?")
            If Choice = 6 Then
                NewSaveFilePath() ' Generate a new savefile path
                Dim SaveStatus As String = SaveNewReplay() ' Write all data to new savefile and return what happened
                MsgBox(SaveStatus, MsgBoxStyle.OkOnly, "Save status...")
                ResetFileSettings() ' Empty the variables
            Else
                MsgBox("Save not created", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

End Module
