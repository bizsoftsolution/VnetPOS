﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRegistration
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
        Me.components = New System.ComponentModel.Container
        Me.lblState = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.txtSearchBox = New System.Windows.Forms.TextBox
        Me.lblEmailId = New System.Windows.Forms.Label
        Me.txtEmailId = New System.Windows.Forms.TextBox
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.ckbisprint = New System.Windows.Forms.CheckBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.btnSearch1 = New System.Windows.Forms.Button
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.lblPostalCode = New System.Windows.Forms.Label
        Me.txtPostalCode = New System.Windows.Forms.TextBox
        Me.ckbIsAutoGenerate = New System.Windows.Forms.CheckBox
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox
        Me.lblPaymentType = New System.Windows.Forms.Label
        Me.lblICNo = New System.Windows.Forms.Label
        Me.txtICNo = New System.Windows.Forms.TextBox
        Me.lblRegAmount = New System.Windows.Forms.Label
        Me.txtRegAmount = New System.Windows.Forms.TextBox
        Me.dtpRenewDate = New System.Windows.Forms.DateTimePicker
        Me.lblRenewDate = New System.Windows.Forms.Label
        Me.dtpRegDate = New System.Windows.Forms.DateTimePicker
        Me.lblRegDate = New System.Windows.Forms.Label
        Me.lblCId = New System.Windows.Forms.Label
        Me.LinkParty = New System.Windows.Forms.Button
        Me.lblCity = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblCPNo1 = New System.Windows.Forms.Label
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.txtAddressLine = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(437, 76)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 16)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtState
        '
        Me.txtState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtState.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(552, 73)
        Me.txtState.MaxLength = 100
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(218, 22)
        Me.txtState.TabIndex = 11
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(53, 45)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(101, 16)
        Me.lblCustomerName.TabIndex = 4
        Me.lblCustomerName.Text = "Member Name"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCustomerName
        '
        Me.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCustomerName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(164, 42)
        Me.txtCustomerName.MaxLength = 100
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(218, 22)
        Me.txtCustomerName.TabIndex = 5
        '
        'txtSearchBox
        '
        Me.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchBox.Location = New System.Drawing.Point(761, 58)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(184, 22)
        Me.txtSearchBox.TabIndex = 5
        Me.txtSearchBox.Visible = False
        '
        'lblEmailId
        '
        Me.lblEmailId.AutoSize = True
        Me.lblEmailId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailId.Location = New System.Drawing.Point(437, 177)
        Me.lblEmailId.Name = "lblEmailId"
        Me.lblEmailId.Size = New System.Drawing.Size(60, 16)
        Me.lblEmailId.TabIndex = 20
        Me.lblEmailId.Text = "Email Id"
        Me.lblEmailId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmailId
        '
        Me.txtEmailId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailId.Location = New System.Drawing.Point(552, 174)
        Me.txtEmailId.MaxLength = 0
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(218, 22)
        Me.txtEmailId.TabIndex = 21
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.txtSearchBox)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.btnSearch1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 107)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.ckbisprint)
        Me.pnlToolBar.Controls.Add(Me.btnPrint)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Location = New System.Drawing.Point(23, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(635, 56)
        Me.pnlToolBar.TabIndex = 0
        '
        'ckbisprint
        '
        Me.ckbisprint.AutoSize = True
        Me.ckbisprint.Checked = True
        Me.ckbisprint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbisprint.Location = New System.Drawing.Point(530, 19)
        Me.ckbisprint.Name = "ckbisprint"
        Me.ckbisprint.Size = New System.Drawing.Size(72, 17)
        Me.ckbisprint.TabIndex = 7
        Me.ckbisprint.Text = "Auto Print"
        Me.ckbisprint.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Image = Global.VnetPOS.My.Resources.Resources.Printer
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(456, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(66, 49)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(382, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.VnetPOS.My.Resources.Resources.adds35
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNew.Location = New System.Drawing.Point(12, 3)
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
        Me.btnSave.Location = New System.Drawing.Point(86, 3)
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
        Me.btnExit.Location = New System.Drawing.Point(308, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.VnetPOS.My.Resources.Resources.delete35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(160, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.VnetPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(234, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = " &VIEW"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Member Registration"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.White
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch1.Location = New System.Drawing.Point(689, 45)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch1.TabIndex = 6
        Me.btnSearch1.Text = "SEARC&H"
        Me.btnSearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch1.UseVisualStyleBackColor = False
        Me.btnSearch1.Visible = False
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.lblPostalCode)
        Me.pnlForm.Controls.Add(Me.txtPostalCode)
        Me.pnlForm.Controls.Add(Me.ckbIsAutoGenerate)
        Me.pnlForm.Controls.Add(Me.cmbPaymentType)
        Me.pnlForm.Controls.Add(Me.lblPaymentType)
        Me.pnlForm.Controls.Add(Me.lblICNo)
        Me.pnlForm.Controls.Add(Me.txtICNo)
        Me.pnlForm.Controls.Add(Me.lblRegAmount)
        Me.pnlForm.Controls.Add(Me.txtRegAmount)
        Me.pnlForm.Controls.Add(Me.dtpRenewDate)
        Me.pnlForm.Controls.Add(Me.lblRenewDate)
        Me.pnlForm.Controls.Add(Me.dtpRegDate)
        Me.pnlForm.Controls.Add(Me.lblRegDate)
        Me.pnlForm.Controls.Add(Me.lblState)
        Me.pnlForm.Controls.Add(Me.txtState)
        Me.pnlForm.Controls.Add(Me.lblCustomerName)
        Me.pnlForm.Controls.Add(Me.txtCustomerName)
        Me.pnlForm.Controls.Add(Me.lblEmailId)
        Me.pnlForm.Controls.Add(Me.txtEmailId)
        Me.pnlForm.Controls.Add(Me.lblCId)
        Me.pnlForm.Controls.Add(Me.LinkParty)
        Me.pnlForm.Controls.Add(Me.lblCity)
        Me.pnlForm.Controls.Add(Me.Label1)
        Me.pnlForm.Controls.Add(Me.lblAddress)
        Me.pnlForm.Controls.Add(Me.lblCPNo1)
        Me.pnlForm.Controls.Add(Me.txtMobileNo)
        Me.pnlForm.Controls.Add(Me.txtAddressLine)
        Me.pnlForm.Controls.Add(Me.txtCity)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Location = New System.Drawing.Point(66, 38)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(833, 336)
        Me.pnlForm.TabIndex = 0
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(437, 109)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(84, 16)
        Me.lblPostalCode.TabIndex = 12
        Me.lblPostalCode.Text = "Postal Code"
        Me.lblPostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPostalCode
        '
        Me.txtPostalCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPostalCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPostalCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(552, 106)
        Me.txtPostalCode.MaxLength = 100
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(218, 22)
        Me.txtPostalCode.TabIndex = 13
        '
        'ckbIsAutoGenerate
        '
        Me.ckbIsAutoGenerate.AutoSize = True
        Me.ckbIsAutoGenerate.Location = New System.Drawing.Point(497, 243)
        Me.ckbIsAutoGenerate.Name = "ckbIsAutoGenerate"
        Me.ckbIsAutoGenerate.Size = New System.Drawing.Size(95, 17)
        Me.ckbIsAutoGenerate.TabIndex = 2
        Me.ckbIsAutoGenerate.Text = "Auto Generate"
        Me.ckbIsAutoGenerate.UseVisualStyleBackColor = True
        Me.ckbIsAutoGenerate.Visible = False
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Items.AddRange(New Object() {"Cash", "Credit Card", "Online Banking"})
        Me.cmbPaymentType.Location = New System.Drawing.Point(164, 175)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(218, 21)
        Me.cmbPaymentType.TabIndex = 19
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(53, 177)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(98, 16)
        Me.lblPaymentType.TabIndex = 18
        Me.lblPaymentType.Text = "Payment Type"
        Me.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(437, 12)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 2
        Me.lblICNo.Text = "IC No"
        Me.lblICNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtICNo
        '
        Me.txtICNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICNo.Location = New System.Drawing.Point(552, 9)
        Me.txtICNo.MaxLength = 100
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(218, 22)
        Me.txtICNo.TabIndex = 3
        '
        'lblRegAmount
        '
        Me.lblRegAmount.AutoSize = True
        Me.lblRegAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegAmount.Location = New System.Drawing.Point(53, 209)
        Me.lblRegAmount.Name = "lblRegAmount"
        Me.lblRegAmount.Size = New System.Drawing.Size(86, 16)
        Me.lblRegAmount.TabIndex = 22
        Me.lblRegAmount.Text = "Reg Amount"
        Me.lblRegAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRegAmount
        '
        Me.txtRegAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRegAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRegAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegAmount.Location = New System.Drawing.Point(164, 206)
        Me.txtRegAmount.MaxLength = 100
        Me.txtRegAmount.Name = "txtRegAmount"
        Me.txtRegAmount.Size = New System.Drawing.Size(218, 22)
        Me.txtRegAmount.TabIndex = 23
        '
        'dtpRenewDate
        '
        Me.dtpRenewDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRenewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRenewDate.Location = New System.Drawing.Point(552, 207)
        Me.dtpRenewDate.Name = "dtpRenewDate"
        Me.dtpRenewDate.Size = New System.Drawing.Size(218, 20)
        Me.dtpRenewDate.TabIndex = 25
        Me.dtpRenewDate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'lblRenewDate
        '
        Me.lblRenewDate.AutoSize = True
        Me.lblRenewDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewDate.Location = New System.Drawing.Point(437, 209)
        Me.lblRenewDate.Name = "lblRenewDate"
        Me.lblRenewDate.Size = New System.Drawing.Size(85, 16)
        Me.lblRenewDate.TabIndex = 24
        Me.lblRenewDate.Text = "Renew Date"
        Me.lblRenewDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpRegDate
        '
        Me.dtpRegDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegDate.Location = New System.Drawing.Point(164, 143)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.Size = New System.Drawing.Size(218, 20)
        Me.dtpRegDate.TabIndex = 15
        Me.dtpRegDate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'lblRegDate
        '
        Me.lblRegDate.AutoSize = True
        Me.lblRegDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegDate.Location = New System.Drawing.Point(53, 145)
        Me.lblRegDate.Name = "lblRegDate"
        Me.lblRegDate.Size = New System.Drawing.Size(66, 16)
        Me.lblRegDate.TabIndex = 14
        Me.lblRegDate.Text = "Reg Date"
        Me.lblRegDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCId
        '
        Me.lblCId.AutoSize = True
        Me.lblCId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCId.Location = New System.Drawing.Point(53, 12)
        Me.lblCId.Name = "lblCId"
        Me.lblCId.Size = New System.Drawing.Size(76, 16)
        Me.lblCId.TabIndex = 0
        Me.lblCId.Text = "Member Id"
        '
        'LinkParty
        '
        Me.LinkParty.BackColor = System.Drawing.Color.White
        Me.LinkParty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LinkParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LinkParty.Location = New System.Drawing.Point(708, -20)
        Me.LinkParty.Name = "LinkParty"
        Me.LinkParty.Size = New System.Drawing.Size(20, 20)
        Me.LinkParty.TabIndex = 24
        Me.LinkParty.TabStop = False
        Me.LinkParty.Text = "..."
        Me.LinkParty.UseVisualStyleBackColor = False
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(437, 44)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(32, 16)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "City"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, -18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = " C&ustomer Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(53, 74)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(90, 16)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address Line"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPNo1
        '
        Me.lblCPNo1.AutoSize = True
        Me.lblCPNo1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPNo1.Location = New System.Drawing.Point(437, 145)
        Me.lblCPNo1.Name = "lblCPNo1"
        Me.lblCPNo1.Size = New System.Drawing.Size(105, 16)
        Me.lblCPNo1.TabIndex = 16
        Me.lblCPNo1.Text = "Mobile Number"
        Me.lblCPNo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(552, 142)
        Me.txtMobileNo.MaxLength = 30
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(218, 22)
        Me.txtMobileNo.TabIndex = 17
        '
        'txtAddressLine
        '
        Me.txtAddressLine.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine.Location = New System.Drawing.Point(164, 74)
        Me.txtAddressLine.MaxLength = 300
        Me.txtAddressLine.Multiline = True
        Me.txtAddressLine.Name = "txtAddressLine"
        Me.txtAddressLine.Size = New System.Drawing.Size(218, 59)
        Me.txtAddressLine.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(552, 41)
        Me.txtCity.MaxLength = 100
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(218, 22)
        Me.txtCity.TabIndex = 7
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(164, 13)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(218, 22)
        Me.txtCode.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(164, 13)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(218, 22)
        Me.txtId.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.pnlMain.TabIndex = 7
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 545)
        Me.pnlContent.TabIndex = 0
        '
        'frmMemberRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmMemberRegistration"
        Me.Text = "Member Registration"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailId As System.Windows.Forms.Label
    Friend WithEvents txtEmailId As System.Windows.Forms.TextBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblCId As System.Windows.Forms.Label
    Friend WithEvents LinkParty As System.Windows.Forms.Button
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCPNo1 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblRegDate As System.Windows.Forms.Label
    Friend WithEvents dtpRenewDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRenewDate As System.Windows.Forms.Label
    Friend WithEvents dtpRegDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRegAmount As System.Windows.Forms.Label
    Friend WithEvents txtRegAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents ckbisprint As System.Windows.Forms.CheckBox
    Friend WithEvents lblICNo As System.Windows.Forms.Label
    Friend WithEvents txtICNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentType As System.Windows.Forms.Label
    Friend WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents ckbIsAutoGenerate As System.Windows.Forms.CheckBox
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
End Class