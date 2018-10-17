<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReplayViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReplayViewer))
        Me.PnlSelectFile = New System.Windows.Forms.Panel()
        Me.TxtFilePath = New System.Windows.Forms.TextBox()
        Me.BtnLoadPreviousReplay = New System.Windows.Forms.Button()
        Me.Btn22 = New System.Windows.Forms.Button()
        Me.Btn00 = New System.Windows.Forms.Button()
        Me.Btn12 = New System.Windows.Forms.Button()
        Me.Btn10 = New System.Windows.Forms.Button()
        Me.Btn02 = New System.Windows.Forms.Button()
        Me.Btn01 = New System.Windows.Forms.Button()
        Me.Btn21 = New System.Windows.Forms.Button()
        Me.Btn11 = New System.Windows.Forms.Button()
        Me.MainMenuReplays = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadPreviousGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlGameBoard = New System.Windows.Forms.Panel()
        Me.PnlGameButtons = New System.Windows.Forms.Panel()
        Me.TrBrMoves = New System.Windows.Forms.TrackBar()
        Me.LblTotalTurns = New System.Windows.Forms.Label()
        Me.LblTurnNumber = New System.Windows.Forms.Label()
        Me.BtnNextMove = New System.Windows.Forms.Button()
        Me.BtnPrevMove = New System.Windows.Forms.Button()
        Me.BtnToLastMove = New System.Windows.Forms.Button()
        Me.BtnToFirstMove = New System.Windows.Forms.Button()
        Me.PnlSelectFile.SuspendLayout()
        Me.MainMenuReplays.SuspendLayout()
        Me.PnlGameButtons.SuspendLayout()
        CType(Me.TrBrMoves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSelectFile
        '
        Me.PnlSelectFile.Controls.Add(Me.TxtFilePath)
        Me.PnlSelectFile.Controls.Add(Me.BtnLoadPreviousReplay)
        Me.PnlSelectFile.Controls.Add(Me.Btn22)
        Me.PnlSelectFile.Controls.Add(Me.Btn00)
        Me.PnlSelectFile.Controls.Add(Me.Btn12)
        Me.PnlSelectFile.Controls.Add(Me.Btn10)
        Me.PnlSelectFile.Controls.Add(Me.Btn02)
        Me.PnlSelectFile.Controls.Add(Me.Btn01)
        Me.PnlSelectFile.Controls.Add(Me.Btn21)
        Me.PnlSelectFile.Controls.Add(Me.Btn11)
        Me.PnlSelectFile.Location = New System.Drawing.Point(12, 27)
        Me.PnlSelectFile.Name = "PnlSelectFile"
        Me.PnlSelectFile.Size = New System.Drawing.Size(260, 23)
        Me.PnlSelectFile.TabIndex = 2
        '
        'TxtFilePath
        '
        Me.TxtFilePath.Enabled = False
        Me.TxtFilePath.Location = New System.Drawing.Point(78, 1)
        Me.TxtFilePath.Name = "TxtFilePath"
        Me.TxtFilePath.Size = New System.Drawing.Size(179, 20)
        Me.TxtFilePath.TabIndex = 4
        Me.TxtFilePath.Text = "Selected file will appear here"
        '
        'BtnLoadPreviousReplay
        '
        Me.BtnLoadPreviousReplay.ForeColor = System.Drawing.Color.Black
        Me.BtnLoadPreviousReplay.Location = New System.Drawing.Point(0, 0)
        Me.BtnLoadPreviousReplay.Name = "BtnLoadPreviousReplay"
        Me.BtnLoadPreviousReplay.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoadPreviousReplay.TabIndex = 3
        Me.BtnLoadPreviousReplay.Text = "Select a file"
        Me.BtnLoadPreviousReplay.UseVisualStyleBackColor = True
        '
        'Btn22
        '
        Me.Btn22.ForeColor = System.Drawing.Color.Black
        Me.Btn22.Location = New System.Drawing.Point(0, 0)
        Me.Btn22.Name = "Btn22"
        Me.Btn22.Size = New System.Drawing.Size(75, 23)
        Me.Btn22.TabIndex = 1
        Me.Btn22.UseVisualStyleBackColor = True
        '
        'Btn00
        '
        Me.Btn00.ForeColor = System.Drawing.Color.Black
        Me.Btn00.Location = New System.Drawing.Point(0, 0)
        Me.Btn00.Name = "Btn00"
        Me.Btn00.Size = New System.Drawing.Size(75, 23)
        Me.Btn00.TabIndex = 2
        Me.Btn00.UseVisualStyleBackColor = True
        '
        'Btn12
        '
        Me.Btn12.ForeColor = System.Drawing.Color.Black
        Me.Btn12.Location = New System.Drawing.Point(0, 0)
        Me.Btn12.Name = "Btn12"
        Me.Btn12.Size = New System.Drawing.Size(75, 23)
        Me.Btn12.TabIndex = 3
        Me.Btn12.UseVisualStyleBackColor = True
        '
        'Btn10
        '
        Me.Btn10.ForeColor = System.Drawing.Color.Black
        Me.Btn10.Location = New System.Drawing.Point(0, 0)
        Me.Btn10.Name = "Btn10"
        Me.Btn10.Size = New System.Drawing.Size(75, 23)
        Me.Btn10.TabIndex = 4
        Me.Btn10.UseVisualStyleBackColor = True
        '
        'Btn02
        '
        Me.Btn02.ForeColor = System.Drawing.Color.Black
        Me.Btn02.Location = New System.Drawing.Point(0, 0)
        Me.Btn02.Name = "Btn02"
        Me.Btn02.Size = New System.Drawing.Size(75, 23)
        Me.Btn02.TabIndex = 5
        Me.Btn02.UseVisualStyleBackColor = True
        '
        'Btn01
        '
        Me.Btn01.ForeColor = System.Drawing.Color.Black
        Me.Btn01.Location = New System.Drawing.Point(0, 0)
        Me.Btn01.Name = "Btn01"
        Me.Btn01.Size = New System.Drawing.Size(75, 23)
        Me.Btn01.TabIndex = 6
        Me.Btn01.UseVisualStyleBackColor = True
        '
        'Btn21
        '
        Me.Btn21.ForeColor = System.Drawing.Color.Black
        Me.Btn21.Location = New System.Drawing.Point(0, 0)
        Me.Btn21.Name = "Btn21"
        Me.Btn21.Size = New System.Drawing.Size(75, 23)
        Me.Btn21.TabIndex = 7
        Me.Btn21.UseVisualStyleBackColor = True
        '
        'Btn11
        '
        Me.Btn11.ForeColor = System.Drawing.Color.Black
        Me.Btn11.Location = New System.Drawing.Point(0, 0)
        Me.Btn11.Name = "Btn11"
        Me.Btn11.Size = New System.Drawing.Size(75, 23)
        Me.Btn11.TabIndex = 8
        Me.Btn11.UseVisualStyleBackColor = True
        '
        'MainMenuReplays
        '
        Me.MainMenuReplays.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenuReplays.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuReplays.Name = "MainMenuReplays"
        Me.MainMenuReplays.Size = New System.Drawing.Size(284, 24)
        Me.MainMenuReplays.TabIndex = 1
        Me.MainMenuReplays.Text = "Main Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.LoadPreviousGameToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NewGameToolStripMenuItem.Text = "Play Game"
        '
        'LoadPreviousGameToolStripMenuItem
        '
        Me.LoadPreviousGameToolStripMenuItem.Checked = True
        Me.LoadPreviousGameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LoadPreviousGameToolStripMenuItem.Name = "LoadPreviousGameToolStripMenuItem"
        Me.LoadPreviousGameToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LoadPreviousGameToolStripMenuItem.Text = "Replays"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetHelpToolStripMenuItem, Me.GetHelpOnlineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GetHelpToolStripMenuItem
        '
        Me.GetHelpToolStripMenuItem.Name = "GetHelpToolStripMenuItem"
        Me.GetHelpToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GetHelpToolStripMenuItem.Text = "Help"
        '
        'GetHelpOnlineToolStripMenuItem
        '
        Me.GetHelpOnlineToolStripMenuItem.Name = "GetHelpOnlineToolStripMenuItem"
        Me.GetHelpOnlineToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GetHelpOnlineToolStripMenuItem.Text = "Get Help Online"
        '
        'PnlGameBoard
        '
        Me.PnlGameBoard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PnlGameBoard.Location = New System.Drawing.Point(11, 56)
        Me.PnlGameBoard.Name = "PnlGameBoard"
        Me.PnlGameBoard.Size = New System.Drawing.Size(261, 261)
        Me.PnlGameBoard.TabIndex = 5
        '
        'PnlGameButtons
        '
        Me.PnlGameButtons.Controls.Add(Me.TrBrMoves)
        Me.PnlGameButtons.Controls.Add(Me.LblTotalTurns)
        Me.PnlGameButtons.Controls.Add(Me.LblTurnNumber)
        Me.PnlGameButtons.Controls.Add(Me.BtnNextMove)
        Me.PnlGameButtons.Controls.Add(Me.BtnPrevMove)
        Me.PnlGameButtons.Controls.Add(Me.BtnToLastMove)
        Me.PnlGameButtons.Controls.Add(Me.BtnToFirstMove)
        'Me.PnlGameButtons.Controls.Add(Me.ShapeContainer1)
        Me.PnlGameButtons.Location = New System.Drawing.Point(12, 324)
        Me.PnlGameButtons.Name = "PnlGameButtons"
        Me.PnlGameButtons.Size = New System.Drawing.Size(260, 106)
        Me.PnlGameButtons.TabIndex = 6
        '
        'TrBrMoves
        '
        Me.TrBrMoves.LargeChange = 1
        Me.TrBrMoves.Location = New System.Drawing.Point(3, 56)
        Me.TrBrMoves.Name = "TrBrMoves"
        Me.TrBrMoves.Size = New System.Drawing.Size(254, 45)
        Me.TrBrMoves.TabIndex = 7
        '
        'LblTotalTurns
        '
        Me.LblTotalTurns.AutoSize = True
        Me.LblTotalTurns.Location = New System.Drawing.Point(125, 34)
        Me.LblTotalTurns.Name = "LblTotalTurns"
        Me.LblTotalTurns.Size = New System.Drawing.Size(13, 13)
        Me.LblTotalTurns.TabIndex = 12
        Me.LblTotalTurns.Text = "0"
        '
        'LblTurnNumber
        '
        Me.LblTurnNumber.AutoSize = True
        Me.LblTurnNumber.Location = New System.Drawing.Point(122, 7)
        Me.LblTurnNumber.Name = "LblTurnNumber"
        Me.LblTurnNumber.Size = New System.Drawing.Size(13, 13)
        Me.LblTurnNumber.TabIndex = 9
        Me.LblTurnNumber.Text = "0"
        '
        'BtnNextMove
        '
        Me.BtnNextMove.Location = New System.Drawing.Point(139, 3)
        Me.BtnNextMove.Name = "BtnNextMove"
        Me.BtnNextMove.Size = New System.Drawing.Size(56, 48)
        Me.BtnNextMove.TabIndex = 10
        Me.BtnNextMove.Text = "NXT"
        Me.BtnNextMove.UseVisualStyleBackColor = True
        '
        'BtnPrevMove
        '
        Me.BtnPrevMove.Location = New System.Drawing.Point(65, 3)
        Me.BtnPrevMove.Name = "BtnPrevMove"
        Me.BtnPrevMove.Size = New System.Drawing.Size(56, 48)
        Me.BtnPrevMove.TabIndex = 8
        Me.BtnPrevMove.Text = "PREV"
        Me.BtnPrevMove.UseVisualStyleBackColor = True
        '
        'BtnToLastMove
        '
        Me.BtnToLastMove.Location = New System.Drawing.Point(201, 3)
        Me.BtnToLastMove.Name = "BtnToLastMove"
        Me.BtnToLastMove.Size = New System.Drawing.Size(56, 48)
        Me.BtnToLastMove.TabIndex = 11
        Me.BtnToLastMove.Text = "LAST"
        Me.BtnToLastMove.UseVisualStyleBackColor = True
        '
        'BtnToFirstMove
        '
        Me.BtnToFirstMove.Location = New System.Drawing.Point(3, 3)
        Me.BtnToFirstMove.Name = "BtnToFirstMove"
        Me.BtnToFirstMove.Size = New System.Drawing.Size(56, 48)
        Me.BtnToFirstMove.TabIndex = 7
        Me.BtnToFirstMove.Text = "1ST"
        Me.BtnToFirstMove.UseVisualStyleBackColor = True
        '
        'FrmReplayViewer
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 438)
        Me.Controls.Add(Me.PnlGameButtons)
        Me.Controls.Add(Me.PnlGameBoard)
        Me.Controls.Add(Me.MainMenuReplays)
        Me.Controls.Add(Me.PnlSelectFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 476)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 476)
        Me.Name = "FrmReplayViewer"
        Me.Text = "Replays"
        Me.PnlSelectFile.ResumeLayout(False)
        Me.PnlSelectFile.PerformLayout()
        Me.MainMenuReplays.ResumeLayout(False)
        Me.MainMenuReplays.PerformLayout()
        Me.PnlGameButtons.ResumeLayout(False)
        Me.PnlGameButtons.PerformLayout()
        CType(Me.TrBrMoves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlSelectFile As System.Windows.Forms.Panel
    Friend WithEvents BtnLoadPreviousReplay As System.Windows.Forms.Button
    Friend WithEvents Btn22 As System.Windows.Forms.Button
    Friend WithEvents Btn00 As System.Windows.Forms.Button
    Friend WithEvents Btn12 As System.Windows.Forms.Button
    Friend WithEvents Btn10 As System.Windows.Forms.Button
    Friend WithEvents Btn02 As System.Windows.Forms.Button
    Friend WithEvents Btn01 As System.Windows.Forms.Button
    Friend WithEvents Btn21 As System.Windows.Forms.Button
    Friend WithEvents Btn11 As System.Windows.Forms.Button
    Friend WithEvents MainMenuReplays As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadPreviousGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHelpOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents PnlGameBoard As System.Windows.Forms.Panel
    Friend WithEvents PnlGameButtons As System.Windows.Forms.Panel
    Friend WithEvents BtnNextMove As System.Windows.Forms.Button
    Friend WithEvents BtnPrevMove As System.Windows.Forms.Button
    Friend WithEvents BtnToLastMove As System.Windows.Forms.Button
    Friend WithEvents BtnToFirstMove As System.Windows.Forms.Button
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblTurnNumber As System.Windows.Forms.Label
    Friend WithEvents LblTotalTurns As System.Windows.Forms.Label
    Friend WithEvents TrBrMoves As System.Windows.Forms.TrackBar
End Class
