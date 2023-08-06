
Public Class PayrollPage

    Dim selectedRow As DataRow


    Private Sub onPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged

        If windowWrapper.ForeColor <> activeForeColor Then Return

        Reload()

        ManageHandlers()
    End Sub

    Private Sub Reload()

        If AdminHomePage.user_role = "Employee" Then ToggleControls({btnAdd, btnCompute, btnDelete, cmbUserName}, False)
        Clearr()
        payrollGrid.DataSource = Nothing
        cmbUserName.DataSource = Nothing
        cmbUserName.DataSource = SelectAllFrom(
            "user",
            "username, 
            CONCAT(first_name, ' ', last_name) as EmployeeName")
        ' set name as value
        cmbUserName.DisplayMember = "username"
        cmbUserName.ValueMember = "EmployeeName"
        cmbUserName.SelectedIndex = -1

        Dim statement As String = $"SELECT u.id AS EMPLOYEE_ID,u.username,  u.first_name, s.id AS Salary_id , uhs.payGrade , s.hoursWorked,b.id AS Benefits_id, b.pagIbig, b.sss, b.philHealth, s.gross_amount, s.net_amount AS Total, uhs.created_at
                                    FROM user AS u
                                    JOIN user_has_salary AS uhs ON uhs.user_id = u.id
                                    JOIN salary AS s ON s.id = uhs.salary_id
                                    JOIN benefits AS b ON b.id = s.benefits_id
                                    {IIf(AdminHomePage.user_role = "Employee",
                                         $"WHERE u.id = {current_user("id")}",
                                         "")}
                                    ORDER BY u.id ASC;"


        payrollGrid.DataSource = dtablefill(statement)



    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs) Handles btnAdd.Click, btnDelete.Click, btnClear.Click, btnCompute.Click

        If validInputs({Employee_Name, Username, Work_Hours, Pay_Grade}) = False Then Return

        Select Case sender.Name
            Case "btnAdd"
                InsPR()
            Case "btnDelete"
                If selectedRow Is Nothing Then Return
                Del()
            Case "btnClear"
                Clearr()
            Case "btnCompute"
                Comp()
        End Select

    End Sub
    Private Sub payrollGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles payrollGrid.CellClick

        If e.RowIndex < 0 Then Return

        selectedRow = payrollGrid.Rows(e.RowIndex).DataBoundItem.Row

        Employee_Name.Text = payrollGrid.Rows(e.RowIndex).Cells(2).Value.ToString
        Username.Text = payrollGrid.Rows(e.RowIndex).Cells(1).Value.ToString
        Pay_Grade.Text = payrollGrid.Rows(e.RowIndex).Cells(4).Value.ToString
        Work_Hours.Text = payrollGrid.Rows(e.RowIndex).Cells(5).Value.ToString
        Gross_Salary.Text = payrollGrid.Rows(e.RowIndex).Cells(10).Value.ToString
        Net_Salary.Text = payrollGrid.Rows(e.RowIndex).Cells(11).Value.ToString

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnView.Click, btnRefresh.Click
        Reload()
    End Sub

    Private Sub cmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbUserName.SelectedIndex < 0 Then Return

        Dim selectedValue As String = cmbUserName.SelectedValue.ToString
        Employee_Name.Text = selectedValue
        Username.Text = cmbUserName.Text

    End Sub


    Private Sub ManageHandlers()
        RemoveHandler payrollGrid.CellClick, AddressOf SelectCellRow
        RemoveHandler cmbUserName.SelectedIndexChanged, AddressOf cmbUserName_SelectedIndexChanged
        AddHandler payrollGrid.CellClick, AddressOf SelectCellRow
        AddHandler cmbUserName.SelectedIndexChanged, AddressOf cmbUserName_SelectedIndexChanged
    End Sub

End Class