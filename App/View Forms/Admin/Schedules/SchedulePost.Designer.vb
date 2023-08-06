<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchedulePost
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
        Me.postWrapper = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.postContainer = New System.Windows.Forms.Panel()
        Me.rightSection = New System.Windows.Forms.Panel()
        Me.employee_name = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.shift_type = New System.Windows.Forms.Label()
        Me.shift_day = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.leftSection = New System.Windows.Forms.Panel()
        Me.shift_date = New System.Windows.Forms.Label()
        Me.windowWrapper.SuspendLayout()
        Me.postWrapper.SuspendLayout()
        Me.postContainer.SuspendLayout()
        Me.rightSection.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.leftSection.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.postWrapper)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Size = New System.Drawing.Size(790, 79)
        Me.windowWrapper.TabIndex = 6
        '
        'postWrapper
        '
        Me.postWrapper.Controls.Add(Me.Panel5)
        Me.postWrapper.Controls.Add(Me.postContainer)
        Me.postWrapper.Dock = System.Windows.Forms.DockStyle.Top
        Me.postWrapper.Location = New System.Drawing.Point(0, 0)
        Me.postWrapper.Name = "postWrapper"
        Me.postWrapper.Padding = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.postWrapper.Size = New System.Drawing.Size(790, 79)
        Me.postWrapper.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(10, 68)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(775, 1)
        Me.Panel5.TabIndex = 2
        '
        'postContainer
        '
        Me.postContainer.Controls.Add(Me.rightSection)
        Me.postContainer.Controls.Add(Me.Panel8)
        Me.postContainer.Controls.Add(Me.leftSection)
        Me.postContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.postContainer.Location = New System.Drawing.Point(10, 10)
        Me.postContainer.Name = "postContainer"
        Me.postContainer.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.postContainer.Size = New System.Drawing.Size(775, 59)
        Me.postContainer.TabIndex = 1
        '
        'rightSection
        '
        Me.rightSection.Controls.Add(Me.employee_name)
        Me.rightSection.Controls.Add(Me.Panel3)
        Me.rightSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightSection.Location = New System.Drawing.Point(236, 0)
        Me.rightSection.Name = "rightSection"
        Me.rightSection.Size = New System.Drawing.Size(519, 59)
        Me.rightSection.TabIndex = 3
        '
        'employee_name
        '
        Me.employee_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employee_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.employee_name.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_name.Location = New System.Drawing.Point(131, 0)
        Me.employee_name.Name = "employee_name"
        Me.employee_name.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.employee_name.Size = New System.Drawing.Size(388, 59)
        Me.employee_name.TabIndex = 3
        Me.employee_name.Text = "Employee Name: John Doe"
        Me.employee_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.shift_type)
        Me.Panel3.Controls.Add(Me.shift_day)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 59)
        Me.Panel3.TabIndex = 0
        '
        'shift_type
        '
        Me.shift_type.AutoSize = True
        Me.shift_type.Dock = System.Windows.Forms.DockStyle.Top
        Me.shift_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shift_type.Font = New System.Drawing.Font("Lexend Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shift_type.Location = New System.Drawing.Point(0, 35)
        Me.shift_type.Name = "shift_type"
        Me.shift_type.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.shift_type.Size = New System.Drawing.Size(89, 19)
        Me.shift_type.TabIndex = 3
        Me.shift_type.Text = "Night Shift"
        '
        'shift_day
        '
        Me.shift_day.AutoSize = True
        Me.shift_day.Dock = System.Windows.Forms.DockStyle.Top
        Me.shift_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shift_day.Font = New System.Drawing.Font("Lexend Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shift_day.Location = New System.Drawing.Point(0, 0)
        Me.shift_day.Name = "shift_day"
        Me.shift_day.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.shift_day.Size = New System.Drawing.Size(124, 35)
        Me.shift_day.TabIndex = 2
        Me.shift_day.Text = "MONDAY"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(233, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(3, 59)
        Me.Panel8.TabIndex = 2
        '
        'leftSection
        '
        Me.leftSection.Controls.Add(Me.shift_date)
        Me.leftSection.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftSection.Location = New System.Drawing.Point(0, 0)
        Me.leftSection.Name = "leftSection"
        Me.leftSection.Size = New System.Drawing.Size(233, 59)
        Me.leftSection.TabIndex = 0
        '
        'shift_date
        '
        Me.shift_date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shift_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shift_date.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shift_date.Location = New System.Drawing.Point(0, 0)
        Me.shift_date.Name = "shift_date"
        Me.shift_date.Size = New System.Drawing.Size(233, 59)
        Me.shift_date.TabIndex = 1
        Me.shift_date.Text = "MM-dd-yyyy HH:mm:ss a"
        Me.shift_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SchedulePost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 79)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(790, 79)
        Me.MinimumSize = New System.Drawing.Size(790, 79)
        Me.Name = "SchedulePost"
        Me.Text = "SchedulePost"
        Me.windowWrapper.ResumeLayout(False)
        Me.postWrapper.ResumeLayout(False)
        Me.postContainer.ResumeLayout(False)
        Me.rightSection.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.leftSection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents postWrapper As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents postContainer As Panel
    Friend WithEvents rightSection As Panel
    Friend WithEvents employee_name As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents shift_type As Label
    Friend WithEvents shift_day As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents leftSection As Panel
    Friend WithEvents shift_date As Label
End Class
