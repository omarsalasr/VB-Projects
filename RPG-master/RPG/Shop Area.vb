Public Class ShopArea
    Dim charMove As Boolean
    Dim nextConv As Integer
    Dim girlConv As Boolean
    Dim guardConv As Boolean
    Dim gLeave As Boolean
    Dim giveEgg As Boolean
    Dim oneTime As Boolean
    Dim groupEnter As Boolean
    Dim moveLeft As Boolean
    Dim moveDown As Boolean
    Dim interogation As Boolean
    Dim justOne1 As Boolean
    Dim justTime3 As Boolean
    Dim justOne2 As Boolean
    Dim groupLeave As Boolean
    Dim moveUp As Boolean
    Dim moveRight As Boolean
    Dim guardFollow As Boolean
    Dim gConv2 As Boolean
    Dim visionOff As Boolean
    Dim throwRock As Boolean
    Dim justonce As Boolean
    Dim flipGI As Integer
    Dim flipG As Boolean
    Dim collide As Boolean
    Dim walls() As PictureBox

    Private Sub Shop_Area_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'midnight = True
        rope = True
        If midnight = True Then
            pctGuard.Visible = True
            pctGuard.Enabled = True
            Timer1.Start()
            pctShopG.Visible = False
            pctGMem2.Left = pctGMem1.Left + 66
        End If
        'MIDNIGHT
        If egg2 = True Then
            Timer1.Stop()
            PictureBox5.Visible = True
        End If
        txtMessages.Clear()
    End Sub
    Private Sub Shop_Area_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        
        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If e.KeyCode = Keys.R Then
            nextConv -= 2
        End If

        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If

        If mainChar.Bounds.IntersectsWith(pctPlaza.Bounds) = True Then
            Me.Hide()
            Plaza.Show()
        End If
        If midnight = False Then
            If mainChar.Bounds.IntersectsWith(pctShopG.Bounds) = True Or mainChar.Bounds.IntersectsWith(PictureBox1.Bounds) = True Then
                girlConv = True
                charMove = False
            End If
        End If
        If midnight = True Then
            If mainChar.Bounds.IntersectsWith(pctVision.Bounds) = True Or mainChar.Bounds.IntersectsWith(pctVision2.Bounds) = True Then
                guardConv = True
            End If
        ElseIf midnight = False Then
            visionOff = True
        End If
        If egg1 = True And mainChar.Bounds.IntersectsWith(PictureBox1.Bounds) = True Then
            giveEgg = True
            charMove = False
        End If
        If e.KeyCode = Keys.E Then
            If mainChar.Bounds.IntersectsWith(pctThrowArea.Bounds) = True Then
                pctRock.Visible = True
                throwRock = True
                txtMessages.Text = vbNewLine & "The guard is distracted" & txtMessages.Text
                pctGuard.Image = ImageList1.Images(0)
                pctVision.Left = pctGuard.Left - 348
                pctVision2.Left -= 150
                rock = False
                flipG = True
            End If
            If mainChar.Bounds.IntersectsWith(pctGuard.Bounds) And rope = True Then
                txtMessages.Text = vbNewLine & hero.hName & ": Now you can't go anywhere." & txtMessages.Text
                visionOff = True
                pctVision.Left -= 10000
                pctVision2.Left -= 10000
                flipG = False
                pctRope.Visible = True
                Timer1.Start()
                moveLeft = True
                groupEnter = True
                charMove = False
            End If
        End If

        If mainChar.Bounds.IntersectsWith(PictureBox1.Bounds) = True And egg2 = True Then
            gConv2 = True
            charMove = False
        End If

        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If
    End Sub
    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick
        If girlConv = True And planB = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Lucy: Hey " & hero.hName & ", what a day don't you think." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Yeah, hey can I ask you something, but you mustn't tell anyone." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Lucy: Ok, I promise" & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & hero.hName & ": These two guys want me to help them rescue you know who." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & hero.hName & ": But some hillbilly was listening and is going to tell Vermel." & txtMessages.Text
            ElseIf nextConv = 5 Then
                txtMessages.Text = vbNewLine & "Lucy: Sounds like your in trouble, but i'll help you." & txtMessages.Text
            ElseIf nextConv = 6 Then
                txtMessages.Text = vbNewLine & hero.hName & ": All you need to do is go on a date with that hillbilly." & txtMessages.Text
            ElseIf nextConv = 7 Then
                txtMessages.Text = vbNewLine & "Lucy: Are you crazy, im not doing it, unless you bring me a dragon egg." & txtMessages.Text
            ElseIf nextConv = 8 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Fine i'll look for one." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                charMove = True
                nextConv = -1
                planB = False
                girlConv = False

            End If

            nextConv += 1
        End If

        If flipG = True Then
            If flipGI = 2 Then
                pctGuard.Image = ImageList1.Images(1)
                pctVision.Left = pctGuard.Left + 100
                pctVision2.Left += 160
                flipG = False
            End If
            flipGI += 1
        End If
        If girlConv = True And planB = False And egg1 = False And egg2 = False And gDate = False And justonce = False Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Lucy: Hey " & hero.hName & ", what a day don't you think." & txtMessages.Text
                nextConv = -1
                justonce = True
            End If
            nextConv += 1
        End If

        If giveEgg = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Lucy: Ooh, you got the dragon egg." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Well, now it's your turn do complete my favor." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Go meet that guy at the fountain." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Lucy: Fine." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Well now you can go sleep in peace until midnight." & txtMessages.Text
                charMove = True
                nextConv = -1
                Timer1.Start()
                giveEgg = False
                gDate = True
                noDate = False
                egg1 = False
                gLeave = True
            End If
            nextConv += 1
        End If
        If guardConv = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Guard: What are you doing here, i'm taking you with Vermel." & txtMessages.Text
            ElseIf nextConv = 1 Then
                charMove = False
                lblEnd.Visible = True
                nextConv = -1
                guardConv = False
            End If
            nextConv += 1
        End If
        If interogation = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Natsu: Nice work " & hero.hName & " ." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Naruto: So, Guard, where is Crota." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Guard: He's in a dungeon only Vermel and Crota can open." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Naruto: Tell us how to get in without them." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Guard: I don't know, but I heard a rumor that the legendary swords of the mist can open it." & txtMessages.Text
            ElseIf nextConv = 5 Then
                txtMessages.Text = vbNewLine & "Natsu: No one knows where the 4th sword is, since the other 3 are taken." & txtMessages.Text
            ElseIf nextConv = 6 Then
                txtMessages.Text = vbNewLine & "Guard: If you guys let me go, i'll tell you where the sword is." & txtMessages.Text
            ElseIf nextConv = 7 Then
                txtMessages.Text = vbNewLine & "Naruto: Fine." & txtMessages.Text
            ElseIf nextConv = 8 Then
                txtMessages.Text = vbNewLine & "Guard: It's in one of the chambers of Mt. Drago." & txtMessages.Text
            ElseIf nextConv = 9 Then
                txtMessages.Text = vbNewLine & "Natsu: Well you were helpfull, now Group M2, go take the guard to the river, he might tell Vermel." & txtMessages.Text
            ElseIf nextConv = 10 Then
                txtMessages.Text = vbNewLine & "Guard: But, you said I could leave!" & txtMessages.Text
            ElseIf nextConv = 11 Then
                txtMessages.Text = vbNewLine & "Naruto: I lied." & txtMessages.Text
            ElseIf nextConv = 12 Then
                txtMessages.Text = vbNewLine & "Well, we're off the look for the dragon." & txtMessages.Text
                charMove = True
                pctVision.Left -= 100000
                pctVision2.Left += 100000
                groupLeave = True
                enterM = True
                moveRight = True
                nextConv = -1
                visionOff = True
                interogation = False
            End If
            nextConv += 1
        End If
        If gConv2 = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & hero.hName & ": Hey, I brought you a Dragon egg." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Lucy: I didn't ask for one, but since you brought me one." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Lucy: Here, take this bomb, it's filled with sleeping gas." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Lucy: It will make anyone who smells it to fall asleep, so make sure to cover your nose." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Use the B key to activate the bomb, you only have one so use it wisely." & txtMessages.Text
                charMove = True
                sleepBomb = True
                nextConv = -1
                egg2 = False
                gConv2 = False
            End If
            nextConv += 1
        End If
    End Sub

    Private Sub Shop_Area_Load(sender As Object, e As EventArgs) Handles Me.Load
        charMove = True
        'rock = True
        'midnight = True
        walls = {w1, w2, w3, w4, w5, w6, w7, w8}
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pctGMem2.Left = pctGMem1.Left + 78
        pctGMem2.Top = pctGMem1.Top
        If gLeave = True Then
            pctShopG.Left += 3
            If pctShopG.Left > pctPlaza.Left + 50 Then
                gLeave = False
            End If
        End If
        If groupEnter = True Then
            If moveLeft = True Then
                pctGMem1.Left -= 3
            End If
            If justOne1 = False Then
                If pctGMem1.Left < pctThrowArea.Left Then
                    moveLeft = False
                    moveDown = True
                    justOne1 = True
                End If
            Else
            End If
            If moveDown = True Then
                pctGMem1.Top += 3
            End If
            If pctGMem1.Top - 5 > pctGuard.Bottom Then
                moveLeft = True
                moveDown = False
            End If
            If pctGMem1.Right <= pctGuard.Left + 50 Then
                interogation = True
                justOne1 = False
                groupEnter = False
            End If
        End If

        If groupLeave = True Then
            If moveRight = True Then
                pctGMem1.Left += 3
            End If
            If justOne2 = False Then
                If pctGMem1.Left >= pctGuard.Right Then
                    moveRight = False
                    moveUp = True
                    justOne2 = True
                End If
            Else
            End If
                If moveUp = True Then
                    pctGMem1.Top -= 3
                End If
                If pctGMem1.Top <= pctGuard.Top Then
                    guardFollow = True
                moveRight = True
                moveUp = False
                End If
                If pctGuard.Left >= pctThrowArea.Left Then
                    moveRight = False
                    moveUp = True
                End If

            If pctGMem1.Bottom <= PictureBox1.Bottom Then
                moveUp = False
                pctGMem1.Left += 3
            End If
        If pctGuard.Left >= pctPlaza.Left Then
            moveRight = False

        End If
        End If
        If guardFollow = True Then
            pctGuard.Top = pctGMem1.Top
            pctGuard.Left = pctGMem1.Left - 78
            pctRope.Left = pctGuard.Left
            pctRope.Top = pctGuard.Top + 61

        End If

        If throwRock = True Then
            pctRock.Left -= 20
            pctRock.Top += 15
            If pctRock.Bounds.IntersectsWith(pctLandArea.Bounds) = True Then

                throwRock = False
            End If
        End If


    End Sub
End Class