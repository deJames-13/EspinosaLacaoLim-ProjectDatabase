Public Class InventoryItemDialog

    Public item As New Dictionary(Of String, Object)
    Public state As String

    Private prod_attr As Control()
    Private control_attr As Control()

    '
    ' SWITCH PAGE
    '
    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return

        supplier.DataSource = SelectAllFrom("supplier", "id, name").DefaultView
        supplier.DisplayMember = "name"
        supplier.ValueMember = "id"

        Reload()
        ManageHandlers()
    End Sub

    '
    ' REFRESH PAGE
    '
    Private Sub Reload()
        '
        ' INFOS NEEDED
        '
        prod_attr = {item_name, price, stock_quantity, description, brand, category, supplier, image_dir}
        control_attr = {item_name, price, stock_quantity, description, brand, category, supplier, btnImage, image_dir}

        '
        ' IF CREATE
        ' 
        If state = "create" Then
            btnDelete.Text = "Cancel"
            btnDelete.BackColor = Color.Transparent
            btnEditProduct.Text = "Save"
            btnEditProduct.BackColor = Color.PaleGreen
            item("id") = GetLastId("product") + 1
            Exit Sub
        End If

        '
        ' IF EDIT
        '
        item = DataRowToDictionary(
            SelectWhere(
            table:="product",
            condition:=$"id={item("id")}")(0)
            )
        UnLoadObjects()

    End Sub
    '
    ' ACTION BUTTON EVENTS
    '
    Private Sub handleButtonClick(sender As Object, e As EventArgs) Handles btnEditProduct.Click, btnDelete.Click
        Dim data As New Dictionary(Of String, Object)

        Select Case sender.text
            Case "Edit"
                ToggleControls(control_attr, True)
                btnEditProduct.Text = "Save"
                btnEditProduct.BackColor = Color.PaleGreen
                btnDelete.Text = "Cancel"

            Case "Delete"
                If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

                data("action") = "delete_item"
                data("id") = item("id")
                AdminTransactions(data)

                btnClose.PerformClick()

            Case "Save"
                data = LoadObjects()
                data("id") = item("id")
                data("action") = "new_item"
                If state = "edit" Then
                    data("action") = "update_item"
                    data("item").Remove("created_at")
                    data("item").Remove("created_by")
                    data("item").Remove("last_modified_at")
                End If
                If AdminTransactions(data) < 1 Then btnClose.PerformClick() : Return
                If state <> "edit" Then btnClose.PerformClick() : Return

                Reload()

            Case "Cancel"
                If state <> "edit" Then btnClose.PerformClick() : Return
                Reload()



        End Select

    End Sub


    '
    ' CONTROLS TO DATA
    '
    Private Function LoadObjects() As Dictionary(Of String, Object)

        For Each attr In prod_attr
            If attr.Name = "supplier" Then
                item("supplier_id") = supplier.SelectedValue
                Continue For
            End If
            item(attr.Name) = attr.Text
        Next
        Dim d As New Dictionary(Of String, Object)
        d("item") = item
        Return d
    End Function

    '
    ' DATA TO CONTROLS
    '
    Private Sub UnLoadObjects()

        btnEditProduct.Text = "Edit"
        btnDelete.Text = "Delete"
        btnEditProduct.BackColor = Color.LightSteelBlue
        btnDelete.BackColor = Color.LightCoral

        ToggleControls(control_attr, False, True)

        For Each attr In prod_attr
            If Not item.Keys.Contains(attr.Name) Then Continue For
            If IsDBNull(item(attr.Name)) Then Continue For
            If attr.Name = "image_dir" Then Continue For

            attr.Text = item(attr.Name)
        Next

        supplier.SelectedValue = item("supplier_id")
        LoadImage()
    End Sub

    '
    ' OTHER EVENTS and EVENT HANDLERS
    '
    Private Sub ManageHandlers()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        switchPanel(InventoryPage.windowWrapper, currentPage)
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        handleImageSelection(item, "product")
        LoadImage()
    End Sub
    Private Sub LoadImage()
        Try
            If IsDBNull(item("image_dir")) Or String.IsNullOrEmpty(item("image_dir")) Then Return

            Using bmp As Bitmap = Bitmap.FromFile(item("image_dir"))
                Dim newimg As New Bitmap(bmp, New Size(200, 200))
                itemImage.Image = newimg
            End Using
            itemImage.SizeMode = PictureBoxSizeMode.Zoom
            If itemImage.Image.Size.Width < itemImage.Parent.Size.Width Then
                itemImage.SizeMode = PictureBoxSizeMode.CenterImage
            End If
            image_dir.Text = item("image_dir")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Image Loading Error")
        End Try
    End Sub
End Class