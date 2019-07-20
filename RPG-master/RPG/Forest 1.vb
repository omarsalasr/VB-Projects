Public Class Forest_1
    Dim charMove As Boolean
    Dim collide As Boolean
    Dim walls() As PictureBox

    Private Sub Forest_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
   
        keyD(collide, charMove, mainChar, walls, e.KeyCode)
        If mainChar.Bounds.IntersectsWith(pctPlazaDoor.Bounds) = True Then
            Me.Hide()
            Plaza.Show()
        End If

        If mainChar.Bounds.IntersectsWith(pctForestL.Bounds) = True Then
            Me.Hide()
            ForestL.Show()
        End If

       
    End Sub

    Private Sub Forest_1_Load(sender As Object, e As EventArgs) Handles Me.Load
        charMove = True
        walls = {w1, w2, w3, w4, w5, w6}
    End Sub
End Class