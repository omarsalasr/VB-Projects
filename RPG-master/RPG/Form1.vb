Public Class Form1
    Dim akatsmoveup As Boolean
    Dim conversation As Boolean
    Dim nextConv As Integer
    Dim akatsmovedown As Boolean
    Dim nextForm As Boolean
    Private Sub tmrConversation_Tick(sender As Object, e As EventArgs) Handles tmrConversation.Tick
        If conversation = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "Vermel: Hello my King." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Crota: WHO ARE YOU AND WHAT HAPPENED TO THE GUARDS OUTSIDE MY H.Q.?" & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Vermel: We are the Akatsuki, an organazition that are here to help this kingdom from their tyrant ruler." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "Crota: WHO SAID I WAS EVIL?" & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "Vermel: I did, Vermel, Pandora's next king." & txtMessages.Text
            ElseIf nextConv = 5 Then
                txtMessages.Text = vbNewLine & "Crota: OVER MY DEAD BODY, ILL LET YOU OVERTHROW ME!" & txtMessages.Text
            ElseIf nextConv = 6 Then
                txtMessages.Text = vbNewLine & "Crota: Fire Blade SLASH!" & txtMessages.Text
                PictureBox2.BringToFront()
            ElseIf nextConv = 7 Then
                txtMessages.Text = vbNewLine & "Vermel: Pathetic." & txtMessages.Text
                PictureBox2.SendToBack()
            ElseIf nextConv = 8 Then
                txtMessages.Text = vbNewLine & "Vermel: Universal EXPLOSION." & txtMessages.Text
                PictureBox5.BringToFront()
            ElseIf nextConv = 9 Then
                txtMessages.Text = vbNewLine & "Vermel: You are weak." & txtMessages.Text
                PictureBox5.SendToBack()
                pctRope.Visible = True
                PictureBox1.Visible = True
                akatsmovedown = True
            End If
            nextConv += 1
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If akatsmoveup = True Then
            pctAkats.Top -= 3
        End If
        If pctAkats.Bounds.IntersectsWith(pctRope.Bounds) = True Then
            akatsmoveup = False
            conversation = True
        End If
      
        If akatsmovedown = True Then
            PictureBox1.Visible = True
            pctAkats.Top += 2
            pctKing.Top += 2
            pctRope.Top += 2
            PictureBox1.Top += 2
        End If
        If pctKing.Top > pctDoor.Top Then
            House.Show()
            Me.Hide()
            Timer1.Stop()
            tmrConversation.Stop()
            charCinema = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        Timer1.Start()
        akatsmoveup = True
        lblStart.Enabled = False
        lblStart.Visible = False
        pctDoor.Visible = True
        pctKing.Visible = True
    End Sub
End Class
