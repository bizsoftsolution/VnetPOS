<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductPassword
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
        Me.PnlFormDesign = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblHeading = New System.Windows.Forms.Label
        Me.PnlDock = New System.Windows.Forms.Panel
        Me.PnlFormDesign.SuspendLayout()
        Me.PnlDock.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlFormDesign
        '
        Me.PnlFormDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlFormDesign.Controls.Add(Me.btnCancel)
        Me.PnlFormDesign.Controls.Add(Me.btnOK)
        Me.PnlFormDesign.Controls.Add(Me.txtPassword)
        Me.PnlFormDesign.Controls.Add(Me.lblPassword)
        Me.PnlFormDesign.Controls.Add(Me.lblHeading)
        Me.PnlFormDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlFormDesign.ForeColor = System.Drawing.Color.Black
        Me.PnlFormDesign.Location = New System.Drawing.Point(0, 0)
        Me.PnlFormDesign.Name = "PnlFormDesign"
        Me.PnlFormDesign.Size = New System.Drawing.Size(584, 258)
        Me.PnlFormDesign.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(287, 150)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 28)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(190, 150)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 28)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(248, 87)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(222, 26)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(125, 91)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 19)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Black
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(582, 38)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "PRODUCT SECURITY"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlDock
        '
        Me.PnlDock.BackColor = System.Drawing.Color.Transparent
        Me.PnlDock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlDock.Controls.Add(Me.PnlFormDesign)
        Me.PnlDock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDock.ForeColor = System.Drawing.Color.Black
        Me.PnlDock.Location = New System.Drawing.Point(0, 0)
        Me.PnlDock.Name = "PnlDock"
        Me.PnlDock.Size = New System.Drawing.Size(588, 262)
        Me.PnlDock.TabIndex = 2
        '
        'frmProductPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 262)
        Me.Controls.Add(Me.PnlDock)
        Me.Name = "frmProductPassword"
        Me.Text = "Product Password"
        Me.PnlFormDesign.ResumeLayout(False)
        Me.PnlFormDesign.PerformLayout()
        Me.PnlDock.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlFormDesign As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents PnlDock As System.Windows.Forms.Panel
End Class
