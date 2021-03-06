Option Explicit On
Option Strict On
Option Compare Text

Public Class MathContestForm
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisabledControls()
    End Sub
    Private Sub GradeTextBox_Validated(sender As Object, e As EventArgs) Handles GradeTextBox.Validated
        If Validation() Then
            DisabledControls()
        Else
            InputInfoGroupBox.Enabled = False
            InputProblemTypeGroupBox.Enabled = True
            InputProblemEnable(True)
            RandomNumbers()
            StudentAnswerTextBox.Select()
        End If
    End Sub
    Private Sub StudentAnswerTextBox_Validated(sender As Object, e As EventArgs) Handles StudentAnswerTextBox.Validated
        SubmitButton.Enabled = True
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim firstNumber As Integer = CInt(FirstNumberTextBox.Text)
        Dim secondNumber As Integer = CInt(SecondNumberTextBox.Text)
        Dim addInput As Integer = firstNumber + secondNumber
        Dim subtractInput As Integer = firstNumber - secondNumber
        Dim multiplyInput As Integer = firstNumber * secondNumber
        Dim divideInput As Integer
        SummaryButton.Enabled = True
        If AddRadioButton.Checked Then
            Results(addInput)
        ElseIf SubtractRadioButton.Checked Then
            Results(subtractInput)
        ElseIf MultiplyRadioButton.Checked Then
            Results(multiplyInput)
        ElseIf DivideRadioButton.Checked Then
            divideInput = CInt(firstNumber / secondNumber)
            If firstNumber <> 0 And divideInput = 0 Then
                divideInput = CInt(CDbl(firstNumber / secondNumber))
            End If
            Results(divideInput)
        End If
        RandomNumbers()
        StudentAnswerTextBox.Text = ""
        StudentAnswerTextBox.Select()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        InputInfoGroupBox.Enabled = True
        Scorecount("incorrect", True)
        DisabledControls()
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        NameTextBox.Select()
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim result() As Integer = Scorecount("startup", False)
        MsgBox($"{NameTextBox.Text} got {result(0)} correct out of possible {result(1)}")
    End Sub
    Private Sub ExitButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ExitButton.MouseClick
        Me.Close()
    End Sub
    Sub Results(answerInput As Integer)
        If Trim(StudentAnswerTextBox.Text) = CStr(answerInput) Then
            MsgBox(($"CONGRATULATIONS!! {answerInput} is correct"))
            Scorecount("correct", False)
        ElseIf Trim(StudentAnswerTextBox.Text) <> CStr(answerInput) Then
            MsgBox(($"Sorry INCORRECT, {answerInput} is the correct answer"))
            Scorecount("incorrect", False)
        End If
    End Sub
    Sub RandomNumbers()
        Randomize(DateTime.Now.Millisecond)
        FirstNumberTextBox.Text = CStr(CInt(12 * Rnd()))
        SecondNumberTextBox.Text = CStr(CInt(11 * Rnd() + 1))
    End Sub
    Function Scorecount(state As String, clear As Boolean) As Integer()
        Static result(1) As Integer
        Dim score As Integer = 1
        Dim cleared As Integer = 0
        Dim startup As String = "startup"
        Dim correct As String = "correct"
        Dim incorrect As String = "incorrect"
        If state = startup And Not clear Then
        ElseIf state = correct And Not clear Then
            result(0) += score
            result(1) += score
        ElseIf state = incorrect And Not clear Then
            result(1) += score
        ElseIf clear Then
            result(0) = cleared
            result(1) = cleared
        End If
        Return result
    End Function
    Sub InputProblemEnable(state As Boolean)
        If Not state Then
            FirstNumberTextBox.Enabled = False
            SecondNumberTextBox.Enabled = False
            StudentAnswerTextBox.Enabled = False
        Else
            FirstNumberTextBox.Enabled = False
            SecondNumberTextBox.Enabled = False
            StudentAnswerTextBox.Enabled = True
        End If
    End Sub
    Sub DisabledControls()
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        InputProblemEnable(False)
        AddRadioButton.Checked = True
        InputProblemTypeGroupBox.Enabled = False
    End Sub
    Function Validation() As Boolean
        Dim status As Boolean = False
        Dim problemMessage As String = ""
        Dim nameError As Integer
        Dim ageValue As Integer
        Dim gradeValue As Integer
        Dim studentEligible As Boolean = False
        Try
            nameError = CInt(NameTextBox.Text)
            If nameError = CInt(NameTextBox.Text) Or NameTextBox.Text = "" Then
                status = True
                NameTextBox.Text = ""
                problemMessage &= "Name cannot be a number" & vbNewLine
                NameTextBox.BackColor = Color.LightYellow
                NameTextBox.Select()
            End If
        Catch ex As Exception
            status = False
            NameTextBox.BackColor = Color.White
        End Try
        If status Then

        ElseIf NameTextBox.Text = "" Then
            status = True
            problemMessage &= "Name is required" & vbNewLine
            NameTextBox.BackColor = Color.LightYellow
            NameTextBox.Select()
        End If
        Try
            ageValue = CInt(AgeTextBox.Text)
            AgeTextBox.BackColor = Color.White
            If CInt(AgeTextBox.Text) < 7 Or CInt(AgeTextBox.Text) > 11 Then
                status = True
                AgeTextBox.Text = ""
                problemMessage &= "Age must be between 7 and 11" & vbNewLine
                AgeTextBox.BackColor = Color.LightYellow
                If Not NameTextBox.BackColor = Color.LightYellow Then
                    AgeTextBox.Select()
                End If
                studentEligible = True
            End If
        Catch ex As Exception
            status = True
            AgeTextBox.Text = ""
            problemMessage &= "Age must be a numberical value" & vbNewLine
            AgeTextBox.BackColor = Color.LightYellow
            If Not NameTextBox.BackColor = Color.LightYellow Then
                AgeTextBox.Select()
            End If
        End Try
        Try
            gradeValue = CInt(GradeTextBox.Text)
            GradeTextBox.BackColor = Color.White
            If CInt(GradeTextBox.Text) < 1 Or CInt(GradeTextBox.Text) > 4 Then
                status = True
                GradeTextBox.Text = ""
                problemMessage &= "Grade must be between 1st and 4th" & vbNewLine
                GradeTextBox.BackColor = Color.LightYellow
                If AgeTextBox.BackColor = Color.White And NameTextBox.BackColor = Color.White Then
                    GradeTextBox.Select()
                End If
                studentEligible = True
            End If
        Catch ex As Exception
            status = True
            GradeTextBox.Text = ""
            problemMessage &= "Grade must be a numberical value" & vbNewLine
            GradeTextBox.BackColor = Color.LightYellow
            If AgeTextBox.BackColor = Color.White And NameTextBox.BackColor = Color.White Then
                GradeTextBox.Select()
            End If
        End Try
        If studentEligible Then
            MsgBox("Student not eligible to compete")
        End If
        If Not problemMessage = "" Then
            MsgBox(problemMessage)
        End If
        Return status
    End Function

End Class
