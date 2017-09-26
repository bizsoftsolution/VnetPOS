Public Class frmMemberRenew
    Dim tb As JISTable = db.MemberRenew

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True
        If txtMemberId.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtMemberId, "Please Enter the Member Id")
            txtMemberId.Focus()
            RValue = False
        ElseIf Not db.MemberRegistration.ExistCode(txtMemberId.Text) Then
            ErrorProvider1.SetError(txtMemberId, txtMemberId.Text + " does not Exist. Please Enter the Valid Member Id")
            txtMemberId.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtMemberId, "")
        End If
        If dtpRenewDate.Value < dtpEntryDate.Value Then
            ErrorProvider1.SetError(dtpRenewDate, "Please Enter the Renew Date must be greater than Entry Date")
            txtMemberId.Focus()
            RValue = False
        Else

        End If
        Return RValue
    End Function

    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Enter, txtMemberName.Enter, txtAmount.Enter, cmbPaymentType.Enter, txtMemberId.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        
        'If sender.name = "txtSearchBox" Then List_Datas(txtSearchBox, db.Customer.UserCodes())
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.Leave, txtMemberName.Leave, txtAmount.Leave, cmbPaymentType.Leave, txtMemberId.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight

    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb.SetControls(txtId, txtCode, txtMemberId, dtpRenewDate, dtpEntryDate, txtAmount, cmbPaymentType)
        SetFormStyle(Me)
        NewForm()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FormShow(frmMemberRenewReport)
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
        FormShow(frmMemberRenewSearch)
    End Sub
    Sub NewForm()
        tb.NewRecord()
        txtCode.Text = db.MemberRenew.NewCode()
        txtMemberId.Focus()
        dtpRenewDate.Value = DateAdd(DateInterval.Year, 1, dtpEntryDate.Value)
        ErrorProvider1.Clear()
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
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg("Membership Successfully Renewed", Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then
                Dim Qry As String
                Qry = String.Format("Update MemberRegistration set RenewDate=#{0}# where MemberCode='{1}'", dtpRenewDate.Value, txtMemberId.Text)
                JISDb.ExecuteQuery(Qry)
                If ckbisprint.Checked = True Then
                    Dim f As New frmQuickMemberRenewReport
                    f.viewprint(txtCode.Text)
                    f.CrystalReportViewer1.RefreshReport()
                    f.Show()
                    f.CrystalReportViewer1.PrintReport()
                End If
                
                NewForm()
            End If
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
        If db.MemberRenew.State = "New" Then Exit Sub
        Dim f As New frmQuickMemberRenewReport
        f.viewprint(txtCode.Text)
        f.CrystalReportViewer1.RefreshReport()
        f.Show()
        f.CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub dtpEntryDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEntryDate.ValueChanged
        dtpRenewDate.Value = DateAdd(DateInterval.Year, 1, dtpEntryDate.Value)
    End Sub

    Private Sub cmbPaymentType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaymentType.SelectedIndexChanged
        Try
            If cmbPaymentType.Text = "Cash" Then
                txtAmount.Text = "50"
            ElseIf cmbPaymentType.Text = "Credit Card" Then
                txtAmount.Text = 50 + (50 * 0.0212)
            Else
                txtAmount.Text = "50"
            End If
        Catch ex As Exception

        End Try
    End Sub
   
    Private Sub txtMemberId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        Try
            txtMemberName.Text = db.MemberRegistration.UserCodeByCode(txtMemberId.Text)
        Catch ex As Exception

        End Try
    End Sub

  
End Class