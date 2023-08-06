
Module HomeQueries
    Public reports_path = Application.StartupPath.Replace("Public", "") & "Reports Path\"
    Public transactionQuery As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public current_table As DataTable = Nothing
    Public current_user As DataRow = Nothing
    Dim query As String = ""

    '#############################################################################################
    '
    ' CUSTOMER/USER ACCOUNT
    '
    '#############################################################################################

    '
    ' CREATING ACCOUNT
    '
    Public Sub CreateAccount(account As Dictionary(Of String, String), Optional table As String = "customer")

        Dim values As String = ""
        For Each field In account.Keys
            If field = "created_at" Then Continue For
            If table = "user" And field = "password" Then Continue For
            values += $"{field}={account(field)},"
        Next
        values = values.TrimEnd(",")

        Dim query As String = $"INSERT INTO {table} SET {values};"
        ExecuteNonQuery(query)

        If role = "user" Then

            Dim id As String = SelectWhere(
                table,
                $"username={account("username")}",
                "id"
                ).Rows(0)("id")

            Dim login_info As String = $"
            id={id}, 
            username={account("username")}, 
            password={account("password")}"

            Dim login As String = $"INSERT INTO login SET {login_info};"
            ExecuteNonQuery(login)
        End If


    End Sub

    '
    ' UPDATING ACCOUNT
    '
    Public Sub UpdateAccount(account As Dictionary(Of String, Object), Optional table As String = "customer")

        Dim values As String = ""
        For Each field As KeyValuePair(Of String, Object) In account
            If field.Key = "created_at" Then Continue For
            values += $"{field.Key} = '{field.Value}',"
        Next
        values = values.TrimEnd(",")

        UpdateTable(table, values, $"id={account("id")}")
        MsgBox("Account Updated!", MsgBoxStyle.Information, "Account")

    End Sub

    '
    ' DELETING ACCOUNT
    '

    Public Sub DeleteCustomerAccount()
        Try
            DeleteFrom("customer", $"id={current_user("id")}")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error while deleting account")
        Finally
            Application.Restart()
        End Try
    End Sub

    '#############################################################################################




    '#############################################################################################
    '
    ' TRANSACTIONS - INSERTING, UPDATING and DELETING multiple datas done in one single transaction
    '
    '#############################################################################################
    '
    ' COMPLETE PENDING TRANSACTIONS
    '
    Public Sub CompleteTransaction(Optional showHistory = False)
        Try

            If transactionQuery.Count < 1 Then Return
            If showHistory Then If Not OnShowResult() Then Return

            query = ""
            transactionQuery.Remove("name")
            For Each transaction As KeyValuePair(Of String, String) In transactionQuery
                query &= transaction.Value & vbNewLine
            Next

            ExecuteNonQuery(query)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error while performing the actions")
        End Try
        transactionQuery.Clear()
    End Sub

    '
    ' CREATE A TRANSACTION FROM CART and ORDER
    '
    Public Sub MakeTransactions(item As Dictionary(Of String, Object), transaction_type As String)
        Select Case transaction_type
            '
            ' MAKING AN ORDER RECORD FROM CART
            '
            Case "make_order"

                Dim order_id As Integer = GetLastId("order") + 1

                query =
                $"
                INSERT INTO `order` (id, customer_id, shipping_type, ship_date)
                VALUES
                ({order_id}, {current_user("id")}, 'standard', NOW() + INTERVAL 7 DAY);
                "

                transactionQuery.Remove("name")
                For Each sql As String In transactionQuery.Values
                    query &= sql.Replace("@order_id", order_id) & vbNewLine
                Next

                transactionQuery.Clear()
                transactionQuery.Add("name", "make_order")
                transactionQuery.Add("query", query)

            Case "insert_product"

                Dim query As String =
                $"
                INSERT INTO `order_has_product` (order_id, product_id, quantity, cost, status)
                VALUES
                (
                @order_id, 
                {item("product_id")}, 
                {item("quantity")}, 
                {item("cost_per_item")}, 
                'pending'
                );

                DELETE FROM `cart` WHERE `cart`.`id` = {item("id")};
                "

                Dim key As String = $"{item("id")}"

                transactionQuery(key) = query
                transactionQuery("name") = "insert"

            '
            ' DELETING AN ORDER RECORD
            '
            Case "delete_order"
                Dim key As String = $"[{item("id")}][Item: {item("item_name")}] Removed from order."

                Dim delete_items As String = $"
                -- CASCADE IS ON
                -- DELETE FROM `order_has_product` WHERE (`order_id` = '{item("id")}'); 
                DELETE FROM `order` WHERE (`id` = '{item("id")}'); 

                "

                transactionQuery(key) = delete_items
                transactionQuery("name") = "delete"

            '
            ' DELETING AN ITEM FROM CART
            '
            Case "delete_cart"
                Dim key As String = $"[{item("id")}][Item: {item("item_name")}] Removed from order."
                Dim delete_items As String = $"DELETE FROM `cart` WHERE `cart`.`id` = {item("id")};"

                transactionQuery(key) = delete_items
                transactionQuery("name") = "delete"

            '
            ' UPDATING AN ITEM FROM CART
            '
            Case "update_cart"
                Dim key As String = $"[UPDATED QUANTITY] {item("item_name")} = {item("new_quantity")}"
                Dim query As String = $"UPDATE cart SET quantity={item("new_quantity")} WHERE id={item("id")};"

                transactionQuery.Add(key, query)
                transactionQuery("name") = "update"
                'MsgBox(query)

        End Select

    End Sub
    '#############################################################################################

    '#############################################################################################
    '
    ' CART QUERIES
    '
    '#############################################################################################

    '
    ' ADDING ITEM TO CART
    '
    Public Sub AddToCart(item As DataRow, quantity As Integer)

        Dim log As String = "Item Saved!" & vbNewLine
        log += "Item ID: " & item("id") & vbNewLine
        log += "Item Name: " & item("item_name") & vbNewLine
        log += "Quantity: " & quantity & vbNewLine
        log += "Price: " & item("price") & vbNewLine
        MsgBox(log, MsgBoxStyle.Information, "Cart")

        '
        ' CHECK IF ITEM IS ALREADY IN CART
        '
        Dim cart As DataTable = SelectWhere("cart", $"customer_id={current_user("id")} AND product_id={item("id")}")

        Dim fields As String = "customer_id, product_id, quantity"
        Dim values As String = $"{current_user("id")}, {item("id")}, {quantity}"

        If cart.Rows.Count > 0 Then
            UpdateTable("cart",
                        $"quantity={cart(0)("quantity") + quantity}",
                        $"id={cart(0)("id")}")
        Else
            InsertInto("cart", fields, values)
        End If


    End Sub



    '#############################################################################################
    '
    ' TABLE QUERIES
    '
    '#############################################################################################

    '
    ' Product rendering
    '
    Public Sub ProductFromSource(Optional source As DataTable = Nothing)

        Dim query As String = "SELECT * FROM product ORDER BY item_name ASC"
        Dim dt As New DataTable
        dt = IIf(source Is Nothing, ExecuteQuery(query), source)
        If dt.Rows.Count = 0 Then Return

        Dim parent As Control = _shoppage.itemsContainer
        Dim index As Integer
        Dim card As ProductCard

        _shoppage.itemsContainer.Controls.Clear()
        _shoppage.itemsContainer.Hide()

        For Each row As DataRow In dt.Rows


            card = New ProductCard(parent, index)
            card.MakeCard()
            card.SetProperties(row)
        Next

        _shoppage.itemsContainer.Show()

        current_table = dt
    End Sub


    '
    ' Orders rendering
    '
    Public Sub OrdersFromSource(Optional source As DataTable = Nothing)
        Dim query As String = $"

        SELECT
        ohp.order_id as id,
        ohp.order_id,
        ohp.product_id,
        o.customer_id,
        ohp.quantity,
        p.item_name,
        p.stock_quantity,
        p.price,
        ohp.cost,
        p.image_dir,
        o.shipping_type,
        o.ship_date,
        s.amount as shipping_fee,
        `ohp`.`status`
        FROM order_has_product as ohp
        INNER JOIN `order` as o
        ON ohp.order_id = o.id
        INNER JOIN product as p
        ON ohp.product_id = p.id
        INNER JOIN shipping_info as s
        ON o.shipping_type = s.`type`
        WHERE o.customer_id = {current_user("id")}
        ORDER BY o.id ASC
        "
        _sqlString = query


        Dim dt As New DataTable
        dt = IIf(source Is Nothing, ExecuteQuery(query), source)
        If dt.Rows.Count = 0 Then Return


        Dim order_item As Cart
        Dim parent As Control = _orderpage.order_itemContainer
        _orderpage.order_itemContainer.Controls.Clear()

        For Each row As DataRow In dt.Rows


            Dim index As String = $"{row("order_id")}_{row("product_id")}"
            order_item = New Cart(parent, index, row)
            order_item.MakeCartItem()
            order_item.SetProperties()
            order_item.SetOrderProperties()

            Select Case _orderpage.btnEditOrders.ForeColor
                Case Color.Red
                    order_item.btnSelect.BackgroundImage = My.Resources.icons8_unchecked_checkbox_30
                    order_item.btnSelect.ForeColor = Color.Black

                Case Color.Black
                    order_item.btnSelect.BackgroundImage = My.Resources.icons8_remove_20
                    order_item.btnSelect.ForeColor = Color.Yellow
            End Select
        Next

        current_table = dt

    End Sub


    '
    ' Cart rendering
    '
    Public Sub CartFromSource(Optional source As DataTable = Nothing)
        Dim query As String = $"
        SELECT 
        c.id,
        c.id as cart_id,
        c.customer_id,
        cust.username,
        c.product_id,
        p.item_name,
        p.price,
        c.quantity,
        (p.price * c.quantity) as cost_per_item,
        p.image_dir

        FROM cart as c
        INNER JOIN customer as cust
        ON c.customer_id = cust.id

        INNER JOIN product as p
        ON c.product_id = p.id

        WHERE cust.username = ""{current_user("username").replace("""", """""")}"";
;
        "

        Dim dt As New DataTable
        dt = IIf(source Is Nothing, ExecuteQuery(query), source)
        If dt.Rows.Count = 0 Then Return

        Dim new_cart As Cart
        Dim parent As Control = CartPage.itemContainer
        CartPage.itemContainer.Controls.Clear()

        For Each row As DataRow In dt.Rows
            Dim index As String = $"{row("cart_id")}_{row("customer_id")}_{row("product_id")}"
            new_cart = New Cart(parent, index, row)
            new_cart.MakeCartItem()
            new_cart.SetProperties()

            Select Case CartPage.btnEdit.ForeColor
                Case Color.Red
                    new_cart.btnSelect.BackgroundImage = My.Resources.icons8_unchecked_checkbox_30
                    new_cart.btnSelect.ForeColor = Color.Black

                Case Color.Black
                    new_cart.btnSelect.BackgroundImage = My.Resources.icons8_remove_20
                    new_cart.btnSelect.ForeColor = Color.Yellow
            End Select
        Next

        current_table = dt
    End Sub

    Public Function ReceiptQuery(order_id, product_id) As String
        Dim receipt_query As String = $"
            SELECT 
            order_has_product.order_id,
            order_has_product.product_id,
            product.item_name,
            product.price,
            order_has_product.quantity,
            order_has_product.cost,
            shipping_info.amount,
            `order`.ship_date
            FROM order_has_product
            INNER JOIN product
            ON order_has_product.product_id = product.id
            INNER JOIN `order`
            ON order_has_product.order_id = `order`.id
            INNER JOIN shipping_info
            ON `order`.shipping_type = shipping_info.`type`
            WHERE 
            order_has_product.order_id = {order_id}
            AND 
            order_has_product.product_id = {product_id};
            "
        Return receipt_query
    End Function


End Module
