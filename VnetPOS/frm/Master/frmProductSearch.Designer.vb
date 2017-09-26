<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductSearch
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
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.lblProductUserCode = New System.Windows.Forms.Label
        Me.txtProductUserCode = New System.Windows.Forms.TextBox
        Me.pnlOne = New System.Windows.Forms.Panel
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.lblProductName = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView
        Me.pnlContent = New System.Windows.Forms.Panel
        Me.pnlMain = New System.Windows.Forms.Panel
        Me.pnlFooter = New System.Windows.Forms.Panel
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.pnlOne.SuspendLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlToolBar.Controls.Add(Me.txtProductName)
        Me.pnlToolBar.Controls.Add(Me.lblProductUserCode)
        Me.pnlToolBar.Controls.Add(Me.txtProductUserCode)
        Me.pnlToolBar.Controls.Add(Me.pnlOne)
        Me.pnlToolBar.Controls.Add(Me.lblProductName)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Location = New System.Drawing.Point(12, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(511, 128)
        Me.pnlToolBar.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(7, 28)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(310, 20)
        Me.txtProductName.TabIndex = 0
        '
        'lblProductUserCode
        '
        Me.lblProductUserCode.AutoSize = True
        Me.lblProductUserCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductUserCode.Location = New System.Drawing.Point(7, 55)
        Me.lblProductUserCode.Name = "lblProductUserCode"
        Me.lblProductUserCode.Size = New System.Drawing.Size(126, 16)
        Me.lblProductUserCode.TabIndex = 20
        Me.lblProductUserCode.Text = "Product User Code"
        '
        'txtProductUserCode
        '
        Me.txtProductUserCode.Location = New System.Drawing.Point(7, 71)
        Me.txtProductUserCode.Name = "txtProductUserCode"
        Me.txtProductUserCode.Size = New System.Drawing.Size(310, 20)
        Me.txtProductUserCode.TabIndex = 0
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
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(7, 12)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(98, 16)
        Me.lblProductName.TabIndex = 10
        Me.lblProductName.Text = "Product Name"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(405, 12)
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
        Me.btnSearch.Location = New System.Drawing.Point(333, 12)
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
        Me.lblHeading.Text = "Product Search"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvCustomerSearch
        '
        Me.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(169, 35)
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(847, 248)
        Me.dgvCustomerSearch.TabIndex = 0
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 231)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1184, 420)
        Me.pnlContent.TabIndex = 0
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
        Me.pnlMain.TabIndex = 15
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 651)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1184, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmProductSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmProductSearch"
        Me.Text = "Product Search"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lblProductUserCode As System.Windows.Forms.Label
    Friend WithEvents txtProductUserCode As System.Windows.Forms.TextBox
    Friend WithEvents pnlOne As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents dgvCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
