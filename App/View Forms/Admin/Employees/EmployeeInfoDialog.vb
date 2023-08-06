Imports System.Dynamic
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class EmployeeInfoDialog

    Private employee_attributes As New Dictionary(Of String, Object)
    Public employee As New Dictionary(Of String, Object)
    Public state As String
    Private inputs As Control()
    Private emp_attr As Object()

    Private Sub handleButtonClick(sender As Object, e As EventArgs) Handles btnEditInfo.Click, btnDelete.Click
        Dim data As New Dictionary(Of String, Object)

        Select Case sender.text
            Case "Edit"
                ToggleControls(inputs, True)
                btnDelete.Text = "Cancel"
                btnEditInfo.Text = "Save"
                btnEditInfo.BackColor = Color.PaleGreen

            Case "Delete"

                If MsgBox($"Are you sure you want to delete {employee("first_name")} {employee("last_name")}'s account?", MsgBoxStyle.YesNo, "Delete Account") = MsgBoxResult.No Then Return

                data("action") = "delete_user"
                data("id") = employee("id")
                AdminTransactions(data)
                btnClose.PerformClick()

            Case "Save"

                data = LoadObjects()
                data("action") = "new_user"
                data("id") = employee("id")
                If state <> "create" Then data("action") = "update_user"


                If AdminTransactions(data) < 1 Then btnClose.PerformClick() : Return
                If state = "create" Then btnClose.PerformClick() : Return
                Reload()

            Case "Cancel"
                If state <> "create" Then btnClose.PerformClick() : Return
                Reload()

        End Select
    End Sub



    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return

        role.DataSource = SelectAllFrom("role")
        role.DisplayMember = "name"
        role.ValueMember = "id"

        department.DataSource = SelectAllFrom("department")
        department.DisplayMember = "name"
        department.ValueMember = "id"
        Reload()
        ManageHandlers()
    End Sub

    Private Sub Reload()
        '
        ' INFOS NEEDED
        '
        inputs = {first_name, last_name, middle_name, username, email, password, phone_number, street_address, user_city, user_region, zipcode, country, birthdate, age, btnImage, role, department}
        emp_attr = {first_name, last_name, middle_name, username, email, phone_number, address, age, birthdate, image_dir}

        '
        ' IF CREATE
        '
        If state = "create" Then
            btnDelete.Text = "Cancel"
            btnEditInfo.Text = "Save"
            btnEditInfo.BackColor = Color.PaleGreen
            employee("id") = GetLastId("user") + 1
            Exit Sub
        End If


        '
        ' IF EDIT
        '
        employee = DataRowToDictionary(
            SelectWhere(
            table:="user",
            condition:=$"id={employee("id")}")(0)
            )
        UnloadObjects()


    End Sub


    Private Function LoadObjects()
        For Each attr In emp_attr
            If attr.Name = "birthdate" Then employee(attr.Name) = attr.value.ToString : Continue For
            employee(attr.Name) = attr.text
        Next
        employee("address") = $"{street_address.Text}, {user_city.Text}, {user_region.Text}, {zipcode.Text}, {country.Text}"
        employee("birthdate") = birthdate.Value.ToString("yyyy-MM-dd")
        employee("age") = age.Text
        employee("role_id") = role.SelectedValue
        employee("department_id") = department.SelectedValue


        Dim d As New Dictionary(Of String, Object) From {
            {"user", employee},
            {"password", password.Text}
        }
        Return d

    End Function

    Private Sub UnloadObjects()
        btnDelete.Text = "Delete"
        btnEditInfo.Text = "Edit"
        btnEditInfo.BackColor = Color.LightSteelBlue
        btnDelete.BackColor = Color.LightCoral
        ToggleControls(inputs, False, True)

        '
        ' UNPACKS the employee into the textboxes
        '
        For Each attr In emp_attr

            If Not employee.Keys.Contains(attr.Name) Then Continue For
            If IsDBNull(employee(attr.Name)) Then Continue For
            If attr.Name = "birthdate" Then attr.Value = employee(attr.Name) : Continue For


            attr.text = employee(attr.Name)
        Next

        '
        ' UNPACKS the address into the textboxes
        '
        Dim addr As String() = address.Text.Split(",")
        If Not addr.Length < 5 Then
            Dim i = 0
            For Each c In {street_address, user_city, user_region, zipcode, country}
                c.Text = addr(i).Trim
                i += 1
            Next
        End If

        '
        ' ROLE and DEPARTMENT
        '
        role.SelectedValue = employee("role_id")
        department.SelectedValue = employee("department_id")
        password.Text = SelectWhere("login", $"id={employee("id")}")(0)("password")

        '
        ' IMAGE
        '
        LoadImage()

    End Sub

    Private Sub LoadImage()
        Try

            If IsDBNull(employee("image_dir")) Then Return

            Using bmp As Bitmap = Bitmap.FromFile(employee("image_dir"))
                Dim new_img As New Bitmap(bmp)
                profileImage.Image = new_img
            End Using

            image_dir.Text = employee("image_dir")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        switchPanel(EmployeesPage.windowWrapper, currentPage)
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        handleImageSelection(employee, "user")
        LoadImage()
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        If btnShowPass.ForeColor <> Color.Black Then
            btnShowPass.ForeColor = Color.Black
            password.PasswordChar = ""
            btnShowPass.BackgroundImage = My.Resources.icons8_eye_20
        Else
            btnShowPass.ForeColor = Color.White
            password.PasswordChar = "•"
            btnShowPass.BackgroundImage = My.Resources.icons8_closed_eye_20
        End If
    End Sub

    Private Sub dropdownChanged(sender As Object, e As EventArgs)
        Select Case sender.name
            Case "role"
                employee("role_id") = CInt(sender.SelectedValue)
            Case "department"
                employee("department_id") = CInt(department.SelectedValue)
        End Select
    End Sub

    Private Sub ManageHandlers()
        RemoveHandler role.SelectedIndexChanged, AddressOf dropdownChanged
        RemoveHandler department.SelectedIndexChanged, AddressOf dropdownChanged
        AddHandler department.SelectedIndexChanged, AddressOf dropdownChanged
        AddHandler role.SelectedIndexChanged, AddressOf dropdownChanged
    End Sub

    Private Sub birthdate_ValueChanged(sender As Object, e As EventArgs) Handles birthdate.ValueChanged
        age.Text = Date.Now.Year - birthdate.Value.Year
    End Sub

End Class