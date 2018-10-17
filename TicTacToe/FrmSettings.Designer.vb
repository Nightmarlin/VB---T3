<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.MainMenuReplays = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadPreviousGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbcSettings = New System.Windows.Forms.TabControl()
        Me.TbpgGame = New System.Windows.Forms.TabPage()
        Me.BtnResetDefaultFilepath = New System.Windows.Forms.Button()
        Me.BtnChangeSaveFolder = New System.Windows.Forms.Button()
        Me.LblFoderpathInfo = New System.Windows.Forms.Label()
        Me.CbxNoughtsFirst = New System.Windows.Forms.CheckBox()
        Me.TxtSaveFolder = New System.Windows.Forms.TextBox()
        Me.CbxAutosave = New System.Windows.Forms.CheckBox()
        Me.TbpgThemes = New System.Windows.Forms.TabPage()
        Me.ProcrastinationIsFun = New System.Windows.Forms.Label()
        Me.LblNA = New System.Windows.Forms.Label()
        Me.MainMenuReplays.SuspendLayout()
        Me.TbcSettings.SuspendLayout()
        Me.TbpgGame.SuspendLayout()
        Me.TbpgThemes.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LoadPreviousGameToolStripMenuItem.Name = "LoadPreviousGameToolStripMenuItem"
        Me.LoadPreviousGameToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LoadPreviousGameToolStripMenuItem.Text = "Replays"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Checked = True
        Me.SettingsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
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
        'TbcSettings
        '
        Me.TbcSettings.Controls.Add(Me.TbpgGame)
        Me.TbcSettings.Controls.Add(Me.TbpgThemes)
        Me.TbcSettings.Location = New System.Drawing.Point(12, 27)
        Me.TbcSettings.Name = "TbcSettings"
        Me.TbcSettings.SelectedIndex = 0
        Me.TbcSettings.Size = New System.Drawing.Size(259, 132)
        Me.TbcSettings.TabIndex = 2
        '
        'TbpgGame
        '
        Me.TbpgGame.Controls.Add(Me.BtnResetDefaultFilepath)
        Me.TbpgGame.Controls.Add(Me.BtnChangeSaveFolder)
        Me.TbpgGame.Controls.Add(Me.LblFoderpathInfo)
        Me.TbpgGame.Controls.Add(Me.CbxNoughtsFirst)
        Me.TbpgGame.Controls.Add(Me.TxtSaveFolder)
        Me.TbpgGame.Controls.Add(Me.CbxAutosave)
        Me.TbpgGame.Location = New System.Drawing.Point(4, 22)
        Me.TbpgGame.Name = "TbpgGame"
        Me.TbpgGame.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpgGame.Size = New System.Drawing.Size(251, 106)
        Me.TbpgGame.TabIndex = 1
        Me.TbpgGame.Text = "Game and Replays"
        Me.TbpgGame.UseVisualStyleBackColor = True
        '
        'BtnResetDefaultFilepath
        '
        Me.BtnResetDefaultFilepath.Location = New System.Drawing.Point(185, 57)
        Me.BtnResetDefaultFilepath.Name = "BtnResetDefaultFilepath"
        Me.BtnResetDefaultFilepath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnResetDefaultFilepath.Size = New System.Drawing.Size(60, 23)
        Me.BtnResetDefaultFilepath.TabIndex = 8
        Me.BtnResetDefaultFilepath.Text = "Reset"
        Me.BtnResetDefaultFilepath.UseVisualStyleBackColor = True
        '
        'BtnChangeSaveFolder
        '
        Me.BtnChangeSaveFolder.Location = New System.Drawing.Point(125, 57)
        Me.BtnChangeSaveFolder.Name = "BtnChangeSaveFolder"
        Me.BtnChangeSaveFolder.Size = New System.Drawing.Size(54, 23)
        Me.BtnChangeSaveFolder.TabIndex = 7
        Me.BtnChangeSaveFolder.Text = "Change"
        Me.BtnChangeSaveFolder.UseVisualStyleBackColor = True
        '
        'LblFoderpathInfo
        '
        Me.LblFoderpathInfo.Location = New System.Drawing.Point(7, 57)
        Me.LblFoderpathInfo.Name = "LblFoderpathInfo"
        Me.LblFoderpathInfo.Size = New System.Drawing.Size(112, 23)
        Me.LblFoderpathInfo.TabIndex = 6
        Me.LblFoderpathInfo.Text = "Save Folder"
        Me.LblFoderpathInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbxNoughtsFirst
        '
        Me.CbxNoughtsFirst.AutoSize = True
        Me.CbxNoughtsFirst.Checked = True
        Me.CbxNoughtsFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbxNoughtsFirst.Location = New System.Drawing.Point(126, 7)
        Me.CbxNoughtsFirst.Name = "CbxNoughtsFirst"
        Me.CbxNoughtsFirst.Size = New System.Drawing.Size(100, 17)
        Me.CbxNoughtsFirst.TabIndex = 4
        Me.CbxNoughtsFirst.Text = "Noughts go first"
        Me.CbxNoughtsFirst.UseVisualStyleBackColor = True
        '
        'TxtSaveFolder
        '
        Me.TxtSaveFolder.Location = New System.Drawing.Point(7, 31)
        Me.TxtSaveFolder.Name = "TxtSaveFolder"
        Me.TxtSaveFolder.ReadOnly = True
        Me.TxtSaveFolder.Size = New System.Drawing.Size(238, 20)
        Me.TxtSaveFolder.TabIndex = 5
        '
        'CbxAutosave
        '
        Me.CbxAutosave.AutoSize = True
        Me.CbxAutosave.Location = New System.Drawing.Point(7, 7)
        Me.CbxAutosave.Name = "CbxAutosave"
        Me.CbxAutosave.Size = New System.Drawing.Size(112, 17)
        Me.CbxAutosave.TabIndex = 3
        Me.CbxAutosave.Text = "Autosave Replays"
        Me.CbxAutosave.UseVisualStyleBackColor = True
        '
        'TbpgThemes
        '
        Me.TbpgThemes.Controls.Add(Me.ProcrastinationIsFun)
        Me.TbpgThemes.Controls.Add(Me.LblNA)
        Me.TbpgThemes.Location = New System.Drawing.Point(4, 22)
        Me.TbpgThemes.Name = "TbpgThemes"
        Me.TbpgThemes.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpgThemes.Size = New System.Drawing.Size(251, 106)
        Me.TbpgThemes.TabIndex = 0
        Me.TbpgThemes.Text = "Themes"
        Me.TbpgThemes.UseVisualStyleBackColor = True
        '
        'ProcrastinationIsFun
        '
        Me.ProcrastinationIsFun.Location = New System.Drawing.Point(11, 64)
        Me.ProcrastinationIsFun.Name = "ProcrastinationIsFun"
        Me.ProcrastinationIsFun.Size = New System.Drawing.Size(234, 39)
        Me.ProcrastinationIsFun.TabIndex = 10
        Me.ProcrastinationIsFun.Text = "Probably never going to be finished"
        Me.ProcrastinationIsFun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNA
        '
        Me.LblNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNA.Location = New System.Drawing.Point(6, 3)
        Me.LblNA.Name = "LblNA"
        Me.LblNA.Size = New System.Drawing.Size(239, 57)
        Me.LblNA.TabIndex = 9
        Me.LblNA.Text = "Not Currently Available"
        Me.LblNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 173)
        Me.Controls.Add(Me.TbcSettings)
        Me.Controls.Add(Me.MainMenuReplays)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 211)
        Me.MinimumSize = New System.Drawing.Size(300, 211)
        Me.Name = "FrmSettings"
        Me.Text = "Settings"
        Me.MainMenuReplays.ResumeLayout(False)
        Me.MainMenuReplays.PerformLayout()
        Me.TbcSettings.ResumeLayout(False)
        Me.TbpgGame.ResumeLayout(False)
        Me.TbpgGame.PerformLayout()
        Me.TbpgThemes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenuReplays As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadPreviousGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHelpOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbcSettings As System.Windows.Forms.TabControl
    Friend WithEvents TbpgThemes As System.Windows.Forms.TabPage
    Friend WithEvents TbpgGame As System.Windows.Forms.TabPage
    Friend WithEvents CbxAutosave As System.Windows.Forms.CheckBox
    Friend WithEvents CbxNoughtsFirst As System.Windows.Forms.CheckBox
    Friend WithEvents TxtSaveFolder As System.Windows.Forms.TextBox
    Friend WithEvents LblNA As System.Windows.Forms.Label
    Friend WithEvents BtnChangeSaveFolder As System.Windows.Forms.Button
    Friend WithEvents LblFoderpathInfo As System.Windows.Forms.Label
    Friend WithEvents BtnResetDefaultFilepath As System.Windows.Forms.Button
    Friend WithEvents ProcrastinationIsFun As System.Windows.Forms.Label
End Class
