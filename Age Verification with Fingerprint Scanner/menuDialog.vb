Imports System.ComponentModel
Imports System.Xml

Public Class menuDialog
    Inherits Form

    Public Sub New(ByVal name As String)
        InitializeComponent()

        ' Set the label's text to the passed name
        nameLabel.Text = "Welcome " + name

        ' Set the text alignment of the label
        nameLabel.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub menuDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = ColorTranslator.FromHtml("#01050F")
        Me.BackColor = bgColor
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        registerOrganization.ShowDialog()
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub enrollPersonButton_Click(sender As Object, e As EventArgs) Handles enrollPersonButton.Click
        enrollment.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        verification.ShowDialog()
    End Sub
End Class