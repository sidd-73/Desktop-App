<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ViewSubmissionBtn = New Button()
        CreateSubmissionBtn = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ViewSubmissionBtn
        ' 
        ViewSubmissionBtn.BackColor = Color.Gold
        ViewSubmissionBtn.Font = New Font("Geist SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewSubmissionBtn.Location = New Point(175, 180)
        ViewSubmissionBtn.Name = "ViewSubmissionBtn"
        ViewSubmissionBtn.Size = New Size(376, 23)
        ViewSubmissionBtn.TabIndex = 0
        ViewSubmissionBtn.Text = "VIEW SUBMISSIONS (CTRL + V)"
        ViewSubmissionBtn.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionBtn
        ' 
        CreateSubmissionBtn.BackColor = SystemColors.ActiveCaption
        CreateSubmissionBtn.Font = New Font("Geist SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CreateSubmissionBtn.Location = New Point(175, 238)
        CreateSubmissionBtn.Name = "CreateSubmissionBtn"
        CreateSubmissionBtn.Size = New Size(376, 23)
        CreateSubmissionBtn.TabIndex = 1
        CreateSubmissionBtn.Text = "CREATE SUBMISSIONS (CTRL + N)"
        CreateSubmissionBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Bright", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(192, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(341, 18)
        Label1.TabIndex = 2
        Label1.Text = "Siddarth, Slidely Task 2- Slidely Form App "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 344)
        Controls.Add(Label1)
        Controls.Add(CreateSubmissionBtn)
        Controls.Add(ViewSubmissionBtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ViewSubmissionBtn As Button
    Friend WithEvents CreateSubmissionBtn As Button
    Friend WithEvents Label1 As Label

End Class
