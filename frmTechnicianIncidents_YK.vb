Imports TechSupportData
Public Class frmTechnicianIncidents_YK
    Private Sub frmTechnicianIncidents_YK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            technicianComboBox.DisplayMember = "Name"
            technicianComboBox.ValueMember = "TechID"
            technicianComboBox.DataSource = TechnicianDB.GetTechnicianList
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub technicianComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles technicianComboBox.SelectedIndexChanged
        Try
            If technicianComboBox.SelectedIndex >= 0 Then
                Dim techId = technicianComboBox.SelectedValue
                Dim technician As Technician = TechnicianDB.GetTechnician(techId)
                Dim incidentList As List(Of Incident) = IncidentDB.GetOpenTechnicianIncidents(techId)

                If technician IsNot Nothing Then
                    emailTextBox.Text = technician.Email
                    phoneTextBox.Text = technician.Phone
                End If

                If incidentList IsNot Nothing And incidentList.Count > 0 Then
                    incidentsDataGridView.DataSource = incidentList

                    'incidentsDataGridView.Columns(0).Visible = False
                    'incidentsDataGridView.Columns(1).Visible = False
                    'incidentsDataGridView.Columns(2).Visible = False
                    'incidentsDataGridView.Columns(3).Visible = False
                    'incidentsDataGridView.Columns(5).Visible = False
                    'incidentsDataGridView.Columns(7).Visible = False
                Else
                    incidentsDataGridView.DataSource = Nothing
                    MessageBox.Show("Selected technician don't has any open incident.", "Information!")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub
End Class