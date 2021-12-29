<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateIncident_YK
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
        Me.customerComboBox = New System.Windows.Forms.ComboBox()
        Me.productComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.createIncidentButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer:"
        '
        'customerComboBox
        '
        Me.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customerComboBox.FormattingEnabled = True
        Me.customerComboBox.Location = New System.Drawing.Point(93, 24)
        Me.customerComboBox.Name = "customerComboBox"
        Me.customerComboBox.Size = New System.Drawing.Size(358, 21)
        Me.customerComboBox.TabIndex = 1
        '
        'productComboBox
        '
        Me.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.productComboBox.FormattingEnabled = True
        Me.productComboBox.Location = New System.Drawing.Point(93, 60)
        Me.productComboBox.Name = "productComboBox"
        Me.productComboBox.Size = New System.Drawing.Size(358, 21)
        Me.productComboBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Title:"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(93, 97)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(358, 20)
        Me.titleTextBox.TabIndex = 5
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(93, 132)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(358, 137)
        Me.descriptionTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Description:"
        '
        'createIncidentButton
        '
        Me.createIncidentButton.Location = New System.Drawing.Point(93, 275)
        Me.createIncidentButton.Name = "createIncidentButton"
        Me.createIncidentButton.Size = New System.Drawing.Size(132, 23)
        Me.createIncidentButton.TabIndex = 8
        Me.createIncidentButton.Text = "Create Incident"
        Me.createIncidentButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(351, 275)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(100, 23)
        Me.cancelButton.TabIndex = 9
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'frmCreateIncident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 317)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.createIncidentButton)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.productComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.customerComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCreateIncident"
        Me.Text = "Create Incident"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents customerComboBox As ComboBox
    Friend WithEvents productComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents createIncidentButton As Button
    Friend WithEvents cancelButton As Button
End Class
