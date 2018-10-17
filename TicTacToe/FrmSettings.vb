Public Class FrmSettings

    Dim ChangeSettingsAllowed As Boolean = False

    ''' <summary>
    ''' Sets the checkboxes to the correct mode depending on the current settings in My.Settings
    ''' </summary>
    ''' <param name="sender">The object that called the sub</param>
    ''' <param name="e">The arguments with which the sub was called</param>
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSaveFolder.Text = My.Settings.SaveFolder

        If My.Settings.AutomaticallySaveReplays = True Then
            CbxAutosave.Checked = True
        Else
            CbxAutosave.Checked = False
        End If
        'Debug.WriteLine(CStr(My.Settings.AutomaticallySaveReplays))

        If My.Settings.CrossesGoFirst = True Then
            CbxNoughtsFirst.Checked = True
        Else
            CbxNoughtsFirst.Checked = False
        End If
        'Debug.WriteLine(CStr(My.Settings.CrossesGoFirst))

        ChangeSettingsAllowed = True
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        FrmPlayTTT.Show()
        Me.Close()
    End Sub

    Private Sub GetHelpOnlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpOnlineToolStripMenuItem.Click
        MsgBox("There is no one to help you online. Sorry", MsgBoxStyle.OkOnly, "HAHAHAHAHAHAHAHAHAHA")
    End Sub

    Private Sub GetHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpToolStripMenuItem.Click
        FrmHelp.Show()
    End Sub

    Private Sub LoadPreviousGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadPreviousGameToolStripMenuItem.Click
        FrmReplayViewer.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Change the My.Settings.AutomaticallySaveReplays depending on the new state of CbxAutosave
    ''' </summary>
    ''' <param name="sender">The object that called the sub</param>
    ''' <param name="e">The event arguments when the sub was called</param>
    Private Sub CbxAutosave_CheckedChanged(sender As Object, e As EventArgs) Handles CbxAutosave.CheckedChanged
        If ChangeSettingsAllowed Then
            If CbxAutosave.Checked Then
                My.Settings.AutomaticallySaveReplays = True
            Else
                My.Settings.AutomaticallySaveReplays = False
            End If
            'Debug.WriteLine(CStr(My.Settings.AutomaticallySaveReplays))
        End If
    End Sub

    ''' <summary>
    ''' Change the My.Settings.CrossesGoFirst depending on the new state of CbxNoughtsFirst
    ''' </summary>
    ''' <param name="sender">The object that called the sub</param>
    ''' <param name="e">The event arguments when the sub was called</param>
    Private Sub CbxNoughtsFirst_CheckedChanged(sender As Object, e As EventArgs) Handles CbxNoughtsFirst.CheckedChanged
        If ChangeSettingsAllowed = True Then
            If CbxNoughtsFirst.Checked Then
                My.Settings.CrossesGoFirst = True
            Else
                My.Settings.CrossesGoFirst = False
            End If
            'Debug.WriteLine(CStr(My.Settings.CrossesGoFirst))
        End If
    End Sub

    ''' <summary>
    ''' Allows the user to select a new folder to save replays to
    ''' </summary>
    Private Sub BtnChangeSaveFolder_Click(sender As Object, e As EventArgs) Handles BtnChangeSaveFolder.Click
        TxtSaveFolder.Text = ModUtilities.ChangeSaveFolder()
    End Sub

    ''' <summary>
    ''' Sets the save path to the folder containing the application
    ''' </summary>
    Private Sub BtnResetDefaultFilepath_Click(sender As Object, e As EventArgs) Handles BtnResetDefaultFilepath.Click
        My.Settings.SaveFolder = Application.StartupPath
        TxtSaveFolder.Text = Application.StartupPath
        MsgBox("Reset save path to " & My.Settings.SaveFolder, MsgBoxStyle.OkOnly, "SUCCESS")
    End Sub
End Class