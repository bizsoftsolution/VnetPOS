<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRegistrationSearch
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
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.lblWords = New System.Windows.Forms.Label
        Me.lblValue = New System.Windows.Forms.Label
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.txtICNo = New System.Windows.Forms.TextBox
        Me.lblICNo = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.lblMailID = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.lblMobile = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.pnlTwo = New System.Windows.Forms.Panel
        Me.rbnInfixMobile = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMobile = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMobile = New System.Windows.Forms.RadioButton
        Me.pnlOne = New System.Windows.Forms.Panel
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.rbnInfixAddress = New System.Windows.Forms.RadioButton
        Me.rbnSuffixAddress = New System.Windows.Forms.RadioButton
        Me.rbnPrefixAddress = New System.Windows.Forms.RadioButton
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpBillDateTo = New System.Windows.Forms.DateTimePicker
        Me.lblBillDateTo = New System.Windows.Forms.Label
        Me.dtpBillDateFrom = New System.Windows.Forms.DateTimePicker
        Me.lblRenewDateFrom = New System.Windows.Forms.Label
        Me.txtBillAmountTo = New System.Windows.Forms.TextBox
        Me.txtBillAmountFrom = New System.Windows.Forms.TextBox
        Me.lblBillAmount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlTwo.SuspendLayout()
        Me.pnlOne.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlMain.TabIndex = 14
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.lblWords)
        Me.pnlContent.Controls.Add(Me.lblValue)
        Me.pnlContent.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 231)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 420)
        Me.pnlContent.TabIndex = 0
        '
        'lblWords
        '
        Me.lblWords.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWords.Location = New System.Drawing.Point(12, 351)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(802, 56)
        Me.lblWords.TabIndex = 63
        '
        'lblValue
        '
        Me.lblValue.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(882, 351)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(290, 56)
        Me.lblValue.TabIndex = 64
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(12, 17)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(1160, 305)
        Me.dgvCustomerSearch.TabIndex = 0
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
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 231)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.Label1)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountTo)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountFrom)
        Me.pnlToolBar.Controls.Add(Me.lblBillAmount)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.lblBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateFrom)
        Me.pnlToolBar.Controls.Add(Me.lblRenewDateFrom)
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.txtCustomerName)
        Me.pnlToolBar.Controls.Add(Me.lblMailID)
        Me.pnlToolBar.Controls.Add(Me.txtMemberId)
        Me.pnlToolBar.Controls.Add(Me.lblMobile)
        Me.pnlToolBar.Controls.Add(Me.txtMobile)
        Me.pnlToolBar.Controls.Add(Me.pnlTwo)
        Me.pnlToolBar.Controls.Add(Me.pnlOne)
        Me.pnlToolBar.Controls.Add(Me.lblCustomerName)
        Me.pnlToolBar.Controls.Add(Me.rbnInfixAddress)
        Me.pnlToolBar.Controls.Add(Me.rbnSuffixAddress)
        Me.pnlToolBar.Controls.Add(Me.rbnPrefixAddress)
        Me.pnlToolBar.Controls.Add(Me.txtAddress)
        Me.pnlToolBar.Controls.Add(Me.lblAddress)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Location = New System.Drawing.Point(12, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(952, 165)
        Me.pnlToolBar.TabIndex = 0
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(321, 124)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(272, 20)
        Me.txtICNo.TabIndex = 34
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(321, 108)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 33
        Me.lblICNo.Text = "IC No"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(7, 28)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(310, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'lblMailID
        '
        Me.lblMailID.AutoSize = True
        Me.lblMailID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailID.Location = New System.Drawing.Point(7, 108)
        Me.lblMailID.Name = "lblMailID"
        Me.lblMailID.Size = New System.Drawing.Size(76, 16)
        Me.lblMailID.TabIndex = 25
        Me.lblMailID.Text = "Member Id"
        '
        'txtMemberId
        '
        Me.txtMemberId.Location = New System.Drawing.Point(7, 124)
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(310, 20)
        Me.txtMemberId.TabIndex = 0
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(7, 55)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(51, 16)
        Me.lblMobile.TabIndex = 20
        Me.lblMobile.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(7, 71)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(310, 20)
        Me.txtMobile.TabIndex = 0
        '
        'pnlTwo
        '
        Me.pnlTwo.Controls.Add(Me.rbnInfixMobile)
        Me.pnlTwo.Controls.Add(Me.rbnSuffixMobile)
        Me.pnlTwo.Controls.Add(Me.rbnPrefixMobile)
        Me.pnlTwo.Location = New System.Drawing.Point(135, 53)
        Me.pnlTwo.Name = "pnlTwo"
        Me.pnlTwo.Size = New System.Drawing.Size(182, 20)
        Me.pnlTwo.TabIndex = 1
        '
        'rbnInfixMobile
        '
        Me.rbnInfixMobile.AutoSize = True
        Me.rbnInfixMobile.Checked = True
        Me.rbnInfixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixMobile.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixMobile.Name = "rbnInfixMobile"
        Me.rbnInfixMobile.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixMobile.TabIndex = 23
        Me.rbnInfixMobile.TabStop = True
        Me.rbnInfixMobile.Text = "Infix"
        Me.rbnInfixMobile.UseVisualStyleBackColor = True
        '
        'rbnSuffixMobile
        '
        Me.rbnSuffixMobile.AutoSize = True
        Me.rbnSuffixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixMobile.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixMobile.Name = "rbnSuffixMobile"
        Me.rbnSuffixMobile.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixMobile.TabIndex = 24
        Me.rbnSuffixMobile.Text = "Suffix"
        Me.rbnSuffixMobile.UseVisualStyleBackColor = True
        '
        'rbnPrefixMobile
        '
        Me.rbnPrefixMobile.AutoSize = True
        Me.rbnPrefixMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixMobile.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixMobile.Name = "rbnPrefixMobile"
        Me.rbnPrefixMobile.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixMobile.TabIndex = 22
        Me.rbnPrefixMobile.Text = "Prefix"
        Me.rbnPrefixMobile.UseVisualStyleBackColor = True
        '
        'pnlOne
        '
        Me.pnlOne.Controls.Add(Me.rbnInfixCustomer)
        Me.pnlOne.Controls.Add(Me.rbnSuffixCustomer)
        Me.pnlOne.Controls.Add(Me.rbnPrefixCustomer)
        Me.pnlOne.Location = New System.Drawing.Point(135, 10)
        Me.pnlOne.Name = "pnlOne"
        Me.pnlOne.Size = New System.Drawing.Size(182, 20)
        Me.pnlOne.TabIndex = 0
        '
        'rbnInfixCustomer
        '
        Me.rbnInfixCustomer.AutoSize = True
        Me.rbnInfixCustomer.Checked = True
        Me.rbnInfixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixCustomer.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixCustomer.Name = "rbnInfixCustomer"
        Me.rbnInfixCustomer.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixCustomer.TabIndex = 13
        Me.rbnInfixCustomer.TabStop = True
        Me.rbnInfixCustomer.Text = "Infix"
        Me.rbnInfixCustomer.UseVisualStyleBackColor = True
        '
        'rbnSuffixCustomer
        '
        Me.rbnSuffixCustomer.AutoSize = True
        Me.rbnSuffixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixCustomer.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixCustomer.Name = "rbnSuffixCustomer"
        Me.rbnSuffixCustomer.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixCustomer.TabIndex = 14
        Me.rbnSuffixCustomer.Text = "Suffix"
        Me.rbnSuffixCustomer.UseVisualStyleBackColor = True
        '
        'rbnPrefixCustomer
        '
        Me.rbnPrefixCustomer.AutoSize = True
        Me.rbnPrefixCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixCustomer.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixCustomer.Name = "rbnPrefixCustomer"
        Me.rbnPrefixCustomer.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixCustomer.TabIndex = 12
        Me.rbnPrefixCustomer.Text = "Prefix"
        Me.rbnPrefixCustomer.UseVisualStyleBackColor = True
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(7, 12)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(101, 16)
        Me.lblCustomerName.TabIndex = 10
        Me.lblCustomerName.Text = "Member Name"
        '
        'rbnInfixAddress
        '
        Me.rbnInfixAddress.AutoSize = True
        Me.rbnInfixAddress.Checked = True
        Me.rbnInfixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixAddress.Location = New System.Drawing.Point(462, 12)
        Me.rbnInfixAddress.Name = "rbnInfixAddress"
        Me.rbnInfixAddress.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixAddress.TabIndex = 8
        Me.rbnInfixAddress.TabStop = True
        Me.rbnInfixAddress.Text = "Infix"
        Me.rbnInfixAddress.UseVisualStyleBackColor = True
        '
        'rbnSuffixAddress
        '
        Me.rbnSuffixAddress.AutoSize = True
        Me.rbnSuffixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixAddress.Location = New System.Drawing.Point(530, 12)
        Me.rbnSuffixAddress.Name = "rbnSuffixAddress"
        Me.rbnSuffixAddress.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixAddress.TabIndex = 9
        Me.rbnSuffixAddress.Text = "Suffix"
        Me.rbnSuffixAddress.UseVisualStyleBackColor = True
        '
        'rbnPrefixAddress
        '
        Me.rbnPrefixAddress.AutoSize = True
        Me.rbnPrefixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixAddress.Location = New System.Drawing.Point(387, 12)
        Me.rbnPrefixAddress.Name = "rbnPrefixAddress"
        Me.rbnPrefixAddress.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixAddress.TabIndex = 7
        Me.rbnPrefixAddress.Text = "Prefix"
        Me.rbnPrefixAddress.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(321, 32)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(272, 59)
        Me.txtAddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(323, 12)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Address"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(780, 95)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 6
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
        Me.btnSearch.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(708, 95)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Member Registration Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dtpBillDateTo
        '
        Me.dtpBillDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateTo.Location = New System.Drawing.Point(740, 33)
        Me.dtpBillDateTo.Name = "dtpBillDateTo"
        Me.dtpBillDateTo.ShowUpDown = True
        Me.dtpBillDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpBillDateTo.TabIndex = 44
        '
        'lblBillDateTo
        '
        Me.lblBillDateTo.AutoSize = True
        Me.lblBillDateTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateTo.Location = New System.Drawing.Point(728, 35)
        Me.lblBillDateTo.Name = "lblBillDateTo"
        Me.lblBillDateTo.Size = New System.Drawing.Size(12, 16)
        Me.lblBillDateTo.TabIndex = 43
        Me.lblBillDateTo.Text = "-"
        '
        'dtpBillDateFrom
        '
        Me.dtpBillDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateFrom.Location = New System.Drawing.Point(605, 33)
        Me.dtpBillDateFrom.Name = "dtpBillDateFrom"
        Me.dtpBillDateFrom.ShowUpDown = True
        Me.dtpBillDateFrom.Size = New System.Drawing.Size(123, 20)
        Me.dtpBillDateFrom.TabIndex = 42
        '
        'lblRenewDateFrom
        '
        Me.lblRenewDateFrom.AutoSize = True
        Me.lblRenewDateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewDateFrom.Location = New System.Drawing.Point(602, 14)
        Me.lblRenewDateFrom.Name = "lblRenewDateFrom"
        Me.lblRenewDateFrom.Size = New System.Drawing.Size(117, 16)
        Me.lblRenewDateFrom.TabIndex = 41
        Me.lblRenewDateFrom.Text = "Registration Date"
        '
        'txtBillAmountTo
        '
        Me.txtBillAmountTo.Location = New System.Drawing.Point(740, 59)
        Me.txtBillAmountTo.Name = "txtBillAmountTo"
        Me.txtBillAmountTo.Size = New System.Drawing.Size(106, 20)
        Me.txtBillAmountTo.TabIndex = 61
        '
        'txtBillAmountFrom
        '
        Me.txtBillAmountFrom.Location = New System.Drawing.Point(668, 59)
        Me.txtBillAmountFrom.Name = "txtBillAmountFrom"
        Me.txtBillAmountFrom.Size = New System.Drawing.Size(60, 20)
        Me.txtBillAmountFrom.TabIndex = 60
        '
        'lblBillAmount
        '
        Me.lblBillAmount.AutoSize = True
        Me.lblBillAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmount.Location = New System.Drawing.Point(603, 61)
        Me.lblBillAmount.Name = "lblBillAmount"
        Me.lblBillAmount.Size = New System.Drawing.Size(57, 16)
        Me.lblBillAmount.TabIndex = 59
        Me.lblBillAmount.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(728, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "-"
        '
        'frmMemberRegistrationSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmMemberRegistrationSearch"
        Me.Text = "Member Registration Search"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.pnlTwo.ResumeLayout(False)
        Me.pnlTwo.PerformLayout()
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents dgvCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblMailID As System.Windows.Forms.Label
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents pnlTwo As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents pnlOne As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents rbnInfixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtICNo As System.Windows.Forms.TextBox
    Friend WithEvents lblICNo As System.Windows.Forms.Label
    Friend WithEvents lblWords As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBillDateTo As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRenewDateFrom As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBillAmountTo As System.Windows.Forms.TextBox
    Friend WithEvents txtBillAmountFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblBillAmount As System.Windows.Forms.Label
End Class
