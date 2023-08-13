Imports System.ComponentModel
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient

Public Class verification

    Implements DPFP.Capture.EventHandler
    Delegate Sub FunctionCall(ByVal param)
    Private Capturer As DPFP.Capture.Capture
    Private Verificator As DPFP.Verification.Verification
    Public Enroller As DPFP.Processing.Enrollment
    Private Template As DPFP.Template
    Private tttemplate As List(Of DPFP.Template)

    Private Sub verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = ColorTranslator.FromHtml("#01050F")
        Me.BackColor = bgColor

        Init()
        StartCapture()

    End Sub

    Protected Overridable Sub Init()
        Try

            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.
            Verificator = New DPFP.Verification.Verification()

            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else

            End If

        Catch ex As DPFP.Error.SDKException
            ' MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "XTech")
        End Try
    End Sub

    Public Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()

            Catch ex As DPFP.Error.SDKException
                'SetPrompt("Can't initiate capture!")
                MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "XTech")
            End Try
        End If
    End Sub

    Protected Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        MakeReport("The fingerprint sample was captured.")
        Process(Sample)
    End Sub


    Protected Sub Process(ByVal Sample As DPFP.Sample)

        Processs(Sample)

        ' Establish a connection to the MySQL database

        Dim connection As New MySqlConnection(Login.connectionString)
        connection.Open()

        ' Process the sample and create a feature set for the verification
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

        Dim matchFound As Boolean = False

        If Not features Is Nothing Then
            ' Retrieve fingerprint templates from the database
            Dim selectQuery As String = "SELECT name, gender, dateOfBirth, bloodGroup, fingerprintTemplate1 FROM person;"
            Dim selectCommand As New MySqlCommand(selectQuery, connection)
            Dim reader As MySqlDataReader = selectCommand.ExecuteReader()

            While reader.Read()
                Dim name As String = reader("name").ToString()
                Dim gender As String = reader("gender").ToString()
                Dim dateOfBirth As Date = Convert.ToDateTime(reader("dateOfBirth"))
                Dim bloodGroup As String = reader("bloodGroup").ToString()
                Dim templateBytes As Byte() = DirectCast(reader("fingerprintTemplate1"), Byte())

                Dim template As New DPFP.Template()
                Using ms As New IO.MemoryStream(templateBytes)
                    template.DeSerialize(ms)
                End Using

                Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                If features IsNot Nothing AndAlso template IsNot Nothing AndAlso Verificator IsNot Nothing Then
                    Verificator.Verify(features, template, result)
                    If result.Verified Then

                        Me.Invoke(Sub()

                                      ' Calculate age based on the retrieved date of birth
                                      Dim presentDate As Date = Date.Today
                                      Dim age As Integer = presentDate.Year - dateOfBirth.Year

                                      ' Adjust age if the birth date has not yet occurred this year
                                      If presentDate < dateOfBirth.AddYears(age) Then
                                          age -= 1
                                      End If


                                      MsgBox($"Hello {name}, you are {age} years old.")

                                      vrFingerprint.Image = Nothing
                                      StatusText.Clear()
                                      Prompt.Text = ""
                                      StatusText.Text = ""


                                      matchFound = True
                                  End Sub)


                        Exit While
                    End If
                Else
                    MsgBox("One or more objects required for verification are null.")
                End If




            End While

            ' Close the database connection
            connection.Close()

            If Not matchFound Then

                Me.Invoke(Sub()

                          End Sub)

                MsgBox("No matching fingerprint found in the database.", MsgBoxStyle.Exclamation, "Verification Failed")


            End If
        End If




    End Sub


    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing

        convertor.ConvertToPicture(Sample, bitmap)

        ' Resize the bitmap to match the size of the pbFingerprint PictureBox
        If vrFingerprint.Width > 0 AndAlso vrFingerprint.Height > 0 Then
            bitmap = New Bitmap(bitmap, vrFingerprint.Width, vrFingerprint.Height)
        End If

        ' Set the image to the pbFingerprint PictureBox
        If vrFingerprint.Image Is Nothing Then
            Invoke(New FunctionCall(AddressOf DrawToPictureBox), bitmap)
        End If

        ' Return bitmap as a result (optional)
        Return bitmap
    End Function

    Private Sub DrawToPictureBox(ByVal bmp As Bitmap)

        vrFingerprint.SizeMode = PictureBoxSizeMode.StretchImage
        vrFingerprint.Image = bmp


    End Sub

    Protected Overridable Sub Processs(ByVal Sample As DPFP.Sample)

        Dim bitmap As Bitmap = ConvertSampleToBitmap(Sample)
        DrawToPictureBox(bitmap)
    End Sub

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()    ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        MakeReport("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        MakeReport("The fingerprint reader was connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MakeReport("The fingerprint reader was disconnected.")
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            MakeReport("The quality of the fingerprint sample is good.")
        Else
            MakeReport("The quality of the fingerprint sample is poor.")
        End If
    End Sub

    Protected Sub UpdateStatus()
        ' Show number of samples needed.
        SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded))
    End Sub


    Protected Sub SetStatus(ByVal status)
        Invoke(New FunctionCall(AddressOf _SetStatus), status)
    End Sub

    Private Sub _SetStatus(ByVal status)
        StatusLine.Visible = True
        StatusLine.Text = status
    End Sub

    Protected Sub SetPrompt(ByVal text)
        Invoke(New FunctionCall(AddressOf _SetPrompt), text)
    End Sub

    Private Sub _SetPrompt(ByVal text)
        Prompt.Visible = True
        Prompt.Text = text
    End Sub

    Protected Sub MakeReport(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _MakeReport), status)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub _MakeReport(ByVal status)
        StatusText.AppendText(status + Chr(13) + Chr(10))
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        StopCapture()
        Me.Close()
    End Sub

    Private Sub verification_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        StopCapture()
    End Sub
End Class