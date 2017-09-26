<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRenewReport
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
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.txtBillAmountTo = New System.Windows.Forms.TextBox
        Me.txtBillAmountFrom = New System.Windows.Forms.TextBox
        Me.lblBillAmount = New System.Windows.Forms.Label
        Me.dtpBillDateTo = New System.Windows.Forms.DateTimePicker
        Me.dtpBillDateFrom = New System.Windows.Forms.DateTimePicker
        Me.lblRenewDateFrom = New System.Windows.Forms.Label
        Me.GBCustomerName = New System.Windows.Forms.GroupBox
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.rbnCusPrefix = New System.Windows.Forms.RadioButton
        Me.rbnCusInfix = New System.Windows.Forms.RadioButton
        Me.rbnCusSuffix = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lblHeading = New System.Windows.Forms.Label
        Me.txtICNo = New System.Windows.Forms.TextBox
        Me.lblICNo = New System.Windows.Forms.Label
        Me.pnlToolBar.SuspendLayout()
        Me.GBCustomerName.SuspendLayout()
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
        Me.CrystalReportViewer1.TabIndex = 9
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountTo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountFrom)
        Me.pnlToolBar.Controls.Add(Me.lblBillAmount)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateFrom)
        Me.pnlToolBar.Controls.Add(Me.lblRenewDateFrom)
        Me.pnlToolBar.Controls.Add(Me.GBCustomerName)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1184, 619)
        Me.pnlToolBar.TabIndex = 10
        '
        'txtBillAmountTo
        '
        Me.txtBillAmountTo.Location = New System.Drawing.Point(516, 31)
        Me.txtBillAmountTo.Name = "txtBillAmountTo"
        Me.txtBillAmountTo.Size = New System.Drawing.Size(85, 20)
        Me.txtBillAmountTo.TabIndex = 65
        '
        'txtBillAmountFrom
        '
        Me.txtBillAmountFrom.Location = New System.Drawing.Point(423, 31)
        Me.txtBillAmountFrom.Name = "txtBillAmountFrom"
        Me.txtBillAmountFrom.Size = New System.Drawing.Size(85, 20)
        Me.txtBillAmountFrom.TabIndex = 64
        '
        'lblBillAmount
        '
        Me.lblBillAmount.AutoSize = True
        Me.lblBillAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmount.Location = New System.Drawing.Point(358, 33)
        Me.lblBillAmount.Name = "lblBillAmount"
        Me.lblBillAmount.Size = New System.Drawing.Size(57, 16)
        Me.lblBillAmount.TabIndex = 63
        Me.lblBillAmount.Text = "Amount"
        '
        'dtpBillDateTo
        '
        Me.dtpBillDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateTo.Location = New System.Drawing.Point(238, 31)
        Me.dtpBillDateTo.Name = "dtpBillDateTo"
        Me.dtpBillDateTo.ShowUpDown = True
        Me.dtpBillDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpBillDateTo.TabIndex = 62
        '
        'dtpBillDateFrom
        '
        Me.dtpBillDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateFrom.Location = New System.Drawing.Point(103, 31)
        Me.dtpBillDateFrom.Name = "dtpBillDateFrom"
        Me.dtpBillDateFrom.ShowUpDown = True
        Me.dtpBillDateFrom.Size = New System.Drawing.Size(123, 20)
        Me.dtpBillDateFrom.TabIndex = 61
        '
        'lblRenewDateFrom
        '
        Me.lblRenewDateFrom.AutoSize = True
        Me.lblRenewDateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewDateFrom.Location = New System.Drawing.Point(13, 33)
        Me.lblRenewDateFrom.Name = "lblRenewDateFrom"
        Me.lblRenewDateFrom.Size = New System.Drawing.Size(85, 16)
        Me.lblRenewDateFrom.TabIndex = 60
        Me.lblRenewDateFrom.Text = "Renew Date"
        '
        'GBCustomerName
        '
        Me.GBCustomerName.Controls.Add(Me.lblCustomerName)
        Me.GBCustomerName.Controls.Add(Me.txtCustomerName)
        Me.GBCustomerName.Controls.Add(Me.rbnCusPrefix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusInfix)
        Me.GBCustomerName.Controls.Add(Me.rbnCusSuffix)
        Me.GBCustomerName.Location = New System.Drawing.Point(623, 7)
        Me.GBCustomerName.Name = "GBCustomerName"
        Me.GBCustomerName.Size = New System.Drawing.Size(346, 64)
        Me.GBCustomerName.TabIndex = 66
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
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(1056, 21)
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
        Me.btnSearch.Location = New System.Drawing.Point(984, 21)
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
        Me.lblHeading.TabIndex = 11
        Me.lblHeading.Text = "Member Renew Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(71, 70)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(271, 20)
        Me.txtICNo.TabIndex = 36
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(13, 72)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 35
        Me.lblICNo.Text = "IC No"
        '
        'frmMemberRenewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.pnlToolBar)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmMemberRenewReport"
        Me.Text = "Member Renew Report"
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.GBCustomerName.ResumeLayout(False)
        Me.GBCustomerName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents txtBillAmountTo As System.Windows.Forms.TextBox
    Friend WithEvents txtBillAmountFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblBillAmount As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBillDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRenewDateFrom As System.Windows.Forms.Label
    Friend WithEvents GBCustomerName As System.Windows.Forms.GroupBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents rbnCusPrefix As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCusInfix As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCusSuffix As System.Windows.Forms.RadioButton
    Friend WithEvents txtICNo As System.Windows.Forms.TextBox
    Friend WithEvents lblICNo As System.Windows.Forms.Label
End Class
