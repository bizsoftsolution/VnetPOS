Public Class frmMemberRegistrationReport
    Dim db As New DBLib
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


    Private Sub frmCustomersReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
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

        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTCustomer As New DataTable()
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        ' DTCustomer = db.Customer.Grid("*").ToTable("Customer")
      
        DTCustomer = db.MemberRegistration.Grid("*", WQry).ToTable("MemberRegistration")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTCustomer)
        ReportView(CrystalReportViewer1, "Master\cryMemberRegistration.rpt", ds)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.Enter, txtAddress.Enter, txtMemberId.Enter, txtMobile.Enter, txtICNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight

    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.Leave, txtAddress.Leave, txtMemberId.Leave, txtMobile.Leave, txtICNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

End Class