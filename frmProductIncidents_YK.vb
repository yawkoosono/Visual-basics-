Public Class frmProductIncidents_YK
    Private Sub frmProductIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IncidentsTableAdapter.Fill(Me.TechSupportDataSet.Incidents)
        Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet.Products)

    End Sub

    Private Sub IncidentsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IncidentsDataGridView.CellContentClick
        Dim incidentId = IncidentsDataGridView.Item(1, e.RowIndex).Value

        Dim frmCust As New frmCustomer_YK
        frmCust.Tag = incidentId
        frmCust.Show()
    End Sub
End Class