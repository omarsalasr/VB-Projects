Public Class Form2
    Dim rand As New Random
    Dim heroLoseP As Integer
    Dim enemyLoseP As Integer
    Dim numclicks As Integer
    Dim x As Integer
    Dim hCriticalH As Integer
    Dim eCriticalH As Integer


    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Form1.Timer1.Stop()
        btnMainForm.Text = "Retreat!"
        If newEnemy = False Then
            HeroAttack.Text = "Attack: " & hero.attack
            HeroDef.Text = "Defense: " & hero.def
            HeroHp.Text = "HP: " & hero.HP & "/" & hero.HPMax
            Herolvl.Text = "Lvl: " & hero.lvl
            If hero.lvl = 1 Then
                getEnemy(0, 5, 11, 0)
            ElseIf hero.lvl = 2 Then
                getEnemy(1, 10, 16, 1)
            ElseIf hero.lvl = 3 Then
                getEnemy(2, 15, 21, 2)
            ElseIf hero.lvl = 4 Then
                getEnemy(3, 20, 26, 3)
            ElseIf hero.lvl = 5 Then
                getEnemy(4, 25, 31, 4)
            ElseIf hero.lvl = 6 Then
                getEnemy(5, 30, 36, 5)
            ElseIf hero.lvl = 7 Then
                getEnemy(6, 35, 41, 6)
            ElseIf hero.lvl = 8 Then
                getEnemy(7, 40, 46, 7)
            ElseIf hero.lvl = 9 Then
                getEnemy(8, 45, 51, 8)
            ElseIf hero.lvl = 10 Then
                getEnemy(9, 50, 56, 9)
            End If
            x = hero.lvl
            newEnemy = True
        End If
        If hero.lvl >= 10 Then
            Herolvl.BackColor = Color.Yellow
            enemyLvl.BackColor = Color.Yellow
        End If
    End Sub
    Private Sub getEnemy(ByVal numEnemy As Integer, ByVal num1 As Integer, ByVal num2 As Integer, ByVal img As Integer)
        enemys.Image = ImageList1.Images(img)

        enemy(numEnemy).attack = rand.Next(num1, num2)
        enemy(numEnemy).def = rand.Next(num1, num2)
        enemy(numEnemy).lvl = hero.lvl
        enemy(numEnemy).HP = hero.HPMax
        enemy(numEnemy).HPMax = hero.HPMax

        enemyAttack.Text = "Attack: " & enemy(numEnemy).attack
        enemyDef.Text = "Deffense: " & enemy(numEnemy).def
        enemyHp.Text = "HP: " & enemy(numEnemy).HP & "/" & enemy(numEnemy).HPMax
        enemyLvl.Text = "Lvl: " & enemy(numEnemy).lvl
    End Sub
    Private Sub btnMainForm_Click(sender As Object, e As EventArgs) Handles btnMainForm.Click
        numclicks = rand.Next(0, 3)
        If endbattle = False Then
            If numclicks = 0 Then
                lblBack.Text = "Pathetic"
            ElseIf numclicks = 1 Then
                lblBack.Text = "Coward"
            ElseIf numclicks = 2 Then
                lblBack.Text = "Chicken"
            End If
        End If
        If endbattle = True Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub btnBattle_Click(sender As Object, e As EventArgs) Handles btnBattle.Click
        lblLoot.Text = ""
        lblBack.Text = ""
        enemyLoseP = hero.attack - (enemy(x - 1).def / 2)
        If enemyLoseP < 0 Then enemyLoseP = 0
        heroLoseP = enemy(x - 1).attack - (hero.def / 2)
        If heroLoseP < 0 Then heroLoseP = 0
        hCriticalH = rand.Next(1, 6)
        If hCriticalH = 3 Then
            enemyLoseP = enemyLoseP * 1.5
            lblLoot.Text = "You dealt bouns damage to your enemy!" & vbNewLine
        End If
        eCriticalH = rand.Next(1, 6)
        If eCriticalH = 3 Then
            enemyLoseP = enemyLoseP * 1.5
            lblLoot.Text = "The enemy dealt bonus damage to you!"
        End If
        hero.HP = hero.HP - heroLoseP
        enemy(x - 1).HP = enemy(x - 1).HP - enemyLoseP
        HeroHp.Text = "HP: " & hero.HP & "/" & hero.HPMax
        enemyHp.Text = "HP: " & enemy(x - 1).HP & "/" & enemy(x - 1).HPMax
        enemyLoseP = 0
        heroLoseP = 0
        If enemy(x - 1).HP <= 0 Then
            enemy(x - 1).HP = 0
            enemyHp.Text = "HP: " & enemy(x - 1).HP & "/" & enemy(x - 1).HPMax
            If hero.HP <= 0 Then hero.HP = 1
            HeroHp.Text = "HP: " & hero.HP & "/" & hero.HPMax
            hero.gold += 80
            If hero.lvl >= 10 Then
                lblLoot.Text = "Rewards:" & vbNewLine & "Gold: + $80"
            Else
                hero.exp += 20
                lblLoot.Text = "Rewards:" & vbNewLine & "Exp: +20" & vbNewLine & "Gold: + $80"
            End If
            MsgBox(hero.hName & " wins!")
            endbattle = True
            btnBattle.Enabled = False
            levelUp(Herolvl)
            btnMainForm.Text = "Town"
        Else
            If hero.HP <= 0 Then
                hero.HP = 0
                HeroHp.Text = "HP: " & hero.HP & "/" & hero.HPMax
                hero.exp += 10
                If hero.lvl >= 10 Then
                    lblLoot.Text = "Rewards:" & vbNewLine & "Nothing"
                Else
                    lblLoot.Text = "Rewards:" & vbNewLine & "Exp: +10"
                End If
                MsgBox(hero.hName & " was defeated!")
                endbattle = True
                btnBattle.Enabled = False
                levelUp(Herolvl)
                btnMainForm.Text = "Town"
            End If
            End If
            'healthBar(HeroHp)
    End Sub
    'when you back to battle, make sure to have a way to heal, else he will only have 1 HP.
    'have a button to auto heal, everytime the battle form is activated make sure the HP is reset
    'in the winning/losing process, he must gain exp to level up and get stronger
    'have an array of enemys where the lowest is the weakest, the higher the strongest
    'enemy you battle should be determined by the Exp of the hero
    'predetermine the attack and def of the enemy with x var and y var
    'show different pictures for the enemys

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        If heroNum = 1 Then
            mainChar.Image = ImageList1.Images(10)
        ElseIf heroNum = 2 Then
            mainChar.Image = ImageList1.Images(11)
        ElseIf heroNum = 3 Then
            mainChar.Image = ImageList1.Images(12)
        End If

    End Sub
End Class