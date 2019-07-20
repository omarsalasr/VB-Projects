Public Class Form2
    Dim myName As String
    Dim correct As Integer
    Dim wrong As Integer
    Dim response As String


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQue2.Click
        response = InputBox("Who was the first man on the moon?")
        If response = "Neil" Or response = "neil" Or response = "Neil Armstrong" Or response = "neil armstrong" Or response = "Armstrong" Or response = "armstrong" Then
            btnQue2.BackColor = Color.Green
            btnQue2.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue2.Enabled = False
            btnQue3.Enabled = True
            btnQue3.Text = "Flag"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue2.BackColor = Color.Red
            btnQue2.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue2.Enabled = False
            btnQue3.Enabled = True
            btnQue3.Text = "Flag"
        End If
    End Sub

    Private Sub btnPresi100_Click(sender As Object, e As EventArgs) Handles btnQue1.Click
        response = InputBox("Who was the first president?")
        If response = "Washington" Or response = "washington" Or response = "George Washington" Or response = "george washington" Then
            btnQue1.BackColor = Color.Green
            btnQue1.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue1.Enabled = False
            btnQue2.Enabled = True
            btnQue2.Text = "Space"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue1.BackColor = Color.Red
            btnQue1.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue1.Enabled = False
            btnQue2.Enabled = True
            btnQue2.Text = "Space"
        End If
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        myName = InputBox("What is your name?")
        lblPlayer.Text = "Player Name: " & myName
        If myName = "" Then
            MsgBox("Please type your name")
        Else
            wrong = 0
            correct = 0
            lblScoreC.Text = correct
            lblScoreW.Text = wrong
            btnQue1.Enabled = True
            btnQue1.BackColor = Color.Transparent
            btnQue1.Text = "President"
            btnQue2.Enabled = False
            btnQue2.BackColor = Color.Transparent
            btnQue2.Text = "?"
            btnQue3.Enabled = False
            btnQue3.BackColor = Color.Transparent
            btnQue3.Text = "?"
            btnQue4.Enabled = False
            btnQue4.BackColor = Color.Transparent
            btnQue4.Text = "?"
            btnQue5.Enabled = False
            btnQue5.BackColor = Color.Transparent
            btnQue5.Text = "?"
            btnQue6.Enabled = False
            btnQue6.BackColor = Color.Transparent
            btnQue6.Text = "?"
            btnQue7.Enabled = False
            btnQue7.BackColor = Color.Transparent
            btnQue7.Text = "?"
            btnQue8.Enabled = False
            btnQue8.BackColor = Color.Transparent
            btnQue8.Text = "?"
            btnQue9.Enabled = False
            btnQue9.BackColor = Color.Transparent
            btnQue9.Text = "?"
            lblStart.Visible = False
        End If
    End Sub

    Private Sub lblRight_Click(sender As Object, e As EventArgs) Handles lblRight.Click, lblScoreW.Click, lblScoreC.Click

    End Sub

    Private Sub btnQue3_Click(sender As Object, e As EventArgs) Handles btnQue3.Click
        response = InputBox("how many stars are on the U.S. flag?")
        If response = "50" Then
            btnQue3.BackColor = Color.Green
            btnQue3.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue3.Enabled = False
            btnQue4.Enabled = True
            btnQue4.Text = "Phone"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue3.BackColor = Color.Red
            btnQue3.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue3.Enabled = False
            btnQue4.Enabled = True
            btnQue4.Text = "Phone"
        End If
    End Sub

    Private Sub btnQue4_Click(sender As Object, e As EventArgs) Handles btnQue4.Click
        response = InputBox("What fruit is on the back cover of and iPhone?")
        If response = "Apple" Or response = "apple" Or response = "an apple" Or response = "An Apple" Then
            btnQue4.BackColor = Color.Green
            btnQue4.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue4.Enabled = False
            btnQue5.Enabled = True
            btnQue5.Text = "Color"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue4.BackColor = Color.Red
            btnQue4.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue4.Enabled = False
            btnQue5.Enabled = True
            btnQue5.Text = "Color"
        End If
    End Sub

    Private Sub btnQue5_Click(sender As Object, e As EventArgs) Handles btnQue5.Click
        response = InputBox("How many primary colors are there?")
        If response = "3" Then
            btnQue5.BackColor = Color.Green
            btnQue5.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue5.Enabled = False
            btnQue6.Enabled = True
            btnQue6.Text = "Animal"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue5.BackColor = Color.Red
            btnQue5.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue5.Enabled = False
            btnQue6.Enabled = True
            btnQue6.Text = "Animal"
        End If
    End Sub

    Private Sub btnQue6_Click(sender As Object, e As EventArgs) Handles btnQue6.Click
        response = InputBox("Can a penguin fly?")
        If response = "no" Or response = "No" Then
            btnQue6.BackColor = Color.Green
            btnQue6.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue6.Enabled = False
            btnQue7.Enabled = True
            btnQue7.Text = "Technology"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue6.BackColor = Color.Red
            btnQue6.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue6.Enabled = False
            btnQue7.Enabled = True
            btnQue7.Text = "Technology"
        End If
    End Sub

    Private Sub btnQue7_Click(sender As Object, e As EventArgs) Handles btnQue7.Click
        response = InputBox("Who created microsoft?")
        If response = "Bill Gates" Or response = "bill gates" Then
            btnQue7.BackColor = Color.Green
            btnQue7.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue7.Enabled = False
            btnQue8.Enabled = True
            btnQue8.Text = "Time"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue7.BackColor = Color.Red
            btnQue7.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue7.Enabled = False
            btnQue8.Enabled = True
            btnQue8.Text = "Time"
        End If
    End Sub

    Private Sub btnQue8_Click(sender As Object, e As EventArgs) Handles btnQue8.Click
        response = InputBox("How many days in one regular year?")
        If response = "365" Then
            btnQue8.BackColor = Color.Green
            btnQue8.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue8.Enabled = False
            btnQue9.Enabled = True
            btnQue9.Text = "Greek Mythology"
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue8.BackColor = Color.Red
            btnQue8.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue8.Enabled = False
            btnQue9.Enabled = True
            btnQue9.Text = "Greek Mythology"
        End If
    End Sub

    Private Sub btnQue9_Click(sender As Object, e As EventArgs) Handles btnQue9.Click
        response = InputBox("Who is the God of the Gods?")
        If response = "Zeus" Or response = "zeus" Then
            btnQue9.BackColor = Color.Green
            btnQue9.Text = "Correct"
            correct = correct + 1
            lblScoreC.Text = correct
            btnQue9.Enabled = False
        ElseIf response = "" Then
            MsgBox("Please type an answer")
        Else
            btnQue9.BackColor = Color.Red
            btnQue9.Text = "Wrong"
            wrong = wrong + 1
            lblScoreW.Text = wrong
            btnQue9.Enabled = False
        End If
        If correct > wrong Then
            MsgBox(myName & " , you really are smart, now lets try stage 2")
            Me.Hide()
            Form1.Show()
        ElseIf correct < wrong Then
            MsgBox(myName & " , you need to get smarter, now lets try stage 2")
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RandomMathGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandomMathGameToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class