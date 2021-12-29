Imports TechSupportData
Public Class frmUpdateIncident_YK
    Dim incident As Incident = Nothing
    Const MAX_DESC_LENGTH As Integer = 2000
    Private Sub getIncidentButton_Click(sender As Object, e As EventArgs) Handles getIncidentButton.Click
        Try
            If Not Validator.IsPresent(incidentIdTextBox, "Incident ID") Then
                Return
            End If
            If Not Validator.IsInt32(incidentIdTextBox, "Incident ID") Then
                Return
            End If
            Dim id As Integer = CInt(incidentIdTextBox.Text)

            incident = IncidentDB.GetIncident(id)

            If incident Is Nothing Then
                MessageBox.Show("No incident found by given incident id.", "Not found")
                incidentIdTextBox.Focus()
            ElseIf incident.DateClosed.HasValue Then
                MessageBox.Show("Its a closed incident id.", "Closed Incident")
                incident = Nothing
                incidentIdTextBox.Focus()
            Else
                textToAddTextBox.Enabled = True
                updateButton.Enabled = True
                closeIncidentButton.Enabled = True

                customerTextBox.Text = incident.CustomerName
                productTextBox.Text = incident.ProductName
                technicianTextBox.Text = incident.TechName
                titleTextBox.Text = incident.Title
                dateOpenedTextBox.Text = incident.DateOpened.ToShortDateString
                descriptionTextBox.Text = incident.Description

                getIncidentButton.Enabled = False
                incidentIdTextBox.Enabled = False

                textToAddTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try


    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Try
            If Not Validator.IsPresent(textToAddTextBox, "Text to add") Then
                Return
            End If

            Dim newDescription = descriptionTextBox.Text & vbNewLine &
                "<" & DateTime.Today.ToShortDateString & "> " &
                textToAddTextBox.Text

            If newDescription.Length > MAX_DESC_LENGTH Then
                Dim result = MessageBox.Show("Description length can't be more than " & MAX_DESC_LENGTH & " characters." &
                                             vbNewLine & "Want to truncate?", "Confirm truncation", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    newDescription = newDescription.Substring(0, MAX_DESC_LENGTH)
                Else
                    MessageBox.Show("Cancelling the update process", "Cancel Update")
                    ResetForm()
                    Return
                End If
            End If

            If IncidentDB.UpdateIncident(incident, newDescription) Then
                MessageBox.Show("Update done successfully", "Update Incident")
                descriptionTextBox.Text = newDescription
            Else
                MessageBox.Show("Update failed", "Update Incident")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try

        textToAddTextBox.Clear()
    End Sub

    Private Sub closeIncidentButton_Click(sender As Object, e As EventArgs) Handles closeIncidentButton.Click
        Try
            Dim result = MessageBox.Show("Are you sure want to close the incident?",
                                         "Confirm close", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                If IncidentDB.CloseIncident(incident) Then
                    MessageBox.Show("Incident has been closed successfully.", "Closed Incident")
                    Me.Close()
                Else
                    MessageBox.Show("Incident has not been closed successfully.", "Closed Incident")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub ResetForm()
        incidentIdTextBox.Clear()
        customerTextBox.Clear()
        productTextBox.Clear()
        technicianTextBox.Clear()
        titleTextBox.Clear()
        dateOpenedTextBox.Clear()
        descriptionTextBox.Clear()
        textToAddTextBox.Clear()

        getIncidentButton.Enabled = True
        incidentIdTextBox.Enabled = True

        textToAddTextBox.Enabled = False
        updateButton.Enabled = False
        closeIncidentButton.Enabled = False

        incidentIdTextBox.Focus()
    End Sub
End Class