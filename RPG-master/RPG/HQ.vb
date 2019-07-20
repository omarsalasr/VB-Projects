Public Class HQ
    Dim kingConv As Boolean
    Dim nextConv As Integer
    Dim kingMove As Boolean
    Dim kingMoveBack As Boolean
    Dim kingDeath As Boolean
    Dim nextConv1 As Integer
    Dim charMove As Boolean
    Dim collide As Boolean
    Dim walls() As PictureBox

    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick
        If kingConv = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "Crota: You have my gratitude, in return, i'm going to give you a house and endless suply of food and money." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Crota: Let me just find the gold." & txtMessages.Text
                tmrCivMove.Start()
                kingMove = True
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Crota: Here it is." & txtMessages.Text
                kingMoveBack = True
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Crota: Well " & hero.hName & ", you saved me and Pandora, you are a hero." & txtMessages.Text
                ending = True
            ElseIf nextConv = 5 Then
                Me.Hide()
                Plaza.Show()
            End If
            nextConv += 1
        End If

        If kingDeath = True Then
            If nextConv1 = 0 Then
                txtMessages.Text = vbNewLine & hero.hName & ": Good bye, my king." & txtMessages.Text
            ElseIf nextConv1 = 1 Then
                txtMessages.Text = vbNewLine & "Crota: You can never trust anyone anymore." & txtMessages.Text
                p1.Visible = True
            ElseIf nextConv1 = 2 Then
                txtMessages.Text = vbNewLine & hero.hName & ": I'm the new king." & txtMessages.Text
                altEnding = True
            ElseIf nextConv1 = 3 Then
                Me.Hide()
                Plaza.Show()
            End If
            nextConv1 += 1
        End If
    End Sub

    Private Sub tmrCivMove_Tick(sender As Object, e As EventArgs) Handles tmrCivMove.Tick
        If kingMove = True Then
            pctKing.Left += 3
            If pctKing.Bounds.IntersectsWith(PictureBox1.Bounds) = True Then
                kingMove = False
            End If
        End If
    End Sub

    Private Sub HQ_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
     
        keyD(collide, charMove, mainChar, walls, e.KeyCode)


        If e.KeyCode = Keys.E Then
            If mainChar.Bounds.IntersectsWith(pctKing.Bounds) = True Then
                kingConv = False
                nextConv = -1
                kingDeath = True
            End If
        End If
    End Sub

    Private Sub HQ_Load(sender As Object, e As EventArgs) Handles Me.Load
        kingConv = True
        enterC = False
        charMove = True
        walls = {w1, w2, w3, w4}
    End Sub
End Class