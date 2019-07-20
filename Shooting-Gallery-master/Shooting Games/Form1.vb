Public Class Form1
    Dim rand As New Random
    Dim score As Integer
    Dim y As Integer
    Dim x As Integer
    Dim sLeft As Boolean
    Dim sRight As Boolean
    Dim bullet1 As Boolean
    Private Sub tmrMoveDragon_Tick(sender As Object, e As EventArgs) Handles tmrMoveDragon.Tick
        DragonRed.Left = DragonRed.Left + 15
        Label1.Text -= 1
        If Label1.Text < 80 Then
            DragonGreen.Left = DragonGreen.Left - 10
        End If
        y = y + rand.Next(-5, 5)
        DragonRed.Top = y
        x = x + rand.Next(-5, 5)
        DragonGreen.Top = x
        If DragonRed.Left > pctBackground.Right Or pctBullet.Bounds.IntersectsWith(DragonRed.Bounds) Then
            DragonRed.Left = pctBackground.Left - 20
            moveBullet()
            pctBullet.Visible = False
            tmrMoveBullet.Stop()
            score = score + 20
            lblScore.Text = score
        End If
        If DragonGreen.Right + 20 < pctBackground.Left Or pctBullet.Bounds.IntersectsWith(DragonGreen.Bounds) Then
            DragonGreen.Left = pctBackground.Right - 20
            moveBullet()
            pctBullet.Visible = False
            tmrMoveBullet.Stop()
            score = score - 10
            lblScore.Text = score
        End If
        If pctBullet.Top < 27 Then
            pctBullet.Visible = False
            tmrMoveBullet.Stop()
        End If
        If lblScore.Text > 200 Then
            tmrMoveDragon.Stop()
            tmrMoveShip.Stop()
            MsgBox("You win")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Shoot the Dragons! Use the Keys A and D to move your ship and press thes the Space key to shoot or click them. Shoot the Red Dragons for 20 points, but avoid the Green ones they take away 10, when you reach 200 points, you win")
        Button1.Enabled = False
        tmrMoveDragon.Start()
        tmrMoveShip.Start()
        DragonRed.Enabled = True
        y = rand.Next(300, 330)
        x = rand.Next(300, 330)
        Button1.Visible = False
        bullet1 = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctSpaceShip.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            sLeft = True
        End If
        If e.KeyCode = Keys.D Then
            sRight = True
        End If
        If e.KeyCode = Keys.Space Then
            tmrMoveBullet.Start()
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then
            sLeft = False
        End If
        If e.KeyCode = Keys.D Then
            sRight = False
            If e.KeyCode = Keys.Space Then
                bullet1 = False
            End If
        End If
    End Sub

    Private Sub tmrMoveShip_Tick(sender As Object, e As EventArgs) Handles tmrMoveShip.Tick
        If sLeft = True And pctSpaceShip.Left > pctBackground.Left Then
            pctSpaceShip.Left = pctSpaceShip.Left - 10
        End If
        If sRight = True And pctSpaceShip.Right < pctBackground.Right Then
            pctSpaceShip.Left = pctSpaceShip.Left + 10
        End If
    End Sub

    Private Sub tmrMoveBullet_Tick(sender As Object, e As EventArgs) Handles tmrMoveBullet.Tick
        If pctBullet.Visible = False Then
            moveBullet()
            pctBullet.Visible = True
        End If
        pctBullet.Top = pctBullet.Top - 20

    End Sub

    Private Sub DragonRed_Click(sender As Object, e As EventArgs) Handles DragonRed.Click
        DragonRed.Left = pctBackground.Left - 10
        lblScore.Text = score
        score = score + 10
    End Sub

    Private Sub DragonGreen_Click(sender As Object, e As EventArgs) Handles DragonGreen.Click
        DragonGreen.Left = pctBackground.Right
        lblScore.Text = score
        score = score - 5
    End Sub
    Private Sub moveBullet()
        pctBullet.Top = pctSpaceShip.Top - 10
        pctBullet.Left = pctSpaceShip.Left + pctSpaceShip.Width / 2 - pctBullet.Width / 2
    End Sub
End Class
