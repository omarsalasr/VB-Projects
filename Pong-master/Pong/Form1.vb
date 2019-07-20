Public Class Form1

    Private Sub lbl1v1_Click(sender As Object, e As EventArgs) Handles lbl1v1.Click
        Form2.Show()
        Me.Hide()
        Form2.lblControl.Visible = True
        Form2.lblRules.Visible = True
        Form2.pctPlayer1.BackColor = Color.White
        Form2.pctPlayer2.BackColor = Color.White
        Form2.lblPlayer1.Text = "Player 1"
        Form2.lblPlayer2.Text = "Player 2"
        Form2.lblScore.Text = "     "
        Form2.lblNum1.Text = 0
        Form2.lblNum2.Text = 0
        pct1.BackColor = Color.White
    End Sub

    Private Sub lbl1v1_MouseHover(sender As Object, e As EventArgs) Handles lbl1v1.MouseHover
        pctHover1.Visible = True
    End Sub

    Private Sub lbl1v1_MouseLeave(sender As Object, e As EventArgs) Handles lbl1v1.MouseLeave
        pctHover1.Visible = False
    End Sub

    Private Sub lbl4way_Click(sender As Object, e As EventArgs) Handles lbl4way.Click
        Form3.Show()
        Me.Hide()
        Form3.lblControl.Visible = True
        Form3.lblRules.Visible = True
        Form3.pctPlayer1.BackColor = Color.White
        Form3.pctPlayer2.BackColor = Color.White
        Form3.pctPlayer3.BackColor = Color.White
        Form3.pctPlayer4.BackColor = Color.White
        Form3.lblPlayer1.Text = "Player 1"
        Form3.lblPlayer2.Text = "Player 2"
        Form3.lblPlayer3.Text = "Player 3"
        Form3.lblPlayer4.Text = "Player 4"
        Form3.lblNum1.Text = 0
        Form3.lblNum2.Text = 0
        Form3.lblNum3.Text = 0
        Form3.lblNum4.Text = 0
    End Sub

    Private Sub lbl4way_MouseHover(sender As Object, e As EventArgs) Handles lbl4way.MouseHover
        pctHover3.Visible = True
    End Sub

    Private Sub lbl4way_MouseLeave(sender As Object, e As EventArgs) Handles lbl4way.MouseLeave
        pctHover3.Visible = False
    End Sub

    Private Sub btn1v1Con_Click(sender As Object, e As EventArgs) Handles btn1v1Con.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btn4WayCon_Click(sender As Object, e As EventArgs) Handles btn4WayCon.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
