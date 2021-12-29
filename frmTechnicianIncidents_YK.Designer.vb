<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechnicianIncidents_YK
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.technicianComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.incidentsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.incidentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Technician:"
        '
        'technicianComboBox
        '
        Me.technicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.technicianComboBox.FormattingEnabled = True
        Me.technicianComboBox.Location = New System.Drawing.Point(91, 22)
        Me.technicianComboBox.Name = "technicianComboBox"
        Me.technicianComboBox.Size = New System.Drawing.Size(273, 21)
        Me.technicianComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Phone:"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(91, 49)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.ReadOnly = True
        Me.emailTextBox.Size = New System.Drawing.Size(273, 20)
        Me.emailTextBox.TabIndex = 4
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Location = New System.Drawing.Point(91, 75)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.ReadOnly = True
        Me.phoneTextBox.Size = New System.Drawing.Size(121, 20)
        Me.phoneTextBox.TabIndex = 5
        '
        'incidentsDataGridView
        '
        Me.incidentsDataGridView.AllowUserToAddRows = False
        Me.incidentsDataGridView.AllowUserToDeleteRows = False
        Me.incidentsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.incidentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.incidentsDataGridView.Location = New System.Drawing.Point(25, 134)
        Me.incidentsDataGridView.Name = "incidentsDataGridView"
        Me.incidentsDataGridView.ReadOnly = True
        Me.incidentsDataGridView.Size = New System.Drawing.Size(745, 288)
        Me.incidentsDataGridView.TabIndex = 6
        '
        'frmTechnicianIncidents_YK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.incidentsDataGridView)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.technicianComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTechnicianIncidents_YK"
        Me.Text = "Open Incidents by Technician"
        CType(Me.incidentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents technicianComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents incidentsDataGridView As DataGridView
End Class
