Public Class frmStockReport
    Dim db As New DBLib

    Private Sub frmINV_SalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmINV_SalesReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frmINV_SalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub
    Sub ViewSearch()
        dtpFDate.Value = New Date(dtpFDate.Value.Year, dtpFDate.Value.Month, dtpFDate.Value.Day, 0, 0, 0)
        dtpTDate.Value = New Date(dtpTDate.Value.Year, dtpTDate.Value.Month, dtpTDate.Value.Day, 23, 59, 59)
        Dim PType As String = ""
        Dim SDate As String = dtpFDate.Value.ToString()
        Dim EDate As String = dtpTDate.Value.ToString()

        Dim WQry As String = "SalesDate between #" + SDate + "# And #" + EDate + "#"

        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTSales As New DataTable()
        Dim DTSalesDetails As New DataTable()

        DTSales = db.ViewSales.Grid("*", WQry, "SalesCode").ToTable("ViewSales")
        WQry = "SalesCode in (select SalesCode from ViewSales where " + WQry + ")"
        DTSalesDetails = db.ViewSalesDetails.Grid("*", WQry, "SalesCode").ToTable("ViewSalesDetails")

        ds.Clear()
        ds.Tables.Add(DTSales)
        ds.Tables.Add(DTSalesDetails)

        ReportView(CrystalReportViewer1, "InventoryReport\crySales.rpt", ds)

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Enter, dtpTDate.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFDate.Leave, dtpTDate.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub
End Class