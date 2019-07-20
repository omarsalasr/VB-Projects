Public Class House
    Dim askName As Boolean
    Dim conversation As Boolean
    Dim conversation2 As Boolean
    Dim nextConv As Integer
    Dim initialMovement As Boolean
    Dim exitDoor As Boolean
    Dim charMove As Boolean
    Dim secondTime As Boolean
    Dim collide As Boolean
    Dim walls() As PictureBox
    Dim justOnce As Boolean
    Dim justOnce1 As Boolean

    Private Sub House_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If secondTime = True Then
            txtMessages.Clear()
        End If
    End Sub
    'SWITCH THE LIGHTER LOCATION WITH THE ROPE LOCATION, KITCHEN AND THE CHEST

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        conversation = True
        egg1 = False
        walls = {w1, w2, w3, w4, w5}
    End Sub

    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick
        If conversation = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & "You are just waking up from a long night at the festival." & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "Celebrating the 10 year of King Crota being the best ruler Pandora ever had." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "So, um..." & txtMessages.Text
            ElseIf nextConv = 3 Then
                txtMessages.Text = vbNewLine & "..." & txtMessages.Text
            ElseIf nextConv = 4 Then
                txtMessages.Text = vbNewLine & "What is your name again?" & txtMessages.Text
                txtMessages.Text = vbNewLine & txtMessages.Text
                conversation = False
                nextConv = -1
                hero.hName = InputBox("What is your name")
                conversation2 = True
                askName = False
            End If
            nextConv += 1
        End If

        If conversation2 = True Then
            If nextConv = 0 Then
                txtMessages.Text = vbNewLine & hero.hName & "!" & txtMessages.Text
            ElseIf nextConv = 1 Then
                txtMessages.Text = vbNewLine & "I knew that." & txtMessages.Text
            ElseIf nextConv = 2 Then
                txtMessages.Text = vbNewLine & "Well rise and shine " & hero.hName & ", go check out the aftermath of the festival." & txtMessages.Text
                initialMovement = True
                tmrConv.Stop()
                Me.Focus()
                charMove = True
                MsgBox("Move with WASD keys. You can also interact with some of the objects with the E key.")
                Me.Focus()
            End If
            nextConv += 1
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If e.KeyCode = Keys.Space Then
            nextConv += 1
        End If

        If e.KeyCode = Keys.R Then
            nextConv -= 2
        End If

            If e.KeyCode = Keys.Space Then
                nextConv += 1
            End If

            If e.KeyCode = Keys.E Then
                If justOnce = False Then
                    If mainChar.Bounds.IntersectsWith(pctCounter.Bounds) = True Then
                        MsgBox("You found a lighter.")
                        lighter = True
                        justOnce = True
                    End If
                End If
                If sleepTime = True Then
                    If mainChar.Bounds.IntersectsWith(PictureBox1.Bounds) = True Then
                        MsgBox("Good night")
                        MsgBox("Wake up it's midnight")
                        midnight = True
                        sleepTime = False
                    End If
                End If
                If justOnce1 = False Then
                    If mainChar.Bounds.IntersectsWith(pctStorage.Bounds) = True Then
                        MsgBox("You found a rope.")
                        rope = True
                        justOnce1 = True
                    End If
                End If
            End If

            If mainChar.Bounds.IntersectsWith(pctDoor.Bounds) = True Then
                Me.Hide()
                Plaza.Show()
                secondTime = True
            End If
    End Sub

    Private Sub pctDoor_Click(sender As Object, e As EventArgs) Handles pctDoor.Click

    End Sub

    Private Sub w2_Click(sender As Object, e As EventArgs) Handles w2.Click, w5.Click

    End Sub
End Class