Imports System.Runtime.InteropServices

Public Class MainApplication
    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the main application
    End Sub
    Private Sub MainApplication_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        ' Load the main application

    End Sub

    Private Sub OnRoleSelection(sender As Object, e As EventArgs) Handles btnAdmin.Click, btnCustomer.Click
        Me.Hide()
        If Not isConnected() Then Application.Exit() : Return

        Select Case sender.name
            Case "btnCustomer"

                role = "customer"
                'HomePage.ShowDialog()
                LogInForm.ShowDialog()


            Case "btnAdmin"

                role = "user"
                LogInForm.ShowDialog()
        End Select
    End Sub
End Class
