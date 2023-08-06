Imports System.Reflection

Module HomeController
    '
    ' USER ROLE
    '
    Public role = "viewer"
    '
    ' BUTTONS and SUMMARIES caches
    '
    Public cartButtons As New Dictionary(Of String, Button())
    Public summaries As New Dictionary(Of String, Panel)

    ' SET CURRENT USER
    Public Sub SetCurrentUser(username As String, Optional table As String = "customer")
        Dim dt As DataTable = SelectWhere(table, $"username='{username}'")
        If dt Is Nothing Then Return
        current_user = dt.Rows(0)
    End Sub

    '#############################################################################################
    '
    ' SETS THE BUTTON STATES IN CART and ORDER
    '
    '#############################################################################################

    '
    ' EDIT BUTTON
    '
    Public Sub btnEdit_Click(sender As Object, e As EventArgs)

        CartPage.txtTotal.Clear()

        Select Case sender.ForeColor

            Case Color.Blue

                sender.BackgroundImage = My.Resources.icons8_remove_20
                sender.ForeColor = Color.LightCoral

                If transactionQuery.Keys.Contains("name") AndAlso transactionQuery("name") = "delete" Then CompleteTransaction(0)
                SetButtonState(My.Resources.icons8_unchecked_checkbox_30, Color.Blue)

            Case Color.LightCoral

                sender.BackgroundImage = My.Resources.icons8_edit_20
                sender.ForeColor = Color.Blue

                SetButtonState(My.Resources.icons8_remove_20, Color.LightCoral)

            Case Color.Black

                sender.BackgroundImage = My.Resources.icons8_edit_20
                sender.ForeColor = Color.Red

                If transactionQuery.Keys.Contains("name") AndAlso transactionQuery("name") = "delete" Then CompleteTransaction()

                SetButtonState(My.Resources.icons8_unchecked_checkbox_30, Color.Black)

            Case Color.Red

                transactionQuery.Clear()

                sender.BackgroundImage = My.Resources.icons8_select_all_20__1_
                sender.ForeColor = Color.Black

                SetButtonState(My.Resources.icons8_remove_20, Color.Yellow)

        End Select

    End Sub


    Public Sub SetButtonState(image As Bitmap, c As Color)

        Dim i As Integer
        ClearCartSummaries()

        For Each btn As Button() In cartButtons.Values

            i = cartButtons.Values.ToList.IndexOf(btn)

            btn(0).BackgroundImage = image
            btn(0).ForeColor = c

            Select Case c
                Case Color.Blue
                    btn(0).Hide()
                    Continue For

                Case Color.LightCoral
                    btn(0).Show()
                    Continue For

                Case Color.Black
                    btn(1).Hide()
                    btn(2).Hide()

                Case Color.Yellow
                    btn(1).Show()
                    btn(2).Show()
            End Select


            Dim q As Label = btn(1).Parent.Parent.Controls(0).Controls(0)
            Dim item As New Dictionary(Of String, Object)

            item("id") = current_table.Rows(i)("id")
            item("item_name") = current_table.Rows(i)("item_name")
            item("new_quantity") = q.Text

            If item("new_quantity") <> current_table.Rows(i)("quantity") Then
                MakeTransactions(item, "update_cart")
                q.Text = item("new_quantity")
            End If
        Next

        CompleteTransaction()
    End Sub
    '#############################################################################################





    '#############################################################################################
    '
    '   MISC and TOOLS
    '
    '#############################################################################################

    'Dim log As String = ""
    'Public Sub btnDebugger_Click(sender As Object, e As EventArgs)
    '    'LoadFromSource()
    '    'CreateCartItem()
    'End Sub


    Public Sub ClearCartSummaries()
        For Each summary As Panel In summaries.Values
            If summary.Parent IsNot Nothing Then summary.Parent.Controls.Remove(summary)
        Next
        summaries.Clear()

    End Sub

    Public Function OnShowResult() As Boolean
        Dim history As String = "You have pending transaction. Do you want to complete them?" & vbCrLf & vbCrLf

        For Each transaction As KeyValuePair(Of String, String) In transactionQuery
            history += transaction.Key & vbNewLine
        Next

        Dim res As Integer = MsgBox(history, MsgBoxStyle.YesNo, "Confirm Actions!")
        If res = DialogResult.No Then
            transactionQuery.Clear()
        End If

        Return res
    End Function

    '#############################################################################################

    Public Sub ViewOrderDialog(cart_item As DataRow)
        Dim page As String = currentPage.Controls(0).Name
        If Not page = "orderWrapper" Then Return

        Dim o As New _ordering_dialog With {
            .order = New Ordering(current_user, cart_item, cart_item("quantity"))
        }



        If cart_item("status") = "pending" Then
            o.btnConfirm.Text = "Save Order"
            o.btnConfirm.BackColor = Color.PaleGreen
            o.btnCancel.Text = "Cancel Order"
            o.btnCancel.BackColor = Color.LightCoral
        Else
            o.btnReceipt.Hide()
            o.btnCancel.Hide()
            o.btnConfirm.Hide()

        End If

        switchPanel(o.windowWrapper, currentPage)
    End Sub

End Module
