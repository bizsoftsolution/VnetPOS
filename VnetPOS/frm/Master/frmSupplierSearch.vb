Public Class frmSupplierSearch

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

        Dim WQry As String = ""

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

        If txtICNo.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "ICNo ='" + txtICNo.Text + "'"
        End If
        dgvCustomerSearch.DataSource = db.Supplier.Grid("SupplierCode,SupplierName,ICNo,Address,ContactNo,EmailId", WQry)
        dgvCustomerSearch.Columns("SupplierCode").Width = 120
        dgvCustomerSearch.Columns("SupplierName").Width = 200
        dgvCustomerSearch.Columns("ICNo").Width = 150
        dgvCustomerSearch.Columns("Address").Width = 180
        dgvCustomerSearch.Columns("ContactNo").Width = 120
        dgvCustomerSearch.Columns("EmailId").Width = 150

        dgvCustomerSearch.Columns("SupplierCode").HeaderText = "Supplier Id"
        dgvCustomerSearch.Columns("SupplierName").HeaderText = "Supplier Name"

    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.Enter, txtMobile.Enter, txtCustomerName.Enter, txtICNo.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.Leave, txtMobile.Leave, txtCustomerName.Leave, txtICNo.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.DoubleClick
        Try
            frmSupplier.txtSearchBox.Text = dgvCustomerSearch.SelectedRows(0).Cells(0).Value()
            frmSupplier.btnSearch1_Click(sender, e)
            FormShow(frmSupplier)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmCustomerSearch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim l As Integer
        l = (pnlHeader.Width - pnlToolBar.Width) / 2
        If l < 0 Then l = 0
        pnlToolBar.Left = l

    End Sub
End Class