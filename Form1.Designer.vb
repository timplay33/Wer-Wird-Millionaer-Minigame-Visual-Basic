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
        Me.Txt_question = New System.Windows.Forms.Label()
        Me.Txt_question_id = New System.Windows.Forms.Label()
        Me.Cmd_choice_A = New System.Windows.Forms.Button()
        Me.Cmd_choice_B = New System.Windows.Forms.Button()
        Me.Cmd_choice_C = New System.Windows.Forms.Button()
        Me.Cmd_choice_D = New System.Windows.Forms.Button()
        Me.Cmd_Next = New System.Windows.Forms.Button()
        Me.Txt_Money = New System.Windows.Forms.Label()
        Me.Cmd_Replay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_question
        '
        Me.Txt_question.Location = New System.Drawing.Point(12, 229)
        Me.Txt_question.Name = "Txt_question"
        Me.Txt_question.Size = New System.Drawing.Size(750, 50)
        Me.Txt_question.TabIndex = 0
        Me.Txt_question.Text = "question"
        Me.Txt_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_question_id
        '
        Me.Txt_question_id.AutoSize = True
        Me.Txt_question_id.Location = New System.Drawing.Point(25, 25)
        Me.Txt_question_id.Name = "Txt_question_id"
        Me.Txt_question_id.Size = New System.Drawing.Size(13, 15)
        Me.Txt_question_id.TabIndex = 1
        Me.Txt_question_id.Text = "0"
        '
        'Cmd_choice_A
        '
        Me.Cmd_choice_A.Location = New System.Drawing.Point(-7, 293)
        Me.Cmd_choice_A.Name = "Cmd_choice_A"
        Me.Cmd_choice_A.Size = New System.Drawing.Size(400, 50)
        Me.Cmd_choice_A.TabIndex = 2
        Me.Cmd_choice_A.Text = "A"
        Me.Cmd_choice_A.UseVisualStyleBackColor = True
        '
        'Cmd_choice_B
        '
        Me.Cmd_choice_B.Location = New System.Drawing.Point(399, 293)
        Me.Cmd_choice_B.Name = "Cmd_choice_B"
        Me.Cmd_choice_B.Size = New System.Drawing.Size(400, 50)
        Me.Cmd_choice_B.TabIndex = 3
        Me.Cmd_choice_B.Text = "B"
        Me.Cmd_choice_B.UseVisualStyleBackColor = True
        '
        'Cmd_choice_C
        '
        Me.Cmd_choice_C.Location = New System.Drawing.Point(-7, 349)
        Me.Cmd_choice_C.Name = "Cmd_choice_C"
        Me.Cmd_choice_C.Size = New System.Drawing.Size(400, 50)
        Me.Cmd_choice_C.TabIndex = 4
        Me.Cmd_choice_C.Text = "C"
        Me.Cmd_choice_C.UseVisualStyleBackColor = True
        '
        'Cmd_choice_D
        '
        Me.Cmd_choice_D.Location = New System.Drawing.Point(399, 349)
        Me.Cmd_choice_D.Name = "Cmd_choice_D"
        Me.Cmd_choice_D.Size = New System.Drawing.Size(400, 50)
        Me.Cmd_choice_D.TabIndex = 5
        Me.Cmd_choice_D.Text = "D"
        Me.Cmd_choice_D.UseVisualStyleBackColor = True
        '
        'Cmd_Next
        '
        Me.Cmd_Next.Location = New System.Drawing.Point(697, 426)
        Me.Cmd_Next.Name = "Cmd_Next"
        Me.Cmd_Next.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_Next.TabIndex = 6
        Me.Cmd_Next.Text = "Next"
        Me.Cmd_Next.UseVisualStyleBackColor = True
        '
        'Txt_Money
        '
        Me.Txt_Money.AutoSize = True
        Me.Txt_Money.Location = New System.Drawing.Point(25, 201)
        Me.Txt_Money.Name = "Txt_Money"
        Me.Txt_Money.Size = New System.Drawing.Size(13, 15)
        Me.Txt_Money.TabIndex = 7
        Me.Txt_Money.Text = "0"
        '
        'Cmd_Replay
        '
        Me.Cmd_Replay.Location = New System.Drawing.Point(337, 405)
        Me.Cmd_Replay.Name = "Cmd_Replay"
        Me.Cmd_Replay.Size = New System.Drawing.Size(115, 23)
        Me.Cmd_Replay.TabIndex = 8
        Me.Cmd_Replay.Text = "Nochmal Spielen"
        Me.Cmd_Replay.UseVisualStyleBackColor = True
        Me.Cmd_Replay.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Cmd_Replay)
        Me.Controls.Add(Me.Txt_Money)
        Me.Controls.Add(Me.Cmd_Next)
        Me.Controls.Add(Me.Cmd_choice_D)
        Me.Controls.Add(Me.Cmd_choice_C)
        Me.Controls.Add(Me.Cmd_choice_B)
        Me.Controls.Add(Me.Cmd_choice_A)
        Me.Controls.Add(Me.Txt_question_id)
        Me.Controls.Add(Me.Txt_question)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_question As Label
    Friend WithEvents Txt_question_id As Label
    Friend WithEvents Cmd_choice_A As Button
    Friend WithEvents Cmd_choice_B As Button
    Friend WithEvents Cmd_choice_C As Button
    Friend WithEvents Cmd_choice_D As Button
    Friend WithEvents Cmd_Next As Button
    Friend WithEvents Txt_Money As Label
    Friend WithEvents Cmd_Replay As Button
End Class
