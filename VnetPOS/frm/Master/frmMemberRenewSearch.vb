Public Class frmMemberRenewSearch
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
        'dtpBillDateFrom.Value = DateAdd(DateInterval.Day, -1, dtpBillDateFrom.Value)
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

        WQry = String.Format("EntryDate between  #{0}# And #{1}# and Amount between {2} and {3}", SDate, EDate, BillAmtFrom, BillAmtTo)

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
            WQry += "ICNo ='" + txtICNo.Text + "'"
        End If

        Dim dv As DataView
        dv = db.ViewRenew.Grid("RenewCode,MemberCode,MemberName,ICNo,EntryDate, NextRenewDate,Address,ContactNo,Amount", WQry, "RenewCode")
        dgvSearch.DataSource = dv
        dgvSearch.Columns("RenewCode").Width = 80
        dgvSearch.Columns("EntryDate").Width = 100
        dgvSearch.Columns("NextRenewDate").Width = 100
        dgvSearch.Columns("MemberCode").Width = 100
        dgvSearch.Columns("MemberName").Width = 180
        dgvSearch.Columns("ICNo").Width = 150
        dgvSearch.Columns("Address").Width = 200
        dgvSearch.Columns("ContactNo").Width = 150
        dgvSearch.Columns("Amount").Width = 100

        dgvSearch.Columns("EntryDate").HeaderText = "Bill Date"
        dgvSearch.Columns("MemberCode").HeaderText = "Member ID"
        Dim TotalAmt As Long
        TotalAmt = Val(db.ViewRenew.Data("Sum(Amount)", WQry))
        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "RM " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If

        dgvSearch.Columns("EntryDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("NextRenewDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvSearch.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dgvSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.DoubleClick
        Try
            txtCode.Text = dgvSearch.SelectedRows(0).Cells(0).Value()
            frmMemberRenew.txtSearchBox.Text = txtCode.Text
            frmMemberRenew.ViewForm()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class