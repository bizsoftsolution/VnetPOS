Public Class frmProductSearch

    Private Sub frmCustomerSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
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

        Dim WQry As String = ""

        If txtProductName.Text.Trim <> "" Then
            WQry += "ProductName Like '"
            If rbnSuffixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += txtProductName.Text
            If rbnPrefixCustomer.Checked = True Or rbnInfixCustomer.Checked = True Then WQry += "%"
            WQry += "'"
        End If

        If txtProductUserCode.Text.Trim <> "" Then
            If WQry <> "" Then WQry += " and "
            WQry += "UserCode='" + txtProductUserCode.Text + "'"
        End If

        dgvCustomerSearch.DataSource = db.Product.Grid("ProductId,ProductName,UserCode,SellingRate,MSellingRate", WQry)
        dgvCustomerSearch.Columns("ProductId").Width = 150
        dgvCustomerSearch.Columns("ProductName").Width = 200
        dgvCustomerSearch.Columns("UserCode").Width = 250
        dgvCustomerSearch.Columns("SellingRate").Width = 150
        dgvCustomerSearch.Columns("MSellingRate").Width = 200

        dgvCustomerSearch.Columns("UserCode").HeaderText = "Product Code"
        dgvCustomerSearch.Columns("ProductName").HeaderText = "Product Name"
        dgvCustomerSearch.Columns("SellingRate").HeaderText = "Non Member Rate"
        dgvCustomerSearch.Columns("MSellingRate").HeaderText = "Member Rate"

        dgvCustomerSearch.Columns("ProductId").Visible = False
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewSearch()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub cmbCustomerName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductUserCode.Enter, txtProductName.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProductUserCode.Leave, txtProductName.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub dgvCustomerSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomerSearch.DoubleClick
        Try
            frmProduct.txtSearchBox.Text = dgvCustomerSearch.SelectedRows(0).Cells(0).Value()
            frmProduct.btnSearch1_Click(sender, e)
            FormShow(frmProduct)
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