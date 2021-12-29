Imports TechSupportData
Public Class Validator
    Public Shared Function IsPresent(ByVal textBox As TextBox, ByVal name As String) As Boolean

        If String.IsNullOrEmpty(textBox.Text) Then
            MessageBox.Show(name & " can't be empty.", "Input Required")
            textBox.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsSelected(ByVal comboBox As ComboBox, ByVal name As String) As Boolean

        If comboBox.SelectedIndex < 0 Then
            MessageBox.Show($"Please select a {name}.", "Selection Required")
            comboBox.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsInt32(ByVal textBox As TextBox, ByVal name As String) As Boolean
        Dim id As Integer

        If Integer.TryParse(textBox.Text, id) Then
            Return True
        Else
            MessageBox.Show(name & " must be an integer.", "Invalid Input")
            textBox.Focus()
            textBox.SelectAll()
            Return False
        End If

        Return True
    End Function

    Public Shared Function HasRegistered(ByVal customerID As Integer,
                                         ByVal productCode As String)
        Return RegistrationDB.ProductRegistered(customerID, productCode)
    End Function
End Class
