Public Class ManageOrdersPage

    Dim form_table As New DataTable
    Dim selectedRow As DataRow
    '
    ' INFORMATIONS THAT WILL SHOW ON ORDERS PAGE
    '



    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return
        order_query = $"
                SELECT 
                o.id,
                o.customer_id,
                ohp.product_id,
                ohp.status as 'Status',
                CONCAT(c.first_name,' ',c.last_name) as 'Customer',
                p.item_name as 'Item Name',
                ohp.quantity as 'Quantity',
                ohp.cost as 'Total Cost',
                c.address as 'Shipping Address',
                o.ship_date as 'Shipping Date'
                FROM order_has_product as ohp
                INNER JOIN product as p
                ON ohp.product_id = p.id
                INNER JOIN `order` as o
                ON ohp.order_id = o.id
                INNER JOIN customer as c
                ON o.customer_id = c.id
                ;
                "
        Reload()
        ManageHandlers()

        cmbSorting.Items.Clear()
        cmbSorting.Items.Add("All")
        For Each col As DataGridViewColumn In ordGrid.Columns
            cmbSorting.Items.Add(col.HeaderText)
        Next
    End Sub
    '

    Private Sub ActionButtonClicked(sender As Object, e As EventArgs) Handles btnShip.Click, btnCancel.Click, btnDelivered.Click

        Dim ship_status As String = ""

        Select Case sender.name
            Case "btnShip"
                ship_status = "shipped"
            Case "btnCancel"

                Dim result As Integer = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then Return

                ship_status = "cancelled"
            Case "btnDelivered"
                ship_status = "delivered"
        End Select
        SetOrderStatus(selectedRow("id"), ship_status)

        Dim data As New Dictionary(Of String, Object) From {
            {"order_id", selectedRow("id")},
            {"user_id", current_user("id")},
            {"product_id", selectedRow("product_id")},
            {"action_type", $"{ship_status}_order"},
            {"action", "manage_orders"}
        }
        AdminTransactions(data)


        Reload()
    End Sub

    Private Sub Reload()
        txtSearch.Clear()
        ordGrid.Columns.Clear()
        ordGrid.Hide()
        ordGrid.DataSource = Nothing
        form_table = QueryToGrid(order_query, ordGrid)
        rowCount.Text = form_table.Rows.Count
        ordGrid.Show()

    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ordGrid.CellClick
        If e.RowIndex < 0 Then Return

        selectedRow = ordGrid.Rows(e.RowIndex).DataBoundItem.Row
        labelSelected.Text = $"Order {selectedRow("id")}: [{selectedRow("Item Name")}] x{selectedRow("Quantity")}"


        btnShip.Enabled = True
        btnCancel.Enabled = True
        btnDelivered.Enabled = True
        Select Case selectedRow("Status").ToString.ToLower
            Case "shipped"
                btnShip.Enabled = False
            Case "cancelled", "delivered"
                btnShip.Enabled = False
                btnCancel.Enabled = False
                btnDelivered.Enabled = False
        End Select

    End Sub

    Private Sub ManageHandlers()
        RemoveHandler ordGrid.CellClick, AddressOf SelectCellRow
        AddHandler ordGrid.CellClick, AddressOf SelectCellRow
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then Return
        Dim search As String = txtSearch.Text
        Dim search_query As String = order_query.Split("WHERE")(0).Replace(";", "")
        search_query &= $"WHERE (o.id LIKE '%{search}%' OR ohp.product_id LIKE '%{search}%' OR o.customer_id LIKE '%{search}%' OR Status LIKE '%{search}%' OR 'Customer' LIKE '%{search}%' OR 'Item Name' LIKE '%{search}%');"

        ordGrid.Columns.Clear()
        ordGrid.Hide()
        ordGrid.DataSource = Nothing
        form_table = QueryToGrid(search_query, ordGrid)
        rowCount.Text = form_table.Rows.Count
        ordGrid.Show()
    End Sub
End Class