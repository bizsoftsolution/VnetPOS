Public Class frmMemberStatusReport
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

        Dim WQry As String = ""

        Dim BillAmtFrom, BillAmtTo As Long
        BillAmtFrom = 0
        BillAmtTo = 99999999

        If cmbMemberStatus.Text.Trim = "Active" Then
            If WQry <> "" Then WQry += " and "
            WQry += "RenewDate >= #" + Now.Date + "#"
        ElseIf cmbMemberStatus.Text.Trim = "Expired" Then
            WQry += "RenewDate < #" + Now.Date + "#"
        End If

        Dim ds As New DataSet
        Dim DTCompanyDetails As New DataTable()
        Dim DTMemberRenew As New DataTable()
        DTCompanyDetails = db.CompanyDetails.Grid("*", "CompanyName='" + CompName + "'").ToTable("CompanyDetails")

        DTMemberRenew = db.MemberRegistration.Grid("*", WQry).ToTable("MemberRegistration")

        ds.Clear()
        ds.Tables.Add(DTCompanyDetails)
        ds.Tables.Add(DTMemberRenew)
        ReportView(CrystalReportViewer1, "Master\cryMemberStatus.rpt", ds)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub txtCode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMemberStatus.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub txtcode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMemberStatus.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub btnExpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpired.Click
        Dim frm As New frmExpiredReport
        frm.Status = "Expired"
        FormShow(frm)
    End Sub

    Private Sub btnToBeExpired_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToBeExpired.Click
        Dim frm As New frmExpiredReport
        frm.Status = "To Be Expired"
        FormShow(frm)
    End Sub
End Class