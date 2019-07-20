Public Class Form4

    Private Sub Natsu(sender As Object, e As EventArgs) Handles Button1.Click
        hero.attack = 10
        hero.def = 8
        hero.exp = 0
        hero.expMax = 30
        hero.lvl = 1
        hero.HP = 20
        hero.HPMax = 20
        hero.gold = 200
        hero.hPotions = 0
        hero.expPotions = 0
        heroNum = 1
        hero.hName = InputBox("What is your name? (If you want the default name, press enter)")
        If hero.hName = "" Or hero.hName = " " Then
            hero.hName = "Natsu"
        End If
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Knight(sender As Object, e As EventArgs) Handles Button2.Click
        hero.attack = 8
        hero.def = 10
        hero.exp = 0
        hero.expMax = 30
        hero.lvl = 1
        hero.HP = 20
        hero.HPMax = 20
        hero.gold = 200
        hero.hPotions = 0
        hero.expPotions = 0
        heroNum = 2
        hero.hName = InputBox("What is your name? (If you want the default name, press enter)")
        If hero.hName = "" Or hero.hName = " " Then
            hero.hName = "Knight"
        End If
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Kisame(sender As Object, e As EventArgs) Handles Button3.Click
        hero.attack = 9
        hero.def = 9
        hero.exp = 0
        hero.expMax = 30
        hero.lvl = 1
        hero.HP = 25
        hero.HPMax = 25
        hero.gold = 200
        hero.hPotions = 0
        hero.expPotions = 0
        heroNum = 3
        hero.hName = InputBox("What is your name? (If you want the default name, press enter)")
        If hero.hName = "" Or hero.hName = " " Then
            hero.hName = "Kisame"
        End If
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Natsus(sender As Object, e As EventArgs) Handles Button1.MouseHover
        mainChar.Image = ImageList1.Images(0)
        Label2.Text = "Description:" & vbNewLine & "Natsu is strong mentaly and physicaly, but he gets hit too many times."
        Label3.Text = "Stats" & vbNewLine & "HP: 20" & vbNewLine & "Attack 10" & vbNewLine & "Defense: 8"
    End Sub
    Private Sub Knights(sender As Object, e As EventArgs) Handles Button2.MouseHover
        mainChar.Image = ImageList1.Images(1)
        Label2.Text = "Description:" & vbNewLine & "The Knight can widthstand many hits, but figured out shovels dont do much damage."
        Label3.Text = "Stats" & vbNewLine & "HP: 20" & vbNewLine & "Attack 8" & vbNewLine & "Defense: 10"
    End Sub
    Private Sub Kisames(sender As Object, e As EventArgs) Handles Button3.MouseHover
        mainChar.Image = ImageList1.Images(2)
        Label2.Text = "Description:" & vbNewLine & "Kisame can defened as musch as he can attack, plus he has more health than normal."
        Label3.Text = "Stats" & vbNewLine & "HP: 25" & vbNewLine & "Attack 9" & vbNewLine & "Defense: 9"
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave
        mainChar.Image = ImageList1.Images(3)
        Label2.Text = ""
        Label3.Text = ""
    End Sub
End Class