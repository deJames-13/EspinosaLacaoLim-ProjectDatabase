<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageOrdersPage
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ordGrid = New System.Windows.Forms.DataGridView()
        Me.gridInfo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rowCount = New System.Windows.Forms.Label()
        Me.labelSelected = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmbSorting = New System.Windows.Forms.ComboBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelivered = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnShip = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pageTitle = New System.Windows.Forms.Label()
        Me.titleIcon = New System.Windows.Forms.PictureBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.contentWrapper.SuspendLayout()
        Me.contentContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.ordGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel7.SuspendLayout()
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
        Me.contentWrapper.TabIndex = 9
        '
        'contentContainer
        '
        Me.contentContainer.Controls.Add(Me.Panel2)
        Me.contentContainer.Controls.Add(Me.Panel1)
        Me.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentContainer.Location = New System.Drawing.Point(5, 76)
        Me.contentContainer.Name = "contentContainer"
        Me.contentContainer.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.contentContainer.Size = New System.Drawing.Size(934, 540)
        Me.contentContainer.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.gridInfo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 74)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel2.Size = New System.Drawing.Size(914, 466)
        Me.Panel2.TabIndex = 35
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.ordGrid)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(10, 29)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel9.Size = New System.Drawing.Size(894, 432)
        Me.Panel9.TabIndex = 7
        '
        'ordGrid
        '
        Me.ordGrid.AllowUserToAddRows = False
        Me.ordGrid.AllowUserToDeleteRows = False
        Me.ordGrid.AllowUserToResizeRows = False
        Me.ordGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ordGrid.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.ordGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ordGrid.Location = New System.Drawing.Point(5, 5)
        Me.ordGrid.Name = "ordGrid"
        Me.ordGrid.ReadOnly = True
        Me.ordGrid.RowTemplate.Height = 25
        Me.ordGrid.Size = New System.Drawing.Size(882, 420)
        Me.ordGrid.TabIndex = 5
        '
        'gridInfo
        '
        Me.gridInfo.Controls.Add(Me.Label1)
        Me.gridInfo.Controls.Add(Me.rowCount)
        Me.gridInfo.Controls.Add(Me.labelSelected)
        Me.gridInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridInfo.Location = New System.Drawing.Point(10, 5)
        Me.gridInfo.Name = "gridInfo"
        Me.gridInfo.Size = New System.Drawing.Size(894, 24)
        Me.gridInfo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(813, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Items:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rowCount
        '
        Me.rowCount.AutoSize = True
        Me.rowCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.rowCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rowCount.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rowCount.Location = New System.Drawing.Point(868, 0)
        Me.rowCount.Name = "rowCount"
        Me.rowCount.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.rowCount.Size = New System.Drawing.Size(26, 24)
        Me.rowCount.TabIndex = 7
        Me.rowCount.Text = "0"
        Me.rowCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelSelected
        '
        Me.labelSelected.AutoSize = True
        Me.labelSelected.Dock = System.Windows.Forms.DockStyle.Left
        Me.labelSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelSelected.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSelected.Location = New System.Drawing.Point(0, 0)
        Me.labelSelected.Name = "labelSelected"
        Me.labelSelected.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.labelSelected.Size = New System.Drawing.Size(89, 24)
        Me.labelSelected.TabIndex = 4
        Me.labelSelected.Text = "Orders Table"
        Me.labelSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 64)
        Me.Panel1.TabIndex = 34
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Panel17)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(914, 64)
        Me.Panel14.TabIndex = 27
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Controls.Add(Me.Panel6)
        Me.Panel17.Controls.Add(Me.Panel5)
        Me.Panel17.Controls.Add(Me.Panel3)
        Me.Panel17.Controls.Add(Me.Panel4)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel17.Size = New System.Drawing.Size(813, 64)
        Me.Panel17.TabIndex = 38
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.Panel20)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(573, 10)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.Panel18.Size = New System.Drawing.Size(230, 44)
        Me.Panel18.TabIndex = 45
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.White
        Me.Panel19.Controls.Add(Me.txtSearch)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(5, 5)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Padding = New System.Windows.Forms.Padding(10, 5, 10, 0)
        Me.Panel19.Size = New System.Drawing.Size(225, 30)
        Me.Panel19.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(10, 5)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 20)
        Me.txtSearch.TabIndex = 3
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Black
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel20.Location = New System.Drawing.Point(5, 41)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(225, 3)
        Me.Panel20.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmbSorting)
        Me.Panel6.Controls.Add(Me.btnSort)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(373, 10)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.Panel6.Size = New System.Drawing.Size(200, 44)
        Me.Panel6.TabIndex = 44
        Me.Panel6.Visible = False
        '
        'cmbSorting
        '
        Me.cmbSorting.BackColor = System.Drawing.Color.GhostWhite
        Me.cmbSorting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSorting.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSorting.FormattingEnabled = True
        Me.cmbSorting.ItemHeight = 19
        Me.cmbSorting.Location = New System.Drawing.Point(85, 8)
        Me.cmbSorting.Name = "cmbSorting"
        Me.cmbSorting.Size = New System.Drawing.Size(110, 27)
        Me.cmbSorting.TabIndex = 7
        '
        'btnSort
        '
        Me.btnSort.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSort.FlatAppearance.BorderSize = 0
        Me.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSort.Font = New System.Drawing.Font("Lexend", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.ForeColor = System.Drawing.Color.Black
        Me.btnSort.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_ascending_sorting_15
        Me.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSort.Location = New System.Drawing.Point(5, 8)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(80, 31)
        Me.btnSort.TabIndex = 6
        Me.btnSort.Text = "Sort By"
        Me.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelivered)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.ForeColor = System.Drawing.Color.LightCoral
        Me.Panel5.Location = New System.Drawing.Point(262, 10)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(111, 44)
        Me.Panel5.TabIndex = 47
        '
        'btnDelivered
        '
        Me.btnDelivered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelivered.FlatAppearance.BorderSize = 0
        Me.btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivered.Font = New System.Drawing.Font("Lexend", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivered.ForeColor = System.Drawing.Color.Black
        Me.btnDelivered.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_delivered_20
        Me.btnDelivered.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelivered.Location = New System.Drawing.Point(5, 5)
        Me.btnDelivered.Name = "btnDelivered"
        Me.btnDelivered.Size = New System.Drawing.Size(101, 34)
        Me.btnDelivered.TabIndex = 1
        Me.btnDelivered.Text = "Delivered"
        Me.btnDelivered.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelivered.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.ForeColor = System.Drawing.Color.LightCoral
        Me.Panel3.Location = New System.Drawing.Point(129, 10)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(133, 44)
        Me.Panel3.TabIndex = 42
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Lexend", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_cancel_20
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(5, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 34)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel Order"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnShip)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(10, 10)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(119, 44)
        Me.Panel4.TabIndex = 46
        '
        'btnShip
        '
        Me.btnShip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShip.FlatAppearance.BorderSize = 0
        Me.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShip.Font = New System.Drawing.Font("Lexend", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShip.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_shipping_20
        Me.btnShip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShip.Location = New System.Drawing.Point(5, 5)
        Me.btnShip.Name = "btnShip"
        Me.btnShip.Size = New System.Drawing.Size(109, 34)
        Me.btnShip.TabIndex = 1
        Me.btnShip.Text = "Ship Order"
        Me.btnShip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShip.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.btnSearch)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(813, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Padding = New System.Windows.Forms.Padding(5, 15, 5, 10)
        Me.Panel15.Size = New System.Drawing.Size(101, 64)
        Me.Panel15.TabIndex = 37
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Lexend", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(5, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 39)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.pageTitle)
        Me.Panel7.Controls.Add(Me.titleIcon)
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
        Me.pageTitle.Location = New System.Drawing.Point(72, 2)
        Me.pageTitle.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.pageTitle.Name = "pageTitle"
        Me.pageTitle.Size = New System.Drawing.Size(152, 58)
        Me.pageTitle.TabIndex = 25
        Me.pageTitle.Text = "Orders"
        '
        'titleIcon
        '
        Me.titleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.titleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.titleIcon.Image = Global.ProjectWithCrystalReport2.My.Resources.Resources.icons8_order_100
        Me.titleIcon.Location = New System.Drawing.Point(2, 2)
        Me.titleIcon.Name = "titleIcon"
        Me.titleIcon.Size = New System.Drawing.Size(70, 64)
        Me.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.titleIcon.TabIndex = 24
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
        'ManageOrdersPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageOrdersPage"
        Me.Text = "_manage_orderspage"
        Me.windowWrapper.ResumeLayout(False)
        Me.contentWrapper.ResumeLayout(False)
        Me.contentContainer.ResumeLayout(False)
        Me.contentContainer.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.ordGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridInfo.ResumeLayout(False)
        Me.gridInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents contentWrapper As Panel
    Friend WithEvents contentContainer As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ordGrid As DataGridView
    Friend WithEvents gridInfo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents rowCount As Label
    Friend WithEvents labelSelected As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pageTitle As Label
    Friend WithEvents titleIcon As PictureBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnShip As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnDelivered As Button
    Friend WithEvents cmbSorting As ComboBox
    Friend WithEvents btnSort As Button
End Class
