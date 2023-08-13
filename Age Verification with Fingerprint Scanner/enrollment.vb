Imports System.ComponentModel
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient

Public Class enrollment

    Implements DPFP.Capture.EventHandler

    Delegate Sub FunctionCall(ByVal param)
    Private Capturer As DPFP.Capture.Capture
    Dim count As Integer
    ' Public Event OnTemplate(ByVal template)
    Public Enroller As DPFP.Processing.Enrollment
    Private Template As DPFP.Template

    Protected Overridable Sub Init()
        Try

            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.
            Enroller = New DPFP.Processing.Enrollment()
            UpdateStatus()
            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else
                SetPrompt("Can't initiate capture operation!")
            End If

        Catch ex As DPFP.Error.SDKException
            ' MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "XTech")
        End Try
    End Sub

    Protected Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()
                SetPrompt("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As DPFP.Error.SDKException
                'SetPrompt("Can't initiate capture!")
                MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "XTech")
            End Try
        End If
    End Sub
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete

        MakeReport("The fingerprint sample was captured.")
        SetPrompt("Scan the same fingerprint again.")
        Process(Sample)

    End Sub

    Protected Sub Process(ByVal Sample As DPFP.Sample)

        Processs(Sample)



        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then
            Try


                MakeReport("The fingerprint feature set was created.")
                Enroller.AddFeatures(features)        ' Add feature set to template.


            Finally
                UpdateStatus()

                ' Check if template has been created.
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready    ' Report success and stop capturing


                        OnTemplate(Enroller.Template)
                        SetPrompt("Fingerprint Enrollment Successfull.")
                        Template = Enroller.Template
                        StopCapture()
                    Case DPFP.Processing.Enrollment.Status.Failed   ' Report failure and restart capturing
                        Enroller.Clear()
                        SetPrompt("Fingerprint Enrollment Failed.")
                        StopCapture()
                        ' OnTemplate(Nothing)
                        StartCapture()

                End Select
            End Try
        End If


    End Sub

    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing

        convertor.ConvertToPicture(Sample, bitmap)

        ' Resize the bitmap to match the size of the pbFingerprint PictureBox
        If pbFingerprint.Width > 0 AndAlso pbFingerprint.Height > 0 Then
            bitmap = New Bitmap(bitmap, pbFingerprint.Width, pbFingerprint.Height)
        End If

        ' Set the image to the pbFingerprint PictureBox
        If pbFingerprint.Image Is Nothing Then
            Invoke(New FunctionCall(AddressOf DrawToPictureBox), bitmap)
        End If

        ' Return bitmap as a result (optional)
        Return bitmap
    End Function

    Private Sub DrawToPictureBox(ByVal bmp As Bitmap)

        pbFingerprint.SizeMode = PictureBoxSizeMode.StretchImage
        pbFingerprint.Image = bmp


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

    Private Sub OnTemplate(ByVal template)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template)
    End Sub

    Private Sub _OnTemplate(ByVal template)
        Me.Template = template
        If Not template Is Nothing Then
            'savetemplate()
            SetStatus(String.Format("Enrollment Successful"))
        Else
            MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

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

    Protected Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                SetPrompt("Can't terminate capture!")
            End Try
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


    Private Sub enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bgColor As Color = ColorTranslator.FromHtml("#01050F")
        Me.BackColor = bgColor

        Init()
        StartCapture()

    End Sub


    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click

        ' Check if the text box is empty
        If enrollName.Text.Trim = "" Then
            ' Display the label with a message
            errorLabel.Text = "Enter a name"
            errorLabel.Visible = True
            Return

        End If

        If Not enrollDOB.Checked OrElse enrollDOB.Value.Date = enrollDOB.MinDate Then
            errorLabel.Text = "Please select a valid date of birth."
            Return
        End If


        ' Check if the text box is empty
        If genderBox.SelectedItem Is Nothing Then
            ' Display the label with a message
            errorLabel.Text = "Select a Gender"
            errorLabel.Visible = True
            Return
        End If

        ' Check if the text box is empty
        If bloodGroupBox.SelectedItem Is Nothing Then
            ' Display the label with a message
            errorLabel.Text = "Select a Blood Group"
            errorLabel.Visible = True
            Return
        End If

        If Template Is Nothing Then
            errorLabel.Text = "Kindly register a fingerprint."
            Return
        End If

        errorLabel.Visible = False



        Using connection As New MySqlConnection(Login.connectionString)

            connection.Open()



            Dim insertQuery As String = "INSERT INTO person (name, gender, dateOfBirth, bloodGroup, fingerprintTemplate1) VALUES (@name, @gender, @dateOfBirth, @bloodGroup, @fingerprintTemplate1);"
            Dim insertCmd As New MySqlCommand(insertQuery, connection)

            ' Use the course code without spaces in the INSERT operation
            insertCmd.Parameters.AddWithValue("@name", enrollName.Text.Trim)
            insertCmd.Parameters.AddWithValue("@gender", genderBox.SelectedItem.ToString().Trim)
            insertCmd.Parameters.AddWithValue("@dateOfBirth", enrollDOB.Value)
            insertCmd.Parameters.AddWithValue("@bloodGroup", bloodGroupBox.SelectedItem.ToString().Trim)

            Using fs As IO.MemoryStream = New IO.MemoryStream()
                Template.Serialize(fs)
                insertCmd.Parameters.AddWithValue("@fingerprintTemplate1", fs.ToArray())
            End Using

            Dim affectedRows As Integer = insertCmd.ExecuteNonQuery()

            If affectedRows > 0 Then
                MsgBox("Enrollment Successfully")

            Else
                MsgBox("Something went wrong. Please try again.")
            End If


            connection.Close()
        End Using






    End Sub



    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        StopCapture()
        Me.Close()
    End Sub

    Private Sub enrollment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        StopCapture()
    End Sub
End Class