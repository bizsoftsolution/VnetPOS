Public Class frmPurchase
    Dim ItemState As String = "New"

    Function FormValidate() As Boolean
        Dim RValue As Boolean = True

        If txtMemberName.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtMemberName, "Please Enter the Member Name")
            txtMemberName.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(txtMemberName, "")
        End If


        If cmbPurchaseType.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPurchaseType, "Please Select the Purchase Type")
            cmbPurchaseType.Focus()
            RValue = False
        Else
            ErrorProvider1.SetError(cmbPurchaseType, "")
        End If


        If RValue = True Then
            If dgvDetails.Rows.Count = 0 Then
                MsgDialog.ShowMsgDlg("Please Enter The Items", Me.Text, "I")
                RValue = False
            ElseIf dgvDetails.Item(0, 0).Value = Nothing Then
                MsgDialog.ShowMsgDlg("Please Enter The Items", Me.Text, "I")
                RValue = False
            End If
        End If
        Return RValue

    End Function

    Private Sub NumericInput(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExtras.KeyPress, txtTotAmount.KeyPress
        e.KeyChar = NumericCheckwithsingledot(sender, e.KeyChar, False)
    End Sub

    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Enter, txtTotalDiscount.Enter, txtTotalAmount.Enter, txtSearchBox.Enter, txtRoundOff.Enter, txtNarration.Enter, txtItemsAmount.Enter, txtId.Enter, txtExtras.Enter, dtpDate.Enter, cmbPurchaseType.Enter, txtSNo.Enter, txtRate.Enter, txtQty.Enter, txtTotAmount.Enter, cmbProductName.Enter, txtAddress.Enter, cmbGSTPer.Enter, txtGSTAmt.Enter, txtDisPer.Enter, txtDisAmt.Enter, txtTotGSTAmt.Enter, cmbCode.Enter, txtOrderNo.Enter, txtICNo.Enter, txtPostalCode.Enter, txtMemberName.Enter, txtPhoneNo.Enter, txtMemberId.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor

        If sender.name = cmbProductName.Name Then
            List_Datas(cmbProductName, db.Product.UserCodes())
        End If
        If sender.Name = cmbCode.Name Then
            List_Datas(cmbCode, db.Product.Column("UserCode"))
        End If

        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Leave, txtTotalDiscount.Leave, txtTotalAmount.Leave, txtSearchBox.Leave, txtRoundOff.Leave, txtNarration.Leave, txtItemsAmount.Leave, txtId.Leave, txtExtras.Leave, dtpDate.Leave, cmbPurchaseType.Leave, txtSNo.Leave, txtRate.Leave, txtQty.Leave, txtTotAmount.Leave, cmbProductName.Leave, txtAddress.Leave, cmbGSTPer.Leave, txtGSTAmt.Leave, txtDisPer.Leave, txtDisAmt.Leave, txtTotGSTAmt.Leave, cmbCode.Leave, txtOrderNo.Leave, txtICNo.Leave, txtPostalCode.Leave, txtMemberName.Leave, txtPhoneNo.Leave, txtMemberId.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SetFormStyle(Me)

        db.Purchase.SetControls(txtId, txtCode, dtpDate, cmbPurchaseType, txtExtras, txtTotalDiscount, txtNarration, txtMemberName, txtAddress, txtOrderNo, txtMemberId, txtICNo, txtPostalCode, txtPhoneNo)
        db.PurchaseDetails.SetControls(txtDetailsId, txtDetailsCode, txtMasterCode, txtProductCode, txtRate, txtQty, cmbGSTPer, txtDisAmt, cmbCode)

        dgvDetails.Columns("SNo").Width = txtSNo.Width
        dgvDetails.Columns("ProductCode").Width = cmbCode.Width
        dgvDetails.Columns("ItemName").Width = cmbProductName.Width
        dgvDetails.Columns("Qty").Width = txtQty.Width
        dgvDetails.Columns("Rate").Width = txtRate.Width
        dgvDetails.Columns("Amount").Width = txtAmount.Width
        dgvDetails.Columns("TaxPer").Width = cmbGSTPer.Width
        dgvDetails.Columns("TaxAmt").Width = txtGSTAmt.Width
        dgvDetails.Columns("DisPer").Width = txtDisPer.Width
        dgvDetails.Columns("DisAmt").Width = txtDisAmt.Width
        dgvDetails.Columns("TotAmount").Width = txtTotAmount.Width

        dgvDetails.ColumnHeadersVisible = False
        dgvDetails.RowHeadersVisible = False
        dgvDetails.Rows.Add()
        lblvalue.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        NewForm()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormShow(frmSalesReport)
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
        ' pnlForm.Top = t
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewForm()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtMemberId.Text = "" Then
            txtMemberId.Text = "0"
        End If
        If txtOrderNo.Text = "" Then
            txtOrderNo.Text = "0"
        End If
        SaveForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteForm()
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ViewForm()
    End Sub

    Private Sub txtITAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveItem()

        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        NewItem()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        ViewItem(dgvDetails.CurrentRow.Index)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgDialog.ShowMsgDlg("Do you Delete this Item?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then
            DeleteItem()
            MsgDialog.ShowMsgDlg("Deleted", Me.Text, "I")
        End If
    End Sub

    Private Sub dgvDetails_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDetails.MouseDown
        dgvDetails.ContextMenuStrip = Nothing
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                If dgvDetails.Item(0, dgvDetails.CurrentRow.Index).Value <> Nothing Then
                    dgvDetails.ContextMenuStrip = ContextMenuStrip1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetails_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvDetails.RowsAdded
        If dgvDetails.Rows.Count > 9 Then
            dgvDetails.Width = 1125
        Else
            dgvDetails.Width = 1107
        End If
    End Sub

    Private Sub dgvDetails_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvDetails.RowsRemoved
        If dgvDetails.Rows.Count > 9 Then
            dgvDetails.Width = 1125
        Else
            dgvDetails.Width = 1107
        End If
    End Sub

    Private Sub FindAmount(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged, txtQty.TextChanged
        If txtAmount.Focused = False Then txtAmount.Text = String.Format("{0:0.00}", Val(txtRate.Text) * Val(txtQty.Text))
    End Sub

    Private Sub FindRate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        If txtAmount.Focused Then txtRate.Text = String.Format("{0:0.00}", Val(txtAmount.Text) / Val(txtQty.Text))
    End Sub


    Private Sub ShowAmountInWord(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAmount.TextChanged
        If Val(txtTotalAmount.Text) <> 0 Then
            lblvalue.Text = "RM " & Val(txtTotalAmount.Text)
            lblwords.Text = Number_to_Word.numtoword(txtTotalAmount.Text)
        Else
            lblvalue.Text = ""
            lblwords.Text = ""
        End If
    End Sub

    Private Sub FindBillAmount(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExtras.TextChanged, txtTotalDiscount.TextChanged
        FindTotalAmount()
    End Sub


    Private Sub frmCustomers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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
    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.Return Then
            Dim ctl As Control = Me.ActiveControl
            If ctl.Text = "+" Then
                If ctl.Name = txtMemberName.Name Then
                End If
                If ctl.Name = cmbProductName.Name Then
                    FormShow(frmProduct)
                End If

                If ctl.Name = cmbGSTPer.Name Then

                End If
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
    Private Sub cmbSalesType_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbPurchaseType.Validating
        If cmbPurchaseType.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbPurchaseType, "Please Enter the Purchase Type")
        Else
            If cmbPurchaseType.FindStringExact(cmbPurchaseType.Text) = -1 Then
                ErrorProvider1.SetError(cmbPurchaseType, "Please Enter the Valid Purchase Type")
            Else
                ErrorProvider1.SetError(cmbPurchaseType, "")
            End If
        End If
    End Sub

    Private Sub txtProductCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductCode.TextChanged
        cmbProductName.Text = db.Product.UserCodeByCode(txtProductCode.Text)
    End Sub

    Private Sub cmbSalesType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPurchaseType.SelectedIndexChanged
        If cmbPurchaseType.Text = "Postage(Net Banking)" Then
            lblInvoiceNo.Visible = True
            txtOrderNo.Visible = True
        End If

    End Sub

    Sub NewForm()
        ErrorProvider1.Clear()
        dgvDetails.Rows.Clear()
        txtCode.Text = db.Purchase.NewCode()
        NewItem()
        db.Purchase.NewRecord()

        txtExtras.Text = "0"
        txtAddress.Text = ""


        txtMemberName.ReadOnly = False
        txtAddress.ReadOnly = False
        cmbPurchaseType.Enabled = True
        txtICNo.ReadOnly = False
        txtPostalCode.ReadOnly = False

    End Sub
    Sub NewItem()
        ItemState = "New"
        db.PurchaseDetails.NewRecord()
        For i As Integer = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("SNo", i).Value = Nothing Then
                txtSNo.Text = i + 1
                Exit For
            End If
        Next
        If Val(txtSNo.Text) = 0 Then txtSNo.Text = 1
        txtMasterCode.Text = txtCode.Text
        txtDisPer.Text = "0"
        txtDisAmt.Text = "0"
        cmbGSTPer.Text = "0"
        txtAmount.Text = "0"
        txtGSTAmt.Text = "0"
        cmbCode.Text = ""
        cmbCode.Focus()
        ErrorProvider1.Clear()
    End Sub


    Sub ViewForm()
        If txtSearchBox.Text.Trim() = "" Then
            txtSearchBox.Focus()
        Else
            Dim str As String = ""
            str = db.Purchase.ViewRecordByCode(txtSearchBox.Text)
            If txtMemberId.Text = "0" Then
                txtMemberId.Text = ""
            End If
            If txtOrderNo.Text = "0" Then
                txtOrderNo.Text = ""
            End If
            If str <> "" Then
                MsgDialog.ShowMsgDlg(str, Me.Text, "I")
            Else
                txtSearchBox.Text = ""
                Dim dv As New DataView
                dv = db.ViewPurchaseDetails.Grid("*", "PurchaseCode='" + txtCode.Text + "'")
                dgvDetails.Rows.Clear()
                For i As Integer = 0 To dv.Count - 1
                    dgvDetails.Rows.Add()
                    dgvDetails.Item("SNo", i).Value = (i + 1).ToString()
                    dgvDetails.Item("ProductCode", i).Value = dv.Item(i)("ProductCode").ToString()
                    dgvDetails.Item("ItemName", i).Value = dv.Item(i)("ProductName").ToString()
                    dgvDetails.Item("Qty", i).Value = dv.Item(i)("Quantity").ToString()
                    dgvDetails.Item("Rate", i).Value = dv.Item(i)("Rate").ToString()
                    dgvDetails.Item("Amount", i).Value = dv.Item(i)("ItemAmount").ToString()
                    dgvDetails.Item("TaxPer", i).Value = dv.Item(i)("TaxPer").ToString()
                    dgvDetails.Item("TaxAmt", i).Value = dv.Item(i)("TaxAmt").ToString()
                    dgvDetails.Item("DisPer", i).Value = dv.Item(i)("DisPer").ToString()
                    dgvDetails.Item("DisAmt", i).Value = dv.Item(i)("DisAmt").ToString()
                    dgvDetails.Item("TotAmount", i).Value = dv.Item(i)("TotAmt").ToString()
                Next
            End If
            FindTotalAmount()
            NewItem()
            ErrorProvider1.Clear()
        End If
    End Sub
    Sub ViewItem(ByVal i As Integer)
        ItemState = "Edit"
        txtSNo.Text = dgvDetails.Item("SNo", i).Value
        cmbProductName.Text = dgvDetails.Item("ItemName", i).Value
        cmbCode.Text = dgvDetails.Item("ProductCode", i).Value
        txtQty.Text = dgvDetails.Item("qty", i).Value
        txtRate.Text = dgvDetails.Item("rate", i).Value
        txtAmount.Text = dgvDetails.Item("Amount", i).Value
        cmbGSTPer.Text = dgvDetails.Item("TaxPer", i).Value
        txtGSTAmt.Text = dgvDetails.Item("TaxAmt", i).Value
        txtDisPer.Text = dgvDetails.Item("DisPer", i).Value
        txtDisAmt.Text = dgvDetails.Item("DisAmt", i).Value
        txtTotAmount.Text = dgvDetails.Item("TotAmount", i).Value
        txtMasterCode.Text = txtCode.Text
    End Sub

    Sub FindTotalAmount()
        Dim IAmt, DAmt, TAmt As Double
        For i As Integer = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
            IAmt = IAmt + Val(dgvDetails.Item("Amount", i).Value)
            DAmt = DAmt + Val(dgvDetails.Item("DisAmt", i).Value)
            TAmt = TAmt + Val(dgvDetails.Item("TaxAmt", i).Value)
        Next
        txtItemsAmount.Text = Format(IAmt, "0.00")
        txtTotalDiscount.Text = Format(DAmt, "0.00")
        txtTotGSTAmt.Text = Format(TAmt, "0.00")

        txtTotalAmount.Text = Val(txtItemsAmount.Text) + Val(txtExtras.Text) - Val(txtTotalDiscount.Text) + Val(txtTotGSTAmt.Text)
        txtRoundOff.Text = Format(Math.Round(Val(txtTotalAmount.Text)) - txtTotalAmount.Text, "0.00")
        txtTotalAmount.Text = Math.Round(Val(txtTotalAmount.Text))
        If cmbPurchaseType.Text = "Credit Card" Then
            txtExtras.Text = Val(txtTotalAmount.Text) * 0.0212
        End If

    End Sub

    Sub SaveForm()
        If FormValidate() Then
            Dim str As String = ""
            str = db.Purchase.SaveRecord()
            If str.Trim() <> "" Then MsgDialog.ShowMsgDlg("Invoice Completed", Me.Text, "I")
            If str.ToLower.Trim() = "inserted" Or str.ToLower.Trim() = "updated" Then

                db.PurchaseDetails.DeleteRecordByUserCode(txtCode.Text)
                For i As Integer = 0 To dgvDetails.Rows.Count - 1
                    If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
                    db.PurchaseDetails.NewRecord()
                    ViewItem(i)
                    db.PurchaseDetails.SaveRecord()
                    Dim TotAmt As String
                    TotAmt = Format((Val(dgvDetails.Item("Amount", i).Value.ToString())), "0.00")
                Next
            End If

            If str.ToLower = "inserted" Then
                NewForm()
            End If

        End If
    End Sub

    Sub SaveItem()

        If Not db.Product.ExistUserCode(cmbProductName.Text) Then
            MsgDialog.ShowMsgDlg("Product Name is not Available", Me.Text, "I")
            cmbProductName.Focus()
            Exit Sub
        End If

        If txtRate.Text.Trim() = "" Then
            MsgDialog.ShowMsgDlg("Please Enter The Item Rate", Me.Text, "I")
            txtRate.Focus()
            Exit Sub
        ElseIf Val(txtRate.Text) < 0 Then
            MsgDialog.ShowMsgDlg("Please Enter The Item Rate as Positive", Me.Text, "I")
            txtRate.Focus()
            Exit Sub
        End If


        If txtQty.Text.Trim() = "" Then
            MsgDialog.ShowMsgDlg("Please Enter The Quantity", Me.Text, "I")
            txtQty.Focus()
            Exit Sub
        ElseIf Val(txtQty.Text) < 0 Then
            MsgDialog.ShowMsgDlg("Please Enter The Quantity as Positive", Me.Text, "I")
            txtQty.Focus()
            Exit Sub
        End If

        If txtTotAmount.Text.Trim() = "" Then
            MsgDialog.ShowMsgDlg("Please Enter The Amount", Me.Text, "I")
            txtTotAmount.Focus()
            Exit Sub
        ElseIf Val(txtTotAmount.Text) < 0 Then
            MsgDialog.ShowMsgDlg("Please Enter The Amount as Positive", Me.Text, "I")
            txtTotAmount.Focus()
            Exit Sub
        End If

        Dim i As Integer

        For i = 0 To dgvDetails.Rows.Count - 1
            If dgvDetails.Item("ItemName", i).Value = Nothing Then Exit For
            If cmbProductName.Text = dgvDetails.Item("ItemName", i).Value Then Exit For
        Next
        If i = dgvDetails.Rows.Count Then dgvDetails.Rows.Add()

        dgvDetails.Item("SNo", i).Value = i + 1
        dgvDetails.Item("ProductCode", i).Value = cmbCode.Text
        dgvDetails.Item("ItemName", i).Value = cmbProductName.Text
        dgvDetails.Item("Qty", i).Value = txtQty.Text
        dgvDetails.Item("Rate", i).Value = txtRate.Text
        dgvDetails.Item("Amount", i).Value = txtAmount.Text
        dgvDetails.Item("TaxPer", i).Value = cmbGSTPer.Text
        dgvDetails.Item("TaxAmt", i).Value = txtGSTAmt.Text
        dgvDetails.Item("DisPer", i).Value = txtDisPer.Text
        dgvDetails.Item("DisAmt", i).Value = txtDisAmt.Text
        dgvDetails.Item("TotAmount", i).Value = txtTotAmount.Text

        FindTotalAmount()
        NewItem()
    End Sub

    Sub DeleteForm()
        If db.Purchase.State = "New" Then Exit Sub
        If MsgDialog.ShowMsgDlg("Do you Delete this Record?", Me.Text, "Q") <> Windows.Forms.DialogResult.Yes Then Exit Sub

        Dim str As String
        db.PurchaseDetails.DeleteRecordByUserCode(txtCode.Text)
        str = db.Purchase.DeleteRecord()
        MsgDialog.ShowMsgDlg(str, "DELETE", "I")
        NewForm()
    End Sub
    Sub DeleteItem()
        dgvDetails.Rows.Remove(dgvDetails.CurrentRow)
        Try
            For i As Integer = dgvDetails.CurrentRow.Index To dgvDetails.Rows.Count - 1
                If dgvDetails.Item("SNo", i).Value = Nothing Then Exit For
                dgvDetails.Item("SNo", i).Value = i + 1
            Next
        Catch ex As Exception

        End Try

        NewItem()
        FindTotalAmount()
    End Sub

    Private Sub btnsearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch1.Click
        FormShow(frmPurchaseSearch)
    End Sub
    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtQty.Text = "1"
    End Sub

    Private Sub cmbProductName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.TextChanged
        Try
            cmbCode.Text = db.Product.Data("UserCode", String.Format("ProductName='{0}'", cmbProductName.Text))
            Dim arr As New ArrayList

            arr = db.Product.Row("MSellingRate,SellingRate", "ProductName='" + cmbProductName.Text + "'")
            If arr.Count > 0 Then
                Dim MStatus As String
                MStatus = db.ViewMemberRegistration.Data("MemberCode", String.Format("MemberStatus='Active' and MemberCode='{0}'", txtMemberId.Text))
                If MStatus <> "" Then
                    txtRate.Text = arr(0)
                Else
                    txtRate.Text = arr(1)
                End If
            End If
            txtProductCode.Text = db.Product.CodeByUserCode(cmbProductName.Text)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub FindProductName(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductCode.TextChanged
        cmbProductName.Text = db.Product.UserCodeByCode(txtProductCode.Text)
    End Sub

    Private Sub FindGSTAmt(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGSTPer.TextChanged, txtAmount.TextChanged, txtDisAmt.TextChanged
        txtGSTAmt.Text = Format((Val(txtAmount.Text) - Val(txtDisAmt.Text)) * Val(cmbGSTPer.Text) / 100, "0.00")
    End Sub

    Private Sub FindDisAmt(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisPer.TextChanged, txtAmount.TextChanged
        If txtDisAmt.Focused = False Then txtDisAmt.Text = Format(Val(txtAmount.Text) * Val(txtDisPer.Text) / 100, "0.00")
    End Sub

    Private Sub FindDisPer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisAmt.TextChanged
        If txtDisAmt.Focused = True Then txtDisPer.Text = Format(Val(txtDisAmt.Text) * 100 / Val(txtAmount.Text), "0.00")
    End Sub
    Private Sub FindItemTotalAmount(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisAmt.TextChanged, txtGSTAmt.TextChanged, txtAmount.TextChanged
        txtTotAmount.Text = Format(Val(txtAmount.Text) - Val(txtDisAmt.Text) + Val(txtGSTAmt.Text), "0.00")
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If db.Sales.State = "New" Then Exit Sub
        Dim f As New frmQuickSalesReport
        f.viewprint(txtCode.Text)
        f.Show()
    End Sub

    Private Sub cmbCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCode.SelectedIndexChanged
        Try
            cmbProductName.Text = db.Product.Data("ProductName", String.Format("UserCode='{0}'", cmbCode.Text))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtMId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberId.TextChanged
        Try
            If txtMemberId.Text <> "" Then
                If txtMemberId.Text <> "0" Then
                    txtMemberName.Enabled = True
                    txtAddress.ReadOnly = True
                    txtICNo.ReadOnly = True
                    txtPostalCode.ReadOnly = True
                    txtPhoneNo.ReadOnly = True

                    txtMemberName.Text = db.MemberRegistration.UserCodeByCode(txtMemberId.Text)

                    Dim ArrMemberList As New ArrayList
                    ArrMemberList = db.MemberRegistration.GetRecordByCode(txtMemberId.Text)

                    txtAddress.Text = ArrMemberList(3).ToString()
                    txtICNo.Text = ArrMemberList(11).ToString()
                    txtPostalCode.Text = ArrMemberList(13).ToString()
                    txtPhoneNo.Text = ArrMemberList(6).ToString()
                End If
            Else
                txtMemberName.Enabled = True
                txtAddress.ReadOnly = False
                txtPostalCode.ReadOnly = False
                txtICNo.ReadOnly = False
                txtPhoneNo.ReadOnly = False
            End If

            If dgvDetails.RowCount > 0 Then
                For i As Integer = 0 To dgvDetails.RowCount - 1
                    Dim arr As New ArrayList
                    arr = db.Product.Row("MSellingRate,SellingRate", "ProductName='" + dgvDetails.Item("ItemName", i).Value + "'")
                    If arr.Count > 0 Then
                        Dim MStatus As String
                        MStatus = db.ViewMemberRegistration.Data("MemberCode", String.Format("MemberStatus='Active' and MemberCode='{0}'", txtMemberId.Text))
                        If MStatus <> "" Then
                            dgvDetails.Item("rate", i).Value = arr(0)
                        Else
                            dgvDetails.Item("rate", i).Value = arr(1)
                        End If

                        dgvDetails.Item("Amount", i).Value = dgvDetails.Item("qty", i).Value * dgvDetails.Item("rate", i).Value
                        dgvDetails.Item("DisAmt", i).Value = dgvDetails.Item("Amount", i).Value * dgvDetails.Item("DisPer", i).Value / 100
                        dgvDetails.Item("TaxAmt", i).Value = dgvDetails.Item("DisAmt", i).Value * dgvDetails.Item("TaxPer", i).Value / 100
                        dgvDetails.Item("TotAmount", i).Value = dgvDetails.Item("Amount", i).Value - dgvDetails.Item("DisAmt", i).Value + dgvDetails.Item("TaxAmt", i).Value

                    End If
                Next
                FindTotalAmount()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class