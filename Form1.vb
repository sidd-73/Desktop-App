Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable key preview for the form
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle Ctrl + V for View Submissions
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ViewSubmissionBtn.PerformClick()
        End If

        ' Handle Ctrl + C for Create Submission
        If e.Control AndAlso e.KeyCode = Keys.N Then
            CreateSubmissionBtn.PerformClick()
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles ViewSubmissionBtn.Click
        Dim viewForm As New ViewSubmissionForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles CreateSubmissionBtn.Click
        Dim createForm As New CreateSubmissionsForm()
        createForm.Show()
    End Sub
End Class

