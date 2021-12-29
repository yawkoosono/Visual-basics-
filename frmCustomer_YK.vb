Public Class frmCustomer_YK
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id = Me.Tag

        Me.CustomersTableAdapter.FillCustomerByID(Me.TechSupportDataSet.Customers, id)

    End Sub
End Class