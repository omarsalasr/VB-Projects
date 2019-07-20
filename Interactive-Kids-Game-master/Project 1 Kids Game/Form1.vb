Public Class Form1

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
  
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnStart_MouseHover(sender As Object, e As EventArgs) Handles btnStart.MouseHover
        btnStart.BackColor = Color.Red
    End Sub

    Private Sub btnStart_MouseLeave(sender As Object, e As EventArgs) Handles btnStart.MouseLeave
        btnStart.BackColor = Color.Cyan
    End Sub
End Class
