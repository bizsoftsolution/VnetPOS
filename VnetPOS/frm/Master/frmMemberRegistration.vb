Public Class frmMemberRegistration

    Dim tb As JISTable = db.MemberRegistration

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtCustomerName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtCustomerName, "Please Enter the Customer Name")
            txtCustomerName.Focus()
            RValue = False
        ElseIf tb.State = "New" And tb.ExistUserCode(txtCustomerName.Text) Then
            ErrorProvider1.SetError(txtCustomerName, txtCustomerName.Text + " is Already Exist. Please Enter the New Customer Name")
            txtCustomerName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtCustomerName, "")
        End If

        If cmbPaymentType.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPaymentType, "Please Select Payment Type")
            cmbPaymentType.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPaymentType, "")
        End If

        If dtpRenewDate.Value < dtpRegDate.Value Then
            ErrorProvider1.SetError(dtpRenewDate, "Renew Date must be greater than Registration Date")
            dtpRenewDate.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(dtpRenewDate, "")
        End If

        Return RValue
    End Function

    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtMobileNo.Enter, txtEmailId.Enter, txtCity.Enter, txtAddressLine.Enter, txtId.Enter, txtCustomerName.Enter, txtState.Enter, txtCode.Enter, txtRegAmount.Enter, txtICNo.Enter, cmbPaymentType.Enter, txtPostalCode.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        'If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, db.Customer.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtMobileNo.Leave, txtEmailId.Leave, txtCity.Leave, txtAddressLine.Leave, txtId.Leave, txtCustomerName.Leave, txtState.Leave, txtCode.Leave, txtRegAmount.Leave, txtICNo.Leave, cmbPaymentType.Leave, txtPostalCode.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtCustomerName, txtAddressLine, txtCity, txtState, txtMobileNo, txtEmailId, dtpRegDate, dtpRenewDate, txtRegAmount, txtICNo, cmbPaymentType, txtPostalCode)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmMemberRegistrationReport)
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

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = NumericCheckwithsingledot(sender, e.KeyChar, False)
    End Sub
    Private Sub frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l, t As Integer

        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

        l = (pnlContent.Width - pnlForm.Width) / 2
        If l < 0 Then l = 0

        t = (pnlContent.Height - pnlForm.Height) / 2
        If t < 0 Then t = 0


        pnlForm.Left = l
        'pnlForm.Top = t

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewForm()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteForm()
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ' ViewForm()
        FormShow(frmMemberRegistrationSearch)
    End Sub

    Sub NewForm()
        tb.NewRecord()
        txtCode.Focus()
        ErrorProvider1.Clear()
        txtRegAmount.Text = "50"
        dtpRenewDate.Value = DateAdd(DateInterval.Year, 1, dtpRegDate.Value)
        ckbIsAutoGeneration()
    End Sub

    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = tb.ViewRecordByCode(txtSearchBox.Text)
            If str <> "" Then MsgDialog.ShowMsgDlg(str, Me.Text, "I") Else txtSearchBox.Text = ""
            ErrorProvider1.Clear()
        End If
    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = tb.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg("Membership Successfully Registered", Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                If ckbisprint.Checked = True Then
                    Dim f As New frmQuickMemberRegReport
                    f.viewprint(txtCode.Text)
                    f.CrystalReportViewer1.RefreshReport()
                    f.Show()
                    f.CrystalReportViewer1.PrintReport()
                End If
            End If
            NewForm()
        End If
    End Sub

    Sub DeleteForm()
        If tb.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        str = tb.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, Me.Text, "I")
        If str = "Deleted" Then
            NewForm()
        End If
    End Sub

    Public Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        ViewForm()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If db.MemberRegistration.State = "New" Then Exit Sub
        Dim f As New frmQuickMemberRegReport
        f.viewprint(txtCode.Text)
        f.CrystalReportViewer1.RefreshReport()
        f.Show()
        f.CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub dtpRegDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpRegDate.ValueChanged
        dtpRenewDate.Value = DateAdd(DateInterval.Year, 1, dtpRegDate.Value)
    End Sub

    Private Sub cmbPaymentType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaymentType.TextChanged
        Try
            If cmbPaymentType.Text = "Cash" Then
                txtRegAmount.Text = "50"
            ElseIf cmbPaymentType.Text = "Credit Card" Then
                txtRegAmount.Text = 50 + (50 * 0.0212)
            Else
                txtRegAmount.Text = "50"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ckbIsAutoGenerate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbIsAutoGenerate.CheckedChanged
        ckbIsAutoGeneration()
    End Sub
    Sub ckbIsAutoGeneration()
        Try
            If ckbIsAutoGenerate.Checked = True Then
                txtCode.Text = db.MemberRegistration.Data("Max(MemberCode)+1")
            Else
                txtCode.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class