Public Class Form3
    Dim rnum As New Random
    Dim x As Integer
    Dim y As Integer
    Dim pUp As Boolean
    Dim pDown As Boolean
    Dim pUp2 As Boolean
    Dim pDown2 As Boolean
    Dim pLeft As Boolean
    Dim pRight As Boolean
    Dim pLeft2 As Boolean
    Dim pRight2 As Boolean
    Dim returnBall As Boolean
    Dim player1 As String
    Dim player2 As String
    Dim player3 As String
    Dim player4 As String
    Dim p1Score As Integer
    Dim p2Score As Integer
    Dim p3Score As Integer
    Dim p4Score As Integer
    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        lblPlayer1.Text = ""
        lblPlayer2.Text = ""
        lblPlayer3.Text = ""
        lblPlayer4.Text = ""
        player1 = InputBox("What is your name Player 1?")
        lblPlayer1.Text = player1
        player2 = InputBox("What is your name Player 2?")
        lblPlayer2.Text = player2
        player3 = InputBox("What is your name Player 3?")
        lblPlayer3.Text = player3
        player4 = InputBox("What is your name Player 4?")
        lblPlayer4.Text = player4
        p1Score = 0
        lblNum1.Text = p1Score
        p2Score = 0
        lblNum2.Text = p2Score
        p3Score = 0
        lblNum3.Text = p3Score
        p4Score = 0
        lblNum4.Text = p4Score
        lblRules.Visible = False
        lblControl.Visible = False
        returnBall = True
    End Sub

    Private Sub MainScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainScreenToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
        Form1.btn4WayCon.Visible = True
    End Sub

    Private Sub tmrMoveBall_Tick(sender As Object, e As EventArgs) Handles tmrMoveBall.Tick
        pctBall.Left = pctBall.Left + x
        pctBall.Top = pctBall.Top + y
        If pctBall.Left < pctPlayer1.Right And pctBall.Top < pctPlayer1.Bottom And pctBall.Bottom > pctPlayer1.Top Then
            x = x * -1.2
        End If
        If pctBall.Right > pctPlayer2.Left And pctBall.Top < pctPlayer2.Bottom And pctBall.Bottom > pctPlayer2.Top Then
            x = x * -1.2
        End If
        If pctBall.Top < pctPlayer3.Bottom And pctBall.Left < pctPlayer3.Right And pctBall.Right > pctPlayer3.Left Then
            y = y * -1.2
        End If
        If pctBall.Bottom > pctPlayer4.Top And pctBall.Left < pctPlayer4.Right And pctBall.Right > pctPlayer4.Left Then
            y = y * -1.2
        End If
        If pctBall.Left + playArea.Left < playArea.Left Then
            resetPaddles()
            tmrMoveBall.Stop()
            pctBall.Top = playArea.Height / 2 - pctBall.Height / 2
            pctBall.Left = playArea.Width / 2 - pctBall.Width / 2
            pctPlayer1.BackColor = Color.Red
            pctPlayer2.BackColor = Color.Green
            pctPlayer3.BackColor = Color.Green
            pctPlayer4.BackColor = Color.Green
            p3Score = p3Score + 1
            lblNum3.Text = p3Score
            p2Score = p2Score + 1
            lblNum2.Text = p2Score
            p4Score = p4Score + 1
            lblNum4.Text = p4Score
            returnBall = True
        End If
        If pctBall.Right + playArea.Left > playArea.Right Then
            resetPaddles()
            tmrMoveBall.Stop()
            pctBall.Top = playArea.Height / 2 - pctBall.Height / 2
            pctBall.Left = playArea.Width / 2 - pctBall.Width / 2
            pctPlayer1.BackColor = Color.Green
            pctPlayer2.BackColor = Color.Red
            pctPlayer3.BackColor = Color.Green
            pctPlayer4.BackColor = Color.Green
            p1Score = p1Score + 1
            lblNum1.Text = p1Score
            p3Score = p3Score + 1
            lblNum3.Text = p3Score
            p4Score = p4Score + 1
            lblNum4.Text = p4Score
            returnBall = True
        End If
        If pctBall.Top + playArea.Top < playArea.Top Then
            resetPaddles()
            tmrMoveBall.Stop()
            pctBall.Top = playArea.Height / 2 - pctBall.Height / 2
            pctBall.Left = playArea.Width / 2 - pctBall.Width / 2
            pctPlayer1.BackColor = Color.Green
            pctPlayer2.BackColor = Color.Green
            pctPlayer3.BackColor = Color.Red
            pctPlayer4.BackColor = Color.Green
            p1Score = p1Score + 1
            lblNum1.Text = p1Score
            p2Score = p2Score + 1
            lblNum2.Text = p2Score
            p4Score = p4Score + 1
            lblNum4.Text = p4Score
            returnBall = True
        End If
        If pctBall.Bottom + playArea.Top > playArea.Bottom Then
            resetPaddles()
            tmrMoveBall.Stop()
            pctBall.Top = playArea.Height / 2 - pctBall.Height / 2
            pctBall.Left = playArea.Width / 2 - pctBall.Width / 2
            pctPlayer1.BackColor = Color.Green
            pctPlayer2.BackColor = Color.Green
            pctPlayer3.BackColor = Color.Green
            pctPlayer4.BackColor = Color.Red
            p1Score = p1Score + 1
            lblNum1.Text = p1Score
            p2Score = p2Score + 1
            lblNum2.Text = p2Score
            p3Score = p3Score + 1
            lblNum3.Text = p3Score
            returnBall = True
        End If
        If lblNum1.Text = 20 Then
            tmrMoveBall.Stop()
            tmrPaddle.Stop()
            pctPlayer1.BackColor = Color.Green
            MsgBox("Congratulations " & player1 & ", you just beat " & player2 & ", " & player3 & ", and " & player4 & "!")
        End If
        If lblNum2.Text = 20 Then
            tmrMoveBall.Stop()
            tmrPaddle.Stop()
            pctPlayer2.BackColor = Color.Green
            MsgBox("Congratulations " & player2 & ", you just beat " & player1 & ", " & player3 & ", and " & player4 & "!")
        End If
        If lblNum3.Text = 20 Then
            tmrMoveBall.Stop()
            tmrPaddle.Stop()
            pctPlayer3.BackColor = Color.Green
            MsgBox("Congratulations " & player3 & ", you just beat " & player1 & ", " & player2 & ", and " & player4 & "!")
        End If
        If lblNum4.Text = 20 Then
            tmrMoveBall.Stop()
            tmrPaddle.Stop()
            pctPlayer4.BackColor = Color.Green
            MsgBox("Congratulations " & player4 & ", you just beat " & player1 & ", " & player2 & ", and " & player3 & "!")
        End If
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            pUp = True
        End If
        If e.KeyCode = Keys.S Then
            pDown = True
        End If
        If e.KeyCode = Keys.Up Then
            pUp2 = True
        End If
        If e.KeyCode = Keys.Down Then
            pDown2 = True
        End If
        If e.KeyCode = Keys.O Then
            pLeft = True
        End If
        If e.KeyCode = Keys.P Then
            pRight = True
        End If
        If e.KeyCode = Keys.NumPad4 Then
            pLeft2 = True
        End If
        If e.KeyCode = Keys.NumPad6 Then
            pRight2 = True
        End If
        If e.KeyCode = Keys.Return And returnBall = True Then
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            startGame()
            pctPlayer1.BackColor = Color.White
            pctPlayer2.BackColor = Color.White
            pctPlayer3.BackColor = Color.White
            pctPlayer4.BackColor = Color.White
            tmrPaddle.Start()
            returnBall = False
        End If
    End Sub

    Private Sub Form4_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            pUp = False
        End If
        If e.KeyCode = Keys.S Then
            pDown = False
        End If
        If e.KeyCode = Keys.Up Then
            pUp2 = False
        End If
        If e.KeyCode = Keys.Down Then
            pDown2 = False
        End If
        If e.KeyCode = Keys.O Then
            pLeft = False
        End If
        If e.KeyCode = Keys.P Then
            pRight = False
        End If
        If e.KeyCode = Keys.NumPad4 Then
            pLeft2 = False
        End If
        If e.KeyCode = Keys.NumPad6 Then
            pRight2 = False
        End If
    End Sub

    Private Sub tmrPaddle_Tick(sender As Object, e As EventArgs) Handles tmrPaddle.Tick
        If pUp = True And pctPlayer1.Top > pctPlayer3.Bottom Then
            pctPlayer1.Top = pctPlayer1.Top - 10
        End If
        If pDown = True And pctPlayer1.Bottom < pctPlayer4.Top Then
            pctPlayer1.Top = pctPlayer1.Top + 10
        End If
        If pUp2 = True And pctPlayer2.Top > pctPlayer3.Bottom Then
            pctPlayer2.Top = pctPlayer2.Top - 10
        End If
        If pDown2 = True And pctPlayer2.Bottom < pctPlayer4.Top Then
            pctPlayer2.Top = pctPlayer2.Top + 10
        End If
        If pLeft = True And pctPlayer3.Left > pctPlayer1.Right Then
            pctPlayer3.Left = pctPlayer3.Left - 10
        End If
        If pRight = True And pctPlayer3.Right < pctPlayer2.Left Then
            pctPlayer3.Left = pctPlayer3.Left + 10
        End If
        If pLeft2 = True And pctPlayer4.Left > pctPlayer1.Right Then
            pctPlayer4.Left = pctPlayer4.Left - 10
        End If
        If pRight2 = True And pctPlayer4.Right < pctPlayer2.Left Then
            pctPlayer4.Left = pctPlayer4.Left + 10
        End If

    End Sub
    Private Sub startGame()
        x = rnum.Next(-5, 5)
        y = rnum.Next(-5, 5)
        If x = -3 Or x = -2 Or x = -1 Or x = 0 Then
            x = -4
        ElseIf x = 1 Or x = 2 Or x = 3 Then
            x = 4
        End If
        If y = -3 Or y = -2 Or y = -1 Or y = 0 Then
            y = -4
        ElseIf y = 1 Or y = 2 Or y = 3 Then
            y = 4
        End If
        tmrMoveBall.Interval = 30
        tmrPaddle.Start()
        tmrMoveBall.Start()
    End Sub
    Private Sub resetPaddles()
        tmrPaddle.Stop()
        pctPlayer1.Top = playArea.Height / 2 - pctPlayer1.Height / 2
        pctPlayer2.Top = playArea.Height / 2 - pctPlayer2.Height / 2
        pctPlayer3.Left = playArea.Width / 2 - pctPlayer3.Width / 2
        pctPlayer4.Left = playArea.Width / 2 - pctPlayer4.Width / 2
    End Sub

    Private Sub pctPlayer2_Click(sender As Object, e As EventArgs) Handles pctPlayer2.Click

    End Sub
End Class