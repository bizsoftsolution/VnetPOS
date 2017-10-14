Public Class DBTBOBJ

    'Common Obj
    Public AutoGeneration As JISTable = JISDb.Table("AutoGeneration")
    Public CompanyDetails As JISTable = JISDb.Table("CompanyDetails")
    Public UserAccount As JISTable = JISDb.Table("UserAccount")
    'Master Obj
    Public MemberRegistration As JISTable = JISDb.Table("MemberRegistration")
    Public Product As JISTable = JISDb.Table("Product")
    Public MemberRenew As JISTable = JISDb.Table("MemberRenewal")
    Public Supplier As JISTable = JISDb.Table("Supplier")
    'Transaction
    Public Journal As JISTable = JISDb.Table("Journal")
    Public Sales As JISTable = JISDb.Table("Sales")
    Public SalesDetails As JISTable = JISDb.Table("SalesDetails")
    Public Postage As JISTable = JISDb.Table("Postage")
    Public PostageDetails As JISTable = JISDb.Table("PostageDetails")
    Public Purchase As JISTable = JISDb.Table("Purchase")
    Public PurchaseDetails As JISTable = JISDb.Table("PurchaseDetails")
    'View
    Public ViewPostage As JISTable = JISDb.View("ViewPostage")
    Public ViewPostageDetails As JISTable = JISDb.View("ViewPostageDetails")
    Public ViewSales As JISTable = JISDb.View("ViewSales")
    Public ViewSalesDetails As JISTable = JISDb.View("ViewSalesDetails")
    Public ViewRenew As JISTable = JISDb.View("ViewMemberRenewal")
    Public ViewMemberRegistration As JISTable = JISDb.View("ViewMemberRegistration")
    Public ViewPurchase As JISTable = JISDb.View("ViewPurchase")
    Public ViewPurchaseDetails As JISTable = JISDb.View("ViewPurchaseDetails")

    Public ViewStock As JISTable = JISDb.View("ViewStock")

    Sub New()

    End Sub

    Public Function ExecuteQuery(ByVal Qry As String) As Object
        Return JISDb.ExecuteQuery(Qry)
    End Function
End Class
