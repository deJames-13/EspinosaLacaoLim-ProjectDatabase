Imports System.Security.Principal

Public Class _signup2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        switchPanel(SignUpTemp.mainPanel, mainPanel)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        If Not validInputs({username, phone_number, city, country, street_address, zipcode}) Then
            Return
        End If

        If userExists(username.Text, role) Then
            MsgBox("Username already exists!", MsgBoxStyle.Exclamation, "Username Exists!")
            Return
        End If


        CreateUser()
        CleanFields()


        Me.Hide()
        SignUpPage1.Hide()
        LogInForm.Show()


    End Sub

    Private Sub CreateUser()



        Dim address As String = $"""{street_address.Text}, {city.Text}, {province.Text}, {country.Text}, {zipcode.Text}"""
        Dim age As Integer = DateTime.Now.Year - birthdate.Value.Year

        new_user_info("username") = $"""{username.Text}"""
        new_user_info("phone_number") = $"""{phone_number.Text}"""
        new_user_info("address") = address
        new_user_info("birthdate") = $"'{birthdate.Value.ToString("yyyy/MM/dd")}'"
        new_user_info("age") = age.ToString()


        Dim result As Integer = MsgBox("Do you want to save this account?", MsgBoxStyle.YesNo, "Confirm Account Creation")

        If Not result = DialogResult.Yes Then
            Return
        End If

        CreateAccount(new_user_info, role)


    End Sub
    Private Sub CleanFields()
        ' CLEAN ALL FIELDS
        Dim f As SignUpTemp = SignUpTemp
        ClearAll({
                     f.first_name, f.last_name, f.middle_name, f.user_email, f.user_password, f.confirm_password,
                     username, phone_number, city, province, country, street_address, zipcode
                })
    End Sub


End Class