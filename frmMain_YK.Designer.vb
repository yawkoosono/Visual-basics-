<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain_YK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainProducts2AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainCustomers2BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainRegistrations3EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainTechnicians5GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCustomerByProduct5FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateIncident3BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateIncident3CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayOpenIncidents3AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayIncidentsByProducts2CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateMailingList5CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.MaintenanceToolStripMenuItem, Me.RegistrationToolStripMenuItem, Me.IncidentsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.ShowShortcutKeys = False
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "&Export Incidents (5-B)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintainProducts2AToolStripMenuItem, Me.MaintainCustomers2BToolStripMenuItem, Me.MaintainRegistrations3EToolStripMenuItem, Me.MaintainTechnicians5GToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'MaintainProducts2AToolStripMenuItem
        '
        Me.MaintainProducts2AToolStripMenuItem.Name = "MaintainProducts2AToolStripMenuItem"
        Me.MaintainProducts2AToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MaintainProducts2AToolStripMenuItem.Text = "Maintain &Products (2-A)"
        '
        'MaintainCustomers2BToolStripMenuItem
        '
        Me.MaintainCustomers2BToolStripMenuItem.Name = "MaintainCustomers2BToolStripMenuItem"
        Me.MaintainCustomers2BToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MaintainCustomers2BToolStripMenuItem.Text = "Maintain &Customers (2-B)"
        '
        'MaintainRegistrations3EToolStripMenuItem
        '
        Me.MaintainRegistrations3EToolStripMenuItem.Name = "MaintainRegistrations3EToolStripMenuItem"
        Me.MaintainRegistrations3EToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MaintainRegistrations3EToolStripMenuItem.Text = "Maintain &Registrations (3-E)"
        '
        'MaintainTechnicians5GToolStripMenuItem
        '
        Me.MaintainTechnicians5GToolStripMenuItem.Name = "MaintainTechnicians5GToolStripMenuItem"
        Me.MaintainTechnicians5GToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MaintainTechnicians5GToolStripMenuItem.Text = "Maintain &Technicians (5-G)"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayCustomerByProduct5FToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RegistrationToolStripMenuItem.Text = "&Registration"
        '
        'DisplayCustomerByProduct5FToolStripMenuItem
        '
        Me.DisplayCustomerByProduct5FToolStripMenuItem.Name = "DisplayCustomerByProduct5FToolStripMenuItem"
        Me.DisplayCustomerByProduct5FToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.DisplayCustomerByProduct5FToolStripMenuItem.Text = "Display Customer by Product (5-F)"
        '
        'IncidentsToolStripMenuItem
        '
        Me.IncidentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateIncident3BToolStripMenuItem, Me.UpdateIncident3CToolStripMenuItem, Me.DisplayOpenIncidents3AToolStripMenuItem, Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem, Me.DisplayIncidentsByProducts2CToolStripMenuItem, Me.CreateMailingList5CToolStripMenuItem, Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem, Me.DisplayIncidentsByCustomer5EToolStripMenuItem})
        Me.IncidentsToolStripMenuItem.Name = "IncidentsToolStripMenuItem"
        Me.IncidentsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.IncidentsToolStripMenuItem.Text = "&Incidents"
        '
        'CreateIncident3BToolStripMenuItem
        '
        Me.CreateIncident3BToolStripMenuItem.Name = "CreateIncident3BToolStripMenuItem"
        Me.CreateIncident3BToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.CreateIncident3BToolStripMenuItem.Text = "Create Incident (3-B)"
        '
        'UpdateIncident3CToolStripMenuItem
        '
        Me.UpdateIncident3CToolStripMenuItem.Name = "UpdateIncident3CToolStripMenuItem"
        Me.UpdateIncident3CToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.UpdateIncident3CToolStripMenuItem.Text = "Update Incident (3-C)"
        '
        'DisplayOpenIncidents3AToolStripMenuItem
        '
        Me.DisplayOpenIncidents3AToolStripMenuItem.Name = "DisplayOpenIncidents3AToolStripMenuItem"
        Me.DisplayOpenIncidents3AToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.DisplayOpenIncidents3AToolStripMenuItem.Text = "Display Open Incidents (3-A)"
        '
        'DisplayOpenIncidentsByTechnician3DToolStripMenuItem
        '
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Name = "DisplayOpenIncidentsByTechnician3DToolStripMenuItem"
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Text = "Display Open Incidents by Technician (3-D)"
        '
        'DisplayIncidentsByProducts2CToolStripMenuItem
        '
        Me.DisplayIncidentsByProducts2CToolStripMenuItem.Name = "DisplayIncidentsByProducts2CToolStripMenuItem"
        Me.DisplayIncidentsByProducts2CToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.DisplayIncidentsByProducts2CToolStripMenuItem.Text = "Display Incidents by Product (2-C)"
        '
        'CreateMailingList5CToolStripMenuItem
        '
        Me.CreateMailingList5CToolStripMenuItem.Name = "CreateMailingList5CToolStripMenuItem"
        Me.CreateMailingList5CToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.CreateMailingList5CToolStripMenuItem.Text = "Create Mailing List (5-C)"
        '
        'DisplayIncidentsByProductAndTechnician5DToolStripMenuItem
        '
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem.Name = "DisplayIncidentsByProductAndTechnician5DToolStripMenuItem"
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem.Text = "Display Incidents by Product and Technician (5-D)"
        '
        'DisplayIncidentsByCustomer5EToolStripMenuItem
        '
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem.Name = "DisplayIncidentsByCustomer5EToolStripMenuItem"
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem.Size = New System.Drawing.Size(336, 22)
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem.Text = "Display Incidents by Customer (5-E)"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(78, 17)
        Me.ToolStripStatusLabel.Text = "Yaw Koosono"
        '
        'frmMain_YK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain_YK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SportsPro System Project 3E_YK"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintainProducts2AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintainCustomers2BToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintainRegistrations3EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintainTechnicians5GToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayCustomerByProduct5FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateIncident3BToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateIncident3CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayOpenIncidents3AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayOpenIncidentsByTechnician3DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayIncidentsByProducts2CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateMailingList5CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayIncidentsByProductAndTechnician5DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayIncidentsByCustomer5EToolStripMenuItem As ToolStripMenuItem
End Class
