<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrollment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enrollment))
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enrollName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.enrollDOB = New System.Windows.Forms.DateTimePicker()
        Me.genderBox = New System.Windows.Forms.ComboBox()
        Me.bloodGroupBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbFingerprint = New System.Windows.Forms.PictureBox()
        Me.Prompt = New System.Windows.Forms.TextBox()
        Me.StatusText = New System.Windows.Forms.RichTextBox()
        Me.StatusLine = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.DarkGray
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.backButton.Location = New System.Drawing.Point(799, 409)
        Me.backButton.Margin = New System.Windows.Forms.Padding(0)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(210, 43)
        Me.backButton.TabIndex = 31
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(49, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Name"
        '
        'enrollName
        '
        Me.enrollName.Location = New System.Drawing.Point(49, 127)
        Me.enrollName.Name = "enrollName"
        Me.enrollName.Size = New System.Drawing.Size(210, 23)
        Me.enrollName.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(519, 487)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(49, 470)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(45, 21)
        Me.errorLabel.TabIndex = 27
        Me.errorLabel.Text = "Error"
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.errorLabel.Visible = False
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.Color.ForestGreen
        Me.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.registerButton.Location = New System.Drawing.Point(49, 409)
        Me.registerButton.Margin = New System.Windows.Forms.Padding(0)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(210, 43)
        Me.registerButton.TabIndex = 25
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(49, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(49, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Date of Birth"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Lato Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label6.Location = New System.Drawing.Point(49, 49)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(213, 35)
        Me.label6.TabIndex = 20
        Me.label6.Text = "Enroll a Person"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'enrollDOB
        '
        Me.enrollDOB.Checked = False
        Me.enrollDOB.Location = New System.Drawing.Point(49, 200)
        Me.enrollDOB.Name = "enrollDOB"
        Me.enrollDOB.ShowCheckBox = True
        Me.enrollDOB.Size = New System.Drawing.Size(210, 23)
        Me.enrollDOB.TabIndex = 32
        '
        'genderBox
        '
        Me.genderBox.FormattingEnabled = True
        Me.genderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.genderBox.Location = New System.Drawing.Point(49, 273)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(210, 23)
        Me.genderBox.TabIndex = 33
        '
        'bloodGroupBox
        '
        Me.bloodGroupBox.FormattingEnabled = True
        Me.bloodGroupBox.Items.AddRange(New Object() {"AA", "AC", "AS", "SC", "SS"})
        Me.bloodGroupBox.Location = New System.Drawing.Point(52, 347)
        Me.bloodGroupBox.Name = "bloodGroupBox"
        Me.bloodGroupBox.Size = New System.Drawing.Size(210, 23)
        Me.bloodGroupBox.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(52, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Blood Group"
        '
        'pbFingerprint
        '
        Me.pbFingerprint.Location = New System.Drawing.Point(344, 118)
        Me.pbFingerprint.Name = "pbFingerprint"
        Me.pbFingerprint.Size = New System.Drawing.Size(232, 252)
        Me.pbFingerprint.TabIndex = 36
        Me.pbFingerprint.TabStop = False
        '
        'Prompt
        '
        Me.Prompt.Enabled = False
        Me.Prompt.Location = New System.Drawing.Point(636, 118)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.Size = New System.Drawing.Size(373, 23)
        Me.Prompt.TabIndex = 37
        '
        'StatusText
        '
        Me.StatusText.Location = New System.Drawing.Point(636, 178)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(373, 181)
        Me.StatusText.TabIndex = 38
        Me.StatusText.Text = ""
        '
        'StatusLine
        '
        Me.StatusLine.AutoSize = True
        Me.StatusLine.BackColor = System.Drawing.Color.Transparent
        Me.StatusLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusLine.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusLine.Location = New System.Drawing.Point(344, 395)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(98, 21)
        Me.StatusLine.TabIndex = 39
        Me.StatusLine.Text = "Blood Group"
        '
        'enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1071, 590)
        Me.Controls.Add(Me.StatusLine)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.Prompt)
        Me.Controls.Add(Me.pbFingerprint)
        Me.Controls.Add(Me.bloodGroupBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.genderBox)
        Me.Controls.Add(Me.enrollDOB)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.enrollName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label6)
        Me.Name = "enrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enrollment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents enrollName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents errorLabel As Label
    Friend WithEvents registerButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents enrollDOB As DateTimePicker
    Friend WithEvents genderBox As ComboBox
    Friend WithEvents bloodGroupBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbFingerprint As PictureBox
    Friend WithEvents Prompt As TextBox
    Friend WithEvents StatusText As RichTextBox
    Friend WithEvents StatusLine As Label
End Class
