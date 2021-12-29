Imports TechSupportData
Public Class frmOpenIncidents_YK
    Private Sub frmOpenIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim incidentList As List(Of Incident)

        Try
            incidentList = IncidentDB.GetOpenIncidents

            If incidentList.Count > 0 Then
                Dim incident As Incident

                For i As Integer = 0 To incidentList.Count - 1
                    incident = incidentList(i)

                    openIncidentsListView.Items.Add(incident.ProductCode)

                    openIncidentsListView.Items(i).SubItems.Add(CDate(incident.DateOpened).ToShortDateString)
                    openIncidentsListView.Items(i).SubItems.Add(incident.CustomerName)
                    openIncidentsListView.Items(i).SubItems.Add(incident.TechName)
                    openIncidentsListView.Items(i).SubItems.Add(incident.Title)
                Next

            Else
                MessageBox.Show("All incidents are closed.", "No data found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub
End Class