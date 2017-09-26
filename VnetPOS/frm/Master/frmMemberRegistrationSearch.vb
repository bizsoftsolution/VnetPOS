Public Class frmMemberRegistrationSearch

    Private Sub frmCustomerSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblValue.Font = New System.Drawing.Font("Arial", 25.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWords.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ViewSearch()
    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then

            ElseIf ctl.Text = "@" Then

            Else
                If TypeOf ctl Is TextBox Then
                    Dim txt As TextBox = DirectCast(ctl, TextBox)
                    If txt.Multiline = True Then
                        If txt.Text.EndsWith(vbCrLf) Then
                            Me.SelectNextControl(ctl, True, True, True, True)
                        End If
                    Else
                        Me.SelectNextControl(ctl, True, True, True, True)
                    End If
                Else
                    Me.SelectNextControl(ctl, True, True, True, True)
                End If


            End If

        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If

    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = Chr(13) Then
            Dim ctl As Control = Me.ActiveControl
            If TypeOf ctl Is TextBox Then
                Dim txt As TextBox = DirectCast(ctl, TextBox)
                If txt.Multiline = False Then e.KeyChar = ChrW(0)
            Else
                e.KeyChar = ChrW(0)
            End If
        End If

    End Sub


    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        Dim dv As New DataView
        ViewSearch()
    End Sub

    Sub ViewSearch()

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
        If txtMemberId.Text = "" And txtICNo.Text = "" Then
            WQry = String.Format("RegDate between  #{0}# And #{1}# and RegAmount between {2} and {3}", SDate, EDate, BillAmtFrom, BillAmtTo)
        Else
            WQry = ""
        End If


        If txtCustomerName.Text.Trim <> "" Then
            WQry += "MemberName Like '"
            If rbnSuffixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += txtCustomerName.Text
            If rbnPrefixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += "'"
        End If


        If txtAddress.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "Address Like '"
            If rbnSuffixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += txtAddress.Text
            If rbnPrefixAddress.Checked = True Or rbnInfixAddress.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtMobile.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "

            WQry += "ContactNo Like '"
            If rbnSuffixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += txtMobile.Text
            If rbnPrefixMobile.Checked = True Or rbnInfixMobile.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtMemberId.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "MemberCode ='" + txtMemberId.Text + "'"
        End If
        If txtICNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ICNo ='" + txtICNo.Text + "'"
        End If
        dgvCustomerSearch.DataSource = db.MemberRegistration.Grid("MemberCode,RegDate,MemberName,ICNo,Address,ContactNo,EmailId,RegAmount as Amount", WQry)
        dgvCustomerSearch.Columns("MemberCode").Width = 120
        dgvCustomerSearch.Columns("MemberName").Width = 200
        dgvCustomerSearch.Columns("ICNo").Width = 150
        dgvCustomerSearch.Columns("Address").Width = 180
        dgvCustomerSearch.Columns("ContactNo").Width = 120
        dgvCustomerSearch.Columns("EmailId").Width = 150

        dgvCustomerSearch.Columns("MemberCode").HeaderText = "Member Id"
        dgvCustomerSearch.Columns("MemberName").HeaderText = "Member Name"
        dgvCustomerSearch.Columns("RegDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvCustomerSearch.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim TotalAmt As Long
        TotalAmt = Val(db.MemberRegistration.Data("Sum(RegAmount)", WQry))
        If TotalAmt = 0 Then
            lblValue.Text = ""
            lblWords.Text = ""
        Else
            lblValue.Text = "RM " & TotalAmt.ToString
            lblWords.Text = Number_to_Word.numtoword(TotalAmt)
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.Enter, txtMobile.Enter, txtMemberId.Enter, txtCustomerName.Enter, txtICNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave, txtMobile.Leave, txtMemberId.Leave, txtCustomerName.Leave, txtICNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.DoubleClick
        Try
            frmMemberRegistration.txtSearchBox.Text = dgvCustomerSearch.SelectedRows(0).Cells(0).Value()
            frmMemberRegistration.btnSearch1_Click(sender, e)
            FormShow(frmMemberRegistration)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvCustomerSearch_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomerSearch.CellContentClick

    End Sub

    Private Sub frmCustomerSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub
End Class