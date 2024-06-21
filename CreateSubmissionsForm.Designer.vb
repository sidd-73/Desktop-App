<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionsForm
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhnNumber = New TextBox()
        txtGitHubLink = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        toggleStopWatchBtn = New Button()
        submitBtn = New Button()
        Timer1 = New Timer(components)
        stopWatchDisp = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(328, 84)
        txtName.Margin = New Padding(5, 4, 5, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(255, 24)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(328, 148)
        txtEmail.Margin = New Padding(5, 4, 5, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(255, 24)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhnNumber
        ' 
        txtPhnNumber.Location = New Point(328, 216)
        txtPhnNumber.Margin = New Padding(5, 4, 5, 4)
        txtPhnNumber.Name = "txtPhnNumber"
        txtPhnNumber.Size = New Size(255, 24)
        txtPhnNumber.TabIndex = 2
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(328, 284)
        txtGitHubLink.Margin = New Padding(5, 4, 5, 4)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(255, 24)
        txtGitHubLink.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Geist SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(117, 87)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 16)
        Label1.TabIndex = 4
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(117, 151)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 16)
        Label2.TabIndex = 5
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(117, 219)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 16)
        Label3.TabIndex = 6
        Label3.Text = "Phn Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(117, 287)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 16)
        Label4.TabIndex = 7
        Label4.Text = "GitHub Link For Task 2"
        ' 
        ' toggleStopWatchBtn
        ' 
        toggleStopWatchBtn.BackColor = Color.Gold
        toggleStopWatchBtn.Font = New Font("Geist SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        toggleStopWatchBtn.Location = New Point(117, 368)
        toggleStopWatchBtn.Margin = New Padding(5, 4, 5, 4)
        toggleStopWatchBtn.Name = "toggleStopWatchBtn"
        toggleStopWatchBtn.Size = New Size(291, 24)
        toggleStopWatchBtn.TabIndex = 8
        toggleStopWatchBtn.Text = "TOGGLE STOPWATCH (CTRL + T)"
        toggleStopWatchBtn.UseVisualStyleBackColor = False
        ' 
        ' submitBtn
        ' 
        submitBtn.BackColor = SystemColors.ActiveCaption
        submitBtn.Font = New Font("Geist SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submitBtn.Location = New Point(117, 432)
        submitBtn.Margin = New Padding(5, 4, 5, 4)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(472, 28)
        submitBtn.TabIndex = 9
        submitBtn.Text = "SUBMIT (CTRL + S)"
        submitBtn.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' stopWatchDisp
        ' 
        stopWatchDisp.BackColor = Color.Cyan
        stopWatchDisp.Location = New Point(446, 368)
        stopWatchDisp.Margin = New Padding(5, 4, 5, 4)
        stopWatchDisp.Name = "stopWatchDisp"
        stopWatchDisp.ReadOnly = True
        stopWatchDisp.Size = New Size(137, 24)
        stopWatchDisp.TabIndex = 10
        stopWatchDisp.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(183, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(355, 18)
        Label5.TabIndex = 11
        Label5.Text = "Siddarth, Slidely Task 2 - Create Submission"
        ' 
        ' CreateSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(768, 492)
        Controls.Add(Label5)
        Controls.Add(stopWatchDisp)
        Controls.Add(submitBtn)
        Controls.Add(toggleStopWatchBtn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhnNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Font = New Font("Geist SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "CreateSubmissionsForm"
        Text = "CreateSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhnNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents toggleStopWatchBtn As Button
    Friend WithEvents submitBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents stopWatchDisp As TextBox
    Friend WithEvents Label5 As Label
End Class
