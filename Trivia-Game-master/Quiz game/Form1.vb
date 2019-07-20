Public Class Form1
    Dim myName As String
    Dim correct As Integer
    Dim wrong As Integer
    Dim num1 As Integer
    Dim num2 As Integer
    Dim response As Integer
    Dim rnum As New Random


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txbResponse.Text = response Then
                lblAnswer.Text = "correct"
                correct = correct + 1
                lblScoreC2.Text = correct
                tmrAnswer.Start()
                txbResponse.Text = ""
                lblAnswer.BackColor = Color.Green
            Else
                lblAnswer.Text = "wrong"
                wrong = wrong + 1
                lblScoreW2.Text = wrong
                tmrAnswer.Start()
                txbResponse.Text = ""
                lblAnswer.BackColor = Color.Red
            End If
            If Me.BackColor = Color.White Then
                getQuestionEasy()
            ElseIf Me.BackColor = Color.Cyan Then
                getQuestionMedium()
            ElseIf Me.BackColor = Color.YellowGreen Then
                getQuestionHard()
            End If
            End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("In stage 2: You must answer as many math questions you can in 1 minute, the timer starts once you choose your difficulty level.")
        
    End Sub

    Private Sub lblPlayer_Click(sender As Object, e As EventArgs) Handles lblPlayer2.Click


    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        myName = InputBox("What is your name?")
        lblPlayer2.Text = "Player name: " & myName
        If myName = "" Then
            MsgBox("Please type your name.")
        Else
            lblProblem.Text = ""
            Me.BackColor = Color.White
            btnEasy.Visible = True
            btnEasy.Enabled = True
            btnHard.Visible = True
            btnHard.Enabled = True
            btnMedium.Visible = True
            btnMedium.Enabled = True
            Label2.Visible = True
            lblPlayer2.Visible = False
            lblRight.Visible = False
            lblWrong.Visible = False
            lblScoreC2.Visible = False
            lblScoreW2.Visible = False
            lblTime.Visible = False
            txbResponse.Visible = False
            lblAnswer.Visible = False
            lblStart.Visible = False
        End If
    End Sub

    Private Sub txbResponse_TextChanged(sender As Object, e As EventArgs) Handles txbResponse.TextChanged

    End Sub
    Private Sub getQuestionHard()
        num1 = rnum.Next(0, 10)
        num2 = rnum.Next(0, 10)
        If num1 = 1 Or num1 = 3 Or num1 = 5 Or num1 = 7 Then
            response = num1 + num2
            lblProblem.Text = "What is " & num1 & " + " & num2 & "."
        ElseIf num1 = 2 Or num1 = 6 Or num1 = 0 Then
            response = num1 * num2
            lblProblem.Text = "What is " & num1 & " * " & num2 & "."
        ElseIf num1 = 4 Or num1 = 8 Or num1 = 9 Then
            response = num1 - num2
            lblProblem.Text = "What is " & num1 & " - " & num2 & "."
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = lblTime.Text - 1
        If lblTime.Text <= 30 And lblScoreC2.Text <= 20 Then
            Label3.Visible = True
            Label3.Text = "You can do better than this"
        ElseIf lblTime.Text <= 30 And lblScoreC2.Text > 20 Then
            Label3.Visible = True
            Label3.Text = "Finish strong"
        End If
        If lblTime.Text = 25 Then
            Label3.Visible = False
        End If
        If lblTime.Text = 0 Then
            Timer1.Stop()
            Label3.Visible = False
            MsgBox("Your time is up")
            txbResponse.Enabled = False
            If lblTime.Text = 0 Then
                If lblScoreC2.Text >= 35 Then
                    MsgBox(correct & " Correct, " & myName & " you are a math genious.")
                ElseIf lblScoreC2.Text >= 20 Then
                    MsgBox(correct & " Correct, " & myName & " you are smart.")
                ElseIf lblScoreC2.Text < 20 Then
                    MsgBox(correct & " Correct, " & myName & " you need to work on your math skills.")
                End If
            End If
        End If
    End Sub

    Private Sub tmrAnswer_Tick(sender As Object, e As EventArgs) Handles tmrAnswer.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            tmrAnswer.Stop()
            lblAnswer.Text = ""
            Label1.Text = 10
            lblAnswer.BackColor = Color.Transparent
            lblAnswer.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Stage1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Stage1ToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        Me.BackColor = Color.YellowGreen
        lblScoreC2.Text = 0
        lblScoreW2.Text = 0
        txbResponse.Text = ""
        Timer1.Start()
        lblTime.Text = 60
        Label1.Text = 8
        lblProblem.Visible = True
        getQuestionHard()
        visibility()
        txbResponse.Focus()
    End Sub
    Private Sub visibility()
        btnEasy.Visible = False
        btnEasy.Enabled = False
        btnHard.Visible = False
        btnHard.Enabled = False
        btnMedium.Visible = False
        btnMedium.Enabled = False
        Label2.Visible = False
        lblPlayer2.Visible = True
        lblRight.Visible = True
        lblWrong.Visible = True
        lblScoreC2.Visible = True
        lblScoreW2.Visible = True
        lblTime.Visible = True
        txbResponse.Visible = True
        lblAnswer.Visible = True
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        Me.BackColor = Color.Cyan
        lblScoreC2.Text = 0
        lblScoreW2.Text = 0
        txbResponse.Text = ""
        Timer1.Start()
        lblTime.Text = 60
        Label1.Text = 8
        lblProblem.Visible = True
        getQuestionMedium()
        visibility()
        txbResponse.Focus()
    End Sub
    Private Sub getQuestionEasy()
        num1 = rnum.Next(0, 10)
        num2 = rnum.Next(0, 10)
        response = num1 + num2
        lblProblem.Text = "What is " & num1 & " + " & num2 & "."
    End Sub

    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        Me.BackColor = Color.White
        lblScoreC2.Text = 0
        lblScoreW2.Text = 0
        txbResponse.Text = ""
        Timer1.Start()
        lblTime.Text = 60
        Label1.Text = 8
        lblProblem.Visible = True
        getQuestionEasy()
        visibility()
        txbResponse.Focus()
    End Sub
    Private Sub getQuestionMedium()
        num1 = rnum.Next(0, 10)
        num2 = rnum.Next(0, 10)
        If num1 = 1 Or num1 = 3 Or num1 = 5 Or num1 = 7 Or num1 = 2 Then
            response = num1 + num2
            lblProblem.Text = "What is " & num1 & " + " & num2 & "."
        ElseIf num1 = 4 Or num1 = 8 Or num1 = 9 Or num1 = 6 Or num1 = 0 Then
            response = num1 - num2
            lblProblem.Text = "What is " & num1 & " - " & num2 & "."
        End If
    End Sub
End Class