<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchedulesPage
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
        Me.contentWrapper = New System.Windows.Forms.Panel()
        Me.contentContainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.schedule_posts = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pageTitle = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.contentWrapper.SuspendLayout()
        Me.contentContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel24.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel34.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.contentWrapper)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Padding = New System.Windows.Forms.Padding(20)
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 6
        '
        'contentWrapper
        '
        Me.contentWrapper.Controls.Add(Me.contentContainer)
        Me.contentWrapper.Controls.Add(Me.Panel7)
        Me.contentWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentWrapper.Location = New System.Drawing.Point(20, 20)
        Me.contentWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.contentWrapper.Name = "contentWrapper"
        Me.contentWrapper.Padding = New System.Windows.Forms.Padding(5)
        Me.contentWrapper.Size = New System.Drawing.Size(944, 621)
        Me.contentWrapper.TabIndex = 9
        '
        'contentContainer
        '
        Me.contentContainer.Controls.Add(Me.Panel1)
        Me.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentContainer.Location = New System.Drawing.Point(5, 76)
        Me.contentContainer.Name = "contentContainer"
        Me.contentContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.contentContainer.Size = New System.Drawing.Size(934, 540)
        Me.contentContainer.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.schedule_posts)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(914, 520)
        Me.Panel1.TabIndex = 2
        '
        'schedule_posts
        '
        Me.schedule_posts.AutoScroll = True
        Me.schedule_posts.BackColor = System.Drawing.Color.White
        Me.schedule_posts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.schedule_posts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.schedule_posts.Location = New System.Drawing.Point(5, 45)
        Me.schedule_posts.Margin = New System.Windows.Forms.Padding(5)
        Me.schedule_posts.Name = "schedule_posts"
        Me.schedule_posts.Padding = New System.Windows.Forms.Padding(10, 10, 100, 50)
        Me.schedule_posts.Size = New System.Drawing.Size(902, 468)
        Me.schedule_posts.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(902, 40)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.btnCreate)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(176, 40)
        Me.Panel4.TabIndex = 42
        '
        'btnCreate
        '
        Me.btnCreate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Lexend", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_edit_20
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.Location = New System.Drawing.Point(5, 5)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(166, 30)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Post New Schedule"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.pageTitle)
        Me.Panel7.Controls.Add(Me.Panel24)
        Me.Panel7.Controls.Add(Me.Panel34)
        Me.Panel7.Controls.Add(Me.Panel21)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(5, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel7.Size = New System.Drawing.Size(934, 71)
        Me.Panel7.TabIndex = 23
        '
        'pageTitle
        '
        Me.pageTitle.AutoSize = True
        Me.pageTitle.BackColor = System.Drawing.Color.Transparent
        Me.pageTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.pageTitle.Font = New System.Drawing.Font("Lexend", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageTitle.Location = New System.Drawing.Point(62, 2)
        Me.pageTitle.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.pageTitle.Name = "pageTitle"
        Me.pageTitle.Size = New System.Drawing.Size(316, 58)
        Me.pageTitle.TabIndex = 60
        Me.pageTitle.Text = "View Schedules"
        '
        'Panel24
        '
        Me.Panel24.AutoSize = True
        Me.Panel24.Controls.Add(Me.PictureBox2)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(2, 2)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel24.Size = New System.Drawing.Size(60, 64)
        Me.Panel24.TabIndex = 59
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_schedule_100
        Me.PictureBox2.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Panel34
        '
        Me.Panel34.AutoSize = True
        Me.Panel34.BackColor = System.Drawing.Color.Transparent
        Me.Panel34.Controls.Add(Me.btnClose)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel34.Location = New System.Drawing.Point(902, 2)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Padding = New System.Windows.Forms.Padding(5, 22, 5, 22)
        Me.Panel34.Size = New System.Drawing.Size(30, 64)
        Me.Panel34.TabIndex = 57
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackgroundImage = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_close_15
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnClose.Location = New System.Drawing.Point(5, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel21.Location = New System.Drawing.Point(2, 66)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(930, 3)
        Me.Panel21.TabIndex = 1
        '
        'SchedulesPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SchedulesPage"
        Me.Text = "SchedulesPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.windowWrapper.ResumeLayout(False)
        Me.contentWrapper.ResumeLayout(False)
        Me.contentContainer.ResumeLayout(False)
        Me.contentContainer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents contentWrapper As Panel
    Friend WithEvents contentContainer As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pageTitle As Label
    Friend WithEvents Panel24 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel34 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCreate As Button
    Friend WithEvents schedule_posts As Panel
End Class
