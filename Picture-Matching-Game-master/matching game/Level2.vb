Public Class Level2
    Dim numclicked As Integer
    Dim matchIndex As Integer
    Dim firstPict As PictureBox
    Dim secondPict As PictureBox
    Dim player1 As String
    Dim player2 As String
    Dim p1Score As Integer
    Dim p2Score As Integer
    Dim pTurn As Integer
    Dim totalMatches As Integer
    Dim myPictures() As PictureBox
    Dim clicked As New List(Of Boolean)
    Dim rnum As New Random
    Dim temp As Integer
    Private Sub p1_Click(sender As Object, e As EventArgs) Handles p1.Click, p2.Click, p3.Click, p4.Click, p5.Click, p6.Click, p7.Click, p8.Click, p9.Click, p10.Click, p11.Click, p12.Click, p13.Click, p14.Click, p15.Click, p16.Click
        temp = CInt(Mid(sender.name, 2))
        'MsgBox(temp)
        If clicked(temp) = False Then
            
        

            numclicked += 1
            sender.Image = ImageList1.Images(CInt(sender.Tag))
            If numclicked = 1 Then
                firstPict = sender
                matchIndex = sender.tag
            End If
            If numclicked = 2 Then
                secondPict = sender

                If matchIndex = sender.tag Then
                    If pTurn = 0 Then
                        p1Score += 1
                        lblScoreP1.Text = p1Score
                    ElseIf pTurn = 1 Then
                        p2Score += 1
                        lblScoreP2.Text = p2Score
                    End If

                    MsgBox("match")
                    firstPict.Visible = False
                    sender.Visible = False


                    totalMatches += 1
                Else


                    'clicked(temp) = False
                    MsgBox(" no match")

                    pTurn += 1
                    If pTurn = 2 Then
                        pTurn = 0
                    End If
                    For i = 0 To myPictures.Length - 1
                        clicked(i) = True
                        If clicked(i) = True Then
                            myPictures(i).Enabled = True
                        End If
                    Next
                End If

                If pTurn = 0 Then
                    pctColor.BackColor = Color.Blue
                ElseIf pTurn = 1 Then
                    pctColor.BackColor = Color.Red
                End If
                firstPict.Image = Nothing
                secondPict.Image = Nothing
                numclicked = 0
            End If
            If totalMatches = 8 Then
                If p1Score > p2Score Then
                    MsgBox(player1 & " wins!")
                ElseIf p1Score < p2Score Then
                    MsgBox(player2 & " wins!")
                ElseIf p1Score = p2Score Then
                    MsgBox("Its a tie!")
                Else
                    MsgBox("not working")
                End If

            End If
            clicked(temp) = True
        End If
        For i = 0 To myPictures.Length - 1
            clicked(i) = False
        Next
        clicked(temp) = True
        'If clicked(temp) = True And numclicked = Then
        '    clicked(temp) = False
        'End If
    End Sub
    Public Sub reset()
        For i = 0 To myPictures.Length - 1
            clicked.Add(False)
            myPictures(i).BackColor = Color.Blue
            myPictures(i).Visible = True
            myPictures(i).Enabled = True
        Next
        p1Score = 0
        lblScoreP1.Text = "0"
        p2Score = 0
        lblScoreP2.Text = "0"
        totalMatches = 0
    End Sub

    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles Me.Load
        myPictures = {p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16}
        reset()
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        player1 = InputBox("What is your name Player 1?")
        lblP1.Text = "Player 1: " & player1
        player2 = InputBox("What is your name Player 2?")
        lblP2.Text = "Player 2: " & player2
        lblScoreP1.Text = p1Score
        lblScoreP2.Text = p2Score
        pTurn = rnum.Next(0, 2)
        If pTurn = 0 Then
            pctColor.BackColor = Color.Blue
        Else
            pctColor.BackColor = Color.Red
        End If
        reset()
    End Sub
    Private Sub Level1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level1ToolStripMenuItem.Click
        Level1.Show()
        Me.Hide()
    End Sub

    Private Sub Level3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level3ToolStripMenuItem.Click
        Level3.Show()
        Me.Hide()
    End Sub
End Class