Public Class Level1
    Dim numclicked As Integer
    'The number of cards clicked, the max has to be 2 and then must be reset down to 0
    Dim matchIndex As Integer
    'To see which image was clicked0
    Dim firstPict As PictureBox
    '
    Dim secondPict As PictureBox
    Dim player1 As String
    Dim player2 As String
    Dim p1Score As Integer
    Dim p2Score As Integer
    Dim pTurn As Integer
    Dim totalMatches As Integer
    Private Sub p1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1.Click
        numclicked += 1
        'Adds 1 to the number of clicks.
        p1.Image = ImageList1.Images(0)
        'Chooses what the first image is from an image list
        If numclicked = 1 Then
            'The If statement checks if the number of clicks is = 1, this will always be true since numclicked always gets added 1 at the start of the button code
            firstPict = p1
            'Declares the firstPict variable = to the image from p1
            matchIndex = 0
            'The index number of the image selected is = 0
        End If
        If numclicked = 2 Then
            'When another picture is clicked, numclicked = 2
            'This If statement checks if the number of clicks = 2, this is always true when a second picture is clicked
            secondPict = p1
            'Declares the second picture to be = to p1

            If matchIndex = 0 Then


                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p1.Visible = False
                p1.Enabled = False
                p2.Visible = False
                p2.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2.Click
        numclicked += 1

        p2.Image = ImageList1.Images(0)
        If numclicked = 1 Then
            firstPict = p2
            matchIndex = 0

        End If
        If numclicked = 2 Then
            secondPict = p2
            If matchIndex = 0 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p1.Visible = False
                p1.Enabled = False
                p2.Visible = False
                p2.Enabled = False
                MsgBox("match")
                totalMatches += 1

            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p3.Click
        numclicked += 1

        p3.Image = ImageList1.Images(1)
        If numclicked = 1 Then
            firstPict = p3
            matchIndex = 1

        End If
        If numclicked = 2 Then
            secondPict = p3
            If matchIndex = 1 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p3.Visible = False
                p3.Enabled = False
                p4.Visible = False
                p4.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p4.Click
        numclicked += 1

        p4.Image = ImageList1.Images(1)
        If numclicked = 1 Then
            firstPict = p4
            matchIndex = 1

        End If
        If numclicked = 2 Then
            secondPict = p4
            If matchIndex = 1 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p3.Visible = False
                p3.Enabled = False
                p4.Visible = False
                p4.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        player1 = InputBox("What is your name Player 1?")
        lblP1.Text = "Player 1: " & player1
        player2 = InputBox("What is your name Player 2?")
        lblP2.Text = "Player 2: " & player2
        lblScoreP1.Text = p1Score
        lblScoreP2.Text = p2Score
        pctColor.BackColor = Color.Blue
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblScoreP1.Click, lblScoreP2.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub Level3_Load(sender As Object, e As EventArgs) Handles Me.Load
        pTurn = 0
        totalMatches = 0
    End Sub

    Private Sub p5_Click(sender As Object, e As EventArgs) Handles p5.Click
        numclicked += 1

        p5.Image = ImageList1.Images(2)
        If numclicked = 1 Then
            firstPict = p5
            matchIndex = 2

        End If
        If numclicked = 2 Then
            secondPict = p5
            If matchIndex = 2 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p5.Visible = False
                p5.Enabled = False
                p6.Visible = False
                p6.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p6_Click(sender As Object, e As EventArgs) Handles p6.Click
        numclicked += 1

        p6.Image = ImageList1.Images(2)
        If numclicked = 1 Then
            firstPict = p6
            matchIndex = 2

        End If
        If numclicked = 2 Then
            secondPict = p6
            If matchIndex = 2 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p5.Visible = False
                p5.Enabled = False
                p6.Visible = False
                p6.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p7_Click(sender As Object, e As EventArgs) Handles p7.Click
        numclicked += 1

        p7.Image = ImageList1.Images(3)
        If numclicked = 1 Then
            firstPict = p7
            matchIndex = 3

        End If
        If numclicked = 2 Then
            secondPict = p7
            If matchIndex = 3 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p7.Visible = False
                p7.Enabled = False
                p8.Visible = False
                p8.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p8_Click(sender As Object, e As EventArgs) Handles p8.Click
        numclicked += 1

        p8.Image = ImageList1.Images(3)
        If numclicked = 1 Then
            firstPict = p8
            matchIndex = 3

        End If
        If numclicked = 2 Then
            secondPict = p8
            If matchIndex = 3 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p7.Visible = False
                p7.Enabled = False
                p8.Visible = False
                p8.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p9_Click(sender As Object, e As EventArgs) Handles p9.Click
        numclicked += 1

        p9.Image = ImageList1.Images(4)
        If numclicked = 1 Then
            firstPict = p9
            matchIndex = 4

        End If
        If numclicked = 2 Then
            secondPict = p9
            If matchIndex = 4 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p9.Visible = False
                p9.Enabled = False
                p10.Visible = False
                p10.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p10_Click(sender As Object, e As EventArgs) Handles p10.Click
        numclicked += 1

        p10.Image = ImageList1.Images(4)
        If numclicked = 1 Then
            firstPict = p10
            matchIndex = 4

        End If
        If numclicked = 2 Then
            secondPict = p10
            If matchIndex = 4 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p9.Visible = False
                p9.Enabled = False
                p10.Visible = False
                p10.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p11_Click(sender As Object, e As EventArgs) Handles p11.Click
        numclicked += 1

        p11.Image = ImageList1.Images(5)
        If numclicked = 1 Then
            firstPict = p11
            matchIndex = 5

        End If
        If numclicked = 2 Then
            secondPict = p11
            If matchIndex = 5 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p11.Visible = False
                p11.Enabled = False
                p12.Visible = False
                p12.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p12_Click(sender As Object, e As EventArgs) Handles p12.Click
        numclicked += 1

        p12.Image = ImageList1.Images(5)
        If numclicked = 1 Then
            firstPict = p12
            matchIndex = 5

        End If
        If numclicked = 2 Then
            secondPict = p12
            If matchIndex = 5 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p11.Visible = False
                p11.Enabled = False
                p12.Visible = False
                p12.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p13_Click(sender As Object, e As EventArgs) Handles p13.Click
        numclicked += 1

        p13.Image = ImageList1.Images(6)
        If numclicked = 1 Then
            firstPict = p13
            matchIndex = 6

        End If
        If numclicked = 2 Then
            secondPict = p13
            If matchIndex = 6 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p13.Visible = False
                p13.Enabled = False
                p14.Visible = False
                p14.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p14_Click(sender As Object, e As EventArgs) Handles p14.Click
        numclicked += 1

        p14.Image = ImageList1.Images(6)
        If numclicked = 1 Then
            firstPict = p14
            matchIndex = 6

        End If
        If numclicked = 2 Then
            secondPict = p14
            If matchIndex = 6 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p13.Visible = False
                p13.Enabled = False
                p14.Visible = False
                p14.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub

    Private Sub p15_Click(sender As Object, e As EventArgs) Handles p15.Click
        numclicked += 1

        p15.Image = ImageList1.Images(7)
        If numclicked = 1 Then
            firstPict = p15
            matchIndex = 7

        End If
        If numclicked = 2 Then
            secondPict = p15
            If matchIndex = 7 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p15.Visible = False
                p15.Enabled = False
                p16.Visible = False
                p16.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If

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
        checkWinner()
    End Sub

    Private Sub p16_Click(sender As Object, e As EventArgs) Handles p16.Click
        numclicked += 1

        p16.Image = ImageList1.Images(7)
        If numclicked = 1 Then
            firstPict = p16
            matchIndex = 7

        End If
        If numclicked = 2 Then
            secondPict = p16
            If matchIndex = 7 Then
                If pTurn = 0 Then
                    p1Score += 1
                    lblScoreP1.Text = p1Score
                ElseIf pTurn = 1 Then
                    p2Score += 1
                    lblScoreP2.Text = p2Score
                End If
                p15.Visible = False
                p15.Enabled = False
                p16.Visible = False
                p16.Enabled = False
                MsgBox("match")
                totalMatches += 1
            Else
                MsgBox(" no match")
                pTurn += 1
                If pTurn = 2 Then
                    pTurn = 0
                End If
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
        checkWinner()
    End Sub
    Private Sub checkWinner()
        If totalMatches = 8 Then

            If p1Score > p2Score Then
                MsgBox(player1 & " wins!")
            ElseIf p1Score < p2Score Then
                MsgBox(player2 & " wins!")
            ElseIf p1Score = p2Score Then
                MsgBox("Its a tie!")
            End If
        End If
    End Sub

    Private Sub Level2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level2ToolStripMenuItem.Click
        Level2.Show()
        Me.Hide()
    End Sub

    Private Sub Level3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level3ToolStripMenuItem.Click
        Level3.Show()
        Me.Hide()
    End Sub

    Private Sub Level1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level1ToolStripMenuItem.Click

    End Sub
End Class
