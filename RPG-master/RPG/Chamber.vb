Public Class Chamber
    Dim charMove As Boolean
    Dim nextConv As Integer
    Dim intiConv As Boolean
    Dim chase As Boolean
    Dim sleepConv As Boolean
    Dim kingConv As Boolean
    Dim enemyLeave As Boolean
    Dim smokeLeave As Boolean
    Dim smokeLeaveI As Integer
    Dim collide As Boolean
    Dim walls() As PictureBox



    Private Sub Chamber_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtMessages.Clear()
    End Sub
    Private Sub Chamber_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If e.KeyCode = Keys.R Then
            nextConv -= 2
        End If

        If mainChar.Bounds.IntersectsWith(pctLine.Bounds) = True Then
            intiConv = True
            charMove = False
        End If

        If chase = True Then
            If sleepBomb = True Then
                If e.KeyCode = Keys.B Then
                    smokeLeave = True
                    'SMOKE ANIMATION
                    sleepConv = True
                    tmrCivMove.Stop()
                End If
            End If
            If dragonHead = True Then
                If e.KeyCode = Keys.H Then
                    'DRAGON HEAD
                    PictureBox7.Visible = True
                    PictureBox7.Top = mainChar.Top - 60
                    PictureBox7.Left = mainChar.Left
                    txtMessages.Text = vbNewLine & "Vermel: Your a dragon, get away from me." & txtMessages.Text
                    enemyLeave = True
                End If
            End If
        End If

        If e.KeyCode = Keys.E Then
            If mainChar.Bounds.IntersectsWith(PictureBox1.Bounds) = True Then
                PictureBox1.Visible = False
                PictureBox4.Visible = True
                kingConv = True
                charMove = False
            End If
        End If

        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If
    End Sub

    Private Sub Chamber_Load(sender As Object, e As EventArgs) Handles Me.Load
        charMove = True
        'dragonHead = True
        walls = {w1, w2, w3, w4, w5, w6, w7}
    End Sub

    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick

        If smokeLeave = True Then
            If smokeLeaveI = 0 Then
                PictureBox6.BringToFront()
                PictureBox6.Enabled = True
            ElseIf smokeLeaveI = 1 Then
                PictureBox6.SendToBack()
                PictureBox6.Enabled = False
                smokeLeave = False
            End If
            smokeLeaveI += 1
        End If

        If intiConv = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "How did you get into the chamber, well nevermind." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "I have Crota and now i'm going to capture you, the only person who knows of this place." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                tmrCivMove.Start()
                chase = True
                charMove = True
                nextConv = -1
                pctLine.Left -= 1000
                intiConv = False
            End If
            nextConv += 1
        End If

        If sleepConv = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Is this poison." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Nope, it's sleeping gas, good night." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                tmrCivMove.Stop()
                nextConv = -1
                sleepConv = False
            End If
            nextConv += 1
        End If

        If kingConv = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Crota: Well you did well finding this place, and what is your name?" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": My name is " & hero.hName & "." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Crota: Well now that i'm freed, lets go to my HQ." & txtMessages.Text
            ElseIf nextConv = 3 Then
                Me.Hide()
                HQ.Show()
                kingConv = False
            End If
            nextConv += 1
        End If
    End Sub

    Private Sub tmrCivMove_Tick(sender As Object, e As EventArgs) Handles tmrCivMove.Tick
        If chase = True Then
            pctAkats.Left += 1
        End If
        If pctAkats.Bounds.IntersectsWith(mainChar.Bounds) = True Then

            lblEnd.Visible = True
            tmrCivMove.Stop()
            'GAME OVER

        End If
        If enemyLeave = True Then
            pctAkats.Left -= 5
            pctAkats.Image = ImageList1.Images(0)
            If pctAkats.Right < Me.Left Then
                PictureBox7.Visible = False
            End If
        End If
    End Sub
End Class