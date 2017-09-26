Public Class frmQuickSalesReport
    Dim db As New DBLib

    Private Sub frmQuickSalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmQuickSalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub
    Public Sub viewprint(ByVal Code As String)
        Dim ds As New DataSet
        Dim DTSales As New DataTable()
        Dim DTSalesDetails As New DataTable()

        DTSales = db.ViewSales.Grid("*", "SalesCode='" + Code + "'").ToTable("ViewSales")
        DTSalesDetails = db.ViewSalesDetails.Grid("*", "SalesCode='" + Code + "'").ToTable("ViewSalesDetails")

        ds.Clear()
        ds.Tables.Add(DTSales)
        ds.Tables.Add(DTSalesDetails)

        ReportView(CrystalReportViewer1, "Transaction\cryQuickSalesReportNew.rpt", ds)

    End Sub
End Class