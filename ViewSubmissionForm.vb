Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionForm

    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission) = New List(Of Submission)()
    Private httpClient As HttpClient = New HttpClient()
    Private baseUrl As String = "http://localhost:3000" ' Replace with your server URL

    Private Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync($"{baseUrl}/submissions")
            response.EnsureSuccessStatusCode()
            Dim json As String = Await response.Content.ReadAsStringAsync()
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
            If submissions.Count > 0 Then
                DisplaySubmission(0)
            Else
                MessageBox.Show("No submissions available.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhnNumber.Text = submission.PhoneNumber
            txtGitHubLink.Text = submission.GithubLink
            txtStopWatch.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
    Private Async Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim email As String = submissions(currentIndex).Email
            Try
                Dim content As New StringContent(email, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await httpClient.PostAsync($"{baseUrl}/deleteSubmission", content)
                response.EnsureSuccessStatusCode()

                submissions.RemoveAt(currentIndex)
                If currentIndex >= submissions.Count Then
                    currentIndex = submissions.Count - 1
                End If
                DisplaySubmission(currentIndex)
                MessageBox.Show("Submission deleted successfully.")
            Catch ex As Exception
                MessageBox.Show($"Error deleting submission: {ex.Message}")
            End Try
        End If
    End Sub

End Class
