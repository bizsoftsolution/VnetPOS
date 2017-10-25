Public Class frmReOrderStock
    Dim db As New DBLib

    Private Sub frmINV_SalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmINV_SalesReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then e.KeyChar = ChrW(0)
    End Sub

    Private Sub frmINV_SalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        ViewSearch()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewSearch()
    End Sub
    Sub ViewSearch()

        Dim ds As New DataSet
        Dim DTStock As New DataTable()

        DTStock = db.ViewStock.Grid("*", "", "ProductName").ToTable("ViewStock")

        ds.Clear()
        ds.Tables.Add(DTStock)
        ReportView(CrystalReportViewer1, "cryReOrderStock.rpt", ds)

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("{ESCAPE}")
    End Sub

    Private Sub dtpFDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.Backcolor = FColor
        sender.Forecolor = BColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbEnterHeight
    End Sub

    Private Sub dtpFDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.Backcolor = BColor
        sender.Forecolor = FColor
        If sender.Name.ToLower.StartsWith("cmb") Then sender.Height = cmbLeaveHeight
    End Sub
End Class