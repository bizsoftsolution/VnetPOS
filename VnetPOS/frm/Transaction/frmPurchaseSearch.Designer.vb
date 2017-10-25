<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseSearch
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dtpBillDateTo = New System.Windows.Forms.DateTimePicker()
        Me.lblBillDateTo = New System.Windows.Forms.Label()
        Me.dtpBillDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblBillDateFrom = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.rbnCusPrefix = New System.Windows.Forms.RadioButton()
        Me.rbnCusInfix = New System.Windows.Forms.RadioButton()
        Me.rbnCusSuffix = New System.Windows.Forms.RadioButton()
        Me.GBCustomerName = New System.Windows.Forms.GroupBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblWords = New System.Windows.Forms.Label()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlToolBar = New System.Windows.Forms.Panel()
        Me.txtMemberId = New System.Windows.Forms.TextBox()
        Me.lblMemberId = New System.Windows.Forms.Label()
        Me.txtICNo = New System.Windows.Forms.TextBox()
        Me.lblICNo = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.GBAddress = New System.Windows.Forms.GroupBox()
        Me.rbnAdrsPrefix = New System.Windows.Forms.RadioButton()
        Me.rbnAdrsInfix = New System.Windows.Forms.RadioButton()
        Me.rbnAdrsSufix = New System.Windows.Forms.RadioButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCustomerName.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.GBAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(830, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(902, 33)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'dtpBillDateTo
        '
        Me.dtpBillDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateTo.Location = New System.Drawing.Point(326, 33)
        Me.dtpBillDateTo.Name = "dtpBillDateTo"
        Me.dtpBillDateTo.ShowUpDown = True
        Me.dtpBillDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpBillDateTo.TabIndex = 40
        '
        'lblBillDateTo
        '
        Me.lblBillDateTo.AutoSize = True
        Me.lblBillDateTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateTo.Location = New System.Drawing.Point(314, 33)
        Me.lblBillDateTo.Name = "lblBillDateTo"
        Me.lblBillDateTo.Size = New System.Drawing.Size(12, 16)
        Me.lblBillDateTo.TabIndex = 39
        Me.lblBillDateTo.Text = "-"
        '
        'dtpBillDateFrom
        '
        Me.dtpBillDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateFrom.Location = New System.Drawing.Point(191, 33)
        Me.dtpBillDateFrom.Name = "dtpBillDateFrom"
        Me.dtpBillDateFrom.ShowUpDown = True
        Me.dtpBillDateFrom.Size = New System.Drawing.Size(123, 20)
        Me.dtpBillDateFrom.TabIndex = 38
        '
        'lblBillDateFrom
        '
        Me.lblBillDateFrom.AutoSize = True
        Me.lblBillDateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateFrom.Location = New System.Drawing.Point(86, 35)
        Me.lblBillDateFrom.Name = "lblBillDateFrom"
        Me.lblBillDateFrom.Size = New System.Drawing.Size(62, 16)
        Me.lblBillDateFrom.TabIndex = 37
        Me.lblBillDateFrom.Text = "Bill Date"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(6, 14)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(103, 16)
        Me.lblCustomerName.TabIndex = 41
        Me.lblCustomerName.Text = "Supplier Name"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(6, 33)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(330, 20)
        Me.txtCustomerName.TabIndex = 42
        '
        'rbnCusPrefix
        '
        Me.rbnCusPrefix.AutoSize = True
        Me.rbnCusPrefix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnCusPrefix.Location = New System.Drawing.Point(121, 14)
        Me.rbnCusPrefix.Name = "rbnCusPrefix"
        Me.rbnCusPrefix.Size = New System.Drawing.Size(59, 19)
        Me.rbnCusPrefix.TabIndex = 43
        Me.rbnCusPrefix.Text = "Prefix"
        Me.rbnCusPrefix.UseVisualStyleBackColor = True
        '
        'rbnCusInfix
        '
        Me.rbnCusInfix.AutoSize = True
        Me.rbnCusInfix.Checked = True
        Me.rbnCusInfix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnCusInfix.Location = New System.Drawing.Point(189, 14)
        Me.rbnCusInfix.Name = "rbnCusInfix"
        Me.rbnCusInfix.Size = New System.Drawing.Size(50, 19)
        Me.rbnCusInfix.TabIndex = 44
        Me.rbnCusInfix.TabStop = True
        Me.rbnCusInfix.Text = "Infix"
        Me.rbnCusInfix.UseVisualStyleBackColor = True
        '
        'rbnCusSuffix
        '
        Me.rbnCusSuffix.AutoSize = True
        Me.rbnCusSuffix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnCusSuffix.Location = New System.Drawing.Point(264, 14)
        Me.rbnCusSuffix.Name = "rbnCusSuffix"
        Me.rbnCusSuffix.Size = New System.Drawing.Size(58, 19)
        Me.rbnCusSuffix.TabIndex = 45
        Me.rbnCusSuffix.Text = "Suffix"
        Me.rbnCusSuffix.UseVisualStyleBackColor = True
        '
        'GBCustomerName
        '
        Me.GBCustomerName.Controls.Add(Me.lblCustomerName)
        Me.GBCustomerName.Controls.Add(Me.txtCustomerName)
        Me.GBCustomerName.Controls.Add(Me.rbnCusPrefix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusInfix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusSuffix)
        Me.GBCustomerName.Location = New System.Drawing.Point(86, 65)
        Me.GBCustomerName.Name = "GBCustomerName"
        Me.GBCustomerName.Size = New System.Drawing.Size(346, 64)
        Me.GBCustomerName.TabIndex = 59
        Me.GBCustomerName.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Stock In Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(8, 12)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 51
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(8, 31)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(330, 66)
        Me.txtAddress.TabIndex = 52
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.lblValue)
        Me.pnlContent.Controls.Add(Me.lblWords)
        Me.pnlContent.Controls.Add(Me.dgvSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 240)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 412)
        Me.pnlContent.TabIndex = 0
        '
        'lblValue
        '
        Me.lblValue.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(676, 287)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(290, 56)
        Me.lblValue.TabIndex = 62
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWords
        '
        Me.lblWords.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWords.Location = New System.Drawing.Point(90, 287)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(463, 56)
        Me.lblWords.TabIndex = 61
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(86, 22)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(882, 248)
        Me.dgvSearch.TabIndex = 0
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
        Me.pnlMain.TabIndex = 14
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
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 240)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.txtMemberId)
        Me.pnlToolBar.Controls.Add(Me.lblMemberId)
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.lblCode)
        Me.pnlToolBar.Controls.Add(Me.txtCode)
        Me.pnlToolBar.Controls.Add(Me.GBAddress)
        Me.pnlToolBar.Controls.Add(Me.GBCustomerName)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.lblBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateFrom)
        Me.pnlToolBar.Controls.Add(Me.lblBillDateFrom)
        Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1184, 198)
        Me.pnlToolBar.TabIndex = 21
        '
        'txtMemberId
        '
        Me.txtMemberId.Location = New System.Drawing.Point(560, 144)
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(273, 20)
        Me.txtMemberId.TabIndex = 65
        '
        'lblMemberId
        '
        Me.lblMemberId.AutoSize = True
        Me.lblMemberId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberId.Location = New System.Drawing.Point(468, 146)
        Me.lblMemberId.Name = "lblMemberId"
        Me.lblMemberId.Size = New System.Drawing.Size(78, 16)
        Me.lblMemberId.TabIndex = 64
        Me.lblMemberId.Text = "Supplier Id"
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(149, 144)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(273, 20)
        Me.txtICNo.TabIndex = 63
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(97, 146)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 62
        Me.lblICNo.Text = "IC No"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(888, 113)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(80, 16)
        Me.lblCode.TabIndex = 36
        Me.lblCode.Text = "Sales Code"
        Me.lblCode.Visible = False
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(891, 132)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(127, 22)
        Me.txtCode.TabIndex = 35
        Me.txtCode.Visible = False
        '
        'GBAddress
        '
        Me.GBAddress.Controls.Add(Me.lblAddress)
        Me.GBAddress.Controls.Add(Me.txtAddress)
        Me.GBAddress.Controls.Add(Me.rbnAdrsPrefix)
        Me.GBAddress.Controls.Add(Me.rbnAdrsInfix)
        Me.GBAddress.Controls.Add(Me.rbnAdrsSufix)
        Me.GBAddress.Location = New System.Drawing.Point(455, 25)
        Me.GBAddress.Name = "GBAddress"
        Me.GBAddress.Size = New System.Drawing.Size(347, 104)
        Me.GBAddress.TabIndex = 46
        Me.GBAddress.TabStop = False
        '
        'rbnAdrsPrefix
        '
        Me.rbnAdrsPrefix.AutoSize = True
        Me.rbnAdrsPrefix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnAdrsPrefix.Location = New System.Drawing.Point(123, 12)
        Me.rbnAdrsPrefix.Name = "rbnAdrsPrefix"
        Me.rbnAdrsPrefix.Size = New System.Drawing.Size(59, 19)
        Me.rbnAdrsPrefix.TabIndex = 53
        Me.rbnAdrsPrefix.Text = "Prefix"
        Me.rbnAdrsPrefix.UseVisualStyleBackColor = True
        '
        'rbnAdrsInfix
        '
        Me.rbnAdrsInfix.AutoSize = True
        Me.rbnAdrsInfix.Checked = True
        Me.rbnAdrsInfix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnAdrsInfix.Location = New System.Drawing.Point(191, 12)
        Me.rbnAdrsInfix.Name = "rbnAdrsInfix"
        Me.rbnAdrsInfix.Size = New System.Drawing.Size(50, 19)
        Me.rbnAdrsInfix.TabIndex = 54
        Me.rbnAdrsInfix.TabStop = True
        Me.rbnAdrsInfix.Text = "Infix"
        Me.rbnAdrsInfix.UseVisualStyleBackColor = True
        '
        'rbnAdrsSufix
        '
        Me.rbnAdrsSufix.AutoSize = True
        Me.rbnAdrsSufix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnAdrsSufix.Location = New System.Drawing.Point(266, 12)
        Me.rbnAdrsSufix.Name = "rbnAdrsSufix"
        Me.rbnAdrsSufix.Size = New System.Drawing.Size(58, 19)
        Me.rbnAdrsSufix.TabIndex = 55
        Me.rbnAdrsSufix.Text = "Suffix"
        Me.rbnAdrsSufix.UseVisualStyleBackColor = True
        '
        'frmPurchaseSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmPurchaseSearch"
        Me.Text = "Stock In Search"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCustomerName.ResumeLayout(False)
        Me.GBCustomerName.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.GBAddress.ResumeLayout(False)
        Me.GBAddress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblValue As Label
    Friend WithEvents lblWords As Label
    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlToolBar As Panel
    Friend WithEvents txtMemberId As TextBox
    Friend WithEvents lblMemberId As Label
    Friend WithEvents txtICNo As TextBox
    Friend WithEvents lblICNo As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents GBAddress As GroupBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents rbnAdrsPrefix As RadioButton
    Friend WithEvents rbnAdrsInfix As RadioButton
    Friend WithEvents rbnAdrsSufix As RadioButton
    Friend WithEvents GBCustomerName As GroupBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents rbnCusPrefix As RadioButton
    Friend WithEvents rbnCusInfix As RadioButton
    Friend WithEvents rbnCusSuffix As RadioButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dtpBillDateTo As DateTimePicker
    Friend WithEvents lblBillDateTo As Label
    Friend WithEvents dtpBillDateFrom As DateTimePicker
    Friend WithEvents lblBillDateFrom As Label
    Friend WithEvents lblHeading As Label
End Class
