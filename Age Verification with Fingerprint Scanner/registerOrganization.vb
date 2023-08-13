Imports MySql.Data.MySqlClient

Public Class registerOrganization


    Private Sub registerOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = ColorTranslator.FromHtml("#01050F")
        Me.BackColor = bgColor
    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click

        ' Check if the text box is empty
        If regCuName.Text.Trim = "" Then
            ' Display the label with a message
            errorLabel.Text = "Company's Name cannot be empty!"
            errorLabel.Visible = True
            Return

        End If

        ' Check if the text box is empty
        If regEmail.Text.Trim = "" Then
            ' Display the label with a message
            errorLabel.Text = "Email cannot be empty!"
            errorLabel.Visible = True
            Return

        End If

        ' Check if the text box is empty
        If regPassword.Text.Trim = "" Then
            ' Display the label with a message
            errorLabel.Text = "Password cannot be empty!"
            errorLabel.Visible = True
            Return
        End If

        errorLabel.Visible = False

        Dim name As String = regCuName.Text
        Dim email As String = regEmail.Text
        Dim password As String = regPassword.Text

        Using connection As New MySqlConnection(Login.connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO admin (name, email, password) VALUES (@name, @email, @password)"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@password", password)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Organisation registered successfully!")
                Else
                    MessageBox.Show("Organisation registration failed, Try Again")
                End If
            End Using

            connection.Close()
        End Using

    End Sub

    Private Sub showPasswordBox_CheckedChanged(sender As Object, e As EventArgs) Handles showPasswordBox.CheckedChanged
        If showPasswordBox.Checked Then
            regPassword.UseSystemPasswordChar = False
            showPasswordBox.Text = "Hide Password"
        Else
            regPassword.UseSystemPasswordChar = True
            showPasswordBox.Text = "Show Password"
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub
End Class