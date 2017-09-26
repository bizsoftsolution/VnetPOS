Module Module1
    Public Stock_Opening As String = "'Products'"
    Public Stock_Inward As String = "'Purchase','ProccessReceipt','Opening Stock','SalesReturn'"
    Public Stock_Outward As String = "'Sales','ProccessIssue','PurchaseReturn'"

    Public CompName As String
    Public UserName As String
    Public UserType As String

    Public Function GetBillNo(ByVal JType As String, ByVal SupplierName As String) As ArrayList
        Try
            Dim RValue As New ArrayList
            Dim dv As DataView = GetBillInfo(JType, SupplierName)
            For i As Integer = 0 To dv.Count - 1
                RValue.Add(dv.Item(i)(0).ToString())
            Next
            Return RValue
        Catch e As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetBillInfo(ByVal JType As String, ByVal SupplierName As String) As DataView
        Dim Qry As String = ""
        If JType = "Payment" Then
            If SupplierName.Trim() <> "" Then SupplierName = " and (LFrom=N'" + SupplierName + "')"
            Qry = "SELECT Code, TotalAmount, PaidAmount, TotalAmount - PaidAmount AS BalanceAmount FROM (SELECT LReport2.RefNo AS Code, LReport2.DRAmount AS TotalAmount, ISNULL ((SELECT SUM(LReport1.CRAmount) AS Expr1 FROM LedgerReport AS LReport1 WHERE (LReport1.RefNo = LReport2.RefNo)), 0) AS PaidAmount FROM LedgerReport AS LReport2 WHERE (LTo = 'Credit')" + SupplierName + ") AS LReport where TotalAmount-PaidAmount>0"
            Return db.ExecuteQuery(Qry)
        Else
            If SupplierName.Trim() <> "" Then SupplierName = " and (LTo=N'" + SupplierName + "')"
            Qry = "SELECT Code, TotalAmount, PaidAmount, TotalAmount - PaidAmount AS BalanceAmount FROM (SELECT LReport2.RefNo AS Code, LReport2.CRAmount AS TotalAmount, ISNULL ((SELECT SUM(LReport1.DRAmount) AS Expr1 FROM LedgerReport AS LReport1 WHERE (LReport1.RefNo = LReport2.RefNo)), 0) AS PaidAmount FROM LedgerReport AS LReport2 WHERE (LFrom = 'Credit')" + SupplierName + ") AS LReport where TotalAmount-PaidAmount>0"
            Return db.ExecuteQuery(Qry)
        End If
    End Function

End Module
