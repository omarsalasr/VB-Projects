Public Class MtDragoS
    Dim charMove As Boolean
    Dim nextConv As Integer
    Dim conv As Boolean
    Dim collide As Boolean
    Dim walls() As PictureBox
    Private Sub MtDragoS_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtMessages.Clear()
    End Sub
    Private Sub MtDragoS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        keyD(collide, charMove, mainChar, walls, e.KeyCode)

        If mainChar.Bounds.IntersectsWith(pctMtDrago.Bounds) = True Then
            Me.Hide()
            MtDrago.Show()
        End If

        If e.KeyCode = Keys.E Then
            If mainChar.Bounds.IntersectsWith(pctSword.Bounds) = True Then
                sword = True
                pctSword.Visible = False
                txtMessages.Text = vbNewLine & "Now lets go the castle." & txtMessages.Text
                enterC = True
                MsgBox("You aqquired the Legendary sword.")
            End If
        End If
    End Sub

    Private Sub MtDragoS_Load(sender As Object, e As EventArgs) Handles Me.Load
        charMove = True
        conv = True
        walls = {w1, w2, w3, w4, w5}
        txtMessages.Text = vbNewLine & "Well theres the sword." & txtMessages.Text
    End Sub

    Private Sub tmrConv_Tick(sender As Object, e As EventArgs) Handles tmrConv.Tick
        
    End Sub
End Class