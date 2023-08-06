<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsPage
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pageTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.titleIcon = New System.Windows.Forms.PictureBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnOrdersReport = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProductReport = New System.Windows.Forms.Button()
        Me.reportWizard1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.windowWrapper.SuspendLayout()
        Me.contentWrapper.SuspendLayout()
        Me.contentContainer.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.contentWrapper.TabIndex = 8
        '
        'contentContainer
        '
        Me.contentContainer.Controls.Add(Me.Panel5)
        Me.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentContainer.Location = New System.Drawing.Point(5, 76)
        Me.contentContainer.Name = "contentContainer"
        Me.contentContainer.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.contentContainer.Size = New System.Drawing.Size(934, 540)
        Me.contentContainer.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(10, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel5.Size = New System.Drawing.Size(914, 530)
        Me.Panel5.TabIndex = 30
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.reportWizard1)
        Me.Panel10.Controls.Add(Me.Panel9)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel10.Size = New System.Drawing.Size(914, 525)
        Me.Panel10.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.pageTitle)
        Me.Panel7.Controls.Add(Me.Panel2)
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
        Me.pageTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pageTitle.Font = New System.Drawing.Font("Lexend", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageTitle.Location = New System.Drawing.Point(62, 2)
        Me.pageTitle.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.pageTitle.Name = "pageTitle"
        Me.pageTitle.Size = New System.Drawing.Size(172, 58)
        Me.pageTitle.TabIndex = 27
        Me.pageTitle.Text = "Reports"
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.titleIcon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(60, 64)
        Me.Panel2.TabIndex = 26
        '
        'titleIcon
        '
        Me.titleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.titleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.titleIcon.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_reports_100
        Me.titleIcon.Location = New System.Drawing.Point(5, 5)
        Me.titleIcon.Name = "titleIcon"
        Me.titleIcon.Size = New System.Drawing.Size(50, 54)
        Me.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.titleIcon.TabIndex = 25
        Me.titleIcon.TabStop = False
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
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(3, 452)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel9.Size = New System.Drawing.Size(908, 70)
        Me.Panel9.TabIndex = 34
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(896, 58)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnOrdersReport)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(453, 5)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(214, 48)
        Me.Panel3.TabIndex = 15
        '
        'btnOrdersReport
        '
        Me.btnOrdersReport.AutoSize = True
        Me.btnOrdersReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOrdersReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnOrdersReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdersReport.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnOrdersReport.Location = New System.Drawing.Point(5, 5)
        Me.btnOrdersReport.Name = "btnOrdersReport"
        Me.btnOrdersReport.Size = New System.Drawing.Size(204, 38)
        Me.btnOrdersReport.TabIndex = 1
        Me.btnOrdersReport.Text = "Orders Report"
        Me.btnOrdersReport.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnProductReport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(677, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(214, 48)
        Me.Panel1.TabIndex = 14
        '
        'btnProductReport
        '
        Me.btnProductReport.AutoSize = True
        Me.btnProductReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProductReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnProductReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductReport.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnProductReport.Location = New System.Drawing.Point(5, 5)
        Me.btnProductReport.Name = "btnProductReport"
        Me.btnProductReport.Size = New System.Drawing.Size(204, 38)
        Me.btnProductReport.TabIndex = 1
        Me.btnProductReport.Text = "Product Report"
        Me.btnProductReport.UseVisualStyleBackColor = True
        '
        'reportWizard1
        '
        Me.reportWizard1.ActiveViewIndex = -1
        Me.reportWizard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportWizard1.Cursor = System.Windows.Forms.Cursors.Default
        Me.reportWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportWizard1.Location = New System.Drawing.Point(3, 3)
        Me.reportWizard1.Name = "reportWizard1"
        Me.reportWizard1.Size = New System.Drawing.Size(908, 449)
        Me.reportWizard1.TabIndex = 35
        '
        'ReportsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportsPage"
        Me.Text = "_reports"
        Me.windowWrapper.ResumeLayout(False)
        Me.contentWrapper.ResumeLayout(False)
        Me.contentContainer.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents contentWrapper As Panel
    Friend WithEvents contentContainer As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents pageTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents titleIcon As PictureBox
    Friend WithEvents reportWizard1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnOrdersReport As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProductReport As Button
End Class
