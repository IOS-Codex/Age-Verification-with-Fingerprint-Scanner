<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.showPasswordBox = New System.Windows.Forms.CheckBox()
        Me.errorLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(300, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(159, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PASS LOCK INC."
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(247, 303)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(210, 23)
        Me.email.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(283, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter your Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(295, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter your Password"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(247, 397)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(210, 23)
        Me.password.TabIndex = 4
        Me.password.UseSystemPasswordChar = True
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.ForestGreen
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.loginButton.Location = New System.Drawing.Point(247, 477)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(0)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(210, 43)
        Me.loginButton.TabIndex = 6
        Me.loginButton.Text = "Log In"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'showPasswordBox
        '
        Me.showPasswordBox.AutoSize = True
        Me.showPasswordBox.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.showPasswordBox.Location = New System.Drawing.Point(298, 426)
        Me.showPasswordBox.Name = "showPasswordBox"
        Me.showPasswordBox.Size = New System.Drawing.Size(108, 19)
        Me.showPasswordBox.TabIndex = 7
        Me.showPasswordBox.Text = "Show Password"
        Me.showPasswordBox.UseVisualStyleBackColor = True
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(247, 538)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(45, 21)
        Me.errorLabel.TabIndex = 8
        Me.errorLabel.Text = "Error"
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.errorLabel.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(763, 590)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.showPasswordBox)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents showPasswordBox As CheckBox
    Friend WithEvents errorLabel As Label
End Class
