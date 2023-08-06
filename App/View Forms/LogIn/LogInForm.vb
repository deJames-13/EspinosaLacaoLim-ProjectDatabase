Imports System.Runtime.Hosting

Public Class LogInForm

    Private Sub _login_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub _login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        If isConnected() Then
            Me.Show()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub togglePass_Click(sender As Object, e As EventArgs) Handles togglePass.Click

        togglePass.Image = Nothing

        Select Case togglePass.ForeColor
            Case Color.Black
                togglePass.Image = My.Resources.icons8_closed_eye_20
                togglePass.ForeColor = Color.Red
                txtPass.PasswordChar = "•"
            Case Color.Red
                togglePass.Image = My.Resources.icons8_eye_20
                txtPass.PasswordChar = ""
                togglePass.ForeColor = Color.Black
        End Select



    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignUpPage1.ShowDialog()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not isValidUser(txtUsername.Text, txtPass.Text, role) Then
            Return
        End If

        SetCurrentUser(txtUsername.Text, role)

        Dim get_role As String = "No Role"
        Select Case role
            Case "user"
                Me.Hide()
                Try
                    AdminHomePage.user_role = get_role
                    If IsNumeric(current_user("role_id")) Then
                        get_role = SelectWhere("role", $"id={current_user("role_id")}", "name")(0)(0)
                        AdminHomePage.user_role = get_role
                    End If



                    AdminHomePage.user = current_user
                Catch ex As Exception
                End Try
                AdminHomePage.ShowDialog()



            Case "customer"
                Me.Hide()
                HomePage.Show()
        End Select

    End Sub

End Class