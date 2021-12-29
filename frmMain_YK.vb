Imports System.Windows.Forms

Public Class frmMain_YK
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaintainProducts2AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainProducts2AToolStripMenuItem.Click
        Dim frmProduct As New frmProductMaintenance_YK

        frmProduct.MdiParent = Me
        frmProduct.Show()

    End Sub

    Private Sub MaintainCustomers2BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainCustomers2BToolStripMenuItem.Click
        Dim frmCustomer As New frmCustomerMaintenance_YK

        frmCustomer.MdiParent = Me
        frmCustomer.Show()
    End Sub

    Private Sub DisplayIncidentsByProducts2CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayIncidentsByProducts2CToolStripMenuItem.Click
        Dim frmProductIncidents As New frmProductIncidents_YK

        frmProductIncidents.MdiParent = Me
        frmProductIncidents.Show()
    End Sub

    Private Sub DisplayOpenIncidents3AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayOpenIncidents3AToolStripMenuItem.Click
        Dim frmOpenInc As New frmOpenIncidents_YK

        frmOpenInc.MdiParent = Me
        frmOpenInc.Show()
    End Sub

    Private Sub CreateIncident3BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateIncident3BToolStripMenuItem.Click
        Dim frmCreateInc As New frmCreateIncident_YK

        frmCreateInc.MdiParent = Me
        frmCreateInc.Show()
    End Sub

    Private Sub UpdateIncident3CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateIncident3CToolStripMenuItem.Click
        Dim frmUpdateInc As New frmUpdateIncident_YK

        frmUpdateInc.Show()
    End Sub

    Private Sub DisplayOpenIncidentsByTechnician3DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Click
        Dim frmTechIncidents As New frmTechnicianIncidents_YK

        frmTechIncidents.Show()
    End Sub

    Private Sub MaintainRegistrations3EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainRegistrations3EToolStripMenuItem.Click
        Dim frmMaintainRegn As New frmMaintainRegistrations_YK

        frmMaintainRegn.MdiParent = Me
        frmMaintainRegn.Show()
    End Sub

    Private Sub frmMain_YK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
