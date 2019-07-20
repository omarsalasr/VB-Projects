Public Class Level3
    Dim numclicked As Integer
    Dim matchIndex As Integer
    Dim firstPict As PictureBox
    Dim secondPict As PictureBox
    Dim player1 As String
    Dim player2 As String
    Dim p1Score As Integer
    Dim p2Score As Integer
    Dim p3Score As Integer
    Dim p4Score As Integer
    Dim pTurn As Integer
    Dim totalMatches As Integer
    Dim myPicts As New List(Of PictureBox)
    Dim numPicts As Integer
    Dim myPictures() As PictureBox
    Dim clicked As New List(Of Boolean)
    Dim rnum As New Random
    Dim temp As Integer
    Dim numPlayers As Integer
    Dim Players As New List(Of String)
    Dim myLabels() As Label
    Dim pScores As New List(Of Integer)
    Dim newPosition As Integer
    Dim numTags As New List(Of String)
    Dim num1 As Integer
    Dim tempPos As Integer
    Dim num2 As Integer

 
    Private Sub click_All(sender As Object, e As EventArgs) Handles p1.Click, p2.Click, p3.Click, p4.Click, p5.Click, p6.Click, p7.Click, p8.Click, p9.Click, p10.Click, p11.Click, p12.Click, p13.Click, p14.Click, p15.Click, p16.Click

        'MsgBox(sender.tag)
        temp = CInt(Mid(sender.name, 2))


        If clicked(temp - 1) = False Then
            numclicked += 1

            sender.image = ImageList1.Images(CInt(sender.tag))

            If numclicked = 1 Then
                firstPict = sender
                matchIndex = sender.Tag
            End If
            If numclicked = 2 Then
                secondPict = sender
                If matchIndex = sender.Tag Then
                    If numPlayers = 2 Then
                        If pTurn = 0 Then
                            p1Score += 1
                            lblScoreP1.Text = p1Score
                        ElseIf pTurn = 1 Then
                            p2Score += 1
                            lblScoreP2.Text = p2Score
                        End If
                    End If
                    If numPlayers = 3 Then
                        If pTurn = 0 Then
                            p1Score += 1
                            lblScoreP1.Text = p1Score
                        ElseIf pTurn = 1 Then
                            p2Score += 1
                            lblScoreP2.Text = p2Score
                        ElseIf pTurn = 2 Then
                            p3Score += 1
                            lblScoreP3.Text = p3Score
                        End If
                    End If
                    If numPlayers = 4 Then
                        If pTurn = 0 Then
                            p1Score += 1
                            lblScoreP1.Text = p1Score
                        ElseIf pTurn = 1 Then
                            p2Score += 1
                            lblScoreP2.Text = p2Score
                        ElseIf pTurn = 2 Then
                            p3Score += 1
                            lblScoreP3.Text = p3Score
                        ElseIf pTurn = 3 Then
                            p4Score += 1
                            lblScoreP4.Text = p4Score
                        End If
                    End If
                    MsgBox("match")
                    firstPict.Visible = False
                    sender.Visible = False
                    totalMatches += 1
                Else
                    MsgBox(" no match")
                    pTurn += 1
                    If numPlayers = 2 Then
                        If pTurn = 2 Then
                            pTurn = 0
                        End If
                    End If
                    If numPlayers = 3 Then
                        If pTurn = 3 Then
                            pTurn = 0
                        End If
                    End If
                    If numPlayers = 4 Then
                        If pTurn = 4 Then
                            pTurn = 0
                        End If
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
                ElseIf pTurn = 2 Then
                    pctColor.BackColor = Color.Green
                ElseIf pTurn = 3 Then
                    pctColor.BackColor = Color.Yellow

                End If
                firstPict.Image = Nothing
                secondPict.Image = Nothing
                numclicked = 0
            End If
            If totalMatches = 8 Then
                If lblScoreP1.Text > lblScoreP2.Text And lblScoreP1.Text > lblScoreP3.Text And lblScoreP1.Text > lblScoreP4.Text Then
                    MsgBox(myLabels(0).Text & " wins!")
                ElseIf lblScoreP2.Text > lblScoreP1.Text And lblScoreP2.Text > lblScoreP3.Text And lblScoreP2.Text > lblScoreP4.Text Then
                    MsgBox(myLabels(1).Text & " wins!")
                ElseIf lblScoreP3.Text > lblScoreP1.Text And lblScoreP3.Text > lblScoreP2.Text And lblScoreP3.Text > lblScoreP4.Text Then
                    MsgBox(myLabels(2).Text & " wins!")
                ElseIf lblScoreP4.Text > lblScoreP1.Text And lblScoreP4.Text > lblScoreP2.Text And lblScoreP4.Text > lblScoreP3.Text Then
                    MsgBox(myLabels(3).Text & " wins!")
                ElseIf lblScoreP1.Text = lblScoreP2.Text Then
                    MsgBox(myLabels(0).Text & " and " & myLabels(1).Text & " tie!")
                ElseIf lblScoreP1.Text = lblScoreP3.Text Then
                    MsgBox(myLabels(0).Text & " and " & myLabels(2).Text & " tie!")
                ElseIf lblScoreP1.Text = lblScoreP4.Text Then
                    MsgBox(myLabels(0).Text & " and " & myLabels(3).Text & " tie!")
                ElseIf lblScoreP2.Text = lblScoreP3.Text Then
                    MsgBox(myLabels(1).Text & " and " & myLabels(2).Text & " tie!")
                ElseIf lblScoreP2.Text = lblScoreP4.Text Then
                    MsgBox(myLabels(1).Text & " and " & myLabels(3).Text & " tie!")
                ElseIf lblScoreP3.Text = lblScoreP4.Text Then
                    MsgBox(myLabels(2).Text & " and " & myLabels(3).Text & " tie!")
                ElseIf lblScoreP1.Text = lblScoreP2.Text And lblScoreP1.Text = lblScoreP3.Text Then
                    MsgBox(myLabels(0).Text & ", " & myLabels(1).Text & ", and " & myLabels(2).Text & " tie!")
                ElseIf lblScoreP1.Text = lblScoreP3.Text And lblScoreP1.Text = lblScoreP4.Text Then
                    MsgBox(myLabels(0).Text & ", " & myLabels(2).Text & ", and " & myLabels(3).Text & " tie!")
                ElseIf lblScoreP1.Text = lblScoreP2.Text And lblScoreP1.Text = lblScoreP4.Text Then
                    MsgBox(myLabels(0).Text & ", " & myLabels(1).Text & ", and " & myLabels(3).Text & " tie!")
                ElseIf lblScoreP2.Text = lblScoreP3.Text And lblScoreP2.Text = lblScoreP4.Text Then
                    MsgBox(myLabels(1).Text & ", " & myLabels(2).Text & ", and " & myLabels(3).Text & " tie!")
                ElseIf lblScoreP1.Text = lblScoreP2.Text And lblScoreP1.Text = lblScoreP3.Text And lblScoreP1.Text = lblScoreP4.Text Then
                    MsgBox(myLabels(0).Text & ", " & myLabels(1).Text & ", " & myLabels(2).Text & ", and " & myLabels(3).Text & " tie!")
                End If
            End If
            clicked(temp - 1) = True
        End If
        For i = 0 To myPictures.Length - 1
            clicked(i) = False
        Next
        clicked(temp - 1) = True
    End Sub
    Public Sub reset()
        For i = 0 To myPictures.Length - 1
            clicked.Add(False)
            myPictures(i).BackColor = Color.Blue
            myPictures(i).Visible = True
            myPictures(i).Enabled = True
        Next
            lblScoreP1.Text = "0"
            lblScoreP2.Text = "0"
            lblScoreP3.Text = "0"
            lblScoreP4.Text = "0"
        totalMatches = 0
        Players.Clear()
        For i = 0 To myPictures.Length - 1
            numTags.Add(i)
            numTags(i) = Math.Round((i) / 2 - 0.1)
        Next
        For i = 0 To numTags.Count - 1
            num1 = rnum.Next(0, numTags.Count - 1)
            myPictures(i).Tag = numTags(num1)
            numTags.RemoveAt(num1)
        Next
       
    End Sub

    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles Me.Load
        myPictures = {p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16}
        myLabels = {lblP1, lblP2, lblP3, lblP4}
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        numPlayers = 0
        'numPicts = InputBox("How many pictures do you want to have? (Pick an even number between 4 and 30)")
        'For i = 0 To numPicts - 1
        '    myPicts.Add(p1)

        'Next
        While numPlayers > 4 Or numPlayers < 2
            numPlayers = InputBox("How many players are going to play? (2 lowes, 4 max)")
        End While
        For i = 0 To numPlayers - 1
            Players.Add(InputBox("What is your name player " & Players.Count + 1))
            pScores.Add(0)
            'Players(i) = InputBox("What is your name Player " & Players(i))
            myLabels(i).Text = Players(i)
        Next
        If numPlayers = 2 Then
            pTurn = rnum.Next(0, 2)
            If pTurn = 0 Then
                pctColor.BackColor = Color.Blue
            Else
                pctColor.BackColor = Color.Red
            End If
        End If
        If numPlayers = 3 Then
            lblP3.Visible = True
            lblScoreP3.Visible = True
            Label7.Visible = True
            lblP4.Visible = False
            lblScoreP4.Visible = False
            Label9.Visible = False
            pTurn = rnum.Next(0, 3)
            If pTurn = 0 Then
                pctColor.BackColor = Color.Blue
            ElseIf pTurn = 1 Then
                pctColor.BackColor = Color.Red
            ElseIf pTurn = 2 Then
                pctColor.BackColor = Color.Green
            End If
        End If
        If numPlayers = 4 Then
            lblP4.Visible = True
            lblScoreP4.Visible = True
            Label9.Visible = True
            lblP3.Visible = True
            lblScoreP3.Visible = True
            Label7.Visible = True
            pTurn = rnum.Next(0, 4)
            If pTurn = 0 Then
                pctColor.BackColor = Color.Blue
            ElseIf pTurn = 1 Then
                pctColor.BackColor = Color.Red
            ElseIf pTurn = 2 Then
                pctColor.BackColor = Color.Green
            ElseIf pTurn = 3 Then
                pctColor.BackColor = Color.Yellow
            End If
        End If
        p1Score = 0
        p2Score = 0
        p3Score = 0
        p4Score = 0
        lblScoreP1.Text = p1Score
        lblScoreP2.Text = p2Score
        lblScoreP3.Text = p3Score
        lblScoreP4.Text = p4Score
        reset()


    End Sub

    Private Sub Level1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level1ToolStripMenuItem.Click
        Level1.Show()
        Me.Hide()
    End Sub

    Private Sub Level2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level2ToolStripMenuItem.Click
        Level2.Show()
        Me.Hide()
    End Sub
End Class