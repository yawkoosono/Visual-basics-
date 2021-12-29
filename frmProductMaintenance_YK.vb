Public Class frmProductMaintenance_YK
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        ' update Products table on insert, edit or delete
        Try
            Me.Validate()
            Me.ProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet)
            MessageBox.Show("Products table updated successfully!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub
    ' load and display products
    Private Sub frmProductMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet.Products)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
