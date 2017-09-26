Public Class frmQuickMemberRenewReport
    Dim db As New DBLib

    Private Sub frmQuickSalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmQuickSalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
    End Sub
    Public Sub viewprint(ByVal Code As String)
        Dim ds As New DataSet
        Dim DTMemberReg As New DataTable()

        DTMemberReg = db.ViewRenew.Grid("*", "RenewCode='" + Code + "'").ToTable("ViewMemberRenewal")

        ds.Clear()
        ds.Tables.Add(DTMemberReg)

        ReportView(CrystalReportViewer1, "Master\cryQuickMemberRenewReport.rpt", ds)

    End Sub
End Class