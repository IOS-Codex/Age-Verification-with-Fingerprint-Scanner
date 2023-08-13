<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuDialog))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.enrollPersonButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(343, 469)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Lato Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.nameLabel.Location = New System.Drawing.Point(156, 105)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(140, 35)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.Text = "Welcome"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'enrollPersonButton
        '
        Me.enrollPersonButton.BackColor = System.Drawing.Color.ForestGreen
        Me.enrollPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enrollPersonButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.enrollPersonButton.Location = New System.Drawing.Point(86, 230)
        Me.enrollPersonButton.Margin = New System.Windows.Forms.Padding(0)
        Me.enrollPersonButton.Name = "enrollPersonButton"
        Me.enrollPersonButton.Size = New System.Drawing.Size(210, 43)
        Me.enrollPersonButton.TabIndex = 7
        Me.enrollPersonButton.Text = "Enroll a Person"
        Me.enrollPersonButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(437, 230)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Verify a Person"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(86, 350)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 43)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Register an Organization"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'logoutButton
        '
        Me.logoutButton.BackColor = System.Drawing.Color.DarkGray
        Me.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.logoutButton.Location = New System.Drawing.Point(437, 350)
        Me.logoutButton.Margin = New System.Windows.Forms.Padding(0)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(210, 43)
        Me.logoutButton.TabIndex = 20
        Me.logoutButton.Text = "Log Out"
        Me.logoutButton.UseVisualStyleBackColor = False
        '
        'menuDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(763, 590)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.enrollPersonButton)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "menuDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents enrollPersonButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents logoutButton As Button
End Class
