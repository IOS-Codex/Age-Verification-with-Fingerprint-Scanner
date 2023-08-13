<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerOrganization
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerOrganization))
        Me.label6 = New System.Windows.Forms.Label()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.showPasswordBox = New System.Windows.Forms.CheckBox()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.regPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.regEmail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.regCuName = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Lato Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label6.Location = New System.Drawing.Point(43, 55)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(342, 35)
        Me.label6.TabIndex = 4
        Me.label6.Text = "Register an Organization"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(43, 469)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(45, 21)
        Me.errorLabel.TabIndex = 15
        Me.errorLabel.Text = "Error"
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.errorLabel.Visible = False
        '
        'showPasswordBox
        '
        Me.showPasswordBox.AutoSize = True
        Me.showPasswordBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.showPasswordBox.Location = New System.Drawing.Point(43, 357)
        Me.showPasswordBox.Name = "showPasswordBox"
        Me.showPasswordBox.Size = New System.Drawing.Size(108, 19)
        Me.showPasswordBox.TabIndex = 14
        Me.showPasswordBox.Text = "Show Password"
        Me.showPasswordBox.UseVisualStyleBackColor = True
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.Color.ForestGreen
        Me.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.registerButton.Location = New System.Drawing.Point(43, 408)
        Me.registerButton.Margin = New System.Windows.Forms.Padding(0)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(210, 43)
        Me.registerButton.TabIndex = 13
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(43, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Enter Password"
        '
        'regPassword
        '
        Me.regPassword.Location = New System.Drawing.Point(43, 328)
        Me.regPassword.Name = "regPassword"
        Me.regPassword.Size = New System.Drawing.Size(210, 23)
        Me.regPassword.TabIndex = 11
        Me.regPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(43, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter Email Address"
        '
        'regEmail
        '
        Me.regEmail.Location = New System.Drawing.Point(43, 234)
        Me.regEmail.Name = "regEmail"
        Me.regEmail.Size = New System.Drawing.Size(210, 23)
        Me.regEmail.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(366, 497)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(43, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Enter Company's Name"
        '
        'regCuName
        '
        Me.regCuName.Location = New System.Drawing.Point(43, 152)
        Me.regCuName.Name = "regCuName"
        Me.regCuName.Size = New System.Drawing.Size(210, 23)
        Me.regCuName.TabIndex = 17
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.DarkGray
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.backButton.Location = New System.Drawing.Point(504, 408)
        Me.backButton.Margin = New System.Windows.Forms.Padding(0)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(210, 43)
        Me.backButton.TabIndex = 19
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'registerOrganization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(763, 590)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.regCuName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.showPasswordBox)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.regPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.regEmail)
        Me.Controls.Add(Me.label6)
        Me.Name = "registerOrganization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Organization"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label6 As Label
    Friend WithEvents errorLabel As Label
    Friend WithEvents showPasswordBox As CheckBox
    Friend WithEvents registerButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents regPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents regEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents regCuName As TextBox
    Friend WithEvents backButton As Button
End Class
