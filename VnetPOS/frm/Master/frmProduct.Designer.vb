<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.pnlToolBar = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.lblCId = New System.Windows.Forms.Label()
        Me.LinkParty = New System.Windows.Forms.Button()
        Me.lblProductUserCode = New System.Windows.Forms.Label()
        Me.lblSellingRate = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtSellingRate = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblSellingRateNon = New System.Windows.Forms.Label()
        Me.txtNonMemberSellingRate = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductUserCode = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.lblOpQty = New System.Windows.Forms.Label()
        Me.txtOpQty = New System.Windows.Forms.TextBox()
        Me.pnlToolBar.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlToolBar
        '
        Me.pnlToolBar.Controls.Add(Me.btnSearch)
        Me.pnlToolBar.Controls.Add(Me.btnNew)
        Me.pnlToolBar.Controls.Add(Me.btnSave)
        Me.pnlToolBar.Controls.Add(Me.btnExit)
        Me.pnlToolBar.Controls.Add(Me.btnDelete)
        Me.pnlToolBar.Controls.Add(Me.btnView)
        Me.pnlToolBar.Location = New System.Drawing.Point(23, 45)
        Me.pnlToolBar.Name = "pnlToolBar"
        Me.pnlToolBar.Size = New System.Drawing.Size(469, 56)
        Me.pnlToolBar.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(386, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "SEARC&H"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.VnetPOS.My.Resources.Resources.adds35
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNew.Location = New System.Drawing.Point(12, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 49)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "&New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.VnetPOS.My.Resources.Resources.Save35
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(86, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 49)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.VnetPOS.My.Resources.Resources.exit35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(306, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.VnetPOS.My.Resources.Resources.delete35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(160, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 49)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.VnetPOS.My.Resources.Resources.report
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.Location = New System.Drawing.Point(232, 2)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(66, 49)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = " &VIEW"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtSearchBox
        '
        Me.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchBox.Location = New System.Drawing.Point(581, 61)
        Me.txtSearchBox.MaxLength = 100
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(184, 22)
        Me.txtSearchBox.TabIndex = 5
        Me.txtSearchBox.Visible = False
        '
        'lblCId
        '
        Me.lblCId.AutoSize = True
        Me.lblCId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCId.Location = New System.Drawing.Point(27, 12)
        Me.lblCId.Name = "lblCId"
        Me.lblCId.Size = New System.Drawing.Size(73, 16)
        Me.lblCId.TabIndex = 0
        Me.lblCId.Text = "Product Id"
        Me.lblCId.Visible = False
        '
        'LinkParty
        '
        Me.LinkParty.BackColor = System.Drawing.Color.White
        Me.LinkParty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LinkParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LinkParty.Location = New System.Drawing.Point(708, -20)
        Me.LinkParty.Name = "LinkParty"
        Me.LinkParty.Size = New System.Drawing.Size(20, 20)
        Me.LinkParty.TabIndex = 24
        Me.LinkParty.TabStop = False
        Me.LinkParty.Text = "..."
        Me.LinkParty.UseVisualStyleBackColor = False
        '
        'lblProductUserCode
        '
        Me.lblProductUserCode.AutoSize = True
        Me.lblProductUserCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductUserCode.Location = New System.Drawing.Point(27, 76)
        Me.lblProductUserCode.Name = "lblProductUserCode"
        Me.lblProductUserCode.Size = New System.Drawing.Size(94, 16)
        Me.lblProductUserCode.TabIndex = 4
        Me.lblProductUserCode.Text = "Product Code"
        Me.lblProductUserCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSellingRate
        '
        Me.lblSellingRate.AutoSize = True
        Me.lblSellingRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellingRate.Location = New System.Drawing.Point(27, 108)
        Me.lblSellingRate.Name = "lblSellingRate"
        Me.lblSellingRate.Size = New System.Drawing.Size(118, 16)
        Me.lblSellingRate.TabIndex = 6
        Me.lblSellingRate.Text = "Rate For Member"
        Me.lblSellingRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtId
        '
        Me.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(186, 13)
        Me.txtId.MaxLength = 100
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(218, 22)
        Me.txtId.TabIndex = 2
        Me.txtId.Visible = False
        '
        'txtSellingRate
        '
        Me.txtSellingRate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingRate.Location = New System.Drawing.Point(186, 105)
        Me.txtSellingRate.MaxLength = 300
        Me.txtSellingRate.Name = "txtSellingRate"
        Me.txtSellingRate.Size = New System.Drawing.Size(218, 22)
        Me.txtSellingRate.TabIndex = 7
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'pnlForm
        '
        Me.pnlForm.Controls.Add(Me.lblOpQty)
        Me.pnlForm.Controls.Add(Me.txtOpQty)
        Me.pnlForm.Controls.Add(Me.lblSellingRateNon)
        Me.pnlForm.Controls.Add(Me.txtNonMemberSellingRate)
        Me.pnlForm.Controls.Add(Me.lblProductName)
        Me.pnlForm.Controls.Add(Me.txtProductName)
        Me.pnlForm.Controls.Add(Me.lblCId)
        Me.pnlForm.Controls.Add(Me.LinkParty)
        Me.pnlForm.Controls.Add(Me.lblProductUserCode)
        Me.pnlForm.Controls.Add(Me.lblSellingRate)
        Me.pnlForm.Controls.Add(Me.txtSellingRate)
        Me.pnlForm.Controls.Add(Me.txtProductUserCode)
        Me.pnlForm.Controls.Add(Me.txtCode)
        Me.pnlForm.Controls.Add(Me.txtId)
        Me.pnlForm.Location = New System.Drawing.Point(66, 38)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(448, 222)
        Me.pnlForm.TabIndex = 0
        '
        'lblSellingRateNon
        '
        Me.lblSellingRateNon.AutoSize = True
        Me.lblSellingRateNon.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellingRateNon.Location = New System.Drawing.Point(27, 140)
        Me.lblSellingRateNon.Name = "lblSellingRateNon"
        Me.lblSellingRateNon.Size = New System.Drawing.Size(147, 16)
        Me.lblSellingRateNon.TabIndex = 8
        Me.lblSellingRateNon.Text = "Rate For Non Member"
        Me.lblSellingRateNon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNonMemberSellingRate
        '
        Me.txtNonMemberSellingRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtNonMemberSellingRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtNonMemberSellingRate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonMemberSellingRate.Location = New System.Drawing.Point(186, 137)
        Me.txtNonMemberSellingRate.MaxLength = 100
        Me.txtNonMemberSellingRate.Name = "txtNonMemberSellingRate"
        Me.txtNonMemberSellingRate.Size = New System.Drawing.Size(218, 22)
        Me.txtNonMemberSellingRate.TabIndex = 9
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(27, 44)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(98, 16)
        Me.lblProductName.TabIndex = 2
        Me.lblProductName.Text = "Product Name"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProductName
        '
        Me.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProductName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(186, 41)
        Me.txtProductName.MaxLength = 100
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(218, 22)
        Me.txtProductName.TabIndex = 3
        '
        'txtProductUserCode
        '
        Me.txtProductUserCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductUserCode.Location = New System.Drawing.Point(186, 73)
        Me.txtProductUserCode.MaxLength = 100
        Me.txtProductUserCode.Name = "txtProductUserCode"
        Me.txtProductUserCode.Size = New System.Drawing.Size(218, 22)
        Me.txtProductUserCode.TabIndex = 5
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(186, 13)
        Me.txtCode.MaxLength = 100
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(218, 22)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Visible = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(859, 409)
        Me.pnlMain.TabIndex = 8
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 107)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(859, 292)
        Me.pnlContent.TabIndex = 0
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 399)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(859, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.txtSearchBox)
        Me.pnlHeader.Controls.Add(Me.pnlToolBar)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Controls.Add(Me.btnSearch1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(859, 107)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(859, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Product"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.White
        Me.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Image = Global.VnetPOS.My.Resources.Resources.search25
        Me.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch1.Location = New System.Drawing.Point(509, 48)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(66, 49)
        Me.btnSearch1.TabIndex = 6
        Me.btnSearch1.Text = "SEARC&H"
        Me.btnSearch1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch1.UseVisualStyleBackColor = False
        Me.btnSearch1.Visible = False
        '
        'lblOpQty
        '
        Me.lblOpQty.AutoSize = True
        Me.lblOpQty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpQty.Location = New System.Drawing.Point(27, 168)
        Me.lblOpQty.Name = "lblOpQty"
        Me.lblOpQty.Size = New System.Drawing.Size(101, 16)
        Me.lblOpQty.TabIndex = 25
        Me.lblOpQty.Text = "Opening Stock"
        Me.lblOpQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOpQty
        '
        Me.txtOpQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtOpQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtOpQty.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpQty.Location = New System.Drawing.Point(186, 165)
        Me.txtOpQty.MaxLength = 100
        Me.txtOpQty.Name = "txtOpQty"
        Me.txtOpQty.Size = New System.Drawing.Size(218, 22)
        Me.txtOpQty.TabIndex = 26
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 409)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmProduct"
        Me.Text = "Product"
        Me.pnlToolBar.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlToolBar As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents txtSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents lblCId As System.Windows.Forms.Label
    Friend WithEvents LinkParty As System.Windows.Forms.Button
    Friend WithEvents lblProductUserCode As System.Windows.Forms.Label
    Friend WithEvents lblSellingRate As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtSellingRate As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductUserCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents lblSellingRateNon As System.Windows.Forms.Label
    Friend WithEvents txtNonMemberSellingRate As System.Windows.Forms.TextBox
    Friend WithEvents lblOpQty As Label
    Friend WithEvents txtOpQty As TextBox
End Class
