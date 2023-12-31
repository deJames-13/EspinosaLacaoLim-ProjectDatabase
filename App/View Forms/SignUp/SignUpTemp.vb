﻿Public Class SignUpTemp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SignUpPage1.Hide()
        LogInForm.Show()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If Not validInputs({first_name, last_name, user_email, user_password, confirm_password}) Then
            Return
        End If

        If user_password.Text <> confirm_password.Text Then
            MsgBox("Password does not match!", MsgBoxStyle.Exclamation, "Password Mismatch!")
            Return
        End If

        If Not chkTerms.Checked Then
            Return
        End If


        new_user_info = New Dictionary(Of String, String)
        new_user_info("first_name") = $"'{first_name.Text}'"
        new_user_info("last_name") = $"'{last_name.Text}'"
        new_user_info("middle_name") = $"'{middle_name.Text}'"
        new_user_info("email") = $"'{user_email.Text}'"
        new_user_info("password") = $"'{user_password.Text}'"
        switchPanel(_signup2.mainPanel, mainPanel)
    End Sub









    '
    '  PASSWORD TOGGLE
    '
    Dim isShowPass1 As Boolean = False
    Dim isShowPass2 As Boolean = False
    Private Sub togglePass1_Click(sender As Object, e As EventArgs) Handles togglePass1.Click
        togglePass1.Image = Nothing
        If isShowPass1 Then
            togglePass1.Image = My.Resources.icons8_closed_eye_20
            user_password.PasswordChar = "•"
            isShowPass1 = False
        Else
            togglePass1.Image = My.Resources.icons8_eye_20
            user_password.PasswordChar = ""
            isShowPass1 = True
        End If
    End Sub

    Private Sub togglePass2_Click(sender As Object, e As EventArgs) Handles togglePass2.Click
        togglePass2.Image = Nothing
        If isShowPass2 Then
            togglePass2.Image = My.Resources.icons8_closed_eye_20
            confirm_password.PasswordChar = "•"
            isShowPass2 = False
        Else
            togglePass2.Image = My.Resources.icons8_eye_20
            confirm_password.PasswordChar = ""
            isShowPass2 = True
        End If
    End Sub
End Class