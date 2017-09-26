Public Class frmProductPassword
    Private Sub CTRL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        sender.Backcolor = FColor
        sender.Forecolor = BColor
    End Sub

    Private Sub CTRL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub

    Private Sub frmProductPassword_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPassword.Text = ""
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyCode = Keys.Escape) Then
            txtPassword.Text = ""
            MsgDialog.ShowMsgDlg(txtPassword, "Do you want to QUIT", "LOGIN", "Q")
            If MsgDialog.DialogResult = Windows.Forms.DialogResult.Yes Then
                End
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtPassword.Text = "vnet2u3953" Then
            FormShow(frmProduct)
            Me.Close()
        Else
            MsgBox("Wrong Password")
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub frmProductPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetFormStyle(Me)
    End Sub
End Class