<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verification))
        Me.StatusLine = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.RichTextBox()
        Me.Prompt = New System.Windows.Forms.TextBox()
        Me.vrFingerprint = New System.Windows.Forms.PictureBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label6 = New System.Windows.Forms.Label()
        CType(Me.vrFingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLine
        '
        Me.StatusLine.AutoSize = True
        Me.StatusLine.BackColor = System.Drawing.Color.Transparent
        Me.StatusLine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusLine.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusLine.Location = New System.Drawing.Point(65, 412)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(216, 21)
        Me.StatusLine.TabIndex = 56
        Me.StatusLine.Text = "Put your hand on the Scanner"
        '
        'StatusText
        '
        Me.StatusText.Location = New System.Drawing.Point(362, 195)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(653, 192)
        Me.StatusText.TabIndex = 55
        Me.StatusText.Text = ""
        '
        'Prompt
        '
        Me.Prompt.Enabled = False
        Me.Prompt.Location = New System.Drawing.Point(362, 135)
        Me.Prompt.Name = "Prompt"
        Me.Prompt.Size = New System.Drawing.Size(653, 23)
        Me.Prompt.TabIndex = 54
        '
        'vrFingerprint
        '
        Me.vrFingerprint.Location = New System.Drawing.Point(65, 135)
        Me.vrFingerprint.Name = "vrFingerprint"
        Me.vrFingerprint.Size = New System.Drawing.Size(232, 252)
        Me.vrFingerprint.TabIndex = 53
        Me.vrFingerprint.TabStop = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.DarkGray
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.backButton.Location = New System.Drawing.Point(805, 426)
        Me.backButton.Margin = New System.Windows.Forms.Padding(0)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(210, 43)
        Me.backButton.TabIndex = 48
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(481, 487)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Lato Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label6.Location = New System.Drawing.Point(55, 66)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(215, 35)
        Me.label6.TabIndex = 40
        Me.label6.Text = "Verify a Person"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1071, 590)
        Me.Controls.Add(Me.StatusLine)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.Prompt)
        Me.Controls.Add(Me.vrFingerprint)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label6)
        Me.Name = "verification"
        Me.Text = "Verification"
        CType(Me.vrFingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusLine As Label
    Friend WithEvents StatusText As RichTextBox
    Friend WithEvents Prompt As TextBox
    Friend WithEvents vrFingerprint As PictureBox
    Friend WithEvents backButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label6 As Label
End Class
