<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberStatusReport
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
        Me.lblMemberStatus = New System.Windows.Forms.Label
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.cmbMemberStatus = New System.Windows.Forms.ComboBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.btnExpired = New System.Windows.Forms.Button
        Me.btnToBeExpired = New System.Windows.Forms.Button
        Me.pnlToolBar.SuspendLayout()
        Me.SuspendLayout()
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
        Me.CrystalReportViewer1.TabIndex = 12
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'lblMemberStatus
        '
        Me.lblMemberStatus.AutoSize = True
        Me.lblMemberStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberStatus.Location = New System.Drawing.Point(108, 48)
        Me.lblMemberStatus.Name = "lblMemberStatus"
        Me.lblMemberStatus.Size = New System.Drawing.Size(103, 16)
        Me.lblMemberStatus.TabIndex = 63
        Me.lblMemberStatus.Text = "Member Status"
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnToBeExpired)
        Me.pnlToolBar.Controls.Add(Me.btnExpired)
        Me.pnlToolBar.Controls.Add(Me.cmbMemberStatus)
        Me.pnlToolBar.Controls.Add(Me.lblMemberStatus)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1184, 619)
        Me.pnlToolBar.TabIndex = 13
        '
        'cmbMemberStatus
        '
        Me.cmbMemberStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMemberStatus.FormattingEnabled = True
        Me.cmbMemberStatus.Items.AddRange(New Object() {"Active", "Expired"})
        Me.cmbMemberStatus.Location = New System.Drawing.Point(217, 46)
        Me.cmbMemberStatus.Name = "cmbMemberStatus"
        Me.cmbMemberStatus.Size = New System.Drawing.Size(193, 20)
        Me.cmbMemberStatus.TabIndex = 64
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(780, 35)
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
        Me.btnSearch.Location = New System.Drawing.Point(436, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 10
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
        Me.lblHeading.TabIndex = 14
        Me.lblHeading.Text = "Member Status Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExpired
        '
        Me.btnExpired.BackColor = System.Drawing.Color.White
        Me.btnExpired.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExpired.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpired.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExpired.Location = New System.Drawing.Point(510, 35)
        Me.btnExpired.Name = "btnExpired"
        Me.btnExpired.Size = New System.Drawing.Size(127, 49)
        Me.btnExpired.TabIndex = 65
        Me.btnExpired.Text = "Expired Membership Report"
        Me.btnExpired.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExpired.UseVisualStyleBackColor = False
        '
        'btnToBeExpired
        '
        Me.btnToBeExpired.BackColor = System.Drawing.Color.White
        Me.btnToBeExpired.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToBeExpired.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToBeExpired.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnToBeExpired.Location = New System.Drawing.Point(645, 35)
        Me.btnToBeExpired.Name = "btnToBeExpired"
        Me.btnToBeExpired.Size = New System.Drawing.Size(127, 49)
        Me.btnToBeExpired.TabIndex = 66
        Me.btnToBeExpired.Text = "To Be Expired Membership Report"
        Me.btnToBeExpired.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnToBeExpired.UseVisualStyleBackColor = False
        '
        'frmMemberStatusReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.pnlToolBar)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmMemberStatusReport"
        Me.Text = "Member Status Report"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblMemberStatus As System.Windows.Forms.Label
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents cmbMemberStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnToBeExpired As System.Windows.Forms.Button
    Friend WithEvents btnExpired As System.Windows.Forms.Button
End Class
