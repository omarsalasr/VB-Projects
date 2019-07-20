Public Class MtDrago
    Dim collide As Boolean
    Dim walls() As PictureBox
    Dim charMove As Boolean

    Private Sub MtDrago_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keyD(collide, charMove, mainChar, walls, e.KeyCode)
       
        If mainChar.Bounds.IntersectsWith(pctMtSword.Bounds) = True Then
            Me.Hide()
            MtDragoS.Show()
        End If
        If enterL = False Then
            If mainChar.Bounds.IntersectsWith(pctMtDragon.Bounds) = True Then
                Me.Hide()
                MtDragoD.Show()
                enterL = True
            End If
        End If

        If mainChar.Bounds.IntersectsWith(pctPlaza.Bounds) = True Then
            Me.Hide()
            Plaza.Show()
        End If
    End Sub

    Private Sub MtDrago_Load(sender As Object, e As EventArgs) Handles Me.Load
        enterF = True
        charMove = True
        walls = {w1, w2, w3, w4, w5, w6, w7}
    End Sub
End Class