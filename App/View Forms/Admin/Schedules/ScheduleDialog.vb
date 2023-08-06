Public Class ScheduleDialog
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Try
            Dim emp_id = cmbEmployee.SelectedValue
            Dim emp_name As String = cmbEmployee.Text
            Dim sched_date As String = shift_date.Value.ToString("yyyy/MM/dd")
            Dim sched_day As String = shift_date.Value.ToString("dddd")
            Dim sched_time As String = DateTime.Parse(shift_time.Text).ToString("HH:mm")


            SchedulesPage.CreateNewPost(sched_date, sched_time, sched_day, emp_name, emp_id)
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ScheduleDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEmployee.DataSource = Nothing
        cmbEmployee.Items.Clear()
        cmbEmployee.DataSource = SelectAllFrom("user", "CONCAT(first_name,' ',last_name) as EmployeeName, id")
        cmbEmployee.DisplayMember = "EmployeeName"
        cmbEmployee.ValueMember = "id"


        AddHandler btnSave.Click, AddressOf btnSave_Click
    End Sub
End Class