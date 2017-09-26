<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostageSearch
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
        Me.lblValue = New System.Windows.Forms.Label
        Me.lblWords = New System.Windows.Forms.Label
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblBillDateTo = New System.Windows.Forms.Label
        Me.dtpBillDateFrom = New System.Windows.Forms.DateTimePicker
        Me.lblBillDateFrom = New System.Windows.Forms.Label
        Me.lblHeading = New System.Windows.Forms.Label
        Me.dtpBillDateTo = New System.Windows.Forms.DateTimePicker
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.txtPostalCode = New System.Windows.Forms.TextBox
        Me.lblPostalCode = New System.Windows.Forms.Label
        Me.cmbOrderNo = New System.Windows.Forms.ComboBox
        Me.lblOrderNo = New System.Windows.Forms.Label
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
        Me.txtCustomerName.Size = New System.Drawing.Size(298, 20)
        Me.txtCustomerName.TabIndex = 1
        '
        'GBCustomerName
        '
        Me.GBCustomerName.Controls.Add(Me.lblCustomerName)
        Me.GBCustomerName.Controls.Add(Me.txtCustomerName)
        Me.GBCustomerName.Controls.Add(Me.rbnCusPrefix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusInfix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusSuffix)
        Me.GBCustomerName.Location = New System.Drawing.Point(15, 66)
        Me.GBCustomerName.Name = "GBCustomerName"
        Me.GBCustomerName.Size = New System.Drawing.Size(315, 64)
        Me.GBCustomerName.TabIndex = 9
        Me.GBCustomerName.TabStop = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(6, 14)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(101, 16)
        Me.lblCustomerName.TabIndex = 0
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
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.lblValue)
        Me.pnlContent.Controls.Add(Me.lblWords)
        Me.pnlContent.Controls.Add(Me.dgvSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 186)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 465)
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
        Me.dgvSearch.Location = New System.Drawing.Point(97, 22)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(990, 248)
        Me.dgvSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(873, 11)
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
        Me.btnExit.Location = New System.Drawing.Point(945, 11)
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
        Me.lblBillDateTo.Location = New System.Drawing.Point(147, 27)
        Me.lblBillDateTo.Name = "lblBillDateTo"
        Me.lblBillDateTo.Size = New System.Drawing.Size(12, 16)
        Me.lblBillDateTo.TabIndex = 39
        Me.lblBillDateTo.Text = "-"
        '
        'dtpBillDateFrom
        '
        Me.dtpBillDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateFrom.Location = New System.Drawing.Point(24, 27)
        Me.dtpBillDateFrom.Name = "dtpBillDateFrom"
        Me.dtpBillDateFrom.ShowUpDown = True
        Me.dtpBillDateFrom.Size = New System.Drawing.Size(123, 20)
        Me.dtpBillDateFrom.TabIndex = 1
        '
        'lblBillDateFrom
        '
        Me.lblBillDateFrom.AutoSize = True
        Me.lblBillDateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateFrom.Location = New System.Drawing.Point(24, 11)
        Me.lblBillDateFrom.Name = "lblBillDateFrom"
        Me.lblBillDateFrom.Size = New System.Drawing.Size(77, 16)
        Me.lblBillDateFrom.TabIndex = 0
        Me.lblBillDateFrom.Text = "Order Date"
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Postage Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpBillDateTo
        '
        Me.dtpBillDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateTo.Location = New System.Drawing.Point(159, 27)
        Me.dtpBillDateTo.Name = "dtpBillDateTo"
        Me.dtpBillDateTo.ShowUpDown = True
        Me.dtpBillDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpBillDateTo.TabIndex = 2
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 186)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.txtPostalCode)
        Me.pnlToolBar.Controls.Add(Me.lblPostalCode)
        Me.pnlToolBar.Controls.Add(Me.cmbOrderNo)
        Me.pnlToolBar.Controls.Add(Me.lblOrderNo)
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.lblCode)
        Me.pnlToolBar.Controls.Add(Me.txtCode)
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
        Me.pnlToolBar.Size = New System.Drawing.Size(1184, 144)
        Me.pnlToolBar.TabIndex = 21
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(679, 27)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(176, 20)
        Me.txtPostalCode.TabIndex = 8
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(679, 8)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(84, 16)
        Me.lblPostalCode.TabIndex = 7
        Me.lblPostalCode.Text = "Postal Code"
        '
        'cmbOrderNo
        '
        Me.cmbOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbOrderNo.FormattingEnabled = True
        Me.cmbOrderNo.Location = New System.Drawing.Point(479, 27)
        Me.cmbOrderNo.Name = "cmbOrderNo"
        Me.cmbOrderNo.Size = New System.Drawing.Size(183, 21)
        Me.cmbOrderNo.TabIndex = 6
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.Location = New System.Drawing.Point(479, 11)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(65, 16)
        Me.lblOrderNo.TabIndex = 5
        Me.lblOrderNo.Text = "Order No"
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(283, 27)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(176, 20)
        Me.txtICNo.TabIndex = 4
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(283, 11)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 3
        Me.lblICNo.Text = "IC No"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(351, 80)
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
        Me.txtCode.Location = New System.Drawing.Point(354, 99)
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
        'frmPostageSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmPostageSearch"
        Me.Text = "Postage Search"
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
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblBillDateTo As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBillDateFrom As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
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
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
    Friend WithEvents cmbOrderNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
End Class
