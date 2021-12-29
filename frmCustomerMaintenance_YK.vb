Public Class frmCustomerMaintenance_YK
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CustomersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet)

            MessageBox.Show("Customers table has been updated successfully.")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmCustomerMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.StatesTableAdapter.Fill(Me.TechSupportDataSet.States)
            Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet.Customers)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet.Customers)
        SearchToolStripTextBox.Clear()

        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        BindingNavigatorMoveNextItem.Enabled = True
        BindingNavigatorMoveLastItem.Enabled = True
        BindingNavigatorPositionItem.Enabled = True
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CustomerIDTextBox.Clear()
    End Sub

    Private Sub GetCustomerToolStripButton_Click(sender As Object, e As EventArgs) Handles GetCustomerToolStripButton.Click
        Try
            If (String.IsNullOrEmpty(SearchToolStripTextBox.Text)) Then
                MessageBox.Show("Please enter customer ID to search.")
            Else
                Dim custId = Convert.ToInt32(SearchToolStripTextBox.Text)
                Me.CustomersTableAdapter.FillCustomerByID(Me.TechSupportDataSet.Customers, custId)

                BindingNavigatorMoveFirstItem.Enabled = False
                BindingNavigatorMovePreviousItem.Enabled = False
                BindingNavigatorMoveNextItem.Enabled = False
                BindingNavigatorMoveLastItem.Enabled = False
                BindingNavigatorPositionItem.Enabled = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class