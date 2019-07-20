Module Module1
    Public colliedTournament As Boolean
    Public colliedShop As Boolean
    Public colliedFreeB As Boolean
    Public endbattle As Boolean
    Public newEnemy As Boolean
    Public lvlUp As Boolean
    Public maxLvl As Boolean
    Public heroNum As Integer
    Structure Stats
        Public exp As Integer
        Public expMax As Integer
        Public attack As Integer
        Public def As Integer
        Public HP As Integer
        Public gold As Integer
        Public hPotions As Integer
        Public expPotions As Integer
        Public hName As String
        Public lvl As Integer
        Public HPMax As Integer
    End Structure

    Public hero As Stats
    Public enemy(9) As Stats

    Public Sub moveChar(ByVal key As Keys, ByVal piece As Object)
        'If charWalk = False Then
        If key = Keys.W Then
            piece.Top -= 10
        End If
        If key = Keys.S Then
            piece.Top += 10
        End If
        If key = Keys.A Then
            piece.Left -= 10
        End If
        If key = Keys.D Then
            piece.Left += 10
        End If
        'End If
    End Sub
    Public Sub collision(ByVal myChar As Object, ByVal otherPiece As Object)
        If myChar.Bounds.IntersectsWith(otherPiece.Bounds) Then
            colliedTournament = True
            colliedFreeB = True
            colliedShop = True
        Else
            colliedTournament = False
            colliedFreeB = False
            colliedShop = False
        End If
    End Sub
    Public Sub levelUp(ByVal label As Label)

        If maxLvl = False Then
            If lvlUp = False Then
                If hero.exp >= 30 Then
                    hero.exp = hero.exp - hero.expMax
                    hero.lvl += 1
                    lvlUp = True
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 2 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 1
                    hero.gold += 10
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+10 Gold" & vbNewLine & "+1 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 3 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 2
                    hero.gold += 20
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+20 Gold" & vbNewLine & "+2 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 4 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 3
                    hero.gold += 30
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+30 Gold" & vbNewLine & "+3 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 5 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 4
                    hero.gold += 40
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+40 Gold" & vbNewLine & "+4 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 6 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 5
                    hero.gold += 50
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+50 Gold" & vbNewLine & "+5 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 7 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 5
                    hero.gold += 60
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+60 Gold" & vbNewLine & "+5 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 8 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 5
                    hero.gold += 70
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+70 Gold" & vbNewLine & "+5 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 9 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 5
                    hero.gold += 80
                    hero.HP = hero.HPMax
                    MsgBox("Level up!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+80 Gold" & vbNewLine & "+5 Health Potion")
                    lvlUp = False
                End If
            End If
            If lvlUp = True Then
                If hero.lvl = 10 Then
                    hero.attack += 5
                    hero.def += 5
                    hero.HPMax += 15
                    hero.hPotions += 5
                    hero.gold += 90
                    hero.HP = hero.HPMax
                    MsgBox("Congratulations " & hero.hName & " you reached max Level!" & vbNewLine & "+15 Max HP" & vbNewLine & "+5 Attack" & vbNewLine & "+5 Defense" & vbNewLine & "+90 Gold" & vbNewLine & "+5 Health Potion")
                    maxLvl = True
                    label.BackColor = Color.Yellow
                End If
            End If
        End If
    End Sub
    Public Sub healthBar(ByVal lbl As Label)
        If hero.HP < hero.HPMax / 2 Then
            lbl.BackColor = Color.Orange
            If hero.HP < 5 Then

                lbl.BackColor = Color.Red
            Else
                lbl.BackColor = Color.Green
            End If
        End If
    End Sub
End Module
