Public Class frmSalesReport
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtAddress.Enter, txtBillAmountFrom.Enter, txtBillAmountTo.Enter, txtCustomerName.Enter, txtICNo.Enter, cmbOrderNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbOrderNo.Name Then
            List_Datas(cmbOrderNo, db.Postage.Column("RefNo"))
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub
    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtAddress.Leave, txtBillAmountFrom.Leave, txtBillAmountTo.Leave, txtCustomerName.Leave, txtICNo.Leave, cmbOrderNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtpBillDateFrom.Value = New Date(dtpBillDateFrom.Value.Year, dtpBillDateFrom.Value.Month, dtpBillDateFrom.Value.Day, 0, 0, 0)
        dtpBillDateTo.Value = New Date(dtpBillDateTo.Value.Year, dtpBillDateTo.Value.Month, dtpBillDateTo.Value.Day, 23, 59, 59)

        Dim PType As String = ""
        Dim SDate As String = dtpBillDateFrom.Value.ToString()
        Dim EDate As String = dtpBillDateTo.Value.ToString()

        Dim WQry As String

        Dim BillAmtFrom, BillAmtTo As Long
        BillAmtFrom = 0
        BillAmtTo = 99999999

        If txtBillAmountFrom.Text.Trim <> "" Then BillAmtFrom = Val(txtBillAmountFrom.Text)
        If txtBillAmountTo.Text.Trim <> "" Then BillAmtTo = Val(txtBillAmountTo.Text)

        WQry = "SalesDate between  #" + SDate + "# And #" + EDate + "# and TotAmt>=" + BillAmtFrom.ToString() + " and TotAmt<=" + BillAmtTo.ToString()

        If txtCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MemberName Like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += txtCustomerName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtAddress.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "Address Like '"
            If rbnAdrsSufix.Checked = True Or rbnAdrsInfix.Checked = True Then WQry += "%"
            WQry += txtAddress.Text
            If rbnAdrsPrefix.Checked = True Or rbnAdrsInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtICNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ICNo='" + txtICNo.Text + "'"
        End If

        If cmbOrderNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "RefNo='" + cmbOrderNo.Text + "'"
        End If

        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTSales As New DataTable()
        Dim DTSalesDetails As New DataTable()
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        DTSales = db.ViewSales.Grid("*", WQry).ToTable("ViewSales")
        WQry = "SalesCode in (select SalesCode from ViewSales where " + WQry + ")"
        DTSalesDetails = db.ViewSalesDetails.Grid("*", WQry, "SalesCode").ToTable("ViewSalesDetails")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTSales)
        ds.Tables.Add(DTSalesDetails)
        ReportView(CrystalReportViewer1, "InventoryReport\crySales.rpt", ds)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Public Sub viewprint(ByVal Code As String)
        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTSales As New DataTable()
        Dim DTSalesDetails As New DataTable()
        Dim DTSplittedDetails As New DataTable()


        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")
        DTSales = db.Sales.Grid("*", "SalesCode='" + Code + "'").ToTable("Sales")
        DTSalesDetails = db.SalesDetails.Grid("*", "SalesCode='" + Code + "'").ToTable("SalesDetails")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTSales)
        ds.Tables.Add(DTSalesDetails)

        ReportView(CrystalReportViewer1, "InventoryReport\crySales.rpt", ds)

    End Sub

End Class