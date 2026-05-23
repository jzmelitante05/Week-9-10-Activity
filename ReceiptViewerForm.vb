Imports System.Data

Public Class ReceiptViewerForm

    Private Sub ReceiptViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable()

        dt.Columns.Add("ItemName")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Price")
        dt.Columns.Add("Total")

        dt.Rows.Add("Keyboard", 2, 500, 1000)
        dt.Rows.Add("Mouse", 1, 300, 300)
        dt.Rows.Add("Monitor", 1, 4500, 4500)

        Dim report As New CrystalReport1()

        report.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()

    End Sub

End Class
