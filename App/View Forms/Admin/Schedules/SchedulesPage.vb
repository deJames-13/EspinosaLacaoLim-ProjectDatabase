Imports System.Linq.Expressions

Public Class SchedulesPage

    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return
        Reload()
        ManageHandlers()

    End Sub

    Private Sub Reload()
        LoadSchedules()
    End Sub




    Private Sub ManageHandlers()

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim new_sched As New ScheduleDialog
        new_sched.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        switchPanel(prevPage, currentPage)
    End Sub




    Public Sub CreateNewPost(sched_date As String, sched_time As String, sched_day As String, emp_name As String, emp_id As Integer, Optional isSave As Boolean = True)

        Dim post_schedule As New SchedulePost
        Dim index As Integer = schedule_posts.Controls.Count + 1
        post_schedule.TopLevel = False
        post_schedule.Dock = DockStyle.Top
        post_schedule.Name = "posted_sched_" & index


        post_schedule.shift_date.Text = $"{sched_date} {sched_time}"
        post_schedule.shift_day.Text = sched_day
        post_schedule.employee_name.Text = $"Assigned: {emp_name}"

        Select Case DateTime.Parse(sched_time).Hour
            Case 6 To 11
                post_schedule.shift_type.Text = "Morning"
            Case 12 To 17
                post_schedule.shift_type.Text = "Afternoon"
            Case 18 To 23
                post_schedule.shift_type.Text = "Evening"
        End Select

        post_schedule.Show()
        schedule_posts.Controls.Add(post_schedule)
        schedule_posts.Refresh()

        If Not isSave Then Return

        Dim schedule_info As New Dictionary(Of String, Object) From {
            {"id", GetLastId("schedule_info") + 1},
            {"schedule_date", sched_date},
            {"schedule_time", sched_time},
            {"shift_type", post_schedule.shift_type.Text}
        }

        Dim data As New Dictionary(Of String, Object) From {
            {"schedule_info", schedule_info},
            {"schedule",
                New Dictionary(Of String, Object) From {
                    {"schedule_id", schedule_info("id")},
                    {"user_id", emp_id}
                }
            }
        }
        data.Add("action", "new_schedule")
        AdminTransactions(data)

    End Sub

    Private Sub LoadSchedules()
        ' sched_date As String, sched_time As String, sched_day As String, emp_name As String, emp_id As Integer
        Dim query As String = $"
        SELECT 
        scheds.user_id as emp_id,
        CONCAT(u.first_name,"" "",u.last_name) as emp_name,
        info.schedule_date as sched_date,
        info.schedule_time as sched_time,
        info.shift_type as shift_type

        FROM user_has_schedules as scheds
        INNER JOIN schedule_info as info
        ON scheds.schedule_id = info.id
        INNER JOIN `user` as u
        ON scheds.user_id = u.id
        ;
        "
        Dim result As DataTable = ExecuteQuery(query)
        If result.Rows.Count = 0 Then Return

        schedule_posts.Controls.Clear()
        schedule_posts.Hide()

        For Each row In result.Rows

            Dim sched_day As String = DateTime.Parse(row("sched_date")).ToString("dddd")
            Dim sched_time As TimeSpan = row("sched_time")
            Dim emp_name As String = row("emp_name")
            Dim emp_id As Integer = row("emp_id")
            CreateNewPost(row("sched_date"), sched_time.ToString, sched_day, emp_name, emp_id, False)
            schedule_posts.Refresh()

        Next
        schedule_posts.Show()



    End Sub

End Class