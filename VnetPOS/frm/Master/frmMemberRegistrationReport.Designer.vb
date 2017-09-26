<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRegistrationReport
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbnInfixMobile = New System.Windows.Forms.RadioButton
        Me.rbnSuffixMobile = New System.Windows.Forms.RadioButton
        Me.rbnPrefixMobile = New System.Windows.Forms.RadioButton
        Me.rbnPrefixAddress = New System.Windows.Forms.RadioButton
        Me.rbnSuffixAddress = New System.Windows.Forms.RadioButton
        Me.rbnInfixAddress = New System.Windows.Forms.RadioButton
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblMobile = New System.Windows.Forms.Label
        Me.rbnInfixCustomer = New System.Windows.Forms.RadioButton
        Me.lblAddress = New System.Windows.Forms.Label
        Me.rbnSuffixCustomer = New System.Windows.Forms.RadioButton
        Me.pnlToolBar = New System.Windows.Forms.Panel
        Me.txtICNo = New System.Windows.Forms.TextBox
        Me.lblICNo = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbnPrefixCustomer = New System.Windows.Forms.RadioButton
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.lblMailID = New System.Windows.Forms.Label
        Me.lblHeading = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBillAmountTo = New System.Windows.Forms.TextBox
        Me.txtBillAmountFrom = New System.Windows.Forms.TextBox
        Me.lblBillAmount = New System.Windows.Forms.Label
        Me.dtpBillDateTo = New System.Windows.Forms.DateTimePicker
        Me.lblBillDateTo = New System.Windows.Forms.Label
        Me.dtpBillDateFrom = New System.Windows.Forms.DateTimePicker
        Me.lblRenewDateFrom = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlToolBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 191)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1014, 442)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbnInfixMobile)
        Me.Panel2.Controls.Add(Me.rbnSuffixMobile)
        Me.Panel2.Controls.Add(Me.rbnPrefixMobile)
        Me.Panel2.Location = New System.Drawing.Point(139, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 20)
        Me.Panel2.TabIndex = 26
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
        'rbnPrefixAddress
        '
        Me.rbnPrefixAddress.AutoSize = True
        Me.rbnPrefixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnPrefixAddress.Location = New System.Drawing.Point(0, 0)
        Me.rbnPrefixAddress.Name = "rbnPrefixAddress"
        Me.rbnPrefixAddress.Size = New System.Drawing.Size(64, 20)
        Me.rbnPrefixAddress.TabIndex = 7
        Me.rbnPrefixAddress.Text = "Prefix"
        Me.rbnPrefixAddress.UseVisualStyleBackColor = True
        '
        'rbnSuffixAddress
        '
        Me.rbnSuffixAddress.AutoSize = True
        Me.rbnSuffixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnSuffixAddress.Location = New System.Drawing.Point(118, 0)
        Me.rbnSuffixAddress.Name = "rbnSuffixAddress"
        Me.rbnSuffixAddress.Size = New System.Drawing.Size(63, 20)
        Me.rbnSuffixAddress.TabIndex = 9
        Me.rbnSuffixAddress.Text = "Suffix"
        Me.rbnSuffixAddress.UseVisualStyleBackColor = True
        '
        'rbnInfixAddress
        '
        Me.rbnInfixAddress.AutoSize = True
        Me.rbnInfixAddress.Checked = True
        Me.rbnInfixAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rbnInfixAddress.Location = New System.Drawing.Point(64, 0)
        Me.rbnInfixAddress.Name = "rbnInfixAddress"
        Me.rbnInfixAddress.Size = New System.Drawing.Size(54, 20)
        Me.rbnInfixAddress.TabIndex = 8
        Me.rbnInfixAddress.TabStop = True
        Me.rbnInfixAddress.Text = "Infix"
        Me.rbnInfixAddress.UseVisualStyleBackColor = True
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(5, 5)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(101, 16)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Member Name"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(818, 83)
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
        Me.btnSearch.Location = New System.Drawing.Point(746, 83)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbnPrefixAddress)
        Me.Panel4.Controls.Add(Me.rbnSuffixAddress)
        Me.Panel4.Controls.Add(Me.rbnInfixAddress)
        Me.Panel4.Location = New System.Drawing.Point(452, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(182, 20)
        Me.Panel4.TabIndex = 30
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(5, 50)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(51, 16)
        Me.lblMobile.TabIndex = 4
        Me.lblMobile.Text = "Mobile"
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
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(333, 9)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Address"
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
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.Label1)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountTo)
        Me.pnlToolBar.Controls.Add(Me.txtBillAmountFrom)
        Me.pnlToolBar.Controls.Add(Me.lblBillAmount)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.lblBillDateTo)
        Me.pnlToolBar.Controls.Add(Me.dtpBillDateFrom)
        Me.pnlToolBar.Controls.Add(Me.lblRenewDateFrom)
        Me.pnlToolBar.Controls.Add(Me.txtICNo)
        Me.pnlToolBar.Controls.Add(Me.lblICNo)
        Me.pnlToolBar.Controls.Add(Me.lblAddress)
        Me.pnlToolBar.Controls.Add(Me.txtAddress)
        Me.pnlToolBar.Controls.Add(Me.Panel1)
        Me.pnlToolBar.Controls.Add(Me.txtCustomerName)
        Me.pnlToolBar.Controls.Add(Me.txtMemberId)
        Me.pnlToolBar.Controls.Add(Me.txtMobile)
        Me.pnlToolBar.Controls.Add(Me.lblMailID)
        Me.pnlToolBar.Controls.Add(Me.lblMobile)
        Me.pnlToolBar.Controls.Add(Me.Panel2)
        Me.pnlToolBar.Controls.Add(Me.lblCustomerName)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.Panel4)
        Me.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlToolBar.Location = New System.Drawing.Point(0, 42)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(1038, 619)
        Me.pnlToolBar.TabIndex = 4
        '
        'txtICNo
        '
        Me.txtICNo.Location = New System.Drawing.Point(333, 112)
        Me.txtICNo.Name = "txtICNo"
        Me.txtICNo.Size = New System.Drawing.Size(301, 20)
        Me.txtICNo.TabIndex = 32
        '
        'lblICNo
        '
        Me.lblICNo.AutoSize = True
        Me.lblICNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICNo.Location = New System.Drawing.Point(333, 96)
        Me.lblICNo.Name = "lblICNo"
        Me.lblICNo.Size = New System.Drawing.Size(42, 16)
        Me.lblICNo.TabIndex = 31
        Me.lblICNo.Text = "IC No"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(333, 25)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(301, 68)
        Me.txtAddress.TabIndex = 7
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
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(5, 21)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(310, 20)
        Me.txtCustomerName.TabIndex = 1
        '
        'txtMemberId
        '
        Me.txtMemberId.Location = New System.Drawing.Point(5, 112)
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(310, 20)
        Me.txtMemberId.TabIndex = 9
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(5, 66)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(310, 20)
        Me.txtMobile.TabIndex = 5
        '
        'lblMailID
        '
        Me.lblMailID.AutoSize = True
        Me.lblMailID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailID.Location = New System.Drawing.Point(5, 96)
        Me.lblMailID.Name = "lblMailID"
        Me.lblMailID.Size = New System.Drawing.Size(76, 16)
        Me.lblMailID.TabIndex = 8
        Me.lblMailID.Text = "Member Id"
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1038, 42)
        Me.lblHeading.TabIndex = 5
        Me.lblHeading.Text = "Member Registration Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(769, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "-"
        '
        'txtBillAmountTo
        '
        Me.txtBillAmountTo.Location = New System.Drawing.Point(781, 51)
        Me.txtBillAmountTo.Name = "txtBillAmountTo"
        Me.txtBillAmountTo.Size = New System.Drawing.Size(106, 20)
        Me.txtBillAmountTo.TabIndex = 69
        '
        'txtBillAmountFrom
        '
        Me.txtBillAmountFrom.Location = New System.Drawing.Point(709, 51)
        Me.txtBillAmountFrom.Name = "txtBillAmountFrom"
        Me.txtBillAmountFrom.Size = New System.Drawing.Size(60, 20)
        Me.txtBillAmountFrom.TabIndex = 68
        '
        'lblBillAmount
        '
        Me.lblBillAmount.AutoSize = True
        Me.lblBillAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmount.Location = New System.Drawing.Point(644, 53)
        Me.lblBillAmount.Name = "lblBillAmount"
        Me.lblBillAmount.Size = New System.Drawing.Size(57, 16)
        Me.lblBillAmount.TabIndex = 67
        Me.lblBillAmount.Text = "Amount"
        '
        'dtpBillDateTo
        '
        Me.dtpBillDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateTo.Location = New System.Drawing.Point(781, 25)
        Me.dtpBillDateTo.Name = "dtpBillDateTo"
        Me.dtpBillDateTo.ShowUpDown = True
        Me.dtpBillDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpBillDateTo.TabIndex = 66
        '
        'lblBillDateTo
        '
        Me.lblBillDateTo.AutoSize = True
        Me.lblBillDateTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillDateTo.Location = New System.Drawing.Point(769, 27)
        Me.lblBillDateTo.Name = "lblBillDateTo"
        Me.lblBillDateTo.Size = New System.Drawing.Size(12, 16)
        Me.lblBillDateTo.TabIndex = 65
        Me.lblBillDateTo.Text = "-"
        '
        'dtpBillDateFrom
        '
        Me.dtpBillDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpBillDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillDateFrom.Location = New System.Drawing.Point(646, 25)
        Me.dtpBillDateFrom.Name = "dtpBillDateFrom"
        Me.dtpBillDateFrom.ShowUpDown = True
        Me.dtpBillDateFrom.Size = New System.Drawing.Size(123, 20)
        Me.dtpBillDateFrom.TabIndex = 64
        '
        'lblRenewDateFrom
        '
        Me.lblRenewDateFrom.AutoSize = True
        Me.lblRenewDateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewDateFrom.Location = New System.Drawing.Point(643, 6)
        Me.lblRenewDateFrom.Name = "lblRenewDateFrom"
        Me.lblRenewDateFrom.Size = New System.Drawing.Size(117, 16)
        Me.lblRenewDateFrom.TabIndex = 63
        Me.lblRenewDateFrom.Text = "Registration Date"
        '
        'frmMemberRegistrationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 661)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.pnlToolBar)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmMemberRegistrationReport"
        Me.Text = "Member Registration Report"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlToolBar.ResumeLayout(False)
        Me.pnlToolBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbnInfixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixMobile As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPrefixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSuffixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents rbnInfixAddress As System.Windows.Forms.RadioButton
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents rbnInfixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents rbnSuffixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbnPrefixCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lblMailID As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents txtICNo As System.Windows.Forms.TextBox
    Friend WithEvents lblICNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBillAmountTo As System.Windows.Forms.TextBox
    Friend WithEvents txtBillAmountFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblBillAmount As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBillDateTo As System.Windows.Forms.Label
    Friend WithEvents dtpBillDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRenewDateFrom As System.Windows.Forms.Label
End Class
