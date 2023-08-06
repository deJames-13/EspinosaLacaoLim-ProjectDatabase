<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _settingspage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.windowWrapper = New System.Windows.Forms.Panel()
        Me.panelSettings = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteAccount = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.bntLogOut = New System.Windows.Forms.Button()
        Me.windowWrapper.SuspendLayout()
        Me.panelSettings.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.Controls.Add(Me.panelSettings)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 2
        '
        'panelSettings
        '
        Me.panelSettings.Controls.Add(Me.Panel2)
        Me.panelSettings.Controls.Add(Me.Panel11)
        Me.panelSettings.Location = New System.Drawing.Point(370, 196)
        Me.panelSettings.Name = "panelSettings"
        Me.panelSettings.Size = New System.Drawing.Size(200, 160)
        Me.panelSettings.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnDeleteAccount)
        Me.Panel2.Location = New System.Drawing.Point(35, 21)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(130, 50)
        Me.Panel2.TabIndex = 18
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.AutoSize = True
        Me.btnDeleteAccount.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnDeleteAccount.Location = New System.Drawing.Point(5, 5)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteAccount.TabIndex = 1
        Me.btnDeleteAccount.Text = "Delete Account"
        Me.btnDeleteAccount.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.bntLogOut)
        Me.Panel11.Location = New System.Drawing.Point(35, 90)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(130, 50)
        Me.Panel11.TabIndex = 17
        '
        'bntLogOut
        '
        Me.bntLogOut.AutoSize = True
        Me.bntLogOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bntLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.bntLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntLogOut.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.bntLogOut.Location = New System.Drawing.Point(5, 5)
        Me.bntLogOut.Name = "bntLogOut"
        Me.bntLogOut.Size = New System.Drawing.Size(120, 40)
        Me.bntLogOut.TabIndex = 1
        Me.bntLogOut.Text = "Log Out"
        Me.bntLogOut.UseVisualStyleBackColor = True
        '
        '_settingspage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_settingspage"
        Me.Text = "_settingspage"
        Me.windowWrapper.ResumeLayout(False)
        Me.panelSettings.ResumeLayout(False)
        Me.panelSettings.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents panelSettings As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents bntLogOut As Button
End Class
