Public Class FrmHelp

    ''' <summary>
    ''' Display the help in a textbox
    ''' </summary>
    Private Sub BtnGamePlayHelp_Click(sender As Object, e As EventArgs) Handles BtnGamePlayHelp.Click
        RtbHelp.Refresh()
        RtbHelp.Text = "How to play." & Environment.NewLine & _
            "Beginning a game" & Environment.NewLine & _
            "-> 1) Click the 'Start Game' button or 'New Game' in the 'File' menu" & Environment.NewLine & _
            "--[ If a game is already in progress you will be prompted to continue or abandon it. If a game is abandoned, the replay is not saved" & Environment.NewLine & _
            "-> 2) If you have not done so previously, enter the names of the players" & Environment.NewLine & Environment.NewLine & _
            "Playing a game" & Environment.NewLine & _
            "-> 1) O's go first, so that player should click on the tile they wish to play" & Environment.NewLine & _
            "-> 2) X's get the second turn, so they should click on any unoccupied square they wish to move to" & Environment.NewLine & _
            "-> 3) Take turns to play tiles until either a player gets 3 of their icons in a row / column / diagonal (a Win) or no tiles are left to play (a Draw)" & Environment.NewLine & _
            "--[ If a tile has already been occupied, you will be unable to select it for your move" & Environment.NewLine & Environment.NewLine & _
            "Ending a game" & Environment.NewLine & _
            "-> 1) Click the 'End Game' button. You will be asked whether or not you wish to end the game" & Environment.NewLine & _
            "-> 2) Click 'Yes' to end the game. Clicking 'No' will return you to the game" & Environment.NewLine & _
            "--[ If a game is abandoned, the replay is not saved" & Environment.NewLine & Environment.NewLine & _
            "Changing player names" & Environment.NewLine & _
            "-> 1) Click 'Change Names'" & Environment.NewLine & _
            "-> 2) Enter Player 1's chosen name" & Environment.NewLine & _
            "-> 3) Enter Player 2's chosen name" & Environment.NewLine & _
            "--[ Clicking 'Cancel' will set the name to 'Player [x]'" & Environment.NewLine & _
            "--[ Names must be between 1 and 10 characters in length" & Environment.NewLine & Environment.NewLine & _
            "Instant replays" & Environment.NewLine & _
            "-> Drag and drop a '*.T3Replay' file into the window to load a replay instantly"
    End Sub

    ''' <summary>
    ''' Moar Halp
    ''' </summary>
    Private Sub BtnReplayHelp_Click(sender As Object, e As EventArgs) Handles BtnReplayHelp.Click
        RtbHelp.Refresh()
        RtbHelp.Text = "Replaying previous games." & Environment.NewLine & _
            "1) Click 'Select a file' or drag and drop a '*.T3Replay' file into the window" & Environment.NewLine & _
            "2) Navigate to the '*.T3Replay' file and open it" & Environment.NewLine & _
            "--[ This step will not be necessary if you have used the drag and drop feature" & Environment.NewLine & _
            "3) Choose any of the following" & Environment.NewLine & _
            "-> '1ST': Jump to the first move" & Environment.NewLine & _
            "--[ Disabled on load" & Environment.NewLine & _
            "-> 'PREV': Step back one move" & Environment.NewLine & _
            "--[ Disabled on load" & Environment.NewLine & _
            "-> 'NXT': Step forward one move" & Environment.NewLine & _
            "-> 'LAST': Jump to the final move" & Environment.NewLine & _
            "-> Scroll Bar: Scroll to the desired move" & Environment.NewLine & _
            "-> Number Keys: Select the desired move to view" & Environment.NewLine & _
            "-> WASD Keys: Scroll to the desired move" & Environment.NewLine & _
            "-[ The number in the middle of the buttons shows you what turn you are currently viewing" & Environment.NewLine & _
            "[ If you want to open another '*.T3Replay' file, simply click 'Select a file' or Drag and Drop a '*.T3Reply' file again" & Environment.NewLine & _
            "[ Alternatively, should you wish to be awesome, drag and drop a '*.T3Replay' file over the T3.exe file itself!!!"
    End Sub

    ''' <summary>
    ''' Yup. Still dishing out help
    ''' </summary>
    Private Sub BtnSettingsHelp_Click(sender As Object, e As EventArgs) Handles BtnSettingsHelp.Click
        RtbHelp.Refresh()
        RtbHelp.Text = "Changing settings." & Environment.NewLine & _
            "Available Settings" & Environment.NewLine & _
            "-> Autosave replays" & Environment.NewLine & _
            "--> Whether or not the application should ask to save replays" & Environment.NewLine & _
            "-> Noughts go first" & Environment.NewLine & _
            "--> Change whether or not Noughts get the first move" & Environment.NewLine & _
            "---[Soon to be 'Random player goes first'" & Environment.NewLine & _
            "-> Save folder" & Environment.NewLine & _
            "--> Change" & Environment.NewLine & _
            "---> Select a folder to save replay files to" & Environment.NewLine & _
            "--> Reset" & Environment.NewLine & _
            "---> Resets the replay folder to the file that the application started in" & Environment.NewLine & Environment.NewLine & _
            "Future settings" & Environment.NewLine & _
            "-> Themes - Change the appearance of the game" & Environment.NewLine & _
            "-> Random player goes first - Game picks a random player to begin playing"
    End Sub

End Class