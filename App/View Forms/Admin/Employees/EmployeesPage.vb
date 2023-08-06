Public Class EmployeesPage
    Dim form_table As New DataTable
    Dim selectedRow As DataRow

    '
    ' PAGE SWITCH
    '
    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return
        Reload()
        ManageHandlers()
        cmbSorting.Items.Clear()
        cmbSorting.Items.Add("All")
        For Each col As DataGridViewColumn In empGrid.Columns
            cmbSorting.Items.Add(col.HeaderText)
        Next
    End Sub
    '
    ' BUTTONS / ACTIONS QUERIES
    '
    Private Sub handleActionQueries(sender As Object, e As EventArgs) Handles btnCreate.Click, btnDelete.Click, btnEdit.Click

        If selectedRow Is Nothing And sender.name <> "btnCreate" Then Return



        Select Case sender.name
            Case "btnCreate"
                '
                ' CREATE NEW EMPLOYEE - opens dialog for creating new employee
                '
                EmployeeInfoDialog.state = "create"
                EmployeeInfoDialog.pageTitle.Text = "Create Account"

            Case "btnEdit"
                '
                ' EDIT EMPLOYEE - opens dialog for editing employee info
                '
                EmployeeInfoDialog.employee = DataRowToDictionary(selectedRow)
                EmployeeInfoDialog.state = "edit"
                EmployeeInfoDialog.pageTitle.Text = "Edit Info"


            Case "btnDelete"
                '
                ' DELETE EMPLOYEE - deletes employee from database
                '

                If MsgBox($"Are you sure you want to delete {selectedRow("first_name")} {selectedRow("last_name")}'s account?", MsgBoxStyle.YesNo, "Delete Account") = MsgBoxResult.No Then Return

                Dim data As New Dictionary(Of String, Object) From {
                    {"action", "delete_user"},
                    {"id", selectedRow("id")}
                }
                AdminTransactions(data)
                Reload()

                Exit Sub

        End Select

        switchPanel(EmployeeInfoDialog.windowWrapper, windowWrapper)
    End Sub
    '
    ' SELECT CELL ROW
    '
    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles empGrid.CellClick
        If e.RowIndex < 0 Then Return

        selectedRow = empGrid.Rows(e.RowIndex).DataBoundItem.Row
        labelSelected.Text = $"Employee {selectedRow("id")}: {selectedRow("first_name")} {selectedRow("last_name")}"
    End Sub
    '
    ' RELOADING CONTROLS
    '
    Private Sub Reload()
        empGrid.Columns.Clear()
        empGrid.Hide()
        empGrid.DataSource = Nothing
        form_table = LoadToGrid("user", empGrid, "*")
        rowCount.Text = form_table.Rows.Count
        empGrid.Show()
    End Sub
    '
    ' MANAGE HANDLERS
    '
    Private Sub ManageHandlers()
        Try
            RemoveHandler empGrid.CellClick, AddressOf SelectCellRow
            AddHandler empGrid.CellClick, AddressOf SelectCellRow
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        empGrid.Columns.Clear()
        empGrid.Hide()
        empGrid.DataSource = Nothing
        form_table = QueryToGrid($"SELECT * FROM user WHERE name='{txtSearch.Text}'", empGrid)
        rowCount.Text = form_table.Rows.Count
        empGrid.Show()
    End Sub
End Class