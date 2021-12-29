<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenIncidents_YK
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
        Me.openIncidentsListView = New System.Windows.Forms.ListView()
        Me.ProductCodeCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateOpenedCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TechnicianCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TitleCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'openIncidentsListView
        '
        Me.openIncidentsListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.openIncidentsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductCodeCol, Me.DateOpenedCol, Me.CustomerCol, Me.TechnicianCol, Me.TitleCol})
        Me.openIncidentsListView.HideSelection = False
        Me.openIncidentsListView.Location = New System.Drawing.Point(12, 12)
        Me.openIncidentsListView.Name = "openIncidentsListView"
        Me.openIncidentsListView.Size = New System.Drawing.Size(710, 287)
        Me.openIncidentsListView.TabIndex = 0
        Me.openIncidentsListView.UseCompatibleStateImageBehavior = False
        Me.openIncidentsListView.View = System.Windows.Forms.View.Details
        '
        'ProductCodeCol
        '
        Me.ProductCodeCol.Text = "Product Code"
        Me.ProductCodeCol.Width = 100
        '
        'DateOpenedCol
        '
        Me.DateOpenedCol.Text = "Date Opened"
        Me.DateOpenedCol.Width = 100
        '
        'CustomerCol
        '
        Me.CustomerCol.Text = "Customer"
        Me.CustomerCol.Width = 150
        '
        'TechnicianCol
        '
        Me.TechnicianCol.Text = "Technician"
        Me.TechnicianCol.Width = 150
        '
        'TitleCol
        '
        Me.TitleCol.Text = "Title"
        Me.TitleCol.Width = 200
        '
        'frmOpenIncidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 311)
        Me.Controls.Add(Me.openIncidentsListView)
        Me.Name = "frmOpenIncidents"
        Me.Text = "Open Incidents"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents openIncidentsListView As ListView
    Friend WithEvents ProductCodeCol As ColumnHeader
    Friend WithEvents DateOpenedCol As ColumnHeader
    Friend WithEvents CustomerCol As ColumnHeader
    Friend WithEvents TechnicianCol As ColumnHeader
    Friend WithEvents TitleCol As ColumnHeader
End Class
