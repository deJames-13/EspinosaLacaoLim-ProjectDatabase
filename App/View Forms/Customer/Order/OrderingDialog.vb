Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class _ordering_dialog

    Public order As Ordering
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        windowWrapper.Hide()
        switchPanel(_shoppage.windowWrapper, windowWrapper)
    End Sub

    Private Sub _ordering_dialog_Load(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return
        LoadContents()

        Try
            Select Case order.product("shipping_type")
                Case "Standard"
                    rbt_standard.PerformClick()
                Case "Priority"
                    rbt_priority.PerformClick()
                Case "Express"
                    rbt_express.PerformClick()
            End Select
        Catch ex As Exception

        End Try


    End Sub


    Public Sub LoadContents()

        order.order_info = New Dictionary(Of String, String)


        If shipping_fee.Text = "" Then rbt_standard.PerformClick()
        item_name.Text = order.product("item_name")
        price.Text = "₱" & order.product("price")
        quantity.Text = order.quantity
        lbQuant.Text = order.quantity

        customer_name.Text = order.customer("first_name") & " " & order.customer("last_name")
        shipping_address.Text = order.customer("address")
        phone_number.Text = order.customer("phone_number")
        sub_total.Text = "₱" & order.product("price") * order.quantity

        itemImage.Image = My.Resources.icons8_no_image_30
        itemImage.SizeMode = ImageLayout.Center

        Try
            If IsDBNull(order.product("image_dir")) Then Return
            Using bmp As Bitmap = Bitmap.FromFile(order.product("image_dir").ToString)
                Dim new_img As New Bitmap(bmp)
                itemImage.Image = new_img
            End Using
            itemImage.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            itemImage.Image = My.Resources.icons8_no_image_30
            itemImage.SizeMode = PictureBoxSizeMode.CenterImage
        End Try



    End Sub

    Private Sub rbt_standard_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_express.Click, rbt_priority.Click, rbt_standard.Click


        Select Case sender.name
            Case "rbt_standard"
                shipping_fee.Text = 150
                order.order_info("shipping_fee") = 150
                order.order_info("shipping_type") = "Standard"
                order.order_info("shipping_interval") = "7"

            Case "rbt_express"
                shipping_fee.Text = 300
                order.order_info("shipping_fee") = 300
                order.order_info("shipping_type") = "Express"
                order.order_info("shipping_interval") = "3"

            Case "rbt_priority"
                shipping_fee.Text = 500
                order.order_info("shipping_fee") = 500
                order.order_info("shipping_type") = "Priority"
                order.order_info("shipping_interval") = "2"

        End Select

        order.order_info("total_cost") = order.product("price") * order.quantity
        total_cost.Text = "₱" & order.order_info("total_cost")



    End Sub

    Private Sub onButtonClick(sender As Object, e As EventArgs) Handles btnCancel.Click, btnConfirm.Click

        Select Case sender.Text
            Case "Place Order"
                order.MakeOrder()
            Case "Save Order"
                order.UpdateOrder()
            Case "Cancel"
                switchPanel(_shoppage.windowWrapper, windowWrapper)
            Case "Cancel Order"

                If MsgBox("Are you sure you want to cancel this order?", MsgBoxStyle.YesNo, "Cancel Order") = MsgBoxResult.No Then Return

                order.CancelOrder()
        End Select
        switchPanel(_orderpage.windowWrapper, windowWrapper)
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        switchPanel(_orderpage.windowWrapper, windowWrapper)
    End Sub

    Private Sub addQuant_Click(sender As Object, e As EventArgs) Handles addQuant.Click, subQuant.Click
        Select Case sender.name
            Case "addQuant"
                If order.product("stock_quantity") > order.quantity Then order.quantity += 1
            Case "subQuant"
                If order.quantity > 1 Then order.quantity -= 1
        End Select

        order.order_info("total_cost") = order.product("price") * order.quantity + order.order_info("shipping_fee")
        lbQuant.Text = order.quantity
        quantity.Text = order.quantity
        sub_total.Text = "₱" & order.product("price") * order.quantity
        total_cost.Text = "₱" & order.order_info("total_cost")

    End Sub

    Private Sub btnEditAddress_Click(sender As Object, e As EventArgs) Handles btnEditAddress.Click
        switchPanel(_profilepage.windowWrapper, windowWrapper)
    End Sub

    Private Sub ViewReceipt(sender As Object, e As EventArgs) Handles btnReceipt.Click
        Dim id As String = order.product("id")
        Dim product_id As String = order.product("product_id")
        Dim receipt As New _viewreceipt_dialog(id, product_id)
        switchPanel(receipt.windowWrapper, windowWrapper)
    End Sub




End Class