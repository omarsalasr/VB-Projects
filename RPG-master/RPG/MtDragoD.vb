Public Class MtDragoD
    Dim charMove As Boolean
    Dim conv As Boolean
    Dim nextConv As Integer
    Dim dragonDead As Boolean
    Dim doorLock As Boolean
    Dim doomed As Boolean
    Dim finalConv As Integer
    Dim expLeave As Boolean
    Dim x As Integer
    Dim collide As Boolean
    Dim walls() As PictureBox


    Private Sub MtDragoD_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtMessages.Clear()
    End Sub
    Private Sub MtDragoD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If doorLock = False Then
            If mainChar.Bounds.IntersectsWith(pctMtDrago.Bounds) = True Then
                Me.Hide()
                MtDrago.Show()
            End If
        End If
        If e.KeyCode = Keys.E Then
            If mainChar.Bounds.IntersectsWith(pctDragon.Bounds) = True Then
                dragonHead = True
                PictureBox1.Visible = True
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "You got the Dragons Head, press H to put it on, you can only put it on one time." & txtMessages.Text
            End If
            If mainChar.Bounds.IntersectsWith(pctEgg.Bounds) = True Then
                pctEgg.Visible = False
                pctEgg.Left += 300
                egg2 = True
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "You found an egg." & txtMessages.Text
            End If
        End If
        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If
    End Sub

    Private Sub MtDragoD_Load(sender As Object, e As EventArgs) Handles Me.Load
        charMove = False
        conv = True
        doorLock = True
        walls = {w1, w2, w3, w4, w5}
        enterL = True
    End Sub

    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick
        If conv = True Then
            If nextConv = 0 Then
                If sword = True Then
                    txtMessages.Text = vbNewLine & "I think you should have gone to the castle." & txtMessages.Text
                ElseIf sword = False Then
                    txtMessages.Text = vbNewLine & "Well I think this is the end." & txtMessages.Text
                    doomed = True
                    'IMAGEGIF.SHOW
                    conv = False
                    'GAME OVER
                End If
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Dragon: RRROOOOOAAAARRR!!!" & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Use the sword to kill the Dragon." & txtMessages.Text
                charMove = True
                Timer1.Start()
                doorLock = False
                btnSmash.Visible = True
                btnSmash.Enabled = True
                ProgressBar1.Visible = True
                pctSword.Visible = True
                nextConv = -1
                conv = False
            End If
                nextConv += 1
        End If
        If dragonDead = True Then
            If nextConv = 0 Then
                pctSword.Visible = False
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Dragon: RRRROOOOOAAAAARRRR!" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "You actually beat the Dragon!" & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Well, no more distractions, lets get to the castle." & txtMessages.Text
            End If
            nextConv += 1
        End If
        If doomed = True Then
            If finalConv = 1 Then
                PictureBox3.BringToFront()
            ElseIf finalConv = 2 Then
                lblEnd.Visible = True
                charMove = False
            End If
            finalConv += 1
        End If

        If expLeave = True Then
            If x = 1 Then
                PictureBox5.Enabled = False
                PictureBox5.SendToBack()
            End If
            x += 1
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(-1)
        If ProgressBar1.Value >= ProgressBar1.Maximum - 5 Then
            pctSword.Width = 34
            pctSword.Height = 158
            pctSword.Left = mainChar.Left - 5
            pctSword.Top = mainChar.Top - 158
            dragonDead = True
            PictureBox5.BringToFront()
            PictureBox5.Enabled = True
            expLeave = True
            txtMessages.Text = vbNewLine & hero.hName & ": Sword Explosion" & txtMessages.Text
            pctSword.Image = ImageList1.Images(0)
            btnSmash.Enabled = False
            btnSmash.Visible = False
            ProgressBar1.Dispose()
            Timer1.Stop()
        End If
    End Sub

    Private Sub btnSmash_Click(sender As Object, e As EventArgs) Handles btnSmash.Click
        ProgressBar1.Increment(10)
    End Sub
End Class