Public Class ForestL
    Dim charMove As Boolean
    Dim nextConv As Integer
    Dim golem As Boolean
    Dim visit As Boolean
    Dim golemLeave As Boolean
    Dim oneTime As Boolean
    Dim up As Boolean
    Dim golemEat As Boolean
    Dim collide As Boolean
    Dim walls() As PictureBox


    Private Sub ForestL_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If lighter = True Then
            pctLighter.Visible = True
            pctLighter.Left = mainChar.Left - 26

        End If
        txtMessages.Clear()
    End Sub

    Private Sub ForestL_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        
        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If e.KeyCode = Keys.R Then
            nextConv -= 2
        End If

        If mainChar.Bounds.IntersectsWith(pctGolem.Bounds) = True And golemLeave = False Then
            golemEat = True
        End If

        pctLighter.Left = mainChar.Left - 26
        pctLighter.Top = mainChar.Top
        'MAKE FIRE APPEAR
        If mainChar.Bounds.IntersectsWith(pctForestR.Bounds) = True Then
            Me.Hide()
            Forest_1.Show()
        End If
        If oneTime = False Then
            If mainChar.Bounds.IntersectsWith(PictureBox3.Bounds) = True Then
                If lighter = False Then
                    txtMessages.Text = vbNewLine & "" & txtMessages.Text
                    txtMessages.Text = vbNewLine & "Golem: Don't come any further, or else i'll eat you up alive." & txtMessages.Text
                    txtMessages.Text = vbNewLine & "" & txtMessages.Text
                    txtMessages.Text = vbNewLine & "Maybe he's afraid of fire, go check in your house for a lighter." & txtMessages.Text
                    visit = True
                    oneTime = True
                Else
                    golem = True
                End If

            End If
        End If
        If lighter = True And mainChar.Bounds.IntersectsWith(PictureBox3.Bounds) = True Then
            golem = True
        End If
        If e.KeyCode = Keys.E Then
            If mainChar.Bounds.IntersectsWith(pctEgg.Bounds) = True Then
                MsgBox("You picked up the egg.")
                egg1 = True
                pctEgg.Visible = False
                pctEgg.Enabled = False
                pctEgg.Left -= 300
            End If
            If mainChar.Bounds.IntersectsWith(pctRock.Bounds) = True Then
                MsgBox("You picked up a useless rock.")
                rock = True
                pctRock.Visible = False
                pctRock.Enabled = False
                pctRock.Left -= 300
            End If
        End If
        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If
    End Sub

    Private Sub tmrConversation_Tick(sender As Object, e As EventArgs) Handles tmrConversation.Tick
        
        If golem = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "" & txtMessages.Text
                If visit = True Then
                    txtMessages.Text = vbNewLine & "Golem: I already told you." & txtMessages.Text
                ElseIf visit = False Then
                    txtMessages.Text = vbNewLine & "Golem: Get lost Buddy." & txtMessages.Text
                End If
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Golem: Wait, how did you know i'm affraid of fire." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Golem: GET AWAY FROM MMMMMEEE!" & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Well, will ya look at that, he's affraid of fire." & txtMessages.Text
                tmrMovePeople.Start()
                golemLeave = True
                up = True
                golem = False
                PictureBox3.Enabled = False
            End If
            nextConv += 1
        End If

    End Sub

    Private Sub tmrMovePeople_Tick(sender As Object, e As EventArgs) Handles tmrMovePeople.Tick

        If golemLeave = True Then

            If up = True Then pctGolem.Top -= 3
            If pctGolem.Bottom + 20 < pctEgg.Top Then
                up = False
                pctGolem.Left -= 3
            End If
        End If

        If golemEat = True Then
            pctGolem.Left += 3
            If pctGolem.Right >= mainChar.Right Then
                golemEat = False
                lblEnd.Visible = True

                charMove = False
            End If
        End If
    End Sub

    Private Sub ForestL_Load(sender As Object, e As EventArgs) Handles Me.Load
        charMove = True
        walls = {w1, w2, w3, w4, w5}
    End Sub
End Class