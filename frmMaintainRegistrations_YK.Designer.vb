<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintainRegistrations_YK
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
        Me.registerButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'customerComboBox
        '
        Me.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customerComboBox.FormattingEnabled = True
        Me.customerComboBox.Location = New System.Drawing.Point(36, 67)
        Me.customerComboBox.Name = "customerComboBox"
        Me.customerComboBox.Size = New System.Drawing.Size(250, 21)
        Me.customerComboBox.TabIndex = 1
        '
        'productComboBox
        '
        Me.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.productComboBox.FormattingEnabled = True
        Me.productComboBox.Location = New System.Drawing.Point(353, 67)
        Me.productComboBox.Name = "productComboBox"
        Me.productComboBox.Size = New System.Drawing.Size(250, 21)
        Me.productComboBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product:"
        '
        'registerButton
        '
        Me.registerButton.Location = New System.Drawing.Point(36, 138)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(150, 40)
        Me.registerButton.TabIndex = 4
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(453, 138)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(150, 40)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'frmMaintainRegistrations_YK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 249)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.productComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.customerComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMaintainRegistrations_YK"
        Me.Text = "Maintain Product Registrations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents customerComboBox As ComboBox
    Friend WithEvents productComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents registerButton As Button
    Friend WithEvents exitButton As Button
End Class
