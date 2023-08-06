Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReportsPage

    Public Shared Info As String

    Private Sub OnPageSwitch(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return
        Reload()
        ManageHandlers()
    End Sub

    Private Sub Reload()

    End Sub

    Private Sub ManageHandlers()
    End Sub

    Private Sub btnProductReport_Click(sender As Object, e As EventArgs) Handles btnProductReport.Click
        Dim report As New ReportDocument()
        report.Load(reports_path & "product_report.rpt")
        reportWizard1.ReportSource = report
    End Sub

    Private Sub reportWizard1_Load(sender As Object, e As EventArgs) Handles reportWizard1.Load

    End Sub
End Class