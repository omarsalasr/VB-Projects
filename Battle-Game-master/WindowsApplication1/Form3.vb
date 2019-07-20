Public Class Form3

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        enableButtons()
        Form1.Timer1.Stop()
    End Sub
    Public Sub enableButtons()
        lblGold.Text = "Gold: $" & hero.gold
        lblExpPotions.Text = "Exp Potions: " & hero.expPotions
        lblHPotions.Text = "Health Potions: " & hero.hPotions
        If hero.gold >= 50 Then
            btnHPotion.Enabled = True
        Else
            btnHPotion.Enabled = False
        End If
        If hero.gold >= 100 Then
            btnSword.Enabled = True
        Else
            btnSword.Enabled = False
        End If
        If hero.gold >= 200 Then
            btnArmor.Enabled = True
        Else
            btnArmor.Enabled = False
        End If
        If hero.gold >= 500 Then
            btnEPotion.Enabled = True
        Else
            btnEPotion.Enabled = False
        End If
    End Sub

    Private Sub btnHPotion_Click(sender As Object, e As EventArgs) Handles btnHPotion.Click
        hero.gold -= 50
        hero.hPotions += 1

        enableButtons()
    End Sub

    Private Sub btnSword_Click(sender As Object, e As EventArgs) Handles btnSword.Click
        hero.gold -= 100
        hero.attack += 3
        enableButtons()
        btnSword.Text = "Upgrade"
    End Sub

    Private Sub btnArmor_Click(sender As Object, e As EventArgs) Handles btnArmor.Click
        hero.gold -= 200
        hero.def += 3
        enableButtons()
        btnArmor.Text = "Upgrade"
    End Sub

    Private Sub btnEPotion_Click(sender As Object, e As EventArgs) Handles btnEPotion.Click
        hero.gold -= 500
        hero.expPotions += 1
        enableButtons()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        If heroNum = 1 Then
            PictureBox1.Image = ImageList1.Images(0)
            PictureBox2.Image = ImageList1.Images(1)
            Label2.Text = "Gauntlets"
            Label3.Text = "Vest"
        ElseIf heroNum = 3 Then
            PictureBox1.Image = ImageList1.Images(2)
            PictureBox2.Image = ImageList1.Images(3)
            Label2.Text = "Sword"
            Label3.Text = "Coat"
        End If
    End Sub
End Class