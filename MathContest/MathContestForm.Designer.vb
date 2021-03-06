<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.components = New System.ComponentModel.Container()
        Me.InputInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.InputProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.InputProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.MathContestToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputInfoGroupBox.SuspendLayout()
        Me.InputProblemGroupBox.SuspendLayout()
        Me.InputProblemTypeGroupBox.SuspendLayout()
        Me.ButtonControlsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputInfoGroupBox
        '
        Me.InputInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.InputInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.InputInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.InputInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.InputInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.InputInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.InputInfoGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.InputInfoGroupBox.Name = "InputInfoGroupBox"
        Me.InputInfoGroupBox.Size = New System.Drawing.Size(600, 153)
        Me.InputInfoGroupBox.TabIndex = 0
        Me.InputInfoGroupBox.TabStop = False
        Me.InputInfoGroupBox.Text = "Student Information"
        Me.MathContestToolTip.SetToolTip(Me.InputInfoGroupBox, "Enter valid student Information (7Years - 11Years) (1st - 4thGrade)")
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(472, 91)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(81, 38)
        Me.GradeTextBox.TabIndex = 5
        Me.MathContestToolTip.SetToolTip(Me.GradeTextBox, "Enter Student's Grade")
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(466, 56)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(94, 32)
        Me.GradeLabel.TabIndex = 4
        Me.GradeLabel.Text = "Grade"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(346, 91)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(81, 38)
        Me.AgeTextBox.TabIndex = 3
        Me.MathContestToolTip.SetToolTip(Me.AgeTextBox, "Enter Student's age")
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(346, 56)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(66, 32)
        Me.AgeLabel.TabIndex = 2
        Me.AgeLabel.Text = "Age"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 91)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(294, 38)
        Me.NameTextBox.TabIndex = 1
        Me.MathContestToolTip.SetToolTip(Me.NameTextBox, "Enter Student's Name")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 56)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(90, 32)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'InputProblemGroupBox
        '
        Me.InputProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.InputProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.InputProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.InputProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.InputProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.InputProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.InputProblemGroupBox.Location = New System.Drawing.Point(12, 189)
        Me.InputProblemGroupBox.Name = "InputProblemGroupBox"
        Me.InputProblemGroupBox.Size = New System.Drawing.Size(306, 409)
        Me.InputProblemGroupBox.TabIndex = 1
        Me.InputProblemGroupBox.TabStop = False
        Me.InputProblemGroupBox.Text = "Current Math Problem"
        Me.MathContestToolTip.SetToolTip(Me.InputProblemGroupBox, "First and Second random numbers generated, Student answer (1st number (Math Probl" &
        "em Type) 2nd Number)")
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(6, 355)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(294, 38)
        Me.StudentAnswerTextBox.TabIndex = 5
        Me.MathContestToolTip.SetToolTip(Me.StudentAnswerTextBox, "Enter Student's Answer of the first and second numbers generated. Select/Change m" &
        "ath problem type for different mathematical functions.")
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 320)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(215, 32)
        Me.StudentAnswerLabel.TabIndex = 4
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(6, 216)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(294, 38)
        Me.SecondNumberTextBox.TabIndex = 3
        Me.MathContestToolTip.SetToolTip(Me.SecondNumberTextBox, "Random second generated number")
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(6, 181)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(170, 32)
        Me.SecondNumberLabel.TabIndex = 2
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(6, 129)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(294, 38)
        Me.FirstNumberTextBox.TabIndex = 1
        Me.MathContestToolTip.SetToolTip(Me.FirstNumberTextBox, "Random first generated number")
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(6, 94)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(160, 32)
        Me.FirstNumberLabel.TabIndex = 0
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'InputProblemTypeGroupBox
        '
        Me.InputProblemTypeGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InputProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.InputProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.InputProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.InputProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.InputProblemTypeGroupBox.Location = New System.Drawing.Point(335, 189)
        Me.InputProblemTypeGroupBox.Name = "InputProblemTypeGroupBox"
        Me.InputProblemTypeGroupBox.Size = New System.Drawing.Size(277, 409)
        Me.InputProblemTypeGroupBox.TabIndex = 2
        Me.InputProblemTypeGroupBox.TabStop = False
        Me.InputProblemTypeGroupBox.Text = "Math Problem Type"
        Me.MathContestToolTip.SetToolTip(Me.InputProblemTypeGroupBox, "Select desired math problem type for student's answer.")
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(28, 295)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(132, 36)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.MathContestToolTip.SetToolTip(Me.DivideRadioButton, "Divides 1st number by 2nd number. IF ANSWER NOT EQUAL TO INTEGER VALUE ROUND TO N" &
        "EAREST FULL NUMBER!")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(28, 216)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(150, 36)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MathContestToolTip.SetToolTip(Me.MultiplyRadioButton, "Multiplies 1st number by 2nd number")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(28, 140)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(158, 36)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.MathContestToolTip.SetToolTip(Me.SubtractRadioButton, "Subtracts 1st number from 2nd number")
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(28, 71)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(103, 36)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.MathContestToolTip.SetToolTip(Me.AddRadioButton, "Add 1st number and 2nd number")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonControlsGroupBox
        '
        Me.ButtonControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonControlsGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonControlsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonControlsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonControlsGroupBox.Location = New System.Drawing.Point(631, 12)
        Me.ButtonControlsGroupBox.Name = "ButtonControlsGroupBox"
        Me.ButtonControlsGroupBox.Size = New System.Drawing.Size(317, 586)
        Me.ButtonControlsGroupBox.TabIndex = 3
        Me.ButtonControlsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(6, 419)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(305, 100)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.MathContestToolTip.SetToolTip(Me.ExitButton, "Enter Exit to leave program.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(6, 290)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(305, 100)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "S&ummary"
        Me.MathContestToolTip.SetToolTip(Me.SummaryButton, "Enter Summary to see score of the student's correct anwers out of the total attem" &
        "pts.")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(6, 163)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(305, 100)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.MathContestToolTip.SetToolTip(Me.ClearButton, "Enter Clear to clear student information and answer.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 37)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(305, 100)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.MathContestToolTip.SetToolTip(Me.SubmitButton, "Enter Submit to check student's answer.")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1002, 619)
        Me.Controls.Add(Me.ButtonControlsGroupBox)
        Me.Controls.Add(Me.InputProblemTypeGroupBox)
        Me.Controls.Add(Me.InputProblemGroupBox)
        Me.Controls.Add(Me.InputInfoGroupBox)
        Me.Name = "MathContestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Contest"
        Me.InputInfoGroupBox.ResumeLayout(False)
        Me.InputInfoGroupBox.PerformLayout()
        Me.InputProblemGroupBox.ResumeLayout(False)
        Me.InputProblemGroupBox.PerformLayout()
        Me.InputProblemTypeGroupBox.ResumeLayout(False)
        Me.InputProblemTypeGroupBox.PerformLayout()
        Me.ButtonControlsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputInfoGroupBox As GroupBox
    Friend WithEvents InputProblemGroupBox As GroupBox
    Friend WithEvents InputProblemTypeGroupBox As GroupBox
    Friend WithEvents ButtonControlsGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents MathContestToolTip As ToolTip
End Class
