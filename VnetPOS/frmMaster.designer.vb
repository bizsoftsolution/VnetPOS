<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaster))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MemberRegistrationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberRenewalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReOrderStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Backup File|*.jbk"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Backup File|*.jbk"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberRegistrationToolStripMenuItem1, Me.SupplierToolStripMenuItem, Me.MemberRenewalToolStripMenuItem, Me.ProductToolStripMenuItem1, Me.PostageToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.InvoiceReportToolStripMenuItem1, Me.MemberStatusToolStripMenuItem, Me.StockReportToolStripMenuItem, Me.ReOrderStockToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MemberRegistrationToolStripMenuItem1
        '
        Me.MemberRegistrationToolStripMenuItem1.Name = "MemberRegistrationToolStripMenuItem1"
        Me.MemberRegistrationToolStripMenuItem1.Size = New System.Drawing.Size(130, 20)
        Me.MemberRegistrationToolStripMenuItem1.Text = "Member Registration"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'MemberRenewalToolStripMenuItem
        '
        Me.MemberRenewalToolStripMenuItem.Name = "MemberRenewalToolStripMenuItem"
        Me.MemberRenewalToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.MemberRenewalToolStripMenuItem.Text = "Member Renewal"
        '
        'ProductToolStripMenuItem1
        '
        Me.ProductToolStripMenuItem1.Name = "ProductToolStripMenuItem1"
        Me.ProductToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ProductToolStripMenuItem1.Text = "Product"
        '
        'PostageToolStripMenuItem
        '
        Me.PostageToolStripMenuItem.Name = "PostageToolStripMenuItem"
        Me.PostageToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PostageToolStripMenuItem.Text = "Postage"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PurchaseToolStripMenuItem.Text = "Stock In"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'InvoiceReportToolStripMenuItem1
        '
        Me.InvoiceReportToolStripMenuItem1.Name = "InvoiceReportToolStripMenuItem1"
        Me.InvoiceReportToolStripMenuItem1.Size = New System.Drawing.Size(95, 20)
        Me.InvoiceReportToolStripMenuItem1.Text = "Invoice Report"
        '
        'MemberStatusToolStripMenuItem
        '
        Me.MemberStatusToolStripMenuItem.Name = "MemberStatusToolStripMenuItem"
        Me.MemberStatusToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MemberStatusToolStripMenuItem.Text = "Member Status"
        '
        'StockReportToolStripMenuItem
        '
        Me.StockReportToolStripMenuItem.Name = "StockReportToolStripMenuItem"
        Me.StockReportToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.StockReportToolStripMenuItem.Text = "Stock Report"
        '
        'ReOrderStockToolStripMenuItem
        '
        Me.ReOrderStockToolStripMenuItem.Name = "ReOrderStockToolStripMenuItem"
        Me.ReOrderStockToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ReOrderStockToolStripMenuItem.Text = "Re-Order Stock"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaster"
        Me.Text = "Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MemberRegistrationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceReportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberRenewalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PostageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReOrderStockToolStripMenuItem As ToolStripMenuItem
End Class
