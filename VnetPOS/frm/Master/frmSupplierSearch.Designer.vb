<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierSearch
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
        Me.txtICNo = New System.Windows.Forms.TextBox()
        Me.lblICNo = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.rbnInfixMobile = New System.Windows.Forms.RadioButton()
        Me.rbnSuffixMobile = New System.Windows.Forms.RadioButton()
        Me.rbnPrefixMobile = New System.Windows.Forms.RadioButton()
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton()
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton()
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlToolBar = New System.Windows.Forms.Panel()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.pnlTwo = New System.Windows.Forms.Panel()
        Me.pnlOne = New System.Windows.Forms.Panel()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.rbnInfixAddress = New System.Windows.Forms.RadioButton()
        Me.rbnSuffixAddress = New System.Windows.Forms.RadioButton()
        Me.rbnPrefixAddress = New System.Windows.Forms.RadioButton()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlTwo.SuspendLayout()
        Me.pnlOne.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(7, 124)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(272, 20)
        Me.txtICNo.TabIndex = 34
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(7, 108)
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
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1072, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Supplier Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.txtCustomerName)
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
        Me.pnlToolBar.Size = New System.Drawing.Size(777, 165)
        Me.pnlToolBar.TabIndex = 0
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
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(7, 12)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(103, 16)
        Me.lblCustomerName.TabIndex = 10
        Me.lblCustomerName.Text = "Supplier Name"
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
        Me.btnExit.Location = New System.Drawing.Point(685, 28)
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
        Me.btnSearch.Location = New System.Drawing.Point(613, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1072, 662)
        Me.pnlMain.TabIndex = 15
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 231)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1072, 421)
        Me.pnlContent.TabIndex = 0
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(12, 17)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(1040, 388)
        Me.dgvCustomerSearch.TabIndex = 0
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 652)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1072, 10)
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
        Me.pnlHeader.Size = New System.Drawing.Size(1072, 231)
        Me.pnlHeader.TabIndex = 0
        '
        'frmSupplierSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmSupplierSearch"
        Me.Text = "Supplier Search"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.pnlTwo.ResumeLayout(False)
        Me.pnlTwo.PerformLayout()
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtICNo As TextBox
    Friend WithEvents lblICNo As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents rbnInfixMobile As RadioButton
    Friend WithEvents rbnSuffixMobile As RadioButton
    Friend WithEvents rbnPrefixMobile As RadioButton
    Friend WithEvents rbnInfixCustomer As RadioButton
    Friend WithEvents rbnSuffixCustomer As RadioButton
    Friend WithEvents rbnPrefixCustomer As RadioButton
    Friend WithEvents lblHeading As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents dgvCustomerSearch As DataGridView
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlToolBar As Panel
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents pnlTwo As Panel
    Friend WithEvents pnlOne As Panel
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents rbnInfixAddress As RadioButton
    Friend WithEvents rbnSuffixAddress As RadioButton
    Friend WithEvents rbnPrefixAddress As RadioButton
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearch As Button
End Class
