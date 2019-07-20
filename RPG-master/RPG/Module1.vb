Module Module1
    Public charCinema As Boolean
    Public pUp As Boolean
    Public pDown As Boolean
    Public pLeft As Boolean
    Public pRight As Boolean
    Public noRunningShoes As Boolean
    Public planB As Boolean
    Public lighter As Boolean
    Public egg1 As Boolean
    Public egg2 As Boolean
    Public gDate As Boolean
    Public midnight As Boolean
    Public sleepTime As Boolean
    Public rock As Boolean
    Public rope As Boolean
    Public sword As Boolean
    Public dragonHead As Boolean
    Public sleepBomb As Boolean
    Public enterM As Boolean
    Public enterC As Boolean
    Public enterF As Boolean
    Public enterL As Boolean
    Public altEnding As Boolean
    Public ending As Boolean
    Public noDate As Boolean
    Public o As Integer
    Public p As Integer
    Public Structure Stats
        Public hName As String

    End Structure
    Public hero As Stats

    Public Sub movement(ByVal key As Keys, ByVal piece As Object, ByVal x As Integer)
        'If charWalk = False Then
        If key = Keys.W Then
            piece.Top -= x
        End If
        If key = Keys.S Then
            piece.Top += x
        End If
        If key = Keys.A Then
            piece.Left -= x
        End If
        If key = Keys.D Then
            piece.Left += x
        End If
        'End If
    End Sub

    Public Sub futureMovement(ByVal key As Keys, ByVal piece As Object)
        o = piece.left
        p = piece.top

        If key = Keys.S Then
            p += 20
        End If

        If key = Keys.A Then
            o -= 20
        End If
        If key = Keys.D Then
            o += 20
        End If

        If key = Keys.W Then
            p -= 20
        End If

    End Sub
    Public Function collision(ByVal myPiece As Object, ByVal testPiece As Object)
        If myPiece.Bounds.IntersectsWith(testPiece.Bounds) Then
            collision = True
        Else
            collision = False
        End If
    End Function
    Public Function futurecollision(ByVal myPiece As Object, ByVal testPiece As Object)
        If p < testPiece.Bottom And o + myPiece.Width > testPiece.Left And o < testPiece.Right And p + myPiece.Height > testPiece.Top Then
            futurecollision = True
        Else
            futurecollision = False
        End If
    End Function


    Public Sub keyD(ByVal col As Boolean, ByVal cMove As Boolean, ByVal heroP As PictureBox, ByVal bound As Array, ByVal key As Keys)
        col = False
        futureMovement(key, heroP)
        For i = 0 To bound.Length - 1
            If futurecollision(heroP, bound(i)) Then
                col = True
            End If
        Next

        If col = False Then
            If cMove = True Then
                If noRunningShoes = False Then
                    movement(key, heroP, 20)
                ElseIf noRunningShoes = True Then
                    movement(key, heroP, 5)
                Else

                End If
            End If
        Else

        End If
    End Sub

End Module
