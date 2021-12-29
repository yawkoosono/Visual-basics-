<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateIncident_YK
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
        Me.incidentIdTextBox = New System.Windows.Forms.TextBox()
        Me.getIncidentButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customerTextBox = New System.Windows.Forms.TextBox()
        Me.productTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.technicianTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateOpenedTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textToAddTextBox = New System.Windows.Forms.TextBox()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.closeIncidentButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Incident ID:"
        '
        'incidentIdTextBox
        '
        Me.incidentIdTextBox.Location = New System.Drawing.Point(104, 24)
        Me.incidentIdTextBox.Name = "incidentIdTextBox"
        Me.incidentIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.incidentIdTextBox.TabIndex = 1
        '
        'getIncidentButton
        '
        Me.getIncidentButton.Location = New System.Drawing.Point(210, 22)
        Me.getIncidentButton.Name = "getIncidentButton"
        Me.getIncidentButton.Size = New System.Drawing.Size(101, 23)
        Me.getIncidentButton.TabIndex = 2
        Me.getIncidentButton.Text = "Get Incident"
        Me.getIncidentButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer:"
        '
        'customerTextBox
        '
        Me.customerTextBox.Location = New System.Drawing.Point(104, 77)
        Me.customerTextBox.Name = "customerTextBox"
        Me.customerTextBox.ReadOnly = True
        Me.customerTextBox.Size = New System.Drawing.Size(358, 20)
        Me.customerTextBox.TabIndex = 4
        '
        'productTextBox
        '
        Me.productTextBox.Location = New System.Drawing.Point(104, 112)
        Me.productTextBox.Name = "productTextBox"
        Me.productTextBox.ReadOnly = True
        Me.productTextBox.Size = New System.Drawing.Size(358, 20)
        Me.productTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product:"
        '
        'technicianTextBox
        '
        Me.technicianTextBox.Location = New System.Drawing.Point(104, 148)
        Me.technicianTextBox.Name = "technicianTextBox"
        Me.technicianTextBox.ReadOnly = True
        Me.technicianTextBox.Size = New System.Drawing.Size(358, 20)
        Me.technicianTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Technician:"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(104, 184)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.ReadOnly = True
        Me.titleTextBox.Size = New System.Drawing.Size(358, 20)
        Me.titleTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Title:"
        '
        'dateOpenedTextBox
        '
        Me.dateOpenedTextBox.Location = New System.Drawing.Point(104, 221)
        Me.dateOpenedTextBox.Name = "dateOpenedTextBox"
        Me.dateOpenedTextBox.ReadOnly = True
        Me.dateOpenedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.dateOpenedTextBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date Opened:"
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(104, 257)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.ReadOnly = True
        Me.descriptionTextBox.Size = New System.Drawing.Size(358, 100)
        Me.descriptionTextBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Description:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Text to add:"
        '
        'textToAddTextBox
        '
        Me.textToAddTextBox.Enabled = False
        Me.textToAddTextBox.Location = New System.Drawing.Point(104, 374)
        Me.textToAddTextBox.Multiline = True
        Me.textToAddTextBox.Name = "textToAddTextBox"
        Me.textToAddTextBox.Size = New System.Drawing.Size(358, 100)
        Me.textToAddTextBox.TabIndex = 16
        '
        'updateButton
        '
        Me.updateButton.Enabled = False
        Me.updateButton.Location = New System.Drawing.Point(104, 480)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(100, 23)
        Me.updateButton.TabIndex = 17
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'closeIncidentButton
        '
        Me.closeIncidentButton.Enabled = False
        Me.closeIncidentButton.Location = New System.Drawing.Point(210, 480)
        Me.closeIncidentButton.Name = "closeIncidentButton"
        Me.closeIncidentButton.Size = New System.Drawing.Size(146, 23)
        Me.closeIncidentButton.TabIndex = 18
        Me.closeIncidentButton.Text = "Close Incident"
        Me.closeIncidentButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(362, 480)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(100, 23)
        Me.cancelButton.TabIndex = 19
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'frmUpdateIncident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 529)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.closeIncidentButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.textToAddTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dateOpenedTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.technicianTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.productTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.customerTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.getIncidentButton)
        Me.Controls.Add(Me.incidentIdTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUpdateIncident"
        Me.Text = "Update Incident"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents incidentIdTextBox As TextBox
    Friend WithEvents getIncidentButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents customerTextBox As TextBox
    Friend WithEvents productTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents technicianTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dateOpenedTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textToAddTextBox As TextBox
    Friend WithEvents updateButton As Button
    Friend WithEvents closeIncidentButton As Button
    Friend WithEvents cancelButton As Button
End Class
