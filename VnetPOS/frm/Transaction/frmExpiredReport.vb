Public Class frmExpiredReport
    Dim db As New DBLib
    Public Status As String
    Private Sub frmQuickSalesReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyValue = Keys.Escape Then
            If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
        End If
    End Sub

    Private Sub frmQuickSalesReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetFormStyle(Me)
        viewprint()
    End Sub
    Public Sub viewprint()
        Dim ds As New DataSet
        Dim DTMemberRegistration As New DataTable()

        If Status = "Expired" Then
            DTMemberRegistration = db.ViewMemberRegistration.Grid("*", String.Format("RenewDate < #{0}#", Now)).ToTable("ViewMemberRegistration")
            ds.Clear()
            ds.Tables.Add(DTMemberRegistration)

            ReportView(CrystalReportViewer1, "Transaction\cryExpiredReport.rpt", ds)
        Else
            DTMemberRegistration = db.ViewMemberRegistration.Grid("*", String.Format("RenewDate > #{0}# and RenewDate < #{1}#", Now, DateAdd(DateInterval.Day, 30, Now))).ToTable("ViewMemberRegistration")
            ds.Clear()
            ds.Tables.Add(DTMemberRegistration)

            ReportView(CrystalReportViewer1, "Transaction\cryToBeExpiredReport.rpt", ds)
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("{Escape}")
    End Sub
End Class