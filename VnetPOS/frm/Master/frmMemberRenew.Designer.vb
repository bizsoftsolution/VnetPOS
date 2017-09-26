<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRenew
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
        Me.lblAmount = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.dtpRenewDate = New System.Windows.Forms.DateTimePicker
        Me.lblRenewDate = New System.Windows.Forms.Label
        Me.dtpEntryDate = New System.Windows.Forms.DateTimePicker
        Me.lblEntryDate = New System.Windows.Forms.Label
        Me.lblId = New System.Windows.Forms.Label
        Me.lblMemberId = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.ckbIsAutoGenerate = New System.Windows.Forms.CheckBox
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox
        Me.lblPaymentType = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.LinkParty = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.txtSearchBox = New System.Windows.Forms.TextBox
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(435, 108)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(57, 16)
        Me.lblAmount.TabIndex = 12
        Me.lblAmount.Text = "Amount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAmount
        '
        Me.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAmount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(546, 105)
        Me.txtAmount.MaxLength = 100
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(218, 22)
        Me.txtAmount.TabIndex = 13
        '
        'dtpRenewDate
        '
        Me.dtpRenewDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRenewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRenewDate.Location = New System.Drawing.Point(546, 74)
        Me.dtpRenewDate.Name = "dtpRenewDate"
        Me.dtpRenewDate.Size = New System.Drawing.Size(218, 20)
        Me.dtpRenewDate.TabIndex = 9
        Me.dtpRenewDate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'lblRenewDate
        '
        Me.lblRenewDate.AutoSize = True
        Me.lblRenewDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewDate.Location = New System.Drawing.Point(435, 76)
        Me.lblRenewDate.Name = "lblRenewDate"
        Me.lblRenewDate.Size = New System.Drawing.Size(85, 16)
        Me.lblRenewDate.TabIndex = 8
        Me.lblRenewDate.Text = "Renew Date"
        Me.lblRenewDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEntryDate
        '
        Me.dtpEntryDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntryDate.Location = New System.Drawing.Point(164, 74)
        Me.dtpEntryDate.Name = "dtpEntryDate"
        Me.dtpEntryDate.Size = New System.Drawing.Size(218, 20)
        Me.dtpEntryDate.TabIndex = 7
        Me.dtpEntryDate.Value = New Date(2011, 10, 10, 0, 0, 0, 0)
        '
        'lblEntryDate
        '
        Me.lblEntryDate.AutoSize = True
        Me.lblEntryDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryDate.Location = New System.Drawing.Point(53, 76)
        Me.lblEntryDate.Name = "lblEntryDate"
        Me.lblEntryDate.Size = New System.Drawing.Size(73, 16)
        Me.lblEntryDate.TabIndex = 6
        Me.lblEntryDate.Text = "Entry Date"
        Me.lblEntryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(53, 12)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(68, 16)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Renew Id"
        '
        'lblMemberId
        '
        Me.lblMemberId.AutoSize = True
        Me.lblMemberId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberId.Location = New System.Drawing.Point(53, 44)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(76, 16)
        Me.lblMemberId.TabIndex = 4
        Me.lblMemberId.Text = "Member Id"
        Me.lblMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.pnlMain.Size = New System.Drawing.Size(1184, 661)
        Me.pnlMain.TabIndex = 8
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 544)
        Me.pnlContent.TabIndex = 0
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.txtMemberId)
        Me.pnlForm.Controls.Add(Me.ckbIsAutoGenerate)
        Me.pnlForm.Controls.Add(Me.cmbPaymentType)
        Me.pnlForm.Controls.Add(Me.lblPaymentType)
        Me.pnlForm.Controls.Add(Me.lblAmount)
        Me.pnlForm.Controls.Add(Me.txtAmount)
        Me.pnlForm.Controls.Add(Me.dtpRenewDate)
        Me.pnlForm.Controls.Add(Me.lblRenewDate)
        Me.pnlForm.Controls.Add(Me.dtpEntryDate)
        Me.pnlForm.Controls.Add(Me.lblEntryDate)
        Me.pnlForm.Controls.Add(Me.lblCustomerName)
        Me.pnlForm.Controls.Add(Me.txtMemberName)
        Me.pnlForm.Controls.Add(Me.lblId)
        Me.pnlForm.Controls.Add(Me.LinkParty)
        Me.pnlForm.Controls.Add(Me.lblMemberId)
        Me.pnlForm.Controls.Add(Me.Label1)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Location = New System.Drawing.Point(66, 38)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(790, 239)
        Me.pnlForm.TabIndex = 0
        '
        'txtMemberId
        '
        Me.txtMemberId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMemberId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMemberId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberId.Location = New System.Drawing.Point(164, 41)
        Me.txtMemberId.MaxLength = 100
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(218, 22)
        Me.txtMemberId.TabIndex = 5
        '
        'ckbIsAutoGenerate
        '
        Me.ckbIsAutoGenerate.AutoSize = True
        Me.ckbIsAutoGenerate.Location = New System.Drawing.Point(438, 11)
        Me.ckbIsAutoGenerate.Name = "ckbIsAutoGenerate"
        Me.ckbIsAutoGenerate.Size = New System.Drawing.Size(95, 17)
        Me.ckbIsAutoGenerate.TabIndex = 3
        Me.ckbIsAutoGenerate.Text = "Auto Generate"
        Me.ckbIsAutoGenerate.UseVisualStyleBackColor = True
        Me.ckbIsAutoGenerate.Visible = False
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Items.AddRange(New Object() {"Cash", "Credit Card", "Net Banking"})
        Me.cmbPaymentType.Location = New System.Drawing.Point(164, 106)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(218, 21)
        Me.cmbPaymentType.TabIndex = 11
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(53, 108)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(98, 16)
        Me.lblPaymentType.TabIndex = 10
        Me.lblPaymentType.Text = "Payment Type"
        Me.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(435, 44)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(101, 16)
        Me.lblCustomerName.TabIndex = 5
        Me.lblCustomerName.Text = "Member Name"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMemberName
        '
        Me.txtMemberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMemberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMemberName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(546, 41)
        Me.txtMemberName.MaxLength = 100
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.ReadOnly = True
        Me.txtMemberName.Size = New System.Drawing.Size(218, 22)
        Me.txtMemberName.TabIndex = 0
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
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(164, 9)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(218, 22)
        Me.txtCode.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(164, 9)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(218, 22)
        Me.txtId.TabIndex = 2
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 651)
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
        Me.lblHeading.Text = "Member Renewal"
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
        'frmMemberRenew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmMemberRenew"
        Me.Text = "Member Renewal"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtpRenewDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRenewDate As System.Windows.Forms.Label
    Friend WithEvents dtpEntryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEntryDate As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblMemberId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents LinkParty As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents ckbisprint As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentType As System.Windows.Forms.Label
    Friend WithEvents ckbIsAutoGenerate As System.Windows.Forms.CheckBox
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
End Class
