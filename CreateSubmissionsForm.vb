Imports System.Diagnostics
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json


Public Class CreateSubmissionsForm
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        stopWatchDisp.Text = "00:00:00"
    End Sub

    Private Sub CreateSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            toggleStopWatchBtn.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then
            submitBtn.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopWatchDisp.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub toggleStopWatchBtn_Click(sender As Object, e As EventArgs) Handles toggleStopWatchBtn.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopWatchDisp.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhnNumber.Text,
            .GithubLink = txtGitHubLink.Text,
            .StopwatchTime = stopWatchDisp.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim url As String = "http://localhost:3000/submit"

        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            request.ContentLength = json.Length

            Using streamWriter As New StreamWriter(request.GetRequestStream())
                streamWriter.Write(json)
                streamWriter.Flush()
                streamWriter.Close()
            End Using

            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Using streamReader As New StreamReader(response.GetResponseStream())
                Dim result As String = streamReader.ReadToEnd()
                MessageBox.Show("Submission saved successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Me.Close()
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property PhoneNumber As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class
End Class
