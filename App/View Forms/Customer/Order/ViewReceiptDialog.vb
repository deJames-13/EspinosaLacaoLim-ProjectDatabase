Imports CrystalDecisions.CrystalReports.Engine

Public Class _viewreceipt_dialog



    Public Sub New(id As String, product_id As String)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Dim receipt_query As String = $"
        SELECT 
        ohp.order_id as 'ORDER_ID',
        ohp.product_id  as 'PRODUCT_ID',
        p.item_name  as 'PRODUCT_NAME',
        p.price  as 'PRICE',
        ohp.quantity  as 'QUANTITY',

        ohp.cost  as 'COST',        

        o.ship_date  as 'SHIPPING_DATE',
        `s`.`type`  as 'ORDER TYPE',
        s.amount  as 'SHIP AMOUNT'
        FROM 
        `order_has_product` as ohp
        INNER JOIN `order` as o
        ON ohp.order_id = o.id
        INNER JOIN `product` as p
        ON ohp.product_id = p.id
        INNER JOIN `shipping_info` as s
        ON s.type = o.shipping_type
        WHERE ohp.order_id = '{id}'
        "

        Dim aggrated_cost = $"
        SELECT 
        SUM(ohp.cost) + s.amount as 'TOTAL_COST'
        FROM 
        order_has_product as ohp
        INNER JOIN `order` as o
        ON ohp.order_id = o.id
        INNER JOIN `shipping_info` as s
        ON s.type = o.shipping_type
        WHERE ohp.order_id = '{id}'
        "


        Dim report As New view_receipt

        report.Database.Tables(0).SetDataSource(ExecuteQuery(receipt_query))
        report.Database.Tables(1).SetDataSource(ExecuteQuery(aggrated_cost))
        report.Refresh()
        reportWizard1.ReportSource = report
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        switchPanel(prevPage, currentPage)
    End Sub

    Private Sub _viewreceipt_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class