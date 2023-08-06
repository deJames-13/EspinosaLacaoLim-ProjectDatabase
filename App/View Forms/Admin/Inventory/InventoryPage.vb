Public Class InventoryPage
    Dim form_table As New DataTable
    Dim selectedRow As DataRow

    '
    ' PAGE SWITCH
    '
    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return
        Reload()
        ManageHandlers()

        cmbSorting.Items.Clear()
        cmbSorting.Items.Add("All")
        For Each col As DataGridViewColumn In invGrid.Columns
            cmbSorting.Items.Add(col.HeaderText)
        Next
    End Sub

    '
    ' ACTION BUTTON EVENTS
    '
    Private Sub handleActionQueries(sender As Object, e As EventArgs) Handles btnCreate.Click, btnEdit.Click, btnDelete.Click
        If selectedRow Is Nothing And sender.name <> "btnCreate" Then Return



        Select Case sender.name
            '
            ' EDIT ITEM - opens dialog for editing item info
            '
            Case "btnEdit"
                InventoryItemDialog.item = DataRowToDictionary(selectedRow)
                InventoryItemDialog.state = "edit"
                InventoryItemDialog.pageTitle.Text = "Edit Item: " & selectedRow("id")

            '
            ' CREATE ITEM - opens dialog for creating new item
            '
            Case "btnCreate"
                InventoryItemDialog.state = "create"

            '
            ' DELETE ITEM - deletes item from database
            '
            Case "btnDelete"
                If MsgBox($"Are you sure you want to delete {selectedRow("item_name")}?", MsgBoxStyle.YesNo, "Delete Item") = MsgBoxResult.No Then Return
                Dim data As New Dictionary(Of String, Object) From {
                    {"action", "delete_item"},
                    {"id", selectedRow("id")}
                }
                AdminTransactions(data)
                Reload()
                Exit Sub

        End Select

        '
        ' SWITCH PANELS
        '
        switchPanel(InventoryItemDialog.windowWrapper, windowWrapper)
    End Sub

    '
    ' PAGE RELOAD
    '
    Private Sub Reload()
        invGrid.Columns.Clear()
        invGrid.Hide()
        invGrid.DataSource = Nothing
        form_table = LoadToGrid("product", invGrid, "*")
        rowCount.Text = form_table.Rows.Count
        invGrid.Show()
    End Sub

    '
    ' OTHER EVENTS and EVENT HANDLERS
    '
    Private Sub invGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles invGrid.CellClick
        If e.RowIndex < 0 Then Return

        selectedRow = invGrid.Rows(e.RowIndex).DataBoundItem.Row
        labelSelected.Text = $"Item {selectedRow("id")}: {selectedRow("item_name")}"
        ReportsPage.Info = selectedRow("id")

    End Sub
    Private Sub ManageHandlers()
        Try
            RemoveHandler invGrid.CellClick, AddressOf SelectCellRow
            AddHandler invGrid.CellClick, AddressOf SelectCellRow
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        invGrid.Columns.Clear()
        invGrid.Hide()
        invGrid.DataSource = Nothing
        form_table = QueryToGrid($"SELECT * FROM user WHERE name='{txtSearch.Text}'", invGrid)
        rowCount.Text = form_table.Rows.Count
        invGrid.Show()
    End Sub
End Class