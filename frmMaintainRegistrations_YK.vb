Imports TechSupportData
Public Class frmMaintainRegistrations_YK
    Private Sub frmMaintainRegistrations_YK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim customerList As List(Of Customer)
            Dim productList As List(Of Product)

            customerList = CustomerDB.GetCustomerList
            customerComboBox.DataSource = customerList
            customerComboBox.DisplayMember = "Name"
            customerComboBox.ValueMember = "CustomerID"

            productList = ProductDB.GetProductList
            productComboBox.DataSource = productList
            productComboBox.DisplayMember = "Name"
            productComboBox.ValueMember = "ProductCode"

            ResetControls()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        Try
            If Validator.IsSelected(customerComboBox, "Customer") AndAlso
               Validator.IsSelected(productComboBox, "Product") Then

                Dim custID As Integer = customerComboBox.SelectedValue
                Dim productCode As String = productComboBox.SelectedValue

                If Validator.HasRegistered(custID, productCode) Then
                    MessageBox.Show("Customer has already registered with selected product.",
                                    "Duplicate Registration!")
                Else
                    Dim regn As New Registration
                    regn.CustomerID = custID
                    regn.ProductCode = productCode
                    regn.RegistrationDate = Date.Today

                    RegistrationDB.AddRegistration(regn)

                    MessageBox.Show("The registration has been created.", "Regn Success")
                End If

                ResetControls()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ResetControls()
        customerComboBox.SelectedIndex = -1
        productComboBox.SelectedIndex = -1
    End Sub
End Class