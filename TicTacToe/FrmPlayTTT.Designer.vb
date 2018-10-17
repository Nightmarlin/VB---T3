<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlayTTT
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlayTTT))
        Me.LblLastMove = New System.Windows.Forms.Label()
        Me.LblPlayerTurn = New System.Windows.Forms.Label()
        Me.LblNameX = New System.Windows.Forms.LinkLabel()
        Me.BtnChangeNames = New System.Windows.Forms.Button()
        Me.PnlInfo = New System.Windows.Forms.Panel()
        Me.LblNameO = New System.Windows.Forms.LinkLabel()
        Me.BtnEndGame = New System.Windows.Forms.Button()
        Me.PnlGameControls = New System.Windows.Forms.Panel()
        Me.BtnStartGame = New System.Windows.Forms.Button()
        Me.Btn20 = New System.Windows.Forms.Button()
        Me.Btn00 = New System.Windows.Forms.Button()
        Me.Btn10 = New System.Windows.Forms.Button()
        Me.Btn01 = New System.Windows.Forms.Button()
        Me.PnlGameButtons = New System.Windows.Forms.Panel()
        Me.Btn22 = New System.Windows.Forms.Button()
        Me.Btn12 = New System.Windows.Forms.Button()
        Me.Btn02 = New System.Windows.Forms.Button()
        Me.Btn21 = New System.Windows.Forms.Button()
        Me.Btn11 = New System.Windows.Forms.Button()
        Me.GetHelpOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadPreviousGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuPlayGame = New System.Windows.Forms.MenuStrip()
        Me.CntxtMenuPlayGame = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CntxtNewGameItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtEndGameItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtChangeNamesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtSettingsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtHelpItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlInfo.SuspendLayout()
        Me.PnlGameControls.SuspendLayout()
        Me.PnlGameButtons.SuspendLayout()
        Me.MainMenuPlayGame.SuspendLayout()
        Me.CntxtMenuPlayGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblLastMove
        '
        Me.LblLastMove.Location = New System.Drawing.Point(3, 28)
        Me.LblLastMove.Name = "LblLastMove"
        Me.LblLastMove.Size = New System.Drawing.Size(75, 37)
        Me.LblLastMove.TabIndex = 18
        Me.LblLastMove.Text = "Last Move:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "X: 0,0"
        Me.LblLastMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPlayerTurn
        '
        Me.LblPlayerTurn.Location = New System.Drawing.Point(3, 5)
        Me.LblPlayerTurn.Name = "LblPlayerTurn"
        Me.LblPlayerTurn.Size = New System.Drawing.Size(75, 23)
        Me.LblPlayerTurn.TabIndex = 17
        Me.LblPlayerTurn.Text = "O's turn"
        Me.LblPlayerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNameX
        '
        Me.LblNameX.ForeColor = System.Drawing.Color.Maroon
        Me.LblNameX.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LblNameX.Location = New System.Drawing.Point(3, 95)
        Me.LblNameX.Name = "LblNameX"
        Me.LblNameX.Size = New System.Drawing.Size(75, 34)
        Me.LblNameX.TabIndex = 20
        Me.LblNameX.Text = "Player 2 - X"
        Me.LblNameX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnChangeNames
        '
        Me.BtnChangeNames.Location = New System.Drawing.Point(3, 132)
        Me.BtnChangeNames.Name = "BtnChangeNames"
        Me.BtnChangeNames.Size = New System.Drawing.Size(75, 34)
        Me.BtnChangeNames.TabIndex = 13
        Me.BtnChangeNames.Text = "Change Names"
        Me.BtnChangeNames.UseVisualStyleBackColor = True
        '
        'PnlInfo
        '
        Me.PnlInfo.Controls.Add(Me.LblLastMove)
        Me.PnlInfo.Controls.Add(Me.LblPlayerTurn)
        Me.PnlInfo.Controls.Add(Me.LblNameX)
        Me.PnlInfo.Controls.Add(Me.LblNameO)
        Me.PnlInfo.Controls.Add(Me.BtnChangeNames)
        Me.PnlInfo.Location = New System.Drawing.Point(249, 88)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.Size = New System.Drawing.Size(81, 169)
        Me.PnlInfo.TabIndex = 16
        '
        'LblNameO
        '
        Me.LblNameO.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblNameO.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.LblNameO.Location = New System.Drawing.Point(3, 65)
        Me.LblNameO.Name = "LblNameO"
        Me.LblNameO.Size = New System.Drawing.Size(75, 30)
        Me.LblNameO.TabIndex = 19
        Me.LblNameO.Text = "Player 1 - O"
        Me.LblNameO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEndGame
        '
        Me.BtnEndGame.Location = New System.Drawing.Point(3, 32)
        Me.BtnEndGame.Name = "BtnEndGame"
        Me.BtnEndGame.Size = New System.Drawing.Size(75, 23)
        Me.BtnEndGame.TabIndex = 12
        Me.BtnEndGame.Text = "End Game"
        Me.BtnEndGame.UseVisualStyleBackColor = True
        '
        'PnlGameControls
        '
        Me.PnlGameControls.Controls.Add(Me.BtnEndGame)
        Me.PnlGameControls.Controls.Add(Me.BtnStartGame)
        Me.PnlGameControls.Location = New System.Drawing.Point(249, 27)
        Me.PnlGameControls.Name = "PnlGameControls"
        Me.PnlGameControls.Size = New System.Drawing.Size(81, 59)
        Me.PnlGameControls.TabIndex = 21
        '
        'BtnStartGame
        '
        Me.BtnStartGame.Location = New System.Drawing.Point(3, 3)
        Me.BtnStartGame.Name = "BtnStartGame"
        Me.BtnStartGame.Size = New System.Drawing.Size(75, 23)
        Me.BtnStartGame.TabIndex = 11
        Me.BtnStartGame.Text = "Start Game"
        Me.BtnStartGame.UseVisualStyleBackColor = True
        '
        'Btn20
        '
        Me.Btn20.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn20.ForeColor = System.Drawing.Color.Black
        Me.Btn20.Location = New System.Drawing.Point(155, 3)
        Me.Btn20.Name = "Btn20"
        Me.Btn20.Size = New System.Drawing.Size(70, 70)
        Me.Btn20.TabIndex = 4
        Me.Btn20.Text = "2, 0"
        Me.Btn20.UseVisualStyleBackColor = True
        '
        'Btn00
        '
        Me.Btn00.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn00.ForeColor = System.Drawing.Color.Black
        Me.Btn00.Location = New System.Drawing.Point(3, 3)
        Me.Btn00.Name = "Btn00"
        Me.Btn00.Size = New System.Drawing.Size(70, 70)
        Me.Btn00.TabIndex = 2
        Me.Btn00.Text = "0, 0"
        Me.Btn00.UseVisualStyleBackColor = True
        '
        'Btn10
        '
        Me.Btn10.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn10.ForeColor = System.Drawing.Color.Black
        Me.Btn10.Location = New System.Drawing.Point(79, 3)
        Me.Btn10.Name = "Btn10"
        Me.Btn10.Size = New System.Drawing.Size(70, 70)
        Me.Btn10.TabIndex = 3
        Me.Btn10.Text = "1, 0"
        Me.Btn10.UseVisualStyleBackColor = True
        '
        'Btn01
        '
        Me.Btn01.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn01.ForeColor = System.Drawing.Color.Black
        Me.Btn01.Location = New System.Drawing.Point(3, 79)
        Me.Btn01.Name = "Btn01"
        Me.Btn01.Size = New System.Drawing.Size(70, 70)
        Me.Btn01.TabIndex = 5
        Me.Btn01.Text = "0, 1"
        Me.Btn01.UseVisualStyleBackColor = True
        '
        'PnlGameButtons
        '
        Me.PnlGameButtons.Controls.Add(Me.Btn20)
        Me.PnlGameButtons.Controls.Add(Me.Btn22)
        Me.PnlGameButtons.Controls.Add(Me.Btn00)
        Me.PnlGameButtons.Controls.Add(Me.Btn12)
        Me.PnlGameButtons.Controls.Add(Me.Btn10)
        Me.PnlGameButtons.Controls.Add(Me.Btn02)
        Me.PnlGameButtons.Controls.Add(Me.Btn01)
        Me.PnlGameButtons.Controls.Add(Me.Btn21)
        Me.PnlGameButtons.Controls.Add(Me.Btn11)
        Me.PnlGameButtons.Location = New System.Drawing.Point(12, 27)
        Me.PnlGameButtons.Name = "PnlGameButtons"
        Me.PnlGameButtons.Size = New System.Drawing.Size(231, 230)
        Me.PnlGameButtons.TabIndex = 15
        '
        'Btn22
        '
        Me.Btn22.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn22.ForeColor = System.Drawing.Color.Black
        Me.Btn22.Location = New System.Drawing.Point(155, 155)
        Me.Btn22.Name = "Btn22"
        Me.Btn22.Size = New System.Drawing.Size(70, 70)
        Me.Btn22.TabIndex = 10
        Me.Btn22.Text = "2, 2"
        Me.Btn22.UseVisualStyleBackColor = True
        '
        'Btn12
        '
        Me.Btn12.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn12.ForeColor = System.Drawing.Color.Black
        Me.Btn12.Location = New System.Drawing.Point(79, 155)
        Me.Btn12.Name = "Btn12"
        Me.Btn12.Size = New System.Drawing.Size(70, 70)
        Me.Btn12.TabIndex = 9
        Me.Btn12.Text = "1, 2"
        Me.Btn12.UseVisualStyleBackColor = True
        '
        'Btn02
        '
        Me.Btn02.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn02.ForeColor = System.Drawing.Color.Black
        Me.Btn02.Location = New System.Drawing.Point(3, 155)
        Me.Btn02.Name = "Btn02"
        Me.Btn02.Size = New System.Drawing.Size(70, 70)
        Me.Btn02.TabIndex = 8
        Me.Btn02.Text = "0, 2"
        Me.Btn02.UseVisualStyleBackColor = True
        '
        'Btn21
        '
        Me.Btn21.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn21.ForeColor = System.Drawing.Color.Black
        Me.Btn21.Location = New System.Drawing.Point(155, 79)
        Me.Btn21.Name = "Btn21"
        Me.Btn21.Size = New System.Drawing.Size(70, 70)
        Me.Btn21.TabIndex = 7
        Me.Btn21.Text = "2, 1"
        Me.Btn21.UseVisualStyleBackColor = True
        '
        'Btn11
        '
        Me.Btn11.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn11.ForeColor = System.Drawing.Color.Black
        Me.Btn11.Location = New System.Drawing.Point(79, 79)
        Me.Btn11.Name = "Btn11"
        Me.Btn11.Size = New System.Drawing.Size(70, 70)
        Me.Btn11.TabIndex = 6
        Me.Btn11.Text = "1, 1"
        Me.Btn11.UseVisualStyleBackColor = True
        '
        'GetHelpOnlineToolStripMenuItem
        '
        Me.GetHelpOnlineToolStripMenuItem.Name = "GetHelpOnlineToolStripMenuItem"
        Me.GetHelpOnlineToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GetHelpOnlineToolStripMenuItem.Text = "Get Help Online"
        '
        'GetHelpToolStripMenuItem
        '
        Me.GetHelpToolStripMenuItem.Name = "GetHelpToolStripMenuItem"
        Me.GetHelpToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GetHelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetHelpToolStripMenuItem, Me.GetHelpOnlineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LoadPreviousGameToolStripMenuItem
        '
        Me.LoadPreviousGameToolStripMenuItem.Name = "LoadPreviousGameToolStripMenuItem"
        Me.LoadPreviousGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LoadPreviousGameToolStripMenuItem.Text = "Replays"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Checked = True
        Me.NewGameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.LoadPreviousGameToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'MainMenuPlayGame
        '
        Me.MainMenuPlayGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenuPlayGame.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuPlayGame.Name = "MainMenuPlayGame"
        Me.MainMenuPlayGame.Size = New System.Drawing.Size(340, 24)
        Me.MainMenuPlayGame.TabIndex = 1
        Me.MainMenuPlayGame.Text = "Main Menu"
        '
        'CntxtMenuPlayGame
        '
        Me.CntxtMenuPlayGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntxtNewGameItem, Me.CntxtEndGameItem, Me.CntxtChangeNamesItem, Me.CntxtSettingsItem, Me.CntxtHelpItem})
        Me.CntxtMenuPlayGame.Name = "CntxtMenuPlayGame"
        Me.CntxtMenuPlayGame.Size = New System.Drawing.Size(156, 114)
        Me.CntxtMenuPlayGame.Text = "Options"
        '
        'CntxtNewGameItem
        '
        Me.CntxtNewGameItem.Name = "CntxtNewGameItem"
        Me.CntxtNewGameItem.Size = New System.Drawing.Size(155, 22)
        Me.CntxtNewGameItem.Text = "New Game"
        '
        'CntxtEndGameItem
        '
        Me.CntxtEndGameItem.Name = "CntxtEndGameItem"
        Me.CntxtEndGameItem.Size = New System.Drawing.Size(155, 22)
        Me.CntxtEndGameItem.Text = "End Game"
        '
        'CntxtChangeNamesItem
        '
        Me.CntxtChangeNamesItem.Name = "CntxtChangeNamesItem"
        Me.CntxtChangeNamesItem.Size = New System.Drawing.Size(155, 22)
        Me.CntxtChangeNamesItem.Text = "Change Names"
        '
        'CntxtSettingsItem
        '
        Me.CntxtSettingsItem.Name = "CntxtSettingsItem"
        Me.CntxtSettingsItem.Size = New System.Drawing.Size(155, 22)
        Me.CntxtSettingsItem.Text = "Settings"
        '
        'CntxtHelpItem
        '
        Me.CntxtHelpItem.Name = "CntxtHelpItem"
        Me.CntxtHelpItem.Size = New System.Drawing.Size(155, 22)
        Me.CntxtHelpItem.Text = "Help"
        '
        'FrmPlayTTT
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 264)
        Me.ContextMenuStrip = Me.CntxtMenuPlayGame
        Me.Controls.Add(Me.PnlInfo)
        Me.Controls.Add(Me.PnlGameControls)
        Me.Controls.Add(Me.PnlGameButtons)
        Me.Controls.Add(Me.MainMenuPlayGame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(356, 302)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(356, 302)
        Me.Name = "FrmPlayTTT"
        Me.Text = "Player Vs Player"
        Me.PnlInfo.ResumeLayout(False)
        Me.PnlGameControls.ResumeLayout(False)
        Me.PnlGameButtons.ResumeLayout(False)
        Me.MainMenuPlayGame.ResumeLayout(False)
        Me.MainMenuPlayGame.PerformLayout()
        Me.CntxtMenuPlayGame.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLastMove As System.Windows.Forms.Label
    Friend WithEvents LblPlayerTurn As System.Windows.Forms.Label
    Friend WithEvents LblNameX As System.Windows.Forms.LinkLabel
    Friend WithEvents BtnChangeNames As System.Windows.Forms.Button
    Friend WithEvents PnlInfo As System.Windows.Forms.Panel
    Friend WithEvents LblNameO As System.Windows.Forms.LinkLabel
    Friend WithEvents BtnEndGame As System.Windows.Forms.Button
    Friend WithEvents PnlGameControls As System.Windows.Forms.Panel
    Friend WithEvents BtnStartGame As System.Windows.Forms.Button
    Friend WithEvents Btn20 As System.Windows.Forms.Button
    Friend WithEvents Btn00 As System.Windows.Forms.Button
    Friend WithEvents Btn10 As System.Windows.Forms.Button
    Friend WithEvents Btn01 As System.Windows.Forms.Button
    Friend WithEvents PnlGameButtons As System.Windows.Forms.Panel
    Friend WithEvents Btn22 As System.Windows.Forms.Button
    Friend WithEvents Btn12 As System.Windows.Forms.Button
    Friend WithEvents Btn02 As System.Windows.Forms.Button
    Friend WithEvents Btn21 As System.Windows.Forms.Button
    Friend WithEvents Btn11 As System.Windows.Forms.Button
    Friend WithEvents GetHelpOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadPreviousGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuPlayGame As System.Windows.Forms.MenuStrip
    Friend WithEvents CntxtMenuPlayGame As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CntxtNewGameItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtEndGameItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtChangeNamesItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtSettingsItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtHelpItem As System.Windows.Forms.ToolStripMenuItem
End Class
