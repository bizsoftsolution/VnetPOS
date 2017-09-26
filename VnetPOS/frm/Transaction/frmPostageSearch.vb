Public Class frmPostageSearch
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtCustomerName.Enter, txtICNo.Enter, cmbOrderNo.Enter, txtPostalCode.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name = cmbOrderNo.Name Then
            List_Datas(cmbOrderNo, db.Postage.UserCodes())
        End If
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub
    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtCustomerName.Leave, txtICNo.Leave, cmbOrderNo.Leave, txtPostalCode.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
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

        Dim SDate As String = dtpBillDateFrom.Value.ToString()
        Dim EDate As String = dtpBillDateTo.Value.ToString()

        Dim WQry As String

        WQry = "OrderDate between  #" + SDate + "# And #" + EDate + "#"

        If txtCustomerName.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MemberName Like '"
            If rbnCusSuffix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += txtCustomerName.Text
            If rbnCusPrefix.Checked = True Or rbnCusInfix.Checked = True Then WQry += "%"
            WQry += "'"
        End If
        If txtICNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ICNO ='" + txtICNo.Text + "'"
        End If

        If cmbOrderNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "RefNo =" + cmbOrderNo.Text
        End If

        If txtPostalCode.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "PostalCode ='" + txtPostalCode.Text + "'"
        End If

        Dim dv As DataView
        dv = db.ViewPostage.Grid("PostageCode,OrderDate,RefNo,PaymentType,MemberName,Address,TotAmt", WQry, "PostageCode")
        dgvSearch.DataSource = dv
        dgvSearch.Columns("PostageCode").Width = 100
        dgvSearch.Columns("OrderDate").Width = 120
        dgvSearch.Columns("PaymentType").Width = 120
        dgvSearch.Columns("MemberName").Width = 170
        dgvSearch.Columns("Address").Width = 150
        dgvSearch.Columns("TotAmt").Width = 120

        dgvSearch.Columns("PostageCode").Visible = False
        dgvSearch.Columns("OrderDate").HeaderText = "ORDER DATE"
        dgvSearch.Columns("RefNo").HeaderText = "ORDER NO"
        dgvSearch.Columns("MemberName").HeaderText = "MEMBER NAME"
        dgvSearch.Columns("Address").HeaderText = "ADDRESS"
        dgvSearch.Columns("TotAmt").HeaderText = "AMOUNT"

        Dim TotalAmt As Long
        TotalAmt = Val(db.ViewPostage.Data("Sum(TotAmt)", WQry))
        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "RM " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If

        dgvSearch.Columns("OrderDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("TotAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmPostage.txtSearchBox.Text = txtCode.Text
            frmPostage.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class