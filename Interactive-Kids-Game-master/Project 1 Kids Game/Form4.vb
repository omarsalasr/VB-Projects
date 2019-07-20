Public Class Form4

    Private Sub pctBack_Click(sender As Object, e As EventArgs) Handles pctBack.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub pctNext_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctPlayer.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pctAI2.Click

    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        pctPlayer.Top = pctPlayer.Top - 50

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        If lblTime.Text > 0 Then
            lblTime.Text = lblTime.Text - 0.01
        Else
            lblTitle.Visible = True
            btnClick.Enabled = True
            pctAI1.Top = pctAI1.Top - 2
            pctAI2.Top = pctAI2.Top - 1
            If pctPlayer.Top < lblFinish.Bottom Then
                tmrTime.Stop()
                MsgBox("Congratulations! You Win the Race.")
                If pctAI1.Top < lblFinish.Bottom Then
                    tmrTime.Stop()
                    MsgBox("Sorry, try again.")
                End If
            End If
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrTime.Start()
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class