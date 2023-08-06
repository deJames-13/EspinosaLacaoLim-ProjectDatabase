Public Class AdminHomePage

    Public user_role As String
    Public user As DataRow




    Private Sub _admin_home_closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub _admin_home_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToggleControls({btnReports, btnInventory, btnEmployees, btnPayroll, btnOrders}, True)

        Select Case user_role
            Case "Developer"
            Case "Admin"
            Case "Employee"
                ToggleControls({btnEmployees}, False)
                btnEmployees.Parent.BringToFront()

            Case "No Role"
                sidePanel.Enabled = False
                leftSection.Hide()
        End Select
    End Sub

    Private Sub _admin_home_shown(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If MyBase.Visible = False Then Return
    End Sub

    Private Sub OnNavClick(sender As Object, e As EventArgs) Handles MyBase.Load, btnInventory.Click, btnReports.Click, btnSettings.Click, btnEmployees.Click, btnOrders.Click, btnPayroll.Click, btnProfile.Click, btnSchedules.Click

        Reload()

        Select Case sender.name
            Case MyBase.Name
                If Not isConnected() Then Application.Exit() : Return
                MakeHandlers()

                switchPanel(InventoryPage.windowWrapper, windowWrapper)
            Case btnInventory.Name
                switchPanel(InventoryPage.windowWrapper, currentPage)
            Case btnReports.Name
                switchPanel(ReportsPage.windowWrapper, currentPage)
            Case btnSettings.Name
                switchPanel(_settingspage.windowWrapper, currentPage)
            Case btnEmployees.Name
                switchPanel(EmployeesPage.windowWrapper, currentPage)
            Case btnPayroll.Name
                switchPanel(PayrollPage.windowWrapper, currentPage)
            Case btnOrders.Name
                switchPanel(ManageOrdersPage.windowWrapper, currentPage)
            Case btnProfile.Name
                EmployeeInfoDialog.employee = DataRowToDictionary(current_user)
                EmployeeInfoDialog.state = "view"
                switchPanel(EmployeeInfoDialog.windowWrapper, currentPage)
            Case btnSchedules.Name
                switchPanel(SchedulesPage.windowWrapper, currentPage)
        End Select

    End Sub

    Private Sub Reload()
    End Sub



    Private Sub MakeHandlers()
        ButtonHoverEvents({btnInventory, btnReports, btnSettings, btnEmployees, btnPayroll, btnOrders})
    End Sub


End Class
