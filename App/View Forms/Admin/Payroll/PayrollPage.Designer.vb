<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollPage
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnView = New System.Windows.Forms.Button()
        Me.payrollGrid = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Net_Salary = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Gross_Salary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Pay_Grade = New System.Windows.Forms.TextBox()
        Me.labelpay = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Work_Hours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmbUserName = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Employee_Name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pageTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.titleIcon = New System.Windows.Forms.PictureBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.contentWrapper.SuspendLayout()
        Me.contentContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.payrollGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.contentContainer.Controls.Add(Me.Panel1)
        Me.contentContainer.Controls.Add(Me.Panel25)
        Me.contentContainer.Controls.Add(Me.Panel3)
        Me.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentContainer.Location = New System.Drawing.Point(5, 76)
        Me.contentContainer.Name = "contentContainer"
        Me.contentContainer.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.contentContainer.Size = New System.Drawing.Size(934, 540)
        Me.contentContainer.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Panel1.Size = New System.Drawing.Size(652, 530)
        Me.Panel1.TabIndex = 32
        '
        'Panel8
        '
        Me.Panel8.AutoSize = True
        Me.Panel8.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel8.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel8.Controls.Add(Me.payrollGrid)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel8.Size = New System.Drawing.Size(642, 530)
        Me.Panel8.TabIndex = 12
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.53798!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.1519!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.1519!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel19, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel18, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel17, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 463)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(632, 62)
        Me.TableLayoutPanel2.TabIndex = 40
        '
        'Panel19
        '
        Me.Panel19.AutoSize = True
        Me.Panel19.BackColor = System.Drawing.Color.Transparent
        Me.Panel19.Controls.Add(Me.btnAdd)
        Me.Panel19.Location = New System.Drawing.Point(6, 5)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel19.Size = New System.Drawing.Size(130, 50)
        Me.Panel19.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnAdd.Location = New System.Drawing.Point(5, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 40)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.AutoSize = True
        Me.Panel18.BackColor = System.Drawing.Color.Transparent
        Me.Panel18.Controls.Add(Me.btnDelete)
        Me.Panel18.Location = New System.Drawing.Point(146, 5)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel18.Size = New System.Drawing.Size(130, 50)
        Me.Panel18.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnDelete.Location = New System.Drawing.Point(5, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 40)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Panel17
        '
        Me.Panel17.AutoSize = True
        Me.Panel17.BackColor = System.Drawing.Color.Transparent
        Me.Panel17.Controls.Add(Me.btnView)
        Me.Panel17.Location = New System.Drawing.Point(497, 5)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel17.Size = New System.Drawing.Size(130, 50)
        Me.Panel17.TabIndex = 13
        '
        'btnView
        '
        Me.btnView.AutoSize = True
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnView.Location = New System.Drawing.Point(5, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(120, 40)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View History"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'payrollGrid
        '
        Me.payrollGrid.AllowUserToAddRows = False
        Me.payrollGrid.AllowUserToDeleteRows = False
        Me.payrollGrid.AllowUserToResizeColumns = False
        Me.payrollGrid.AllowUserToResizeRows = False
        Me.payrollGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.payrollGrid.BackgroundColor = System.Drawing.Color.White
        Me.payrollGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.payrollGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.payrollGrid.Location = New System.Drawing.Point(5, 37)
        Me.payrollGrid.Name = "payrollGrid"
        Me.payrollGrid.ReadOnly = True
        Me.payrollGrid.RowTemplate.Height = 25
        Me.payrollGrid.Size = New System.Drawing.Size(632, 420)
        Me.payrollGrid.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel34)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(5, 5)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel9.Size = New System.Drawing.Size(632, 32)
        Me.Panel9.TabIndex = 45
        '
        'Panel34
        '
        Me.Panel34.AutoSize = True
        Me.Panel34.BackColor = System.Drawing.Color.Transparent
        Me.Panel34.Controls.Add(Me.btnRefresh)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel34.Location = New System.Drawing.Point(609, 3)
        Me.Panel34.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(20, 26)
        Me.Panel34.TabIndex = 58
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.BackgroundImage = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_refresh_20
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnRefresh.Location = New System.Drawing.Point(0, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(20, 26)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Gross Salary"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.DimGray
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel25.Location = New System.Drawing.Point(662, 10)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(2, 530)
        Me.Panel25.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel14)
        Me.Panel3.Controls.Add(Me.Panel13)
        Me.Panel3.Controls.Add(Me.Panel12)
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.Panel20)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel26)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(664, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.Panel3.Size = New System.Drawing.Size(260, 530)
        Me.Panel3.TabIndex = 31
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DimGray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(10, 373)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(245, 1)
        Me.Panel14.TabIndex = 46
        '
        'Panel13
        '
        Me.Panel13.AutoSize = True
        Me.Panel13.Controls.Add(Me.Net_Salary)
        Me.Panel13.Controls.Add(Me.Label8)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(10, 325)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.Panel13.Size = New System.Drawing.Size(245, 48)
        Me.Panel13.TabIndex = 45
        '
        'Net_Salary
        '
        Me.Net_Salary.BackColor = System.Drawing.Color.AliceBlue
        Me.Net_Salary.Dock = System.Windows.Forms.DockStyle.Top
        Me.Net_Salary.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net_Salary.Location = New System.Drawing.Point(115, 23)
        Me.Net_Salary.Name = "Net_Salary"
        Me.Net_Salary.ReadOnly = True
        Me.Net_Salary.Size = New System.Drawing.Size(127, 22)
        Me.Net_Salary.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.Label8.Size = New System.Drawing.Size(112, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Net Salary"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.AutoSize = True
        Me.Panel12.Controls.Add(Me.Gross_Salary)
        Me.Panel12.Controls.Add(Me.Label7)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(10, 277)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.Panel12.Size = New System.Drawing.Size(245, 48)
        Me.Panel12.TabIndex = 44
        '
        'Gross_Salary
        '
        Me.Gross_Salary.BackColor = System.Drawing.Color.AliceBlue
        Me.Gross_Salary.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gross_Salary.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gross_Salary.Location = New System.Drawing.Point(115, 23)
        Me.Gross_Salary.Name = "Gross_Salary"
        Me.Gross_Salary.ReadOnly = True
        Me.Gross_Salary.Size = New System.Drawing.Size(127, 22)
        Me.Gross_Salary.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.Label7.Size = New System.Drawing.Size(112, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Gross Salary"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DimGray
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(10, 276)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(245, 1)
        Me.Panel11.TabIndex = 35
        '
        'Panel20
        '
        Me.Panel20.AutoSize = True
        Me.Panel20.Controls.Add(Me.Pay_Grade)
        Me.Panel20.Controls.Add(Me.labelpay)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(10, 228)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.Panel20.Size = New System.Drawing.Size(245, 48)
        Me.Panel20.TabIndex = 40
        '
        'Pay_Grade
        '
        Me.Pay_Grade.BackColor = System.Drawing.Color.AliceBlue
        Me.Pay_Grade.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pay_Grade.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pay_Grade.Location = New System.Drawing.Point(115, 23)
        Me.Pay_Grade.Name = "Pay_Grade"
        Me.Pay_Grade.Size = New System.Drawing.Size(127, 22)
        Me.Pay_Grade.TabIndex = 32
        '
        'labelpay
        '
        Me.labelpay.Dock = System.Windows.Forms.DockStyle.Left
        Me.labelpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelpay.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelpay.Location = New System.Drawing.Point(3, 23)
        Me.labelpay.Name = "labelpay"
        Me.labelpay.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.labelpay.Size = New System.Drawing.Size(112, 22)
        Me.labelpay.TabIndex = 0
        Me.labelpay.Text = "Pay Grade"
        Me.labelpay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel16, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel15, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 463)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(245, 62)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'Panel16
        '
        Me.Panel16.AutoSize = True
        Me.Panel16.BackColor = System.Drawing.Color.Silver
        Me.Panel16.Controls.Add(Me.btnClear)
        Me.Panel16.Location = New System.Drawing.Point(127, 5)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel16.Size = New System.Drawing.Size(112, 50)
        Me.Panel16.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.BackColor = System.Drawing.Color.GhostWhite
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnClear.Location = New System.Drawing.Point(5, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 40)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Info"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel15
        '
        Me.Panel15.AutoSize = True
        Me.Panel15.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel15.Controls.Add(Me.btnCompute)
        Me.Panel15.Location = New System.Drawing.Point(5, 5)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel15.Size = New System.Drawing.Size(112, 50)
        Me.Panel15.TabIndex = 13
        '
        'btnCompute
        '
        Me.btnCompute.AutoSize = True
        Me.btnCompute.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCompute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCompute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCompute.FlatAppearance.BorderSize = 0
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnCompute.Location = New System.Drawing.Point(5, 5)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(102, 40)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.AutoSize = True
        Me.Panel10.Controls.Add(Me.Work_Hours)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(10, 160)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(3, 23, 3, 23)
        Me.Panel10.Size = New System.Drawing.Size(245, 68)
        Me.Panel10.TabIndex = 34
        '
        'Work_Hours
        '
        Me.Work_Hours.BackColor = System.Drawing.Color.AliceBlue
        Me.Work_Hours.Dock = System.Windows.Forms.DockStyle.Top
        Me.Work_Hours.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Work_Hours.Location = New System.Drawing.Point(115, 23)
        Me.Work_Hours.Name = "Work_Hours"
        Me.Work_Hours.Size = New System.Drawing.Size(127, 22)
        Me.Work_Hours.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.Label5.Size = New System.Drawing.Size(112, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Work Hours"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.AutoSize = True
        Me.Panel5.Controls.Add(Me.cmbUserName)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 78)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.Panel5.Size = New System.Drawing.Size(245, 82)
        Me.Panel5.TabIndex = 31
        '
        'cmbUserName
        '
        Me.cmbUserName.BackColor = System.Drawing.Color.AliceBlue
        Me.cmbUserName.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUserName.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.ItemHeight = 19
        Me.cmbUserName.Location = New System.Drawing.Point(3, 52)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.Size = New System.Drawing.Size(239, 27)
        Me.cmbUserName.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Username)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 23)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Panel6.Size = New System.Drawing.Size(239, 29)
        Me.Panel6.TabIndex = 0
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.AliceBlue
        Me.Username.Dock = System.Windows.Forms.DockStyle.Top
        Me.Username.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(112, 0)
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.Size = New System.Drawing.Size(127, 22)
        Me.Username.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel26
        '
        Me.Panel26.AutoSize = True
        Me.Panel26.Controls.Add(Me.Employee_Name)
        Me.Panel26.Controls.Add(Me.Label9)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel26.Location = New System.Drawing.Point(10, 30)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.Panel26.Size = New System.Drawing.Size(245, 48)
        Me.Panel26.TabIndex = 30
        '
        'Employee_Name
        '
        Me.Employee_Name.BackColor = System.Drawing.Color.AliceBlue
        Me.Employee_Name.Dock = System.Windows.Forms.DockStyle.Top
        Me.Employee_Name.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_Name.Location = New System.Drawing.Point(115, 23)
        Me.Employee_Name.Name = "Employee_Name"
        Me.Employee_Name.ReadOnly = True
        Me.Employee_Name.Size = New System.Drawing.Size(127, 22)
        Me.Employee_Name.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.Label9.Size = New System.Drawing.Size(112, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Employee Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 29)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(245, 1)
        Me.Panel4.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Payroll Info"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pageTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.pageTitle.Font = New System.Drawing.Font("Lexend", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageTitle.Location = New System.Drawing.Point(62, 2)
        Me.pageTitle.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.pageTitle.Name = "pageTitle"
        Me.pageTitle.Size = New System.Drawing.Size(158, 58)
        Me.pageTitle.TabIndex = 29
        Me.pageTitle.Text = "Payroll"
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
        Me.Panel2.TabIndex = 28
        '
        'titleIcon
        '
        Me.titleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.titleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.titleIcon.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_payroll_100
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
        'PayrollPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayrollPage"
        Me.Text = "_payroll"
        Me.windowWrapper.ResumeLayout(False)
        Me.contentWrapper.ResumeLayout(False)
        Me.contentContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.payrollGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents contentWrapper As Panel
    Friend WithEvents contentContainer As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents pageTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents titleIcon As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents payrollGrid As DataGridView
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Employee_Name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Work_Hours As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents btnCompute As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel17 As Panel
    Friend WithEvents btnView As Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Net_Salary As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Gross_Salary As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Pay_Grade As TextBox
    Friend WithEvents labelpay As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel34 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbUserName As ComboBox
End Class
