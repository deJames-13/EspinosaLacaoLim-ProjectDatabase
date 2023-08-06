Imports System.IO
Imports System.Reflection

Public Class _viewitemdialog

    Public item As DataRow
    Dim quant As Integer = 1
    ' my base load
    Private Sub _viewitemdialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If role Is "viewer" Then
            ToggleControls({btnAddToCart, btnOrderNow, quantWrapper}, False)
        Else
            ToggleControls({btnAddToCart, btnOrderNow, quantWrapper}, True)
        End If

        Reload()



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub changeQuantity(sender As Object, e As EventArgs) Handles addQuant.Click, subQuant.Click
        Select Case sender.name
            Case "addQuant"
                If Val(quant) < item("stock_quantity") Then
                    quant += 1
                    quantity.Text = quant
                End If
            Case "subQuant"

                If quant > 1 Then
                    quant -= 1
                    quantity.Text = quant
                End If
        End Select

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddToCart(item, quant)

    End Sub

    Private Sub btnOrderNow_Click(sender As Object, e As EventArgs) Handles btnOrderNow.Click
        Me.Close()
        Dim ordering As New _ordering_dialog
        ordering.order = New Ordering(current_user, item, quant)
        ordering.btnReceipt.Hide()
        switchPanel(ordering.windowWrapper, currentPage)


    End Sub
    Private Sub Reload()
        windowTitle.Text = "View Item ID: " & item("id")
        item_name.Text = item("item_name")
        price.Text = "₱" & item("price")
        stock_quantity.Text = item("stock_quantity")
        tags_specification.Text = item("description")
        quantity.Text = quant

        Try

            If item("image_dir") IsNot DBNull.Value Then
                Using bmp As Bitmap = Bitmap.FromFile(item("image_dir").ToString)
                    Dim new_img As New Bitmap(bmp)
                    itemImage.Image = new_img
                End Using

                itemImage.SizeMode = PictureBoxSizeMode.Zoom
            Else
                itemImage.Image = My.Resources.icons8_no_image_30
                itemImage.SizeMode = PictureBoxSizeMode.CenterImage
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class