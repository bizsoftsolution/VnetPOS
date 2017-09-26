<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRenewSearch
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
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.lblWords = New System.Windows.Forms.Label
        Me.lblValue = New System.Windows.Forms.Label
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        Me.txtBillAmountTo = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblBillDateTo = New System.Windows.Forms.Label
        Me.dtpBillDateFrom = New System.Windows.Forms.DateTimePicker
        Me.lblRenewDateFrom = New System.Windows.Forms.Label
        Me.lblBillAmount = New System.Windows.Forms.Label
        Me.lblHeading = New System.Windows.Forms.Label
        Me.txtBillAmountFrom = New System.Windows.Forms.TextBox
        Me.dtpBillDateTo = New System.Windows.Forms.DateTimePicker
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.txtICNo = New System.Windows.Forms.TextBox
        Me.lblICNo = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GBCustomerName.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(6, 33)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(330, 20)
        Me.txtCustomerName.TabIndex = 42
        '
        'GBCustomerName
        '
        Me.GBCustomerName.Controls.Add(Me.lblCustomerName)
        Me.GBCustomerName.Controls.Add(Me.txtCustomerName)
        Me.GBCustomerName.Controls.Add(Me.rbnCusPrefix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusInfix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusSuffix)
        Me.GBCustomerName.Location = New System.Drawing.Point(619, 7)
        Me.GBCustomerName.Name = "GBCustomerName"
        Me.GBCustomerName.Size = New System.Drawing.Size(346, 64)
        Me.GBCustomerName.TabIndex = 59
        Me.GBCustomerName.TabStop = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(6, 14)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(101, 16)
        Me.lblCustomerName.TabIndex = 41
        Me.lblCustomerName.Text = "Member Name"
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
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.lblWords)
        Me.pnlContent.Controls.Add(Me.lblValue)
        Me.pnlContent.Controls.Add(Me.dgvSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 169)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 482)
        Me.pnlContent.TabIndex = 0
        '
        'lblWords
        '
        Me.lblWords.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWords.Location = New System.Drawing.Point(12, 407)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(802, 56)
        Me.lblWords.TabIndex = 61
        '
        'lblValue
        '
        Me.lblValue.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(882, 407)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(290, 56)
        Me.lblValue.TabIndex = 62
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(12, 22)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(1160, 368)
        Me.dgvSearch.TabIndex = 0
        '
        'txtBillAmountTo
        '
        Me.txtBillAmountTo.Location = New System.Drawing.Point(512, 31)
        Me.txtBillAmountTo.Name = "txtBillAmountTo"
        Me.txtBillAmountTo.Size = New System.Drawing.Size(85, 20)
        Me.txtBillAmountTo.TabIndex = 58
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(982, 21)
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
        Me.btnExit.Location = New System.Drawing.Point(1054, 21)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblBillDateTo
        '
        Me.lblBillDateTo.AutoSize = True
        Me.lblBillDateTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateTo.Location = New System.Drawing.Point(222, 33)
        Me.lblBillDateTo.Name = "lblBillDateTo"
        Me.lblBillDateTo.Size = New System.Drawing.Size(12, 16)
        Me.lblBillDateTo.TabIndex = 39
        Me.lblBillDateTo.Text = "-"
        '
        'dtpBillDateFrom
        '
        Me.dtpBillDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateFrom.Location = New System.Drawing.Point(99, 31)
        Me.dtpBillDateFrom.Name = "dtpBillDateFrom"
        Me.dtpBillDateFrom.ShowUpDown = True
        Me.dtpBillDateFrom.Size = New System.Drawing.Size(123, 20)
        Me.dtpBillDateFrom.TabIndex = 38
        '
        'lblRenewDateFrom
        '
        Me.lblRenewDateFrom.AutoSize = True
        Me.lblRenewDateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewDateFrom.Location = New System.Drawing.Point(9, 33)
        Me.lblRenewDateFrom.Name = "lblRenewDateFrom"
        Me.lblRenewDateFrom.Size = New System.Drawing.Size(85, 16)
        Me.lblRenewDateFrom.TabIndex = 37
        Me.lblRenewDateFrom.Text = "Renew Date"
        '
        'lblBillAmount
        '
        Me.lblBillAmount.AutoSize = True
        Me.lblBillAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmount.Location = New System.Drawing.Point(354, 33)
        Me.lblBillAmount.Name = "lblBillAmount"
        Me.lblBillAmount.Size = New System.Drawing.Size(57, 16)
        Me.lblBillAmount.TabIndex = 56
        Me.lblBillAmount.Text = "Amount"
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Member Renew Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBillAmountFrom
        '
        Me.txtBillAmountFrom.Location = New System.Drawing.Point(419, 31)
        Me.txtBillAmountFrom.Name = "txtBillAmountFrom"
        Me.txtBillAmountFrom.Size = New System.Drawing.Size(85, 20)
        Me.txtBillAmountFrom.TabIndex = 57
        '
        'dtpBillDateTo
        '
        Me.dtpBillDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateTo.Location = New System.Drawing.Point(234, 31)
        Me.dtpBillDateTo.Name = "dtpBillDateTo"
        Me.dtpBillDateTo.ShowUpDown = True
        Me.dtpBillDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpBillDateTo.TabIndex = 40
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 169)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.lblCode)
        Me.pnlToolBar.Controls.Add(Me.txtCode)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountTo)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountFrom)
        Me.pnlToolBar.Controls.Add(Me.lblBillAmount)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.lblBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateFrom)
        Me.pnlToolBar.Controls.Add(Me.lblRenewDateFrom)
        Me.pnlToolBar.Controls.Add(Me.GBCustomerName)
        Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1184, 127)
        Me.pnlToolBar.TabIndex = 21
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(67, 71)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(271, 20)
        Me.txtICNo.TabIndex = 38
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(9, 73)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 37
        Me.lblICNo.Text = "IC No"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(927, 92)
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
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 651)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 1
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMemberRenewSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmMemberRenewSearch"
        Me.Text = "Member Renew Search"
        Me.GBCustomerName.ResumeLayout(False)
        Me.GBCustomerName.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
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
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents lblWords As System.Windows.Forms.Label
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents txtBillAmountTo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblBillDateTo As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRenewDateFrom As System.Windows.Forms.Label
    Friend WithEvents lblBillAmount As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents txtBillAmountFrom As System.Windows.Forms.TextBox
    Friend WithEvents dtpBillDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtICNo As System.Windows.Forms.TextBox
    Friend WithEvents lblICNo As System.Windows.Forms.Label
End Class
