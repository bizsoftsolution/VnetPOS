﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbCode = New System.Windows.Forms.ComboBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtSOCode = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAnount = New System.Windows.Forms.Label()
        Me.cmbGSTPer = New System.Windows.Forms.ComboBox()
        Me.lblGSTPer = New System.Windows.Forms.Label()
        Me.txtGSTAmt = New System.Windows.Forms.TextBox()
        Me.lblGSTAmt = New System.Windows.Forms.Label()
        Me.txtDisAmt = New System.Windows.Forms.TextBox()
        Me.lblDisAmt = New System.Windows.Forms.Label()
        Me.txtDisPer = New System.Windows.Forms.TextBox()
        Me.lblDisPer = New System.Windows.Forms.Label()
        Me.txtMasterCode = New System.Windows.Forms.TextBox()
        Me.txtDetailsId = New System.Windows.Forms.TextBox()
        Me.txtDetailsCode = New System.Windows.Forms.TextBox()
        Me.lblTotAmount = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.lblNarration = New System.Windows.Forms.Label()
        Me.txtItemsAmount = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.TotAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotAmount = New System.Windows.Forms.TextBox()
        Me.DisAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.txtMemberId = New System.Windows.Forms.TextBox()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.cmbPurchaseType = New System.Windows.Forms.ComboBox()
        Me.lblICNo = New System.Windows.Forms.Label()
        Me.txtICNo = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.lblGSTAmount = New System.Windows.Forms.Label()
        Me.txtTotGSTAmt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSNo = New System.Windows.Forms.TextBox()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblSNo = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblItemAmount = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSalesType = New System.Windows.Forms.Label()
        Me.lblwords = New System.Windows.Forms.Label()
        Me.txtExtras = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtRoundOff = New System.Windows.Forms.TextBox()
        Me.txtTotalDiscount = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblvalue = New System.Windows.Forms.Label()
        Me.lblExtras = New System.Windows.Forms.Label()
        Me.lblRoundOff = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.pnlToolBar = New System.Windows.Forms.Panel()
        Me.btnsearch1 = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCode
        '
        Me.cmbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCode.FormattingEnabled = True
        Me.cmbCode.Items.AddRange(New Object() {"2", "4", "6"})
        Me.cmbCode.Location = New System.Drawing.Point(33, 24)
        Me.cmbCode.Name = "cmbCode"
        Me.cmbCode.Size = New System.Drawing.Size(68, 22)
        Me.cmbCode.TabIndex = 3
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Maroon
        Me.lblCode.Location = New System.Drawing.Point(33, 2)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(68, 22)
        Me.lblCode.TabIndex = 2
        Me.lblCode.Tag = "Heading"
        Me.lblCode.Text = "Code"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSOCode
        '
        Me.txtSOCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOCode.Location = New System.Drawing.Point(429, 135)
        Me.txtSOCode.MaxLength = 300
        Me.txtSOCode.Name = "txtSOCode"
        Me.txtSOCode.Size = New System.Drawing.Size(76, 22)
        Me.txtSOCode.TabIndex = 26
        Me.txtSOCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSOCode.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(480, 24)
        Me.txtAmount.MaxLength = 300
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(103, 22)
        Me.txtAmount.TabIndex = 11
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAnount
        '
        Me.lblAnount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnount.ForeColor = System.Drawing.Color.Maroon
        Me.lblAnount.Location = New System.Drawing.Point(480, 2)
        Me.lblAnount.Name = "lblAnount"
        Me.lblAnount.Size = New System.Drawing.Size(103, 22)
        Me.lblAnount.TabIndex = 10
        Me.lblAnount.Tag = "Heading"
        Me.lblAnount.Text = "Amount"
        Me.lblAnount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbGSTPer
        '
        Me.cmbGSTPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbGSTPer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGSTPer.FormattingEnabled = True
        Me.cmbGSTPer.Items.AddRange(New Object() {"2", "4", "6"})
        Me.cmbGSTPer.Location = New System.Drawing.Point(772, 24)
        Me.cmbGSTPer.Name = "cmbGSTPer"
        Me.cmbGSTPer.Size = New System.Drawing.Size(68, 22)
        Me.cmbGSTPer.TabIndex = 17
        '
        'lblGSTPer
        '
        Me.lblGSTPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGSTPer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSTPer.ForeColor = System.Drawing.Color.Maroon
        Me.lblGSTPer.Location = New System.Drawing.Point(772, 2)
        Me.lblGSTPer.Name = "lblGSTPer"
        Me.lblGSTPer.Size = New System.Drawing.Size(68, 22)
        Me.lblGSTPer.TabIndex = 16
        Me.lblGSTPer.Tag = "Heading"
        Me.lblGSTPer.Text = "GST Per"
        Me.lblGSTPer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGSTAmt
        '
        Me.txtGSTAmt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSTAmt.Location = New System.Drawing.Point(840, 24)
        Me.txtGSTAmt.MaxLength = 300
        Me.txtGSTAmt.Name = "txtGSTAmt"
        Me.txtGSTAmt.ReadOnly = True
        Me.txtGSTAmt.Size = New System.Drawing.Size(103, 22)
        Me.txtGSTAmt.TabIndex = 19
        Me.txtGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGSTAmt
        '
        Me.lblGSTAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGSTAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSTAmt.ForeColor = System.Drawing.Color.Maroon
        Me.lblGSTAmt.Location = New System.Drawing.Point(840, 2)
        Me.lblGSTAmt.Name = "lblGSTAmt"
        Me.lblGSTAmt.Size = New System.Drawing.Size(103, 22)
        Me.lblGSTAmt.TabIndex = 18
        Me.lblGSTAmt.Tag = "Heading"
        Me.lblGSTAmt.Text = "GST Amt"
        Me.lblGSTAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDisAmt
        '
        Me.txtDisAmt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisAmt.Location = New System.Drawing.Point(583, 24)
        Me.txtDisAmt.MaxLength = 300
        Me.txtDisAmt.Name = "txtDisAmt"
        Me.txtDisAmt.Size = New System.Drawing.Size(193, 22)
        Me.txtDisAmt.TabIndex = 15
        Me.txtDisAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDisAmt
        '
        Me.lblDisAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDisAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisAmt.ForeColor = System.Drawing.Color.Maroon
        Me.lblDisAmt.Location = New System.Drawing.Point(583, 2)
        Me.lblDisAmt.Name = "lblDisAmt"
        Me.lblDisAmt.Size = New System.Drawing.Size(193, 22)
        Me.lblDisAmt.TabIndex = 14
        Me.lblDisAmt.Tag = "Heading"
        Me.lblDisAmt.Text = "Total Discount"
        Me.lblDisAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDisPer
        '
        Me.txtDisPer.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisPer.Location = New System.Drawing.Point(617, 113)
        Me.txtDisPer.MaxLength = 300
        Me.txtDisPer.Name = "txtDisPer"
        Me.txtDisPer.Size = New System.Drawing.Size(93, 22)
        Me.txtDisPer.TabIndex = 13
        Me.txtDisPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDisPer.Visible = False
        '
        'lblDisPer
        '
        Me.lblDisPer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDisPer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisPer.ForeColor = System.Drawing.Color.Maroon
        Me.lblDisPer.Location = New System.Drawing.Point(617, 91)
        Me.lblDisPer.Name = "lblDisPer"
        Me.lblDisPer.Size = New System.Drawing.Size(93, 22)
        Me.lblDisPer.TabIndex = 12
        Me.lblDisPer.Tag = "Heading"
        Me.lblDisPer.Text = "Dis.Per"
        Me.lblDisPer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDisPer.Visible = False
        '
        'txtMasterCode
        '
        Me.txtMasterCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMasterCode.Location = New System.Drawing.Point(429, 92)
        Me.txtMasterCode.MaxLength = 300
        Me.txtMasterCode.Name = "txtMasterCode"
        Me.txtMasterCode.Size = New System.Drawing.Size(76, 22)
        Me.txtMasterCode.TabIndex = 25
        Me.txtMasterCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMasterCode.Visible = False
        '
        'txtDetailsId
        '
        Me.txtDetailsId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailsId.Location = New System.Drawing.Point(347, 135)
        Me.txtDetailsId.MaxLength = 300
        Me.txtDetailsId.Name = "txtDetailsId"
        Me.txtDetailsId.Size = New System.Drawing.Size(76, 22)
        Me.txtDetailsId.TabIndex = 24
        Me.txtDetailsId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDetailsId.Visible = False
        '
        'txtDetailsCode
        '
        Me.txtDetailsCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailsCode.Location = New System.Drawing.Point(347, 92)
        Me.txtDetailsCode.MaxLength = 300
        Me.txtDetailsCode.Name = "txtDetailsCode"
        Me.txtDetailsCode.Size = New System.Drawing.Size(76, 22)
        Me.txtDetailsCode.TabIndex = 23
        Me.txtDetailsCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDetailsCode.Visible = False
        '
        'lblTotAmount
        '
        Me.lblTotAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotAmount.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotAmount.Location = New System.Drawing.Point(943, 2)
        Me.lblTotAmount.Name = "lblTotAmount"
        Me.lblTotAmount.Size = New System.Drawing.Size(165, 22)
        Me.lblTotAmount.TabIndex = 20
        Me.lblTotAmount.Tag = "Heading"
        Me.lblTotAmount.Text = "Total Amount"
        Me.lblTotAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(388, 24)
        Me.txtRate.MaxLength = 300
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(92, 22)
        Me.txtRate.TabIndex = 9
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(332, 24)
        Me.txtQty.MaxLength = 300
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(56, 22)
        Me.txtQty.TabIndex = 7
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbProductName
        '
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbProductName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(101, 24)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(231, 22)
        Me.cmbProductName.TabIndex = 5
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(26, 382)
        Me.txtNarration.MaxLength = 75
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(400, 22)
        Me.txtNarration.TabIndex = 29
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNarration.Location = New System.Drawing.Point(24, 363)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(57, 16)
        Me.lblNarration.TabIndex = 28
        Me.lblNarration.Text = "Remark"
        Me.lblNarration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtItemsAmount
        '
        Me.txtItemsAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemsAmount.Location = New System.Drawing.Point(924, 366)
        Me.txtItemsAmount.MaxLength = 300
        Me.txtItemsAmount.Name = "txtItemsAmount"
        Me.txtItemsAmount.ReadOnly = True
        Me.txtItemsAmount.Size = New System.Drawing.Size(188, 22)
        Me.txtItemsAmount.TabIndex = 17
        Me.txtItemsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(298, 13)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(79, 16)
        Me.lblCustomerName.TabIndex = 8
        Me.lblCustomerName.Text = "Supplier ID"
        '
        'TotAmount
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TotAmount.DefaultCellStyle = DataGridViewCellStyle23
        Me.TotAmount.HeaderText = "TotAmount"
        Me.TotAmount.Name = "TotAmount"
        Me.TotAmount.ReadOnly = True
        '
        'TaxAmt
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TaxAmt.DefaultCellStyle = DataGridViewCellStyle24
        Me.TaxAmt.HeaderText = "TaxAmt"
        Me.TaxAmt.Name = "TaxAmt"
        '
        'txtTotAmount
        '
        Me.txtTotAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotAmount.Location = New System.Drawing.Point(943, 24)
        Me.txtTotAmount.MaxLength = 300
        Me.txtTotAmount.Name = "txtTotAmount"
        Me.txtTotAmount.ReadOnly = True
        Me.txtTotAmount.Size = New System.Drawing.Size(165, 22)
        Me.txtTotAmount.TabIndex = 21
        Me.txtTotAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DisAmt
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DisAmt.DefaultCellStyle = DataGridViewCellStyle25
        Me.DisAmt.HeaderText = "Total Discount"
        Me.DisAmt.Name = "DisAmt"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(8, 78)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(92, 16)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Stock In Date"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 70)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1184, 662)
        Me.pnlMain.TabIndex = 10
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 110)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 542)
        Me.pnlContent.TabIndex = 0
        '
        'pnlForm
        '
        Me.pnlForm.AutoScroll = True
        Me.pnlForm.Controls.Add(Me.txtMemberId)
        Me.pnlForm.Controls.Add(Me.lblPhoneNo)
        Me.pnlForm.Controls.Add(Me.txtMemberName)
        Me.pnlForm.Controls.Add(Me.txtPhoneNo)
        Me.pnlForm.Controls.Add(Me.lblPostalCode)
        Me.pnlForm.Controls.Add(Me.txtPostalCode)
        Me.pnlForm.Controls.Add(Me.cmbPurchaseType)
        Me.pnlForm.Controls.Add(Me.lblICNo)
        Me.pnlForm.Controls.Add(Me.txtICNo)
        Me.pnlForm.Controls.Add(Me.txtOrderNo)
        Me.pnlForm.Controls.Add(Me.lblInvoiceNo)
        Me.pnlForm.Controls.Add(Me.lblMemberName)
        Me.pnlForm.Controls.Add(Me.lblGSTAmount)
        Me.pnlForm.Controls.Add(Me.txtTotGSTAmt)
        Me.pnlForm.Controls.Add(Me.Panel1)
        Me.pnlForm.Controls.Add(Me.lblTotalAmount)
        Me.pnlForm.Controls.Add(Me.lblDiscount)
        Me.pnlForm.Controls.Add(Me.lblItemAmount)
        Me.pnlForm.Controls.Add(Me.lblAddress)
        Me.pnlForm.Controls.Add(Me.lblSalesType)
        Me.pnlForm.Controls.Add(Me.lblwords)
        Me.pnlForm.Controls.Add(Me.txtNarration)
        Me.pnlForm.Controls.Add(Me.lblNarration)
        Me.pnlForm.Controls.Add(Me.txtExtras)
        Me.pnlForm.Controls.Add(Me.txtTotalAmount)
        Me.pnlForm.Controls.Add(Me.txtRoundOff)
        Me.pnlForm.Controls.Add(Me.txtTotalDiscount)
        Me.pnlForm.Controls.Add(Me.txtItemsAmount)
        Me.pnlForm.Controls.Add(Me.lblCustomerName)
        Me.pnlForm.Controls.Add(Me.lblDate)
        Me.pnlForm.Controls.Add(Me.lblId)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Controls.Add(Me.lblvalue)
        Me.pnlForm.Controls.Add(Me.lblExtras)
        Me.pnlForm.Controls.Add(Me.lblRoundOff)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.dtpDate)
        Me.pnlForm.Controls.Add(Me.txtAddress)
        Me.pnlForm.Location = New System.Drawing.Point(12, 3)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(1172, 530)
        Me.pnlForm.TabIndex = 0
        '
        'txtMemberId
        '
        Me.txtMemberId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMemberId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMemberId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberId.ForeColor = System.Drawing.Color.DarkGray
        Me.txtMemberId.Location = New System.Drawing.Point(388, 10)
        Me.txtMemberId.MaxLength = 500
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(67, 22)
        Me.txtMemberId.TabIndex = 6
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNo.Location = New System.Drawing.Point(765, 41)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(70, 16)
        Me.lblPhoneNo.TabIndex = 42
        Me.lblPhoneNo.Text = "Phone No"
        '
        'txtMemberName
        '
        Me.txtMemberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMemberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMemberName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtMemberName.Location = New System.Drawing.Point(463, 10)
        Me.txtMemberName.MaxLength = 500
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(286, 22)
        Me.txtMemberName.TabIndex = 32
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPhoneNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPhoneNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPhoneNo.Location = New System.Drawing.Point(857, 41)
        Me.txtPhoneNo.MaxLength = 500
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(168, 22)
        Me.txtPhoneNo.TabIndex = 41
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(765, 13)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(84, 16)
        Me.lblPostalCode.TabIndex = 15
        Me.lblPostalCode.Text = "Postal Code"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPostalCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPostalCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.ForeColor = System.Drawing.Color.DarkGray
        Me.txtPostalCode.Location = New System.Drawing.Point(857, 10)
        Me.txtPostalCode.MaxLength = 500
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(168, 22)
        Me.txtPostalCode.TabIndex = 16
        '
        'cmbPurchaseType
        '
        Me.cmbPurchaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPurchaseType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurchaseType.FormattingEnabled = True
        Me.cmbPurchaseType.IntegralHeight = False
        Me.cmbPurchaseType.ItemHeight = 16
        Me.cmbPurchaseType.Items.AddRange(New Object() {"Cash", "Credit Card"})
        Me.cmbPurchaseType.Location = New System.Drawing.Point(118, 43)
        Me.cmbPurchaseType.Name = "cmbPurchaseType"
        Me.cmbPurchaseType.Size = New System.Drawing.Size(167, 22)
        Me.cmbPurchaseType.TabIndex = 3
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(298, 110)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 13
        Me.lblICNo.Text = "IC No"
        '
        'txtICNo
        '
        Me.txtICNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtICNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtICNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICNo.ForeColor = System.Drawing.Color.DarkGray
        Me.txtICNo.Location = New System.Drawing.Point(388, 107)
        Me.txtICNo.MaxLength = 500
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(359, 22)
        Me.txtICNo.TabIndex = 14
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(118, 108)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(167, 20)
        Me.txtOrderNo.TabIndex = 7
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceNo.Location = New System.Drawing.Point(8, 110)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(75, 16)
        Me.lblInvoiceNo.TabIndex = 6
        Me.lblInvoiceNo.Text = "Invoice No"
        '
        'lblMemberName
        '
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.Location = New System.Drawing.Point(967, 20)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(0, 16)
        Me.lblMemberName.TabIndex = 29
        Me.lblMemberName.Visible = False
        '
        'lblGSTAmount
        '
        Me.lblGSTAmount.AutoSize = True
        Me.lblGSTAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSTAmount.Location = New System.Drawing.Point(819, 424)
        Me.lblGSTAmount.Name = "lblGSTAmount"
        Me.lblGSTAmount.Size = New System.Drawing.Size(88, 16)
        Me.lblGSTAmount.TabIndex = 20
        Me.lblGSTAmount.Text = "GST Amount"
        Me.lblGSTAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotGSTAmt
        '
        Me.txtTotGSTAmt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGSTAmt.Location = New System.Drawing.Point(924, 421)
        Me.txtTotGSTAmt.MaxLength = 300
        Me.txtTotGSTAmt.Name = "txtTotGSTAmt"
        Me.txtTotGSTAmt.ReadOnly = True
        Me.txtTotGSTAmt.Size = New System.Drawing.Size(188, 22)
        Me.txtTotGSTAmt.TabIndex = 21
        Me.txtTotGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cmbCode)
        Me.Panel1.Controls.Add(Me.lblCode)
        Me.Panel1.Controls.Add(Me.txtSOCode)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.lblAnount)
        Me.Panel1.Controls.Add(Me.cmbGSTPer)
        Me.Panel1.Controls.Add(Me.lblGSTPer)
        Me.Panel1.Controls.Add(Me.txtGSTAmt)
        Me.Panel1.Controls.Add(Me.lblGSTAmt)
        Me.Panel1.Controls.Add(Me.txtDisAmt)
        Me.Panel1.Controls.Add(Me.lblDisAmt)
        Me.Panel1.Controls.Add(Me.txtDisPer)
        Me.Panel1.Controls.Add(Me.lblDisPer)
        Me.Panel1.Controls.Add(Me.txtMasterCode)
        Me.Panel1.Controls.Add(Me.txtDetailsId)
        Me.Panel1.Controls.Add(Me.txtTotAmount)
        Me.Panel1.Controls.Add(Me.txtDetailsCode)
        Me.Panel1.Controls.Add(Me.lblTotAmount)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.txtQty)
        Me.Panel1.Controls.Add(Me.cmbProductName)
        Me.Panel1.Controls.Add(Me.txtSNo)
        Me.Panel1.Controls.Add(Me.dgvDetails)
        Me.Panel1.Controls.Add(Me.lblQty)
        Me.Panel1.Controls.Add(Me.lblProductName)
        Me.Panel1.Controls.Add(Me.lblSNo)
        Me.Panel1.Controls.Add(Me.lblRate)
        Me.Panel1.Location = New System.Drawing.Point(5, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1119, 209)
        Me.Panel1.TabIndex = 17
        '
        'txtSNo
        '
        Me.txtSNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNo.Location = New System.Drawing.Point(2, 24)
        Me.txtSNo.MaxLength = 300
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.ReadOnly = True
        Me.txtSNo.Size = New System.Drawing.Size(31, 22)
        Me.txtSNo.TabIndex = 1
        '
        'dgvDetails
        '
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.ColumnHeadersVisible = False
        Me.dgvDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.ProductCode, Me.ItemName, Me.Qty, Me.Rate, Me.Amount, Me.DisPer, Me.DisAmt, Me.TaxPer, Me.TaxAmt, Me.TotAmount})
        Me.dgvDetails.Location = New System.Drawing.Point(1, 46)
        Me.dgvDetails.Name = "dgvDetails"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle33.Format = "N2"
        DataGridViewCellStyle33.NullValue = Nothing
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle33
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDetails.Size = New System.Drawing.Size(1107, 159)
        Me.dgvDetails.TabIndex = 2
        '
        'SNo
        '
        Me.SNo.HeaderText = "SNo"
        Me.SNo.Name = "SNo"
        '
        'ProductCode
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ProductCode.DefaultCellStyle = DataGridViewCellStyle26
        Me.ProductCode.HeaderText = "Code"
        Me.ProductCode.Name = "ProductCode"
        '
        'ItemName
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ItemName.DefaultCellStyle = DataGridViewCellStyle27
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 50
        '
        'Qty
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle28
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'Rate
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle29
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'Amount
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle30
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'DisPer
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DisPer.DefaultCellStyle = DataGridViewCellStyle31
        Me.DisPer.HeaderText = "DisPer"
        Me.DisPer.Name = "DisPer"
        Me.DisPer.Visible = False
        '
        'TaxPer
        '
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TaxPer.DefaultCellStyle = DataGridViewCellStyle32
        Me.TaxPer.HeaderText = "TaxPer"
        Me.TaxPer.Name = "TaxPer"
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Maroon
        Me.lblQty.Location = New System.Drawing.Point(332, 2)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(56, 22)
        Me.lblQty.TabIndex = 6
        Me.lblQty.Tag = "Heading"
        Me.lblQty.Text = "Qty"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductName
        '
        Me.lblProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.Maroon
        Me.lblProductName.Location = New System.Drawing.Point(101, 2)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(231, 22)
        Me.lblProductName.TabIndex = 4
        Me.lblProductName.Tag = "Heading"
        Me.lblProductName.Text = "Item Name"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSNo
        '
        Me.lblSNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblSNo.Location = New System.Drawing.Point(2, 2)
        Me.lblSNo.Name = "lblSNo"
        Me.lblSNo.Size = New System.Drawing.Size(31, 22)
        Me.lblSNo.TabIndex = 0
        Me.lblSNo.Tag = "Heading"
        Me.lblSNo.Text = "No"
        Me.lblSNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRate
        '
        Me.lblRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Maroon
        Me.lblRate.Location = New System.Drawing.Point(388, 2)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(92, 22)
        Me.lblRate.TabIndex = 8
        Me.lblRate.Tag = "Heading"
        Me.lblRate.Text = "Rate"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(819, 508)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(92, 16)
        Me.lblTotalAmount.TabIndex = 26
        Me.lblTotalAmount.Text = "Total Amount"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(819, 397)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(62, 16)
        Me.lblDiscount.TabIndex = 18
        Me.lblDiscount.Text = "Discount"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblItemAmount
        '
        Me.lblItemAmount.AutoSize = True
        Me.lblItemAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemAmount.Location = New System.Drawing.Point(819, 369)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Size = New System.Drawing.Size(91, 16)
        Me.lblItemAmount.TabIndex = 16
        Me.lblItemAmount.Text = "ItemsAmount"
        Me.lblItemAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(298, 44)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Address"
        '
        'lblSalesType
        '
        Me.lblSalesType.AutoSize = True
        Me.lblSalesType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesType.Location = New System.Drawing.Point(8, 46)
        Me.lblSalesType.Name = "lblSalesType"
        Me.lblSalesType.Size = New System.Drawing.Size(93, 16)
        Me.lblSalesType.TabIndex = 2
        Me.lblSalesType.Text = "Stock In Type"
        '
        'lblwords
        '
        Me.lblwords.AutoSize = True
        Me.lblwords.BackColor = System.Drawing.Color.Transparent
        Me.lblwords.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwords.Location = New System.Drawing.Point(26, 426)
        Me.lblwords.Name = "lblwords"
        Me.lblwords.Size = New System.Drawing.Size(0, 16)
        Me.lblwords.TabIndex = 30
        '
        'txtExtras
        '
        Me.txtExtras.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtras.Location = New System.Drawing.Point(924, 448)
        Me.txtExtras.MaxLength = 300
        Me.txtExtras.Name = "txtExtras"
        Me.txtExtras.Size = New System.Drawing.Size(188, 22)
        Me.txtExtras.TabIndex = 23
        Me.txtExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(924, 505)
        Me.txtTotalAmount.MaxLength = 300
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(188, 22)
        Me.txtTotalAmount.TabIndex = 27
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRoundOff
        '
        Me.txtRoundOff.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundOff.Location = New System.Drawing.Point(924, 475)
        Me.txtRoundOff.MaxLength = 300
        Me.txtRoundOff.Name = "txtRoundOff"
        Me.txtRoundOff.ReadOnly = True
        Me.txtRoundOff.Size = New System.Drawing.Size(188, 22)
        Me.txtRoundOff.TabIndex = 25
        Me.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDiscount
        '
        Me.txtTotalDiscount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscount.Location = New System.Drawing.Point(924, 394)
        Me.txtTotalDiscount.MaxLength = 300
        Me.txtTotalDiscount.Name = "txtTotalDiscount"
        Me.txtTotalDiscount.ReadOnly = True
        Me.txtTotalDiscount.Size = New System.Drawing.Size(188, 22)
        Me.txtTotalDiscount.TabIndex = 19
        Me.txtTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(8, 14)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(75, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Stock In Id"
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(118, 11)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(167, 22)
        Me.txtId.TabIndex = 1
        Me.txtId.Visible = False
        '
        'lblvalue
        '
        Me.lblvalue.BackColor = System.Drawing.Color.Transparent
        Me.lblvalue.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalue.ForeColor = System.Drawing.Color.Red
        Me.lblvalue.Location = New System.Drawing.Point(23, 451)
        Me.lblvalue.Name = "lblvalue"
        Me.lblvalue.Size = New System.Drawing.Size(307, 53)
        Me.lblvalue.TabIndex = 31
        '
        'lblExtras
        '
        Me.lblExtras.AutoSize = True
        Me.lblExtras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtras.Location = New System.Drawing.Point(819, 451)
        Me.lblExtras.Name = "lblExtras"
        Me.lblExtras.Size = New System.Drawing.Size(47, 16)
        Me.lblExtras.TabIndex = 22
        Me.lblExtras.Text = "Extras"
        Me.lblExtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRoundOff
        '
        Me.lblRoundOff.AutoSize = True
        Me.lblRoundOff.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundOff.Location = New System.Drawing.Point(819, 478)
        Me.lblRoundOff.Name = "lblRoundOff"
        Me.lblRoundOff.Size = New System.Drawing.Size(71, 16)
        Me.lblRoundOff.TabIndex = 24
        Me.lblRoundOff.Text = "Round Off"
        Me.lblRoundOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(118, 11)
        Me.txtCode.MaxLength = 150
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(167, 22)
        Me.txtCode.TabIndex = 1
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(118, 76)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(167, 20)
        Me.dtpDate.TabIndex = 5
        Me.dtpDate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'txtAddress
        '
        Me.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.DarkGray
        Me.txtAddress.Location = New System.Drawing.Point(390, 41)
        Me.txtAddress.MaxLength = 500
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(359, 49)
        Me.txtAddress.TabIndex = 12
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 2
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.txtProductCode)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 110)
        Me.pnlHeader.TabIndex = 1
        '
        'txtProductCode
        '
        Me.txtProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProductCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.ForeColor = System.Drawing.Color.DarkGray
        Me.txtProductCode.Location = New System.Drawing.Point(232, 33)
        Me.txtProductCode.MaxLength = 500
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(117, 22)
        Me.txtProductCode.TabIndex = 5
        Me.txtProductCode.Visible = False
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnsearch1)
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Controls.Add(Me.txtSearchBox)
        Me.pnlToolBar.Location = New System.Drawing.Point(355, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(404, 65)
        Me.pnlToolBar.TabIndex = 0
        '
        'btnsearch1
        '
        Me.btnsearch1.BackColor = System.Drawing.Color.White
        Me.btnsearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch1.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnsearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsearch1.Location = New System.Drawing.Point(306, 7)
        Me.btnsearch1.Name = "btnsearch1"
        Me.btnsearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnsearch1.TabIndex = 5
        Me.btnsearch1.Text = "SEARC&H"
        Me.btnsearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnsearch1.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.VnetPOS.My.Resources.Resources.adds35
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNew.Location = New System.Drawing.Point(12, 7)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 49)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "&New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.VnetPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(84, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 49)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(232, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(753, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.VnetPOS.My.Resources.Resources.delete35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(158, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtSearchBox
        '
        Me.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchBox.Location = New System.Drawing.Point(825, 20)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(184, 22)
        Me.txtSearchBox.TabIndex = 7
        Me.txtSearchBox.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 30)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Tag = "Heading"
        Me.lblHeading.Text = "Stock In"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmPurchase"
        Me.Text = "Stock In"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbCode As ComboBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtSOCode As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAnount As Label
    Friend WithEvents cmbGSTPer As ComboBox
    Friend WithEvents lblGSTPer As Label
    Friend WithEvents txtGSTAmt As TextBox
    Friend WithEvents lblGSTAmt As Label
    Friend WithEvents txtDisAmt As TextBox
    Friend WithEvents lblDisAmt As Label
    Friend WithEvents txtDisPer As TextBox
    Friend WithEvents lblDisPer As Label
    Friend WithEvents txtMasterCode As TextBox
    Friend WithEvents txtDetailsId As TextBox
    Friend WithEvents txtDetailsCode As TextBox
    Friend WithEvents lblTotAmount As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents txtNarration As TextBox
    Friend WithEvents lblNarration As Label
    Friend WithEvents txtItemsAmount As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents TotAmount As DataGridViewTextBoxColumn
    Friend WithEvents TaxAmt As DataGridViewTextBoxColumn
    Friend WithEvents txtTotAmount As TextBox
    Friend WithEvents DisAmt As DataGridViewTextBoxColumn
    Friend WithEvents lblDate As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlForm As Panel
    Friend WithEvents txtMemberId As TextBox
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents cmbPurchaseType As ComboBox
    Friend WithEvents lblICNo As Label
    Friend WithEvents txtICNo As TextBox
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents lblMemberName As Label
    Friend WithEvents lblGSTAmount As Label
    Friend WithEvents txtTotGSTAmt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSNo As TextBox
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents ProductCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents DisPer As DataGridViewTextBoxColumn
    Friend WithEvents TaxPer As DataGridViewTextBoxColumn
    Friend WithEvents lblQty As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblSNo As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblItemAmount As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSalesType As Label
    Friend WithEvents lblwords As Label
    Friend WithEvents txtExtras As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtRoundOff As TextBox
    Friend WithEvents txtTotalDiscount As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblvalue As Label
    Friend WithEvents lblExtras As Label
    Friend WithEvents lblRoundOff As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents pnlToolBar As Panel
    Friend WithEvents btnsearch1 As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
