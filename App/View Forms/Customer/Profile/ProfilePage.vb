Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class _profilepage

    Private user_info_controls As ArrayList
    Private profile_info As Dictionary(Of String, Object)

    Private Sub windowWrapper_ForeColorChanged(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged

        If Not windowWrapper.ForeColor = activeForeColor Then Return
        Reload()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click, btnLogOut.Click

        Select Case sender.text
            Case "Edit"
                btnEdit.Text = "Save"
                btnEdit.BackColor = Color.PaleGreen
                btnLogOut.Text = "Cancel"
                toggleEnable(user_info_controls, True)
                btnSelectImage.Visible = True
                image_dir.Visible = True

            Case "Save", "Cancel"
                If sender.text = "Save" Then UpdateInfo()
                btnSelectImage.Visible = False
                image_dir.Visible = False

                Reload()

            Case "Log Out"
                Application.Restart()
        End Select

    End Sub


    Private Sub toggleEnable(ByRef controls As ArrayList, state As Boolean)
        For Each c In controls
            c.enabled = state
        Next
    End Sub

    Private Sub UpdateInfo()

        If profile_info("username") <> username.Text AndAlso userExists(username.Text) Then
            MsgBox("Username already exists")
            username.Focus()
            Return
        End If

        Dim age As Integer = DateTime.Now.Year - birthdate.Value.Year
        profile_info("first_name") = first_name.Text
        profile_info("last_name") = last_name.Text
        profile_info("middle_name") = middle_name.Text

        If current_user("username") <> username.Text.Trim And userExists(username.Text) Then
            MsgBox("Username already exists")
            username.Focus()
            Return
        End If

        profile_info("username") = username.Text

        profile_info("email") = email.Text
        profile_info("password") = password.Text
        profile_info("address") = $"{street_address.Text}, {user_city.Text}, {user_region.Text}, {country.Text}, {zipcode.Text}"
        profile_info("phone_number") = phone_number.Text
        profile_info("birthdate") = $"{birthdate.Value.ToString("yyyy/MM/dd")}"
        profile_info("age") = age.ToString()

        UpdateAccount(profile_info)
    End Sub

    Private Sub Reload()
        SetCurrentUser(current_user("username"))
        profile_info = DataRowToDictionary(current_user)

        btnSelectImage.Visible = False
        image_dir.Visible = False
        btnEdit.Text = "Edit"
        btnEdit.BackColor = Color.Transparent
        btnLogOut.Text = "Log Out"
        user_info_controls = New ArrayList({
                first_name,
                last_name,
                middle_name,
                username,
                email,
                password,
                street_address,
                user_city,
                user_region,
                zipcode,
                country,
                phone_number,
                birthdate,
                btnSelectImage,
                labelAge
                })
        toggleEnable(user_info_controls, False)
        Dim lol = citylabel

        first_name.Text = profile_info("first_name")
        last_name.Text = profile_info("last_name")
        middle_name.Text = profile_info("middle_name")
        username.Text = profile_info("username")
        email.Text = profile_info("email")
        password.Text = profile_info("password")

        Dim address As String() = profile_info("address").Split(",")
        street_address.Text = address(0).Trim
        user_city.Text = address(1).Trim
        user_region.Text = address(2).Trim
        country.Text = address(3).Trim
        zipcode.Text = address(4).Trim

        phone_number.Text = profile_info("phone_number")
        birthdate.Value = profile_info("birthdate")
        labelAge.Text = profile_info("age")

        LoadImage()

    End Sub

    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        handleImageSelection(profile_info, "customer")
        LoadImage()
    End Sub
    Private Sub LoadImage()
        Try

            If IsDBNull(profile_info("image_dir")) Then Return
            Using bmp As Bitmap = Bitmap.FromFile(profile_info("image_dir").ToString)
                Dim new_img As New Bitmap(bmp)
                profileImage.Image = new_img
            End Using
            image_dir.Text = profile_info("image_dir")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If btnShowPass.ForeColor <> Color.Black Then
            btnShowPass.ForeColor = Color.Black
            btnShowPass.BackgroundImage = My.Resources.icons8_eye_20
            password.PasswordChar = ""
        Else
            btnShowPass.ForeColor = Color.White
            btnShowPass.BackgroundImage = My.Resources.icons8_closed_eye_20
            password.PasswordChar = "•"
        End If
    End Sub
End Class