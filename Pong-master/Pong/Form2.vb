Public Class Form2
    Dim rnum As New Random
    Dim x As Integer
    Dim y As Integer
    Dim pUp As Boolean
    Dim pDown As Boolean
    Dim pUp2 As Boolean
    Dim pDown2 As Boolean
    Dim player1 As String
    Dim player2 As String
    Dim p1Score As Integer
    Dim p2Score As Integer
    Dim returnBall As Boolean
    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        lblScore.Text = ""
        lblPlayer1.Text = "Player 1"
        lblPlayer2.Text = "Player 2"
        pctPlayer1.BackColor = Color.White
        pctPlayer2.BackColor = Color.White
        player1 = InputBox("What is your name Player 1?")
        lblPlayer1.Text = player1
        player2 = InputBox("What is your name Player 2?")
        lblPlayer2.Text = player2
        p1Score = 0
        lblNum1.Text = p1Score
        p2Score = 0
        lblNum2.Text = p2Score
        lblControl.Visible = False
        lblRules.Visible = False
        returnBall = True
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
        If pctBall.Top + playArea.Top < playArea.Top Or pctBall.Bottom + playArea.Top > playArea.Bottom Then
            y = y * -1
        End If
        If pctBall.Left + playArea.Left < playArea.Left Then
            resetPaddles()
            tmrMoveBall.Stop()
            pctBall.Top = playArea.Height / 2 - pctBall.Height / 2
            pctBall.Left = playArea.Width / 2 - pctBall.Width / 2
            lblScore.Text = (player2 & " scored!")
            pctPlayer2.BackColor = Color.Green
            pctPlayer1.BackColor = Color.Red
            p2Score = p2Score + 1
            lblNum2.Text = p2Score
            returnBall = True
            If lblNum2.Text = 10 Then
                MsgBox("Congratulations " & player2 & ", you beat " & player1 & "!")
                lblScore.ForeColor = Color.Blue
                lblScore.Text = player2 & " Wins!"
                tmrMovePaddle.Stop()
            End If
        End If
        If pctBall.Right + playArea.Left > playArea.Right Then
            resetPaddles()
            tmrMoveBall.Stop()
            pctBall.Top = playArea.Height / 2 - pctBall.Height / 2
            pctBall.Left = playArea.Width / 2 - pctBall.Width / 2
            lblScore.Text = (player1 & " scored!")
            pctPlayer2.BackColor = Color.Red
            pctPlayer1.BackColor = Color.Green
            p1Score = p1Score + 1
            lblNum1.Text = p1Score
            returnBall = True
            If lblNum1.Text = 10 Then
                MsgBox("Congratulations " & player1 & ", you beat " & player2 & "!")
                lblScore.ForeColor = Color.Blue
                lblScore.Text = player1 & " Wins!"
                tmrMovePaddle.Stop()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctBall.Click

    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        If e.KeyCode = Keys.Return And returnBall = True Then
            Label2.Visible = False
            Label3.Visible = False
            startGame()
            lblScore.Text = " "
            pctPlayer2.BackColor = Color.White
            pctPlayer1.BackColor = Color.White
            returnBall = False
            tmrMovePaddle.Start()
        End If
    End Sub

    Private Sub tmrMovePaddle_Tick(sender As Object, e As EventArgs) Handles tmrMovePaddle.Tick
        If pUp = True And pctPlayer1.Top + playArea.Top > playArea.Top Then
            pctPlayer1.Top = pctPlayer1.Top - 10
        End If
        If pDown = True And pctPlayer1.Bottom + playArea.Top < playArea.Bottom Then
            pctPlayer1.Top = pctPlayer1.Top + 10
        End If
        If pUp2 = True And pctPlayer2.Top + playArea.Top > playArea.Top Then
            pctPlayer2.Top = pctPlayer2.Top - 10
        End If
        If pDown2 = True And pctPlayer2.Bottom + playArea.Top < playArea.Bottom Then
            pctPlayer2.Top = pctPlayer2.Top + 10
        End If
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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
        tmrMovePaddle.Start()
        tmrMoveBall.Start()
    End Sub

    Private Sub MainScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainScreenToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
        Form1.btn1v1Con.Visible = True
    End Sub
    Private Sub resetPaddles()
        tmrMovePaddle.Stop()
        pctPlayer1.Top = playArea.Height / 2 - pctPlayer1.Height / 2
        pctPlayer2.Top = playArea.Height / 2 - pctPlayer2.Height / 2
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayer1.Text = "Player 1"
        lblPlayer2.Text = "Player 2"
    End Sub
End Class