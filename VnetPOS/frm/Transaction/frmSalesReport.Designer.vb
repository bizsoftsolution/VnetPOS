<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.GBCustomerName = New System.Windows.Forms.GroupBox
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.rbnCusPrefix = New System.Windows.Forms.RadioButton
        Me.rbnCusInfix = New System.Windows.Forms.RadioButton
        Me.rbnCusSuffix = New System.Windows.Forms.RadioButton
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblHeading = New System.Windows.Forms.Label
        Me.rbnAdrsPrefix = New System.Windows.Forms.RadioButton
        Me.txtBillAmountTo = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtBillAmountFrom = New System.Windows.Forms.TextBox
        Me.lblBillAmount = New System.Windows.Forms.Label
        Me.dtpBillDateTo = New System.Windows.Forms.DateTimePicker
        Me.lblBillDateTo = New System.Windows.Forms.Label
        Me.dtpBillDateFrom = New System.Windows.Forms.DateTimePicker
        Me.lblBillDateFrom = New System.Windows.Forms.Label
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.cmbOrderNo = New System.Windows.Forms.ComboBox
        Me.lblICNo = New System.Windows.Forms.Label
        Me.lblOrderNo = New System.Windows.Forms.Label
        Me.txtICNo = New System.Windows.Forms.TextBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.GBAddress = New System.Windows.Forms.GroupBox
        Me.rbnAdrsInfix = New System.Windows.Forms.RadioButton
        Me.rbnAdrsSufix = New System.Windows.Forms.RadioButton
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GBCustomerName.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.GBAddress.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(6, 33)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(298, 20)
        Me.txtCustomerName.TabIndex = 42
        '
        'GBCustomerName
        '
        Me.GBCustomerName.Controls.Add(Me.lblCustomerName)
        Me.GBCustomerName.Controls.Add(Me.txtCustomerName)
        Me.GBCustomerName.Controls.Add(Me.rbnCusPrefix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusInfix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusSuffix)
        Me.GBCustomerName.Location = New System.Drawing.Point(26, 65)
        Me.GBCustomerName.Name = "GBCustomerName"
        Me.GBCustomerName.Size = New System.Drawing.Size(312, 64)
        Me.GBCustomerName.TabIndex = 59
        Me.GBCustomerName.TabStop = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(6, 14)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(109, 16)
        Me.lblCustomerName.TabIndex = 41
        Me.lblCustomerName.Text = "Customer Name"
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
        Me.rbnCusInfix.Location = New System.Drawing.Point(188, 14)
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
        Me.rbnCusSuffix.Location = New System.Drawing.Point(246, 14)
        Me.rbnCusSuffix.Name = "rbnCusSuffix"
        Me.rbnCusSuffix.Size = New System.Drawing.Size(58, 19)
        Me.rbnCusSuffix.TabIndex = 45
        Me.rbnCusSuffix.Text = "Suffix"
        Me.rbnCusSuffix.UseVisualStyleBackColor = True
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
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Invoice Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'txtBillAmountTo
        '
        Me.txtBillAmountTo.Location = New System.Drawing.Point(417, 31)
        Me.txtBillAmountTo.Name = "txtBillAmountTo"
        Me.txtBillAmountTo.Size = New System.Drawing.Size(119, 20)
        Me.txtBillAmountTo.TabIndex = 58
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(719, 79)
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
        Me.btnExit.Location = New System.Drawing.Point(791, 79)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtBillAmountFrom
        '
        Me.txtBillAmountFrom.Location = New System.Drawing.Point(290, 31)
        Me.txtBillAmountFrom.Name = "txtBillAmountFrom"
        Me.txtBillAmountFrom.Size = New System.Drawing.Size(119, 20)
        Me.txtBillAmountFrom.TabIndex = 57
        '
        'lblBillAmount
        '
        Me.lblBillAmount.AutoSize = True
        Me.lblBillAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmount.Location = New System.Drawing.Point(290, 15)
        Me.lblBillAmount.Name = "lblBillAmount"
        Me.lblBillAmount.Size = New System.Drawing.Size(82, 16)
        Me.lblBillAmount.TabIndex = 56
        Me.lblBillAmount.Text = "Bill Amount"
        '
        'dtpBillDateTo
        '
        Me.dtpBillDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateTo.Location = New System.Drawing.Point(159, 31)
        Me.dtpBillDateTo.Name = "dtpBillDateTo"
        Me.dtpBillDateTo.ShowUpDown = True
        Me.dtpBillDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpBillDateTo.TabIndex = 40
        '
        'lblBillDateTo
        '
        Me.lblBillDateTo.AutoSize = True
        Me.lblBillDateTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateTo.Location = New System.Drawing.Point(147, 33)
        Me.lblBillDateTo.Name = "lblBillDateTo"
        Me.lblBillDateTo.Size = New System.Drawing.Size(12, 16)
        Me.lblBillDateTo.TabIndex = 39
        Me.lblBillDateTo.Text = "-"
        '
        'dtpBillDateFrom
        '
        Me.dtpBillDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateFrom.Location = New System.Drawing.Point(24, 31)
        Me.dtpBillDateFrom.Name = "dtpBillDateFrom"
        Me.dtpBillDateFrom.ShowUpDown = True
        Me.dtpBillDateFrom.Size = New System.Drawing.Size(123, 20)
        Me.dtpBillDateFrom.TabIndex = 38
        '
        'lblBillDateFrom
        '
        Me.lblBillDateFrom.AutoSize = True
        Me.lblBillDateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateFrom.Location = New System.Drawing.Point(24, 15)
        Me.lblBillDateFrom.Name = "lblBillDateFrom"
        Me.lblBillDateFrom.Size = New System.Drawing.Size(62, 16)
        Me.lblBillDateFrom.TabIndex = 37
        Me.lblBillDateFrom.Text = "Bill Date"
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
        Me.pnlToolBar.Controls.Add(Me.cmbOrderNo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.lblOrderNo)
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.lblCode)
        Me.pnlToolBar.Controls.Add(Me.txtCode)
        Me.pnlToolBar.Controls.Add(Me.GBAddress)
        Me.pnlToolBar.Controls.Add(Me.GBCustomerName)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountTo)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountFrom)
        Me.pnlToolBar.Controls.Add(Me.lblBillAmount)
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
        'cmbOrderNo
        '
        Me.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbOrderNo.FormattingEnabled = True
        Me.cmbOrderNo.Location = New System.Drawing.Point(547, 31)
        Me.cmbOrderNo.Name = "cmbOrderNo"
        Me.cmbOrderNo.Size = New System.Drawing.Size(152, 21)
        Me.cmbOrderNo.TabIndex = 67
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(719, 15)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 46
        Me.lblICNo.Text = "IC No"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.Location = New System.Drawing.Point(547, 15)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(65, 16)
        Me.lblOrderNo.TabIndex = 66
        Me.lblOrderNo.Text = "Order No"
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(719, 31)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(199, 20)
        Me.txtICNo.TabIndex = 47
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
        Me.GBAddress.Location = New System.Drawing.Point(352, 65)
        Me.GBAddress.Name = "GBAddress"
        Me.GBAddress.Size = New System.Drawing.Size(347, 104)
        Me.GBAddress.TabIndex = 46
        Me.GBAddress.TabStop = False
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
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.CrystalReportViewer1)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 240)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 412)
        Me.pnlContent.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1184, 412)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmSalesReport"
        Me.Text = "Sales Report"
        Me.GBCustomerName.ResumeLayout(False)
        Me.GBCustomerName.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.GBAddress.ResumeLayout(False)
        Me.GBAddress.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents GBCustomerName As System.Windows.Forms.GroupBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents rbnCusPrefix As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCusInfix As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCusSuffix As System.Windows.Forms.RadioButton
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents rbnAdrsPrefix As System.Windows.Forms.RadioButton
    Friend WithEvents txtBillAmountTo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtBillAmountFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblBillAmount As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBillDateTo As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBillDateFrom As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents GBAddress As System.Windows.Forms.GroupBox
    Friend WithEvents rbnAdrsInfix As System.Windows.Forms.RadioButton
    Friend WithEvents rbnAdrsSufix As System.Windows.Forms.RadioButton
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblICNo As System.Windows.Forms.Label
    Friend WithEvents txtICNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbOrderNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
End Class
