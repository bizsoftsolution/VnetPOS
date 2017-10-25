Public Class frmPurchaseSearch
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
        lblValue.Font = New System.Drawing.Font("Arial", 25.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWords.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ViewSearch()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub
    Sub ViewSearch()
        dtpBillDateFrom.Value = New Date(dtpBillDateFrom.Value.Year, dtpBillDateFrom.Value.Month, dtpBillDateFrom.Value.Day, 0, 0, 0)
        dtpBillDateTo.Value = New Date(dtpBillDateTo.Value.Year, dtpBillDateTo.Value.Month, dtpBillDateTo.Value.Day, 23, 59, 59)

        Dim PType As String = ""
        Dim SDate As String = dtpBillDateFrom.Value.ToString()
        Dim EDate As String = dtpBillDateTo.Value.ToString()

        Dim WQry As String

        WQry = "PurchaseDate between  #" + SDate + "# And #" + EDate + "#"

        If txtCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "SupplierName Like '"
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
            WQry += "ICNO ='" + txtICNo.Text + "'"
        End If
        If txtMemberId.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "SupplierId ='" + txtMemberId.Text + "'"
        End If
        Dim dv As DataView
        dv = db.ViewPurchase.Grid("PurchaseCode,PurchaseDate, PurchaseType, SupplierName, Address,TotAmt", WQry, "PurchaseCode")
        dgvSearch.DataSource = dv
        dgvSearch.Columns("PurchaseCode").HeaderText = "Id"
        dgvSearch.Columns("PurchaseDate").HeaderText = "Date"
        dgvSearch.Columns("PurchaseCode").Width = 100
        dgvSearch.Columns("PurchaseDate").Width = 80
        dgvSearch.Columns("PurchaseType").Width = 80
        dgvSearch.Columns("SupplierName").Width = 200
        dgvSearch.Columns("Address").Width = 270
        dgvSearch.Columns("TotAmt").Width = 150
        Dim TotalAmt As Long
        TotalAmt = Val(db.ViewSales.Data("Sum(TotAmt)", WQry))
        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "RM " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If

        dgvSearch.Columns("PurchaseDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("TotAmt").DefaultCellStyle.Format = "0.00"
        dgvSearch.Columns("TotAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmPurchase.txtSearchBox.Text = txtCode.Text
            frmPurchase.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class