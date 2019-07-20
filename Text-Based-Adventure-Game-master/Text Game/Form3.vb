Public Class Form3

    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If playerDead = True Then
            lblCrash.Visible = True
        End If

        If ogreWins = True Then
            lblLoseOgre.Visible = True
        End If

        If timerDone = True Then
            lblLose.Visible = True
        End If

        If escape = True Then
            lblWin.Visible = True
        End If

        If giveUp = True Then
            lblGiveUp.Visible = True
        End If

    End Sub
End Class