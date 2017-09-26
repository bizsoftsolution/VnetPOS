<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductReport
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
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.txtMemberName = New System.Windows.Forms.TextBox
        Me.txtProductCode = New System.Windows.Forms.TextBox
        Me.lblProductUserCode = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lblHeading = New System.Windows.Forms.Label
        Me.pnlToolBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.Panel1)
        Me.pnlToolBar.Controls.Add(Me.txtMemberName)
        Me.pnlToolBar.Controls.Add(Me.txtProductCode)
        Me.pnlToolBar.Controls.Add(Me.lblProductUserCode)
        Me.pnlToolBar.Controls.Add(Me.lblCustomerName)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Location = New System.Drawing.Point(4, 46)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(880, 139)
        Me.pnlToolBar.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbnInfixCustomer)
        Me.Panel1.Controls.Add(Me.rbnSuffixCustomer)
        Me.Panel1.Controls.Add(Me.rbnPrefixCustomer)
        Me.Panel1.Location = New System.Drawing.Point(139, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 20)
        Me.Panel1.TabIndex = 25
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
        'txtMemberName
        '
        Me.txtMemberName.Location = New System.Drawing.Point(5, 21)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(310, 20)
        Me.txtMemberName.TabIndex = 1
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(6, 66)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(310, 20)
        Me.txtProductCode.TabIndex = 9
        '
        'lblProductUserCode
        '
        Me.lblProductUserCode.AutoSize = True
        Me.lblProductUserCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductUserCode.Location = New System.Drawing.Point(6, 50)
        Me.lblProductUserCode.Name = "lblProductUserCode"
        Me.lblProductUserCode.Size = New System.Drawing.Size(94, 16)
        Me.lblProductUserCode.TabIndex = 8
        Me.lblProductUserCode.Text = "Product Code"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(5, 5)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(98, 16)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Product Name"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(414, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 11
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
        Me.btnSearch.Location = New System.Drawing.Point(342, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, 191)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1187, 469)
        Me.CrystalReportViewer1.TabIndex = 6
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 42)
        Me.lblHeading.TabIndex = 8
        Me.lblHeading.Text = "Product Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProductReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlToolBar)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmProductReport"
        Me.ShowInTaskbar = False
        Me.Text = "Product Report"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents lblProductUserCode As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblHeading As System.Windows.Forms.Label
End Class
