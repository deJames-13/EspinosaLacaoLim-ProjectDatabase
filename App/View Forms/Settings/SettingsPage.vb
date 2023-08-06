Public Class _settingspage
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles bntLogOut.Click
        Application.Restart()
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        DeleteCustomerAccount()
    End Sub

    Private Sub windowWrapper_Paint(sender As Object, e As PaintEventArgs) Handles windowWrapper.Paint
        If role <> "customer" Then btnDeleteAccount.Hide()
        ' center panel
        Dim x As Integer = (windowWrapper.Width - panelSettings.Width) / 2
        Dim y As Integer = (windowWrapper.Height - panelSettings.Height) / 2
        panelSettings.Location = New Point(x, y)

    End Sub
End Class