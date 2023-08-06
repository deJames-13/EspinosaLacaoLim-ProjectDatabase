Public Class HomePage
    Private Sub home_FormClosed() Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub _home_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If MyBase.Visible = False Then Return

        If role Is "viewer" Then
            btnSettings.Image = My.Resources.signinBtn
            ToggleControls({btnCart, btnProfile, btnOrders}, False)
        Else
            btnSettings.Image = My.Resources.settingsBtn
            ToggleControls({btnCart, btnProfile, btnSettings, btnOrders}, True)
        End If




    End Sub

    Private Sub selectNav(sender As Object, e As EventArgs) Handles MyBase.Load, btnShop.Click, btnCart.Click, btnProfile.Click, btnSettings.Click, btnOrders.Click

        Reload()
        Select Case sender.name
            Case MyBase.Name
                CreateHandlers()

                switchPanel(_shoppage.windowWrapper, windowWrapper)
                ProductFromSource()
            Case "btnShop"
                switchPanel(_shoppage.windowWrapper, currentPage)

            Case "btnCart"
                switchPanel(CartPage.windowWrapper, currentPage)

            Case "btnOrders"
                switchPanel(_orderpage.windowWrapper, currentPage)

            Case "btnProfile"
                switchPanel(_profilepage.windowWrapper, currentPage)

            Case "btnSettings"
                If role Is "viewer" Then
                    role = "customer"
                    Me.Hide()
                    LogInForm.ShowDialog()
                    Exit Sub
                End If
                switchPanel(_settingspage.windowWrapper, currentPage)
        End Select


    End Sub

    Private Sub Reload()
        If Not isConnected() Then
            Application.Exit()
            Return
        End If

        ClearCartSummaries()
        If transactionQuery.ContainsKey("name") AndAlso transactionQuery("name") = "delete" Then
            CompleteTransaction(0)
        Else
            transactionQuery.Clear()
        End If
    End Sub

    Private Sub CreateHandlers()
        'AddHandler btnDebug.Click, AddressOf btnDebugger_Click
        ButtonHoverEvents({btnShop, btnCart, btnProfile, btnSettings, btnOrders})
    End Sub


End Class
