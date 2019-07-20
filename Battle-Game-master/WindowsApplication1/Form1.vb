Public Class Form1
    Dim nextConv As Integer
    Dim otherGuyTalk As Integer
    Dim rand As New Random
    Dim wShop As Boolean
    Dim pShop As Boolean
    Dim fBattle As Boolean
    Dim lowHealth As Boolean
    Dim pUp As Boolean
    Dim pDown As Boolean
    Dim pLeft As Boolean
    Dim pRight As Boolean

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Timer1.Start()
        pUp = False
        pDown = False
        pLeft = False
        pRight = False

        mainChar.Left = 422
        mainChar.Top = 250
        lblPlayerName.Text = "Player Name: " & hero.hName
        lblAttack.Text = "Attack: " & hero.attack
        lblDef.Text = "Defense: " & hero.def
        If hero.lvl >= 10 Then
            lblExp.Text = "Exp: Max!"
            lblLvl.BackColor = Color.Yellow
        Else
            lblExp.Text = "Exp: " & hero.exp & "/" & hero.expMax
        End If
        lblHealth.Text = "Health: " & hero.HP & "/" & hero.HPMax
        lblGold.Text = "Gold: $" & hero.gold
        lblHPotions.Text = "Health Potions: " & hero.hPotions
        lblExpPotions.Text = "Exp Potions: " & hero.expPotions
        lblLvl.Text = "Lvl: " & hero.lvl


        newEnemy = False
        Form2.btnBattle.Enabled = True
        endbattle = False
        potionButtons()

        If hero.HP < 5 Then
            If hero.HP = 0 Then hero.HP = 1
            lblHealth.Text = "Health: " & hero.HP & "/" & hero.HPMax

            lblHealth.BackColor = Color.Red
        Else
            lblHealth.BackColor = Color.Green

        End If


    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        

        levelUp(lblLvl)

        If e.KeyCode = Keys.W Then
            pUp = True
        End If
        If e.KeyCode = Keys.S Then
            pDown = True
        End If
        If e.KeyCode = Keys.A Then
            pLeft = True
        End If
        If e.KeyCode = Keys.D Then
            pRight = True
        End If

        'moveChar(e.KeyCode, mainChar)


        collision(mainChar, pctwShop)
        If colliedShop = True Then
            Timer1.Stop()
            Form3.Show()
            Me.Hide()
        End If

        collision(mainChar, battleArena)
        If colliedFreeB = True Then
            Form2.Show()
            Me.Hide()
            Form2.lblLoot.Text = ""
        End If



        'If e.KeyCode = Keys.W Then
        '    mainChar.Top -= 10
        'End If
        'If e.KeyCode = Keys.S Then
        '    mainChar.Top += 10
        'End If
        'If e.KeyCode = Keys.A Then
        '    mainChar.Left -= 10
        'End If
        'If e.KeyCode = Keys.D Then
        '    mainChar.Left += 10
        'End If

        'If rand.Next(1, 5) = 1 Then
        '    MsgBox("Prepare to battle")
        '    Me.Hide()
        '    Form2.Show()
        'End If

        'If mainChar.Bounds.IntersectsWith(PictureBox1.Bounds) Then

        '    If otherGuyTalk = 0 Then
        '        tmrConversation1.Start()
        '        nextConv = 0

        '    ElseIf otherGuyTalk = 5 Then
        '        tmrConversation2.Start()
        '        nextConv = 0
        '    End If
        '    otherGuyTalk += 1
        'End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            pUp = False
        End If
        If e.KeyCode = Keys.S Then
            pDown = False
        End If
        If e.KeyCode = Keys.A Then
            pLeft = False
        End If
        If e.KeyCode = Keys.D Then
            pRight = False
        End If
    End Sub
    'Set wordwrap to true when long lines of text in the messages

    'Private Sub tmrConversation1_Tick(sender As Object, e As EventArgs) Handles tmrConversation1.Tick
    '    If nextConv = 0 Then
    '        txtMessages.Text = vbNewLine & "Hello" & txtMessages.Text
    '    ElseIf nextConv = 1 Then
    '        txtMessages.Text = vbNewLine & "how are you" & txtMessages.Text
    '    ElseIf nextConv = 2 Then
    '        txtMessages.Text = vbNewLine & "im fine thanks for asking" & txtMessages.Text
    '    ElseIf nextConv = 3 Then
    '        txtMessages.Text = vbNewLine & "1" & txtMessages.Text
    '    ElseIf nextConv = 4 Then
    '        txtMessages.Text = vbNewLine & "2" & txtMessages.Text
    '    ElseIf nextConv = 5 Then
    '        txtMessages.Text = vbNewLine & "3" & txtMessages.Text
    '        tmrConversation1.Stop()
    '    End If
    '    nextConv += 1


    'End Sub

    'Private Sub tmrConversation2_Tick(sender As Object, e As EventArgs) Handles tmrConversation2.Tick
    '    nextConv = 0
    '    If nextConv = 0 Then
    '        txtMessages.Text = vbNewLine & "Bye" & txtMessages.Text
    '    ElseIf nextConv = 1 Then
    '        txtMessages.Text = vbNewLine & "Your bad" & txtMessages.Text
    '    ElseIf nextConv = 2 Then
    '        txtMessages.Text = vbNewLine & "hhhheeei" & txtMessages.Text
    '    ElseIf nextConv = 3 Then
    '        txtMessages.Text = vbNewLine & "4" & txtMessages.Text
    '    ElseIf nextConv = 4 Then
    '        txtMessages.Text = vbNewLine & "5" & txtMessages.Text
    '    ElseIf nextConv = 5 Then
    '        txtMessages.Text = vbNewLine & "6" & txtMessages.Text
    '        tmrConversation2.Stop()
    '    End If
    '    nextConv += 1

    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Controls:" & vbNewLine & "Use the Keys WASD to move your character" & vbNewLine & vbNewLine & "Potions:" & vbNewLine & "Health Potion regains 10 HP" & vbNewLine & "Exp Potions give you 10 Exp" & vbNewLine & vbNewLine & "Objective:" & vbNewLine & "Defeat enemys to earn exp to level up and become the most OP slayer." & vbNewLine & "Tips: Heal before you enter a battle and enemys scale to your lvl.")

        If heroNum = 1 Then
            mainChar.Image = ImageList1.Images(0)
        ElseIf heroNum = 2 Then
            mainChar.Image = ImageList1.Images(1)
        ElseIf heroNum = 3 Then
            mainChar.Image = ImageList1.Images(2)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHPotion.Click
        hero.HP += 10
        hero.hPotions -= 1
        If hero.HP >= hero.HPMax Then
            hero.HP = hero.HPMax
        End If
        lblHealth.Text = "Health: " & hero.HP & "/" & hero.HPMax
        lblHPotions.Text = "Health Potions: " & hero.hPotions
        potionButtons()
        healthBar(lblHealth)
    End Sub
    Public Sub potionButtons()

        If hero.hPotions < 1 Or hero.HP = hero.HPMax Then
            btnHPotion.Enabled = False
        Else
            btnHPotion.Enabled = True
        End If
        If hero.expPotions < 1 Or hero.lvl = 10 Then
            btnExpPotion.Enabled = False
        Else
            btnExpPotion.Enabled = True
        End If
    End Sub

    Private Sub btnExpPotion_Click(sender As Object, e As EventArgs) Handles btnExpPotion.Click
        hero.exp += 10
        hero.expPotions -= 1
        potionButtons()
        lblExpPotions.Text = "Exp Potions: " & hero.expPotions
        If hero.lvl >= 10 Then
            lblExp.Text = "Exp: Max!"
        Else
            lblExp.Text = "Exp: " & hero.exp & "/" & hero.expMax
        End If
        lblLvl.Text = "Lvl: " & hero.lvl
        levelUp(lblLvl)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pUp = True And mainChar.Top > playArea.Top Then
            mainChar.Top -= 10
        End If

        If pDown = True And mainChar.Bottom < playArea.Bottom Then
            mainChar.Top += 10
        End If

        If pLeft = True And mainChar.Left > playArea.Left Then
            mainChar.Left -= 10
        End If

        If pRight = True And mainChar.Right < playArea.Right Then
            mainChar.Left += 10
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        hero.gold += 999
        lblGold.Text = "Gold: $" & hero.gold
    End Sub
End Class
