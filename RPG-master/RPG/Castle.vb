Public Class Castle
    Dim charMove As Boolean
    Dim nextConv As Integer
    Dim nextConv1 As Integer
    Dim guardSleep As Boolean
    Dim onlyOne As Boolean
    Dim trans As Boolean
    Dim headOn As Boolean
    Dim guardRun As Boolean
    Dim busted As Integer
    Dim guardWalk As Boolean
    Dim smokeLeaveI As Integer
    Dim smokeLeave As Boolean
    Dim pics() As PictureBox
    Dim collide As Boolean
    Dim walls() As PictureBox

    Private Sub Castle_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtMessages.Clear()
        txtMessages.Text = vbNewLine & "There's a sword holder, but there's also a lot of guards." & txtMessages.Text
    End Sub
    Private Sub Caslte_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If e.KeyCode = Keys.R Then
            nextConv -= 2
        End If

        If onlyOne = False Then
            If sleepBomb = True Then
                If e.KeyCode = Keys.B Then
                    If mainChar.Bounds.IntersectsWith(pctSwordHolder.Bounds) = True Then
                        'GIF OF SMOKE   
                        smokeLeave = True
                        guardSleep = True

                        
                        sleepBomb = False
                        onlyOne = True
                    End If
                End If
            End If
            
            End If
            If dragonHead = True Then
                If e.KeyCode = Keys.H Then
                    If mainChar.Bounds.IntersectsWith(pctSwordHolder.Bounds) = True Then
                        PictureBox2.Visible = True
                    PictureBox2.Top = mainChar.Top - 85

                    tmrCivMove.Start()
                    'headOn = True
                    'DRAGON HEAD
                    charMove = False
                        guardRun = True
                        txtMessages.Text = vbNewLine & "Guards: ITS A DRAGON, RRRUUUNNN!!!" & txtMessages.Text
                        tmrCivMove.Start()
                        onlyOne = True
                    End If
                End If
            End If
        'End If
        If e.KeyCode = Keys.E Then
            If mainChar.Bounds.IntersectsWith(pctSwordHolder.Bounds) = True Then
                If guardSleep = True Or guardRun = True Then
                    pctSword.Visible = True
                    trans = True
                    PictureBox2.Visible = False
                End If
            End If
            If mainChar.Bounds.IntersectsWith(pctHQ.Bounds) = True Then
                txtMessages.Text = vbNewLine & "The door is locked." & txtMessages.Text
            End If
        End If
        If mainChar.Bounds.IntersectsWith(pctPlaza.Bounds) = True Then
            Me.Hide()
            Plaza.Show()
        End If

        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If
    End Sub
    Private Sub Caslte_Load(sender As Object, e As EventArgs) Handles Me.Load
        charMove = True
        'sleepBomb = True
        'dragonHead = True
        'DRAGON HEAD AND SLEEPBOMB IS = TRUE
        nextConv = 0
        busted = 0
        pics = {p1, p2, p3, p4, p5, p6}
        walls = {w1, w2, w3, w4, w5, w6}
    End Sub
    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick

        If smokeLeave = True Then
            If smokeLeaveI = 0 Then
                PictureBox5.BringToFront()
                PictureBox5.Enabled = True
            ElseIf smokeLeaveI = 1 Then
                txtMessages.Text = vbNewLine & "Nice Job, you put the Guards to sleep" & txtMessages.Text
                PictureBox5.SendToBack()
                For i = 0 To pics.Count - 1
                    pics(i).Visible = True
                Next
                PictureBox5.Enabled = False
                smokeLeave = False
            End If
            smokeLeaveI += 1
        End If
        If guardRun = True Then
            If nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Good work, you scared them, now put the sword in the holder and let's see what happens." & txtMessages.Text
                charMove = True
                PictureBox2.Visible = False
            End If
            nextConv += 1
        End If
        If trans = True Then
            If nextConv1 = 0 Then
                txtMessages.Text = vbNewLine & "It's teleporting you." & txtMessages.Text
            ElseIf nextConv1 = 1 Then
                'SHOW CHAMBER
                Me.Hide()
                Chamber.Show()
                trans = False
            End If
            nextConv1 += 1
        End If
        busted += 1
        If busted > 2 Then
            If guardRun = False And guardSleep = False Then
                txtMessages.Text = vbNewLine & "Guards: There's an intrudor, get him." & txtMessages.Text
                charMove = False
                guardWalk = True
                tmrCivMove.Start()
            End If
        End If
    End Sub
    Private Sub tmrCivMove_Tick(sender As Object, e As EventArgs) Handles tmrCivMove.Tick
        If guardRun = True Then
            one.Top += 5
            two.Left -= 5
            three.Top -= 3
            four.Top -= 3
            five.Left += 5
            six.Top += 5
        End If
        If guardWalk = True Then
            three.Top += 3
            four.Top += 3
            If three.Bounds.IntersectsWith(mainChar.Bounds) = True Or four.Bounds.IntersectsWith(mainChar.Bounds) = True Then
                'GAME OVER
                charMove = False
                guardWalk = False
                lblEnd.Visible = True
                tmrConv.Stop()
                tmrCivMove.Stop()
            End If
        End If
        If headOn = True Then
            PictureBox2.Top = mainChar.Top - mainChar.Height / 2 - mainChar.Height / 2
            PictureBox2.Left = mainChar.Left
        End If
    End Sub
End Class