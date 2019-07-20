Public Class Plaza
    Dim conversation As Boolean
    Dim conversation2 As Boolean
    Dim nextConv As Integer
    Dim nextConv1 As Integer
    Dim otherGuyConv As Boolean
    Dim vermelConv As Boolean
    Dim nextConv2 As Integer
    Dim charMove As Boolean
    Dim otherGuyLeave As Boolean
    Dim finalConv As Integer
    Dim hillB As Boolean
    Dim HillConv As Boolean
    Dim collide As Boolean
    Dim enterH As Boolean
    Dim walls() As PictureBox
    Private Sub tmrMoveChar_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Plaza_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtMessages.Clear()
        pctOtherGuy.Enabled = True

        If noDate = True And midnight = True Then
            tmrCivMove.Start()
            enterH = True
            charMove = False
            hillB = True
            pctHillGuy.Visible = True
        End If

    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown



        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If e.KeyCode = Keys.R Then
            nextConv -= 2
        End If

        If enterH = False Then
            If mainChar.Bounds.IntersectsWith(pctHouse.Bounds) = True Then
                Me.Hide()
                House.Show()
            End If
        End If
        If mainChar.Bounds.IntersectsWith(pctOtherGuy.Bounds) = True Then
            tmrConv.Start()
            otherGuyConv = True

        End If
        If enterF = False Then
            If mainChar.Bounds.IntersectsWith(pctVillage.Bounds) = True Then
                Me.Hide()
                Fountain.Show()
            End If
        End If
        If mainChar.Bounds.IntersectsWith(pctShopArea.Bounds) = True Then
            Me.Hide()
            ShopArea.Show()
        End If

        If mainChar.Bounds.IntersectsWith(pctForestDoor.Bounds) = True Then
            Me.Hide()
            Forest_1.Show()
        End If
        If enterM = True Then
            If mainChar.Bounds.IntersectsWith(pctMtDrago.Bounds) = True Then
                Me.Hide()
                MtDrago.Show()
            End If
        End If
        If enterC = True Then
            If mainChar.Bounds.IntersectsWith(pctCastleD.Bounds) = True Then
                Me.Hide()
                Castle.Show()
            End If
        End If

        If e.KeyCode = Keys.Space Then
            nextConv2 += 1
        End If

    End Sub
    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick
        If conversation = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "What is with the huge crowd?" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Crowd: Give us our king." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "What happened to the King." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Go talk to that guy." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                charMove = True
                tmrConv.Stop()
            End If
            nextConv += 1
        End If

        If otherGuyConv = True Then
            If nextConv1 = 0 Then
                mainChar.Left -= 10
                charMove = False
                txtMessages.Text = vbNewLine & hero.hName & ": Hey, what happened here?" & txtMessages.Text
            ElseIf nextConv1 = 1 Then
                txtMessages.Text = vbNewLine & "Legolas: The king was kidnapped by some weird guys." & txtMessages.Text
            ElseIf nextConv1 = 2 Then
                pctAkats.Visible = True
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                vermelConv = True
            End If
            nextConv1 += 1
        End If

        If vermelConv = True Then
            If nextConv2 = 0 Then
                pctAkats.Visible = True
                txtMessages.Text = vbNewLine & "Vermel: Citizens of Pandora, your new king has arrived, Vermel." & txtMessages.Text
            ElseIf nextConv2 = 1 Then
                txtMessages.Text = vbNewLine & "Crowd: BBBBOOOOOOOOOOOOO!!!!!!" & txtMessages.Text
            ElseIf nextConv2 = 2 Then
                txtMessages.Text = vbNewLine & "Vermel: Your old king seemed a bit too mean, so I took care of him and threw him in the dungeon." & txtMessages.Text
            ElseIf nextConv2 = 3 Then
                txtMessages.Text = vbNewLine & "Crowd: Your the mean one you phony king." & txtMessages.Text
            ElseIf nextConv2 = 4 Then
                txtMessages.Text = vbNewLine & "Vermel: As your new king, I will arrest any person who dares talk about Crota." & txtMessages.Text
            ElseIf nextConv2 = 5 Then
                txtMessages.Text = vbNewLine & "Vermel: Now BEGONE!" & txtMessages.Text
                pctAkats.Visible = False
            ElseIf nextConv2 = 6 Then
                pctAkats.Visible = False
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                tmrCivMove.Start()
            ElseIf nextConv2 = 7 Then
                txtMessages.Text = vbNewLine & "Legolas: Well smell ya later." & txtMessages.Text
                charMove = True
                otherGuyLeave = True
            ElseIf nextConv2 = 8 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
            ElseIf nextConv2 = 9 Then
                txtMessages.Text = vbNewLine & "Well, don't just stand there " & hero.hName & " go talk to people to find out where Vermel is keeping Crota." & txtMessages.Text
            End If
            nextConv2 += 1
        End If
        If altEnding = True Then
            charMove = False
            pctMe.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            If finalConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": I " & hero.hName & ", am your new king, it seems Crota was a tyrant, I took care of him." & txtMessages.Text
            ElseIf finalConv = 2 Then
                txtMessages.Text = vbNewLine & "Crowd: Not again." & txtMessages.Text
            ElseIf finalConv = 3 Then
                PictureBox4.BringToFront()
                lblEndAtl.BringToFront()
                lblEndAtl.Visible = True
            End If
            finalConv += 1
        End If
        If ending = True Then
            charMove = True
            pctMe2.Visible = True
            pctKing.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            If finalConv = 1 Then
                txtMessages.Text = vbNewLine & "Crota: Behold our hero, he saved us." & txtMessages.Text
            ElseIf finalConv = 2 Then
                txtMessages.Text = vbNewLine & "Crowd: We are saved, yyyyyyyyeeeeeeaaaaahhhh!!!" & txtMessages.Text
            ElseIf finalConv = 3 Then
                PictureBox4.BringToFront()
                Label1.BringToFront()
                Label1.Visible = True
            End If
            finalConv += 1
        End If

        If HillConv = True Then
            If finalConv = 0 Then
                txtMessages.Text = vbNewLine & "HillBilly: You didn't get me a date with her so now your busted." & txtMessages.Text
            ElseIf finalConv = 1 Then
                lblEnd.Visible = True
            End If
            finalConv += 1
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrConv.Start()
        House.txtMessages.Text = ""
        conversation = True
        enterC = False
        walls = {w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, w11, w12}
    End Sub

    Private Sub tmrCivMove_Tick(sender As Object, e As EventArgs) Handles tmrCivMove.Tick
        p1.Left -= 3
        PictureBox1.Left += 3
        If otherGuyLeave = True Then
            pctOtherGuy.Left += 3
        End If
        If pctOtherGuy.Left >= Me.Right Then
            tmrCivMove.Stop()
        End If

        If hillB = True Then
            pctHillGuy.Left -= 3
            If mainChar.Bounds.IntersectsWith(pctHillGuy.Bounds) = True Then
                HillConv = True
            End If
        End If
    End Sub
End Class