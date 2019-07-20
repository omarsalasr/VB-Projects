Public Class Form3

    Private Sub pctBack_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub pctNext_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()
        MsgBox("Click the Orange Button to Win the Race")

    End Sub

    Private Sub txbBlue_TextChanged(sender As Object, e As EventArgs) Handles txbBlue.TextChanged, txbGreen.TextChanged, txbYellow.TextChanged, txbRed.TextChanged
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        If txbYellow.Text = ("Yellow") Then
            lblYellow.Text = ("You are Correct")
        Else
            lblYellow.Text = ("Try again")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        If txbRed.Text = ("Red") Then
            lblRed.Text = ("You are Correct")
        Else
            lblRed.Text = ("Try again")
        End If
    End Sub

    Private Sub pctBack_Click_1(sender As Object, e As EventArgs) Handles pctBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub pctNext_Click_1(sender As Object, e As EventArgs) Handles pctNext.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        If txbBlue.Text = ("Blue") Then
            lblBlue.Text = ("You are Correct")
        Else
            lblBlue.Text = ("Try again")
        End If
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        If txbGreen.Text = ("Green") Then
            lblGreen.Text = ("You are Correct")
        Else
            lblGreen.Text = ("Try again")
        End If
    End Sub

    Private Sub lblDone_Click(sender As Object, e As EventArgs) Handles lblDone.Click
        If lblBlue.Text = ("You are Correct") And lblGreen.Text = ("You are Correct") And lblYellow.Text = ("You are Correct") And lblRed.Text = ("You are Correct") Then
            lblDone.Text = ("You finished!")
        End If
    End Sub
End Class