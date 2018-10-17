<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Me.RtbHelp = New System.Windows.Forms.RichTextBox()
        Me.BtnReplayHelp = New System.Windows.Forms.Button()
        Me.BtnSettingsHelp = New System.Windows.Forms.Button()
        Me.BtnGamePlayHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RtbHelp
        '
        Me.RtbHelp.Location = New System.Drawing.Point(13, 42)
        Me.RtbHelp.Name = "RtbHelp"
        Me.RtbHelp.ReadOnly = True
        Me.RtbHelp.Size = New System.Drawing.Size(259, 207)
        Me.RtbHelp.TabIndex = 4
        Me.RtbHelp.Text = "/\" & Global.Microsoft.VisualBasic.ChrW(10) & "Please select whether you want help for:" & Global.Microsoft.VisualBasic.ChrW(10) & "1) How to play the game" & Global.Microsoft.VisualBasic.ChrW(10) & "2) How to cha" & _
    "nge settings" & Global.Microsoft.VisualBasic.ChrW(10) & "3) How replays work"
        '
        'BtnReplayHelp
        '
        Me.BtnReplayHelp.Location = New System.Drawing.Point(197, 13)
        Me.BtnReplayHelp.Name = "BtnReplayHelp"
        Me.BtnReplayHelp.Size = New System.Drawing.Size(75, 23)
        Me.BtnReplayHelp.TabIndex = 3
        Me.BtnReplayHelp.Text = "Replays"
        Me.BtnReplayHelp.UseVisualStyleBackColor = True
        '
        'BtnSettingsHelp
        '
        Me.BtnSettingsHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSettingsHelp.Location = New System.Drawing.Point(94, 13)
        Me.BtnSettingsHelp.Name = "BtnSettingsHelp"
        Me.BtnSettingsHelp.Size = New System.Drawing.Size(97, 23)
        Me.BtnSettingsHelp.TabIndex = 2
        Me.BtnSettingsHelp.Text = "Settings"
        Me.BtnSettingsHelp.UseVisualStyleBackColor = True
        '
        'BtnGamePlayHelp
        '
        Me.BtnGamePlayHelp.Location = New System.Drawing.Point(13, 13)
        Me.BtnGamePlayHelp.Name = "BtnGamePlayHelp"
        Me.BtnGamePlayHelp.Size = New System.Drawing.Size(75, 23)
        Me.BtnGamePlayHelp.TabIndex = 1
        Me.BtnGamePlayHelp.Text = "How to play"
        Me.BtnGamePlayHelp.UseVisualStyleBackColor = True
        '
        'FrmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RtbHelp)
        Me.Controls.Add(Me.BtnReplayHelp)
        Me.Controls.Add(Me.BtnSettingsHelp)
        Me.Controls.Add(Me.BtnGamePlayHelp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "FrmHelp"
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RtbHelp As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnReplayHelp As System.Windows.Forms.Button
    Friend WithEvents BtnSettingsHelp As System.Windows.Forms.Button
    Friend WithEvents BtnGamePlayHelp As System.Windows.Forms.Button
End Class
