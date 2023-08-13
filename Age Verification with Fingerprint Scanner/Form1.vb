Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class Login


    Public connectionString As String = "Data Source=localhost;database=age_verification;username=codebender;password=Admin@codebender1234"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = ColorTranslator.FromHtml("#01050F")
        Me.BackColor = bgColor
    End Sub



    Private Sub showPasswordBox_CheckedChanged(sender As Object, e As EventArgs) Handles showPasswordBox.CheckedChanged
        If showPasswordBox.Checked Then
            password.UseSystemPasswordChar = False
            showPasswordBox.Text = "Hide Password"
        Else
            password.UseSystemPasswordChar = True
            showPasswordBox.Text = "Show Password"
        End If
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        ' Check if the text box is empty
        If email.Text.Trim = "" Then
            ' Display the label with a message
            errorLabel.Text = "Email cannot be empty!"
            errorLabel.Visible = True
            Return

        End If

        ' Check if the text box is empty
        If password.Text.Trim = "" Then
            ' Display the label with a message
            errorLabel.Text = "Password cannot be empty!"
            errorLabel.Visible = True
            Return
        End If

        errorLabel.Visible = False

        Try
            Dim connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Connection is now open, and you can perform database operations here.

            Dim cmd As New MySqlCommand("SELECT * FROM admin WHERE email=@email AND Password=@password;", connection)

            cmd.Parameters.AddWithValue("@email", email.Text.Trim)
            cmd.Parameters.AddWithValue("@password", password.Text.Trim)

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim name As String = reader("name").ToString() ' Assuming "Name" is the column name in your database table

                ' Pass the name to the menuDialog form
                Dim menuDialog As New menuDialog(name)
                menuDialog.Show()
                Me.Hide()
            Else
                errorLabel.Text = "Wrong Username or Password"
                errorLabel.Visible = True
            End If

            connection.Close()

        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try

    End Sub



    Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged

    End Sub

    Private Sub errorLabel_Click(sender As Object, e As EventArgs) Handles errorLabel.Click

    End Sub
End Class
