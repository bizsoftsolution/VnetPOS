<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpiredReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pnlTool = New System.Windows.Forms.Panel
        Me.lblHeading = New System.Windows.Forms.Label
        Me.pnlTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 49)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1184, 612)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'pnlTool
        '
        Me.pnlTool.Controls.Add(Me.lblHeading)
        Me.pnlTool.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTool.Location = New System.Drawing.Point(0, 0)
        Me.pnlTool.Name = "pnlTool"
        Me.pnlTool.Size = New System.Drawing.Size(1184, 43)
        Me.pnlTool.TabIndex = 4
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1184, 34)
        Me.lblHeading.TabIndex = 15
        Me.lblHeading.Text = "Expired Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmExpiredReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.pnlTool)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmExpiredReport"
        Me.Text = "Expired Report"
        Me.pnlTool.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pnlTool As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
End Class
