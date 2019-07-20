Public Class Fountain
    Dim couple As Boolean
    Dim charMove As Boolean
    Dim person1 As Boolean
    Dim person2 As Boolean
    Dim person3 As Boolean
    Dim person4 As Boolean
    Dim oneTime1 As Boolean
    Dim oneTime2 As Boolean
    Dim oneTime3 As Boolean
    Dim oneTime4 As Boolean
    Dim person4Run As Boolean
    Dim hiddenManConv As Boolean
    Dim hiddenManLeave As Boolean
    Dim Stocker As Boolean
    Dim groupTalk As Boolean
    Dim groupLeave As Boolean
    Dim nextConv As Integer
    Dim dateConv As Boolean
    Dim privacyC As Boolean
    Dim hillLeave As Boolean
    Dim busted As Boolean
    Dim collide As Boolean
    Dim walls() As PictureBox

    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        charMove = True
        If gDate = True Then
            pctHillGuy.Visible = True
            pctHillGuy.Enabled = True
            pctShopG.Visible = True
            pctShopG.Enabled = True
            dateConv = True
            pctPerson1.Left += 5000
            pctPerson2.Left += 5000
            pctPerson3.Left += 5000
            pctPerson4.Left += 5000
        Else
        End If
        txtMessages.Clear()
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        
        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If e.KeyCode = Keys.R Then
            nextConv -= 2
        End If

        If oneTime1 = False Then
            If mainChar.Bounds.IntersectsWith(pctPerson1.Bounds) = True Then
                person1 = True
                charMove = False
                oneTime1 = True
            End If
        End If
        If oneTime2 = False Then
            If mainChar.Bounds.IntersectsWith(pctPerson2.Bounds) = True Then
                person2 = True
                charMove = False
                oneTime2 = True
            End If
        End If
        If oneTime3 = False Then
            If mainChar.Bounds.IntersectsWith(pctPerson3.Bounds) = True Then
                person3 = True
                charMove = False
                oneTime3 = True
            End If
        End If
        If oneTime4 = False Then
            If mainChar.Bounds.IntersectsWith(pctPerson4.Bounds) = True Then
                person4 = True
                charMove = False
                oneTime4 = True
            End If
        End If
        If mainChar.Bounds.IntersectsWith(pctOutsideCastle.Bounds) = True Then
            Me.Hide()
            Plaza.Show()
        End If
        If sleepTime = False Then
            If mainChar.Bounds.IntersectsWith(pctGMem1.Bounds) = True Or mainChar.Bounds.IntersectsWith(pctGMem2.Bounds) = True Then
                groupTalk = True
                charMove = False
            End If
        End If
        If mainChar.Bounds.IntersectsWith(pctHiddenPerson.Bounds) = True And Stocker = True Then
            pctHiddenPerson.Visible = True
            hiddenManConv = True
            charMove = False
        End If
        If gDate = True Then
            If mainChar.Bounds.IntersectsWith(pctShopG.Bounds) = True Or mainChar.Bounds.IntersectsWith(pctHillGuy.Bounds) = True Then
                privacyC = True

            End If
        End If

        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If
    End Sub

    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick
        If person1 = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & hero.hName & ": Do you know anything about..." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Jiraiya: (whispering) Dont mention you know whos name." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Jiraiya: I heard that a man was tortured and tossed out in the river." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Well at least he worned you." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                charMove = True
                nextConv = -1
                person1 = False
            End If
            nextConv += 1
        End If

        If person2 = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Gray: WE ARE DOOMED FOREVER!" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "I think we should just leave." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                charMove = True
                nextConv = -1
                person2 = False
            End If
            nextConv += 1
        End If

        If person3 = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Jet: Do you have the goods." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": What goods?" & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Jet: What do you mean you don't know, everybody knows." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Well not everybody." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Jet: The candy bro." & txtMessages.Text
            ElseIf nextConv = 5 Then
                txtMessages.Text = vbNewLine & "I think he had too much candy, leave him." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                charMove = True
                nextConv = -1
                person3 = False
            End If
            nextConv += 1
        End If

        If person4 = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Shrek: Hey, do you want to see a magic trick?" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Sure" & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Shrek: Close your eyes and count to 3." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & hero.hName & ": 1..." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & hero.hName & ": 2..." & txtMessages.Text
            ElseIf nextConv = 5 Then
                txtMessages.Text = vbNewLine & hero.hName & ": 3... AAAAAAHHHHH" & txtMessages.Text
                mainChar.Top += 25
                person4Run = True
            ElseIf nextConv = 6 Then
                txtMessages.Text = vbNewLine & hero.hName & ": You thief, come back with my running shoes." & txtMessages.Text
            ElseIf nextConv = 7 Then
                txtMessages.Text = vbNewLine & "I don't think you should have talked to that guy." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                charMove = True
                noRunningShoes = True
                nextConv = -1
                person4 = False
            End If
            nextConv += 1
        End If

        If groupTalk = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Natsu: Do you want to help us with a job?" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": What kind of job?" & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Naruto: We want to rescue, you know who." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Natsu: We've been here too much time." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Naruto: If you want in, kidnap the guard by the shop." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
            ElseIf nextConv = 5 Then
                txtMessages.Text = vbNewLine & "If your going to capture a someone, maybe you should get a rope, there might be one in your house." & txtMessages.Text
                groupLeave = True
                Stocker = True
                sleepTime = True
            ElseIf nextConv = 6 Then
                txtMessages.Text = vbNewLine & "Well its still not midnight, you should go sleep to make time go by." & txtMessages.Text
                charMove = True
                nextConv = -1
                groupTalk = False
            End If
            nextConv += 1
        End If

        If hiddenManConv = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                txtMessages.Text = vbNewLine & "Hillbilly: Watch where your stepping!" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Sorry" & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Hillbilly: I heard what your triying to do." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & hero.hName & ": I have no clue what your saying." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Hillbilly: I heard you and im going to tell our King." & txtMessages.Text
            ElseIf nextConv = 5 Then
                txtMessages.Text = vbNewLine & hero.hName & ": NNNOOO, dont tell him, i'll do anything you want." & txtMessages.Text
            ElseIf nextConv = 6 Then
                txtMessages.Text = vbNewLine & "Hillbilly: Fine then, get me a date with the girl from the shop." & txtMessages.Text
            ElseIf nextConv = 7 Then
                txtMessages.Text = vbNewLine & hero.hName & ": She would never go out with a Hillbilly." & txtMessages.Text
            ElseIf nextConv = 8 Then
                txtMessages.Text = vbNewLine & "Hillbilly: Date or King, you choose, and chooce quickly I want a date by midnight." & txtMessages.Text
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                hiddenManLeave = True
            ElseIf nextConv = 9 Then
                txtMessages.Text = vbNewLine & "Well, you really are in a pickle." & txtMessages.Text
                noDate = True
                charMove = True
                planB = True
                nextConv = -1
                hiddenManConv = False
            End If
            nextConv += 1
        End If
        If dateConv = True Then
            txtMessages.Text = vbNewLine & "" & txtMessages.Text
            txtMessages.Text = vbNewLine & "Hillbilly: Haven't you heard of privacy, get out of here or else." & txtMessages.Text
            dateConv = False
        End If
        If privacyC = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "Hillbilly: You crossed the line, i'm telling Vermel." & txtMessages.Text
                hillLeave = True
            End If
        End If
    End Sub
    Private Sub tmrMovePeople_Tick(sender As Object, e As EventArgs) Handles tmrMovePeople.Tick
        If person4Run = True Then
            pctPerson4.Image = ImageList1.Images(0)
            pctPerson4.Left -= 3
            If pctPerson4.Bounds.IntersectsWith(pctPerson2.Bounds) = True Then
                pctPerson2.Top += 70
                txtMessages.Text = vbNewLine & "Shrek: MMMMMMMMMMMMOOOOOOOOOOOVVVVVVVVVVEEEEEEEEEE!!!!!!" & txtMessages.Text
            End If
        End If
        If groupLeave = True Then
            pctGMem1.Left -= 8
            pctGMem2.Left -= 8
        End If
        If hiddenManLeave = True Then
            pctHiddenPerson.Image = ImageList1.Images(1)
            pctHiddenPerson.Left -= 3
        End If
        If hillLeave = True Then
            pctHillGuy.Image = ImageList1.Images(1)
            pctHillGuy.Left -= 3
            If pctHillGuy.Bounds.IntersectsWith(pctOutsideCastle.Bounds) = True Then
                lblEnd.Visible = True
                charMove = False
                hillLeave = False
            End If
        End If
    End Sub

    Private Sub Fountain_Load(sender As Object, e As EventArgs) Handles Me.Load
        walls = {w1, w2, w3, w4}
    End Sub
End Class