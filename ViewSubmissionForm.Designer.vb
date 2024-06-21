<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhnNumber = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopWatch = New TextBox()
        previousBtn = New Button()
        nextBtn = New Button()
        Label6 = New Label()
        deleteBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(173, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 16)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(175, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 16)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(173, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 16)
        Label3.TabIndex = 2
        Label3.Text = "Phn Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(173, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 16)
        Label4.TabIndex = 3
        Label4.Text = "GitHub Link For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(175, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 16)
        Label5.TabIndex = 4
        Label5.Text = "Stopwatch Time"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.GradientInactiveCaption
        txtName.Location = New Point(439, 96)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(211, 24)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.GradientInactiveCaption
        txtEmail.Location = New Point(439, 146)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(211, 24)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhnNumber
        ' 
        txtPhnNumber.BackColor = SystemColors.GradientInactiveCaption
        txtPhnNumber.Location = New Point(439, 195)
        txtPhnNumber.Name = "txtPhnNumber"
        txtPhnNumber.ReadOnly = True
        txtPhnNumber.Size = New Size(211, 24)
        txtPhnNumber.TabIndex = 7
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.BackColor = SystemColors.GradientInactiveCaption
        txtGitHubLink.Location = New Point(439, 247)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.ReadOnly = True
        txtGitHubLink.Size = New Size(211, 24)
        txtGitHubLink.TabIndex = 8
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.BackColor = SystemColors.GradientInactiveCaption
        txtStopWatch.Location = New Point(439, 298)
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.ReadOnly = True
        txtStopWatch.Size = New Size(211, 24)
        txtStopWatch.TabIndex = 9
        ' 
        ' previousBtn
        ' 
        previousBtn.BackColor = Color.Gold
        previousBtn.Location = New Point(173, 380)
        previousBtn.Name = "previousBtn"
        previousBtn.Size = New Size(193, 33)
        previousBtn.TabIndex = 10
        previousBtn.Text = "PREVIOUS (CTRL + P)"
        previousBtn.UseVisualStyleBackColor = False
        ' 
        ' nextBtn
        ' 
        nextBtn.BackColor = SystemColors.ActiveCaption
        nextBtn.Location = New Point(454, 380)
        nextBtn.Name = "nextBtn"
        nextBtn.Size = New Size(196, 33)
        nextBtn.TabIndex = 11
        nextBtn.Text = "NEXT (CTRL + N)"
        nextBtn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(235, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(349, 18)
        Label6.TabIndex = 12
        Label6.Text = "Siddarth, Slidely Task 2 - View Submissions"
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.Red
        deleteBtn.Location = New Point(375, 434)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(75, 34)
        deleteBtn.TabIndex = 13
        deleteBtn.Text = "DELETE"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(837, 480)
        Controls.Add(deleteBtn)
        Controls.Add(Label6)
        Controls.Add(nextBtn)
        Controls.Add(previousBtn)
        Controls.Add(txtStopWatch)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhnNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Geist SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "ViewSubmissionForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhnNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents previousBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents deleteBtn As Button
End Class
