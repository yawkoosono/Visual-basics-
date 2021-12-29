Imports TechSupportData
Public Class frmCreateIncident_YK
    Private Sub frmCreateIncident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            customerComboBox.DataSource = CustomerDB.GetCustomerList
            customerComboBox.DisplayMember = "Name"
            customerComboBox.ValueMember = "CustomerID"

            productComboBox.DataSource = ProductDB.GetProductList
            productComboBox.DisplayMember = "Name"
            productComboBox.ValueMember = "ProductCode"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub createIncidentButton_Click(sender As Object, e As EventArgs) Handles createIncidentButton.Click
        Try
            Dim custId = customerComboBox.SelectedValue
            Dim productCode = productComboBox.SelectedValue

            If RegistrationDB.ProductRegistered(custId, productCode) Then
                If Validator.IsPresent(titleTextBox, "Title") And
                    Validator.IsPresent(descriptionTextBox, "Description") Then

                    Dim incident As New Incident
                    incident.CustomerID = custId
                    incident.ProductCode = productCode
                    incident.Title = titleTextBox.Text
                    incident.Description = descriptionTextBox.Text

                    IncidentDB.AddIncident(incident)

                    MessageBox.Show("New Incident has been added successfully.", "Incident Saved")
                    Me.Close()
                End If
            Else
                MessageBox.Show("Customer has not been registered for selected product.", "Not Registered!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
End Class