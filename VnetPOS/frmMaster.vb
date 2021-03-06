﻿Imports System.IO
Imports System.IO.Packaging

Public Class frmMaster

    Private Sub frmMaster_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmLogin.Show()
        frmLogin.txtuserid.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.txtuserid.Focus()
        frmLogin.BringToFront()
    End Sub

    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Type <> "Admin" Then
            MenuStrip2.Visible = False
        Else
            MenuStrip2.Visible = True
        End If

        Me.Text = CompName

        Dim ComCode As String = db.CompanyDetails.CodeByUserCode(CompName)
        If File.Exists(Application.StartupPath + "\Images\CompanyBG\" + ComCode + ".jpg") Then
            Dim buffer As Byte() = File.ReadAllBytes(Application.StartupPath + "\Images\CompanyBG\" + ComCode + ".jpg")
            Dim stream As MemoryStream = New MemoryStream(buffer)

            Dim bm As Bitmap = CType(Bitmap.FromStream(stream), Bitmap)

            Me.BackgroundImage = bm.Clone
            stream.Dispose()
            bm.Dispose()
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Me.BackgroundImage = Nothing
        End If

    End Sub
    
    Private Sub MemberRegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberRegistrationToolStripMenuItem1.Click
        FormShow(frmMemberRegistration)
    End Sub

    Private Sub ProductToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem1.Click
        FormShow(frmProductPassword)
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        FormShow(frmSales)
    End Sub

    Private Sub InvoiceReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceReportToolStripMenuItem1.Click
        FormShow(frmINV_Sales)
    End Sub

    Private Sub MemberRenewalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberRenewalToolStripMenuItem.Click
        FormShow(frmMemberRenew)
    End Sub

    Private Sub MemberStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberStatusToolStripMenuItem.Click
        FormShow(frmMemberStatusReport)
    End Sub

    Private Sub PostageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostageToolStripMenuItem.Click
        FormShow(frmPostage)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgDialog.ShowMsgDlg("Do you want to Exit?", Me.Text, "Q") = Windows.Forms.DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        FormShow(frmPurchase)
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        FormShow(frmSupplier)
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReportToolStripMenuItem.Click
        FormShow(frmStockReport)
    End Sub

    Private Sub ReOrderStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReOrderStockToolStripMenuItem.Click
        FormShow(frmReOrderStock)
    End Sub
End Class