Public Class Form1
    Dim count As Integer
    Dim inventory As New List(Of String)
    Dim invCount As Integer
    Dim intro As Boolean
    Dim search As Boolean
    Dim hole As Boolean
    Dim sForest As Boolean
    Dim sHouse As Boolean
    Dim sRiver As Boolean
    Dim sWaterfall As Boolean
    Dim lighter As Boolean
    Dim wood As Boolean
    Dim knife As Boolean
    Dim potion As Boolean
    Dim fString As Boolean
    Dim engine As Boolean
    Dim key As Boolean
    Dim fish As Boolean
    Dim fishingRod As Boolean
    Dim fishingStick As Boolean
    Dim fIntro As Boolean
    Dim golemAlive As Boolean
    Dim sHole As Boolean
    Dim dropIt As Boolean
    Dim sBHouse As Boolean
    Dim kitchen As Boolean
    Dim confirm As Boolean
    Dim potionActv As Boolean
    Dim sKitchen As Boolean
    Dim livingRoom As Boolean
    Dim basement As Boolean
    Dim sBasement As Boolean
    Dim mTable As Boolean
    Dim sDoorK As Boolean
    Dim sDoorC As Boolean
    Dim sLivingR As Boolean
    Dim bedRoom As Boolean
    Dim fDoor As Boolean
    Dim challenge As Boolean
    Dim sBedRoom As Boolean
    Dim umbrella As Boolean
    Dim gotFish As Integer
    Dim rnum As New Random
    Dim pUpWood As Boolean
    Dim pUpPotion As Boolean
    Dim pUpString As Boolean
    Dim pUpLighter As Boolean
    Dim pUpStick As Boolean
    Dim pUpUmbrella As Boolean
    Dim cave As Boolean
    Dim umbrellaOn As Boolean
    Dim ogre As Boolean
    Dim lair As Boolean
    Dim cpath As Integer
    Dim hit As Integer
    Dim ogreHP As Integer
    Dim plHP As Integer
    Dim sLair As Boolean
    Dim pUpEngine As Boolean
    Dim extConfirm As Boolean
    Dim underHouse As Boolean
    Dim oneT As Boolean
    Dim engineInstalled As Boolean
    Dim leaving As Boolean
    Dim escPath As Integer
    Dim mistake As Integer
    Dim keyInst As Boolean
    Dim onetime As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intro = True
        Button1.Enabled = False
        Button1.Visible = False
        TextA.Enabled = True
        golemAlive = True
        ogre = True
        ogreHP = 1
        plHP = 10
        If count = 0 Then
            ListA.Items.Insert(0, "> Hello")
            count += 1
        End If
        TextA.Focus()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextA.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListA.Items.Insert(0, TextA.Text)
            If TextA.Text = "=" Then
                sForest = False
                sHouse = False
                sHole = False
                sBasement = False
                sBHouse = False
                sBedRoom = False
                sLivingR = False
                sRiver = False
                sWaterfall = False
                pUpLighter = False
                pUpPotion = False
                pUpStick = False
                pUpString = False
                pUpUmbrella = False
                pUpWood = False
                dropIt = True
            End If
            If TextA.Text = "`kill ogre" Then
                ogre = False
            End If
            If TextA.Text = "`umbrella" And umbrella = False Then
                If invCount < 5 Then
                    invCount += 1
                    umbrella = True
                    inventory.Add("umbrella")
                    ListA.Items.Insert(0, "> You picked up the umbrella.")
                    pUpUmbrella = True
                ElseIf invCount >= 5 Then
                    ListA.Items.Insert(0, "> Your inventory is full.")
                End If
                dropIt = True
            End If
            If TextA.Text = "`engine" And pUpEngine = False Then
                pUpEngine = True
                dropIt = True
            End If
            If TextA.Text = "`ogre" Then
                ogreHP = 10
                plHP = 1
                dropIt = True
            End If
            If TextA.Text = "`potion" And potion = False Then
                If invCount < 5 Then
                    invCount += 1
                    potion = True
                    inventory.Add("potion")
                    ListA.Items.Insert(0, "> You picked up the potion.")
                    pUpPotion = True
                ElseIf invCount >= 5 Then
                    ListA.Items.Insert(0, "> Your inventory is full.")
                End If
                dropIt = True
            End If
            If TextA.Text = "`key" And key = False Then
                If invCount < 5 Then
                    invCount += 1
                    key = True
                    inventory.Add("key")
                    ListA.Items.Insert(0, "> You picked up the key.")
                ElseIf invCount >= 5 Then
                    ListA.Items.Insert(0, "> Your inventory is full.")
                End If
                dropIt = True
            End If
            If TextA.Text = "`fishing rod" And fishingRod = False Then
                If invCount <= 5 Then
                    ListA.Items.Insert(0, "> You crafted a fishing rod.")
                    fishingRod = True
                    fishingStick = False
                    fString = False
                    invCount -= 1
                    inventory.Remove("fishing stick")
                    inventory.Remove("string")
                    inventory.Add("fishing rod")
                    dropIt = True
                ElseIf invCount >= 5 Then
                    ListA.Items.Insert(0, "> Your inventory is full.")
                End If
                dropIt = True
            End If
            If TextA.Text = "`timer" And challenge = True Then
                minutes.Text = 0
                seconds.Text = 10
                dropIt = True
            End If
            If intro = True Then
                If count = 1 And TextA.Text = "hello" Then
                    ListA.Items.Insert(0, "> Do you want to play a game?")
                    count += 1
                ElseIf count = 2 And TextA.Text = "yes" Then
                    ListA.Items.Clear()
                    forest = True
                    count = 0
                    fIntro = True
                    intro = False
                    MsgBox("You can do Ctrl + C for a list of commands and Ctrl + M for an updating map.")
                Else
                    ListA.Items.Insert(0, "> Try again")
                End If
            End If
            '................................................ a............................................FOREST
            If forest = True Then
                dropItems()
                If dropIt = False Then
                    If fIntro = True And count = 0 Then
                        ListA.Items.Insert(0, "> You find yourself in a dark forest.")
                        ListA.Items.Insert(0, "> There is no one here.")
                        ListA.Items.Insert(0, "> You have a knife.")
                        ListA.Items.Insert(0, "> There is some wood on the ground and a dark hole.")
                        inventory.Add("knife")
                        knife = True
                        invCount = 1
                        fIntro = False
                    ElseIf sForest = False And TextA.Text = "search" Then
                        ListA.Items.Insert(0, "> There is a dark hole and some wood.")
                        sForest = True
                    ElseIf sForest = True And TextA.Text = "search" Then
                        ListA.Items.Insert(0, "> You already searched here.")
                        sForest = True
                    ElseIf TextA.Text = "go north" And fDoor = True Then
                        ListA.Items.Insert(0, "> There is a house here and the front door is unlocked.")
                        house = True
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "go north" Then
                        ListA.Items.Insert(0, "> There is a house, but the front door is locked.")
                        house = True
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "go south" Then
                        ListA.Items.Insert(0, "> There is a waterfall, there is something through the waterfall.")
                        waterfall = True
                        umbrellaOn = False
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "go east" Then
                        ListA.Items.Insert(0, "> There is a river here.")
                        river = True
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "go west" Then
                        ListA.Items.Insert(0, "> There is a helicopter here.")
                        helicopter = True
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "pick up wood" And pUpWood = True Then
                        ListA.Items.Insert(0, "> There is no more wood here.")
                    ElseIf TextA.Text = "pick up wood" And wood = False Then
                        If invCount < 5 Then
                            invCount += 1
                            wood = True
                            inventory.Add("wood")
                            ListA.Items.Insert(0, "> You picked up wood.")
                            pUpWood = True
                        ElseIf invCount >= 5 Then
                            ListA.Items.Insert(0, "> Your inventory is full.")
                        End If
                    ElseIf TextA.Text = "pick up wood" And wood = True Then
                        ListA.Items.Insert(0, "> You already picked up some wood.")
                    ElseIf TextA.Text = "go in hole" And lighter = False Then
                        ListA.Items.Insert(0, "> It is too dark, you might be eaten by an animal.")
                        dropIt = True
                    ElseIf TextA.Text = "go in hole" And lighter = True And golemAlive = True Then
                        ListA.Items.Insert(0, "> There is a Golem guarding a mysterious potion.")
                        ListA.Items.Insert(0, "> Golem: Get away from my precious or else i'll eat you.")
                        hole = True
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "go in hole" And lighter = True And golemAlive = False And potion = False And potionActv = False Then
                        ListA.Items.Insert(0, "> There is a mysterious potion.")
                        hole = True
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "go in hole" And lighter = True And golemAlive = False And potion = False And potionActv = True Then
                        ListA.Items.Insert(0, "> There is a nothing here.")
                        hole = True
                        forest = False
                        dropIt = True
                    ElseIf TextA.Text = "go in hole" And lighter = True And golemAlive = False And potion = True Then
                        ListA.Items.Insert(0, "> There is a nothing here.")
                        hole = True
                        forest = False
                        dropIt = True
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '...............................................................................................HOLE
            If hole = True Then
                dropItems()
                If dropIt = False Then
                    If sHole = False And TextA.Text = "search" And golemAlive = True Then
                        ListA.Items.Insert(0, "> There is the hole exit and a Golem guarding a mysterious potion.")
                        sHole = True
                    ElseIf sHole = False And TextA.Text = "search" And golemAlive = False Then
                        ListA.Items.Insert(0, "> There is a potion and the exit.")
                        sHole = True
                    ElseIf sHole = True And TextA.Text = "search" Then
                        ListA.Items.Insert(0, "> You already searched here.")
                    ElseIf TextA.Text = "pick up potion" And pUpPotion = True Then
                        ListA.Items.Insert(0, "> There is no potion here.")
                    ElseIf TextA.Text = "pick up potion" And potion = True Then
                        ListA.Items.Insert(0, "> You already picked up the potion.")
                    ElseIf TextA.Text = "pick up potion" And potion = False And golemAlive = True Then
                        ListA.Items.Insert(0, "> Golem is still here, you must get rid of him first.")
                    ElseIf TextA.Text = "pick up potion" And potion = False And golemAlive = False Then
                        If invCount < 5 Then
                            invCount += 1
                            potion = True
                            inventory.Add("potion")
                            ListA.Items.Insert(0, "> You picked up the potion.")
                            pUpPotion = True
                        ElseIf invCount >= 5 Then
                            ListA.Items.Insert(0, "> Your inventory is full.")
                        End If
                    ElseIf TextA.Text = "exit hole" And golemAlive = True Then
                        ListA.Items.Insert(0, "> Golem: You are not going anywhere.")
                    ElseIf TextA.Text = "exit hole" And golemAlive = False Then
                        ListA.Items.Insert(0, "> You are at the forest.")
                        forest = True
                        hole = False
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '.................................................................................FRONT HOUSE
            If house = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sHouse = False And fDoor = False Then
                        ListA.Items.Insert(0, "> The front door of the house is locked, but if you go north there is a back door.")
                        sHouse = True
                    ElseIf TextA.Text = "search" And sHouse = False And fDoor = True Then
                        ListA.Items.Insert(0, "> The front and back door are unlocked.")
                        sHouse = True
                    ElseIf TextA.Text = "search" And sHouse = True Then
                        ListA.Items.Insert(0, "> You already searched here.")
                    ElseIf TextA.Text = "go north" Then
                        ListA.Items.Insert(0, "> The back door seems to be unlocked.")
                        bHouse = True
                        house = False
                        dropIt = True
                    ElseIf TextA.Text = "go south" Then
                        ListA.Items.Insert(0, "> You are in the forest.")
                        forest = True
                        house = False
                        dropIt = True
                    ElseIf TextA.Text = "go east" Then
                        ListA.Items.Insert(0, "> There is a river here.")
                        river = True
                        house = False
                        dropIt = True
                    ElseIf TextA.Text = "go west" Then
                        ListA.Items.Insert(0, "> There is a helicopter here.")
                        helicopter = True
                        house = False
                        dropIt = True
                    ElseIf TextA.Text = "go in house" And fDoor = True Then
                        ListA.Items.Insert(0, "> You are in the living room.")
                        livingRoom = True
                        house = False
                        dropIt = True
                    ElseIf TextA.Text = "go in house" And fDoor = False Then
                        ListA.Items.Insert(0, "> The door is locked.")
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '..................................................................................BACK HOUSE 
            If bHouse = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sBHouse = False Then
                        ListA.Items.Insert(0, "> This door is unlocked")
                        sBHouse = True
                    ElseIf TextA.Text = "search" And sBHouse = True Then
                        ListA.Items.Insert(0, "> You already search here.")
                    ElseIf TextA.Text = "go in house" Then
                        ListA.Items.Insert(0, "> You are at the basement, the exit and a door that leads to the kitchen are here.")
                        basement = True
                        bHouse = False
                        dropIt = True
                    ElseIf TextA.Text = "go north" Then
                        ListA.Items.Insert(0, "> There is a waterfall here.")
                        waterfall = True
                        umbrellaOn = False
                        bHouse = False
                        dropIt = True
                    ElseIf TextA.Text = "go south" Then
                        ListA.Items.Insert(0, "> You are at the front of the house.")
                        house = True
                        bHouse = False
                        dropIt = True
                    ElseIf TextA.Text = "go east" Then
                        ListA.Items.Insert(0, "> There is a river here.")
                        river = True
                        bHouse = False
                        dropIt = True
                    ElseIf TextA.Text = "go west" Then
                        ListA.Items.Insert(0, "> There is a helicopter, but looks like it's missing the engine.")
                        helicopter = True
                        bHouse = False
                        dropIt = True
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '.................................................................................BASEMENT 
            If basement = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sBasement = False Then
                        ListA.Items.Insert(0, "> There is a lighter, some string, and a door that leads to the kitchen.")
                        sBasement = True
                    ElseIf TextA.Text = "search" And sBasement = True Then
                        ListA.Items.Insert(0, "> You already searched here.")
                        sBasement = True
                    ElseIf TextA.Text = "go in kitchen" Then
                        ListA.Items.Insert(0, "> You are in the kitchen, the living room and basement doors are here, but the floor feels weird.")
                        kitchen = True
                        basement = False
                        dropIt = True
                    ElseIf TextA.Text = "exit house" Then
                        ListA.Items.Insert(0, "> You are at the back of the house.")
                        bHouse = True
                        basement = False
                        dropIt = True
                    ElseIf TextA.Text = "pick up string" And pUpString = True Then
                        ListA.Items.Insert(0, "> There is no more string here.")
                    ElseIf TextA.Text = "pick up string" And fString = True Then
                        ListA.Items.Insert(0, "> You already picked up the string.")
                    ElseIf TextA.Text = "pick up string" And fString = False Then
                        If invCount < 5 Then
                            invCount += 1
                            fString = True
                            inventory.Add("string")
                            ListA.Items.Insert(0, "> You picked up the string.")
                            pUpString = True
                        ElseIf invCount >= 5 Then
                            ListA.Items.Insert(0, "> Your inventory is full.")
                        End If
                    ElseIf TextA.Text = "pick up lighter" And pUpLighter = True Then
                        ListA.Items.Insert(0, "> There is no lighter here.")
                    ElseIf TextA.Text = "pick up lighter" And lighter = True Then
                        ListA.Items.Insert(0, "> You already picked up the lighter.")
                    ElseIf TextA.Text = "pick up lighter" And lighter = False Then
                        If invCount < 5 Then
                            invCount += 1
                            lighter = True
                            inventory.Add("lighter")
                            ListA.Items.Insert(0, "> You picked up the lighter.")
                            pUpLighter = True
                        ElseIf invCount >= 5 Then
                            ListA.Items.Insert(0, "> Your inventory is full.")
                        End If
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '.................................................................................KITCHEN 
            If kitchen = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sKitchen = False Then
                        ListA.Items.Insert(0, "> There is the basement and living room door. The floor feels weird.")
                        ListA.Items.Insert(0, "> There is a table, fridge, and a counter here.")
                        sKitchen = True
                    ElseIf TextA.Text = "search" And sKitchen = True Then
                        ListA.Items.Insert(0, "> You already searched here.")
                    ElseIf TextA.Text = "go in living room" Then
                        ListA.Items.Insert(0, "> You are in the living room.")
                        livingRoom = True
                        kitchen = False
                        dropIt = True
                    ElseIf TextA.Text = "go in basement" Then
                        ListA.Items.Insert(0, "> You are in the basement.")
                        basement = True
                        kitchen = False
                        dropIt = True
                    ElseIf TextA.Text = "move fridge" Then
                        ListA.Items.Insert(0, "> It's too heavy to move.")
                    ElseIf TextA.Text = "move counter" Then
                        ListA.Items.Insert(0, "> It's too heavy to move.")
                    ElseIf TextA.Text = "move table" And mTable = False Then
                        ListA.Items.Insert(0, "> You moved the table and uncovered a secret door.")
                        mTable = True
                    ElseIf TextA.Text = "go through door" And sDoorK = False And mTable = True Then
                        ListA.Items.Insert(0, "> It's locked.")
                    ElseIf TextA.Text = "unlock door" And sDoorK = False And mTable = True Then
                        ListA.Items.Insert(0, "> You unlocked the door, but it's locked from the other side.")
                        sDoorK = True
                    ElseIf TextA.Text = "go through door" And sDoorC = False And mTable = True Then
                        ListA.Items.Insert(0, "> It's locked from the other side.")
                    ElseIf TextA.Text = "go through door" And sDoorK = True And mTable = True And sDoorC = True Then
                        ListA.Items.Insert(0, "> You are under the house.")
                        ListA.Items.Insert(0, "> The door to the kitchen and to the lair are here.")
                        kitchen = False
                        underHouse = True
                        dropIt = True
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            ' .....................................................................................LIVING ROOM
            If livingRoom = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sLivingR = False Then
                        ListA.Items.Insert(0, "> The front door and the stairs that leads to a bedroom are here.")
                        ListA.Items.Insert(0, "> There is a mysterious letter here.")
                        sLivingR = True
                    ElseIf TextA.Text = "search" And sLivingR = True Then
                        ListA.Items.Insert(0, "> You already searched here.")
                    ElseIf TextA.Text = "go in kitchen" Then
                        ListA.Items.Insert(0, "> You are in the kitchen.")
                        kitchen = True
                        livingRoom = False
                        dropIt = True
                    ElseIf TextA.Text = "go upstairs" Then
                        ListA.Items.Insert(0, "> You are in the bedroom.")
                        bedRoom = True
                        livingRoom = False
                        dropIt = True
                    ElseIf TextA.Text = "open door" And fDoor = False Then
                        ListA.Items.Insert(0, "> It's locked.")
                    ElseIf TextA.Text = "unlock door" And fDoor = False Then
                        ListA.Items.Insert(0, "> You unlocked the front door.")
                        fDoor = True
                    ElseIf TextA.Text = "read letter" Then
                        ListA.Items.Insert(0, "> 'RUN! The zombies will come for you, if you don't get out of here you will die.")
                        Timer1.Start()
                        challenge = True
                        Label2.Visible = True
                        Label1.Visible = True
                        GroupBox1.Visible = True
                        minutes.Visible = True
                        seconds.Visible = True
                    ElseIf TextA.Text = "exit house" And fDoor = True Then
                        ListA.Items.Insert(0, "> You are at the front of the house.")
                        house = True
                        livingRoom = False
                        dropIt = True
                    ElseIf TextA.Text = "exit house" And fDoor = False Then
                        ListA.Items.Insert(0, "> The front door is locked.")
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '............................................................................................BEDROOM
            If bedRoom = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sBedRoom = False Then
                        ListA.Items.Insert(0, "> There are some stairs that lead downstairs.")
                        ListA.Items.Insert(0, "> There is fishing stick and an umbrella.")
                        sBedRoom = True
                    ElseIf TextA.Text = "search" And sBedRoom = True Then
                        ListA.Items.Insert(0, "> You already searched here.")
                    ElseIf TextA.Text = "pick up fishing stick" And pUpStick = True Then
                        ListA.Items.Insert(0, "> There is no fishing stick here.")
                    ElseIf TextA.Text = "pick up fishing stick" And fishingStick = True Then
                        ListA.Items.Insert(0, "> You already picked up the fishing stick.")
                    ElseIf TextA.Text = "pick up fishing stick" And fishingStick = False Then
                        If invCount < 5 Then
                            invCount += 1
                            fishingStick = True
                            inventory.Add("fishing stick")
                            ListA.Items.Insert(0, "> You picked up the fishing stick.")
                        ElseIf invCount >= 5 Then
                            ListA.Items.Insert(0, "> Your inventory is full.")
                        End If
                    ElseIf TextA.Text = "pick up umbrella" And pUpUmbrella = True Then
                        ListA.Items.Insert(0, "> There is no umbrella here.")
                    ElseIf TextA.Text = "pick up umbrella" And umbrella = True Then
                        ListA.Items.Insert(0, "> You already picked up the umbrella.")
                    ElseIf TextA.Text = "pick up umbrella" And umbrella = False Then
                        If invCount < 5 Then
                            invCount += 1
                            umbrella = True
                            inventory.Add("umbrella")
                            ListA.Items.Insert(0, "> You picked up the umbrella.")
                            pUpUmbrella = True
                        ElseIf invCount >= 5 Then
                            ListA.Items.Insert(0, "> Your inventory is full.")
                        End If
                    ElseIf TextA.Text = "go downstairs" Then
                        ListA.Items.Insert(0, "> You are in the living room.")
                        livingRoom = True
                        bedRoom = False
                        dropIt = True
                    Else
                        ListA.Items.Insert(0, "> Try again.")

                    End If
                End If
            End If
            '.....................................................................................RIVER
            If river = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sRiver = False Then
                        ListA.Items.Insert(0, "> There is a river here, there are some fish.")
                        sRiver = True
                    ElseIf TextA.Text = "search" And sRiver = True Then
                        ListA.Items.Insert(0, "> You already searched here.")
                    ElseIf TextA.Text = "go north" Then
                        ListA.Items.Insert(0, "> You are at the front of the house.")
                        house = True
                        river = False
                        dropIt = True
                    ElseIf TextA.Text = "go south" Then
                        ListA.Items.Insert(0, "> You are at the waterfall.")
                        waterfall = True
                        umbrellaOn = False
                        river = False
                        dropIt = True
                    ElseIf TextA.Text = "go east" Then
                        ListA.Items.Insert(0, "> There is a helicopter here.")
                        helicopter = True
                        river = False
                        dropIt = True
                    ElseIf TextA.Text = "go west" Then
                        ListA.Items.Insert(0, "> You are in the forest.")
                        forest = True
                        river = False
                        dropIt = True
                    ElseIf TextA.Text = "go fishing" And fishingRod = False Then
                        ListA.Items.Insert(0, "> You need something to fish with.")
                    ElseIf TextA.Text = "go fishing" And fishingRod = True Then
                        gotFish = rnum.Next(1, 12)
                        If gotFish = 1 Or gotFish = 2 Or gotFish = 3 Or gotFish = 4 Or gotFish = 5 Then
                            ListA.Items.Insert(0, "> You didn't catch anything.")
                        ElseIf gotFish = 7 Or gotFish = 8 Or gotFish = 9 Or gotFish = 10 Or gotFish = 11 Then
                            If fish = True Then
                                ListA.Items.Insert(0, "> You already have a fish.")
                            ElseIf invCount < 5 Then
                                invCount += 1
                                fish = True
                                inventory.Add("fish")
                                ListA.Items.Insert(0, "> You caught a fish.")
                            ElseIf invCount >= 5 Then
                                ListA.Items.Insert(0, "> Your inventory is full.")
                            End If
                        ElseIf gotFish = 6 And invCount < 5 And key = False Then
                            invCount += 1
                            key = True
                            inventory.Add("key")
                            ListA.Items.Insert(0, "> Wow, you found the key to the helicopter!")
                        ElseIf gotFish = 6 And key = True Then
                            ListA.Items.Insert(0, "> You didn't catch anything.")
                        ElseIf gotFish = 6 And invCount >= 5 Then
                            ListA.Items.Insert(0, "> You didn't catch anything.")
                        End If
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If

            End If
            '...........................................................................................WATERFALL
            If waterfall = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sWaterfall = False Then
                        ListA.Items.Insert(0, "> There is a waterfall here, there seems to be something through it.")
                        sWaterfall = True
                    ElseIf TextA.Text = "search" And sWaterfall = True Then
                        ListA.Items.Insert(0, "> You already searched here.")
                    ElseIf TextA.Text = "go north" Then
                        ListA.Items.Insert(0, "> You are at the forest.")
                        forest = True
                        waterfall = False
                        dropIt = True
                    ElseIf TextA.Text = "go south" Then
                        ListA.Items.Insert(0, "> You are at the back of the house.")
                        bHouse = True
                        waterfall = False
                        dropIt = True
                    ElseIf TextA.Text = "go east" Then
                        ListA.Items.Insert(0, "> You are at the river.")
                        river = True
                        waterfall = False
                        dropIt = True
                    ElseIf TextA.Text = "go west" Then
                        ListA.Items.Insert(0, "> There is a helicopter here.")
                        helicopter = True
                        waterfall = False
                        dropIt = True
                    ElseIf TextA.Text = "go through waterfall" And umbrellaOn = False Then
                        ListA.Items.Insert(0, "> The water is too hot to pass through.")
                    ElseIf TextA.Text = "go through waterfall" And umbrellaOn = True Then
                        ListA.Items.Insert(0, "> You are in a cave with 2 paths to choose from.")
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        umbrellaOn = False
                        cave = True
                        waterfall = False
                        dropIt = True
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '............................................................................................CAVE
            If cave = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" Then
                        ListA.Items.Insert(0, "> There is nothing here.")
                    ElseIf TextA.Text = "left" And cpath = 0 Then
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        cpath += 1
                    ElseIf TextA.Text = "right" And cpath = 0 Then
                        ListA.Items.Insert(0, "> You are at the place where you started.")
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        cpath = 0
                    ElseIf TextA.Text = "left" And cpath = 1 Then
                        ListA.Items.Insert(0, "> You are at the place where you started.")
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        cpath = 0
                    ElseIf TextA.Text = "right" And cpath = 1 Then
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        cpath += 1
                    ElseIf TextA.Text = "left" And cpath = 2 Then
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        cpath += 1
                    ElseIf TextA.Text = "right" And cpath = 2 Then
                        ListA.Items.Insert(0, "> You are at the place where you started.")
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        cpath = 0
                    ElseIf TextA.Text = "exit cave" And cpath = 0 And pUpEngine = True Then
                        ListA.Items.Insert(0, "> The water is too hot to pass through.")
                        ListA.Items.Insert(0, "> The engine will get damaged.")
                    ElseIf TextA.Text = "exit cave" And cpath = 0 And umbrellaOn = False Then
                        ListA.Items.Insert(0, "> The water is too hot to pass through.")
                    ElseIf TextA.Text = "exit cave" And cpath = 0 And umbrellaOn = True Then
                        ListA.Items.Insert(0, "> You are at the waterfall.")
                        umbrellaOn = False
                        cave = False
                        waterfall = True
                        dropIt = True
                    ElseIf TextA.Text = "exit cave" And cpath = 1 Then
                        ListA.Items.Insert(0, "> There is no exit here.")
                    ElseIf TextA.Text = "exit cave" And cpath = 2 Then
                        ListA.Items.Insert(0, "> There is no exit here.")
                    ElseIf TextA.Text = "exit cave" And cpath = 3 Then
                        ListA.Items.Insert(0, "> There is no exit here.")
                    ElseIf cpath = 3 And ogre = True And oneT = False Then
                        ListA.Items.Insert(0, "> There is an Ogre here.")
                        ListA.Items.Insert(0, "> Ogre: RROOAARR!!!")
                        ListA.Items.Insert(0, "> The door to the Ogre's lair is here.")
                        oneT = True
                    ElseIf TextA.Text = "go in lair" And ogre = False And cpath = 3 Then
                        ListA.Items.Insert(0, "> There are 2 paths to choose from for the exit.")
                        ListA.Items.Insert(0, "> The helicopter engine is here!")
                        lair = True
                        cave = False
                        dropIt = True
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '.............................................................................................LAIR
            If lair = True Then
                dropItems()
                If dropIt = False Then
                    If extConfirm = False Then
                        If TextA.Text = "search" And sLair = False Then
                            ListA.Items.Insert(0, "> There are 2 paths to choose from for the exit.")
                            ListA.Items.Insert(0, "> The helicopter engine is here!")
                            sLair = True
                        ElseIf TextA.Text = "search" And sLair = True Then
                            ListA.Items.Insert(0, "> You already searched here.")
                        ElseIf TextA.Text = "pick up engine" And pUpEngine = True Then
                            ListA.Items.Insert(0, "> There is no engine here.")
                        ElseIf TextA.Text = "pick up engine" And engine = True Then
                            ListA.Items.Insert(0, "> You already picked up the engine.")
                        ElseIf TextA.Text = "pick up engine" And engine = False And potionActv = False Then
                            ListA.Items.Insert(0, "> The engine is too heavy to carry.")
                        ElseIf TextA.Text = "pick up engine" And engine = False And potionActv = True Then
                            ListA.Items.Insert(0, "> You are carrying the engine.")
                            pUpEngine = True
                        ElseIf TextA.Text = "exit lair" Then
                            ListA.Items.Insert(0, "> Which path do you want to go through, right or left?.")
                            extConfirm = True
                            dropIt = True
                        Else
                            ListA.Items.Insert(0, "> Try again.")
                        End If
                    End If
                    If extConfirm = True Then
                        If TextA.Text = "right" Then
                            If sDoorC = True Then
                                ListA.Items.Insert(0, "> There is a door here.")
                            End If
                            If sDoorC = False Then
                                ListA.Items.Insert(0, "> There is a door here but seems to be locked.")
                            End If
                            underHouse = True
                            lair = False
                            extConfirm = False
                            dropIt = True
                        ElseIf TextA.Text = "left" Then
                            ListA.Items.Insert(0, "> You are in the cave entrance.")
                            cave = True
                            lair = False
                            extConfirm = False
                            dropIt = True
                            cpath = 0
                        Else
                            ListA.Items.Insert(0, "> Choose a path.")
                        End If
                    End If
                End If
            End If
            '...............................................................................UNDER HOUSE
            If underHouse = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And sDoorC = False Then
                        ListA.Items.Insert(0, "> There is a door here but seems to be locked.")
                        ListA.Items.Insert(0, "> There is also a path to the Ogre's lair.")
                    ElseIf TextA.Text = "search" And sDoorC = True Then
                        ListA.Items.Insert(0, "> There is also a path to the Ogre's lair.")
                        ListA.Items.Insert(0, "> There is a door here.")
                    ElseIf TextA.Text = "go through door" And sDoorC = False Then
                        ListA.Items.Insert(0, "> The door is locked.")
                    ElseIf TextA.Text = "unlock door" And sDoorC = False Then
                        ListA.Items.Insert(0, "> You unlocked the door.")
                        sDoorC = True
                    ElseIf TextA.Text = "go through door" And sDoorC = True And sDoorK = False Then
                        ListA.Items.Insert(0, "> The door seems to be locked from the other side.")
                    ElseIf TextA.Text = "go through door" And sDoorC = True And sDoorK = True Then
                        ListA.Items.Insert(0, "> You are in the kitchen.")
                        underHouse = False
                        kitchen = True
                    ElseIf TextA.Text = "go to lair" Then
                        lair = True
                        underHouse = False
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '...............................................................................HELICOPTER
            If helicopter = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "search" And pUpEngine = True And key = True Then
                        ListA.Items.Insert(0, "> There is a broken helicopter here.")
                        ListA.Items.Insert(0, "> It seems you have picked up all of the missing parts.")
                    ElseIf TextA.Text = "search" And pUpEngine = True And key = False Then
                        ListA.Items.Insert(0, "> There is a broken helicopter here.")
                        ListA.Items.Insert(0, "> You currently have the engine, but it is missing the key to start it.")
                    ElseIf TextA.Text = "search" And pUpEngine = False And key = True Then
                        ListA.Items.Insert(0, "> There is a broken helicopter here.")
                        ListA.Items.Insert(0, "> You currently have the key to start it, but you are missing the engine.")
                    ElseIf TextA.Text = "search" And pUpEngine = False And key = False Then
                        ListA.Items.Insert(0, "> There is a helicopter here.")
                        ListA.Items.Insert(0, "> The engine and the key to start it are missing.")
                    ElseIf TextA.Text = "put in the engine" And pUpEngine = False Then
                        ListA.Items.Insert(0, "> You don't have an engine.")
                    ElseIf TextA.Text = "put in the engine" And pUpEngine = True Then
                        ListA.Items.Insert(0, "> You installed the engine.")
                        pUpEngine = False
                        engineInstalled = True
                    ElseIf TextA.Text = "put in the key" And key = False Then
                        ListA.Items.Insert(0, "> You don't have a key.")
                    ElseIf TextA.Text = "put in the key" And key = True Then
                        ListA.Items.Insert(0, "> You put the key in, now get out of here.")
                        keyInst = True
                    ElseIf TextA.Text = "start the helicopter" And keyInst = False And engineInstalled = False Then
                        ListA.Items.Insert(0, "> You are missing some parts.")
                    ElseIf TextA.Text = "start the helicopter" And keyInst = True And engineInstalled = False Then
                        ListA.Items.Insert(0, "> You are missing some parts.")
                    ElseIf TextA.Text = "start the helicopter" And keyInst = False And engineInstalled = True Then
                        ListA.Items.Insert(0, "> You are missing some parts.")
                    ElseIf TextA.Text = "start the helicopter" And keyInst = True And engineInstalled = True Then
                        ListA.Items.Insert(0, "> The trees are in the way, do you want to move left or right?.")
                        helicopter = False
                        leaving = True
                        dropIt = True
                    ElseIf TextA.Text = "go north" Then
                        ListA.Items.Insert(0, "> You are at the front of the house.")
                        house = True
                        helicopter = False
                        dropIt = True
                    ElseIf TextA.Text = "go south" Then
                        ListA.Items.Insert(0, "> You are at the waterfall.")
                        waterfall = True
                        helicopter = False
                        dropIt = True
                    ElseIf TextA.Text = "go east" Then
                        ListA.Items.Insert(0, "> You are at the forest.")
                        forest = True
                        helicopter = False
                        dropIt = True
                    ElseIf TextA.Text = "go west" Then
                        ListA.Items.Insert(0, "> You are at the river.")
                        river = True
                        helicopter = False
                        dropIt = True
                    Else
                        ListA.Items.Insert(0, "> Try again.")
                    End If
                End If
            End If
            '...............................................................................LEAVING
            If leaving = True Then
                dropItems()
                If dropIt = False Then
                    If TextA.Text = "left" And escPath = 0 Then
                        ListA.Items.Insert(0, "> You almost hit a tree, that was close.")
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        mistake += 1
                    ElseIf TextA.Text = "right" And escPath = 0 Then
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        escPath += 1

                    ElseIf TextA.Text = "left" And escPath = 1 And mistake = 0 Then
                        ListA.Items.Insert(0, "> You almost hit a tree, that was close.")
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        mistake += 1
                    ElseIf TextA.Text = "left" And escPath = 1 And mistake = 1 Then
                        mistake += 1
                    ElseIf TextA.Text = "right" And escPath = 1 Then
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        escPath += 1
                    ElseIf TextA.Text = "left" And escPath = 2 And mistake = 0 Then
                        ListA.Items.Insert(0, "> You almost hit a tree, that was close.")
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        mistake += 1
                    ElseIf TextA.Text = "left" And escPath = 2 And mistake = 1 Then
                        mistake += 1
                    ElseIf TextA.Text = "right" And escPath = 2 Then
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                        escPath += 1
                    Else
                        ListA.Items.Insert(0, "> Do you want to go left or right?.")
                    End If
                    If escPath = 3 Then
                        'WIN THE GAME
                        escape = True
                        Me.Hide()
                        Form3.Show()
                    ElseIf mistake = 2 Then
                        'GAMEOVER 
                        playerDead = True
                        Me.Hide()
                        Form3.Show()
                    End If
                End If
            End If
            If TextA.Text = "i give up" Then
                giveUp = True
                Me.Hide()
                Form3.Show()
            End If
            TextA.Text = ""
        End If
        If e.Control = True And e.KeyCode = Keys.P Then
            MsgBox(cpath)
        End If
        If e.Control = True And e.KeyCode = Keys.L Then
            MsgBox(invCount)
        End If
        If e.Control = True And e.KeyCode = Keys.C Then
            MsgBox("Commands:" & vbNewLine & "search" & vbNewLine & "unlock door" & vbNewLine & "move (object)" & vbNewLine & "go through (thing)" & vbNewLine & "exit (place)" & vbNewLine & "go north; go south; go east; go west" & vbNewLine & "pick up (item)" & vbNewLine & "craft (item)" & vbNewLine & "go in (place)" & vbNewLine & "inventory" & vbNewLine & "drop (item)" & vbNewLine & "use (item)" & vbNewLine & "swing knife")
        End If
        If intro = False Then
            If e.Control = True And e.KeyCode = Keys.M Then
                Form2.Show()
            End If
        End If
        dropIt = False
    End Sub
    Private Sub dropItems()
        If confirm = True Then
            If TextA.Text = "yes" Then
                'ACTIVATE TIMER FOR COUNTDOWN
                Label4.Visible = True
                GroupBox2.Visible = True
                minutes1.Visible = True
                seconds1.Visible = True
                Label3.Visible = True
                Timer1.Start()
                ListA.Items.Insert(0, "> You drank the potion.")
                potion = False
                inventory.Remove("potion")
                invCount -= 1
                potionActv = True
                dropIt = True
                confirm = False
            ElseIf confirm = True And TextA.Text = "no" Then
                'DONT ACT
                ListA.Items.Insert(0, "> You saved it for later.")
                dropIt = True
                confirm = False
            Else
                ListA.Items.Insert(0, "> Do you want to use the potion?")
                dropIt = True
            End If
        End If
        If confirm = False Then
            If TextA.Text = "drop" Then
                ListA.Items.Insert(0, "> Drop what.")
                dropIt = True
            ElseIf TextA.Text = "drop wood" And wood = True Then
                ListA.Items.Insert(0, "> Your dropped wood, you can't get it back.")
                wood = False
                inventory.Remove("wood")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop knife" And knife = True Then
                ListA.Items.Insert(0, "> Your dropped your knife, you can't get it back.")
                knife = False
                inventory.Remove("knife")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop lighter" And lighter = True Then
                ListA.Items.Insert(0, "> Your dropped your lighter, you can't get it back.")
                lighter = False
                inventory.Remove("lighter")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop string" And fString = True Then
                ListA.Items.Insert(0, "> Your dropped your string, you can't get it back.")
                fString = False
                inventory.Remove("string")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop fishing rod" And fishingRod = True Then
                ListA.Items.Insert(0, "> Your dropped your fishing rod, you can't get it back.")
                fishingRod = False
                inventory.Remove("fishing rod")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop key" And key = True Then
                ListA.Items.Insert(0, "> Your dropped key, you can't get it back.")
                key = False
                inventory.Remove("key")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop fish" And fish = True Then
                ListA.Items.Insert(0, "> Your dropped fish, you can't get it back.")
                fish = False
                inventory.Remove("fish")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop fishing stick" And fishingStick = True Then
                ListA.Items.Insert(0, "> Your dropped your fishing stick, you can't get it back.")
                fishingStick = False
                inventory.Remove("fishing stick")
                invCount -= 1
                dropIt = True
            ElseIf TextA.Text = "drop potion" And potion = True Then
                ListA.Items.Insert(0, "> You dropped the potion.")
                potion = False
                inventory.Remove("potion")
                invCount -= 1
                dropIt = True
                'ENGINE
            ElseIf TextA.Text = "drop potion" And pUpEngine = True Then
                ListA.Items.Insert(0, "> You dropped the engine.")
                pUpEngine = False
                dropIt = True
            ElseIf TextA.Text = "inventory" Then
                ListA.Items.Insert(0, "/\ Inventory /\")
                For i = 0 To inventory.Count - 1
                    ListA.Items.Insert(0, inventory(i))
                Next
                ListA.Items.Insert(0, "\/ Inventory \/")
                dropIt = True
            ElseIf TextA.Text = "craft fishing rod" And fString = True And fishingStick = True Then
                If invCount <= 5 Then
                    ListA.Items.Insert(0, "> You crafted a fishing rod.")
                    fishingRod = True
                    fishingStick = False
                    fString = False
                    invCount -= 1
                    inventory.Remove("fishing stick")
                    inventory.Remove("string")
                    inventory.Add("fishing rod")
                    dropIt = True
                ElseIf invCount > 5 Then
                    ListA.Items.Insert(0, "> Your inventory is full.")
                    dropIt = True
                End If
            ElseIf TextA.Text = "craft fishing rod" And fString = False And fishingStick = True Then
                ListA.Items.Insert(0, "> You need some string.")
                dropIt = True
            ElseIf TextA.Text = "craft fishing rod" And fString = True And fishingStick = False Then
                ListA.Items.Insert(0, "> You need a fishing stick.")
                dropIt = True
            ElseIf TextA.Text = "craft fishing rod" And fString = False And fishingStick = False Then
                ListA.Items.Insert(0, "> You don't have any items to make one.")
                dropIt = True
            ElseIf TextA.Text = "craft" Then
                ListA.Items.Insert(0, "> Craft what.")
                dropIt = True
                'USE
            ElseIf TextA.Text = "use" Then
                ListA.Items.Insert(0, "> Use what.")
                dropIt = True
                'UMBRELLA
            ElseIf TextA.Text = "use umbrella" And umbrella = True And umbrellaOn = False And cave = True And cpath = 0 And pUpEngine = True Then
                ListA.Items.Insert(0, "> You can only carry one thing at a time.")
                ListA.Items.Insert(0, "> Decide, the engine or the umbrella.")
            ElseIf TextA.Text = "use umbrella" And umbrella = True And umbrellaOn = False And waterfall = True Then
                ListA.Items.Insert(0, "> You opened the umbrella.")
                umbrellaOn = True
                dropIt = True
            ElseIf TextA.Text = "use umbrella" And umbrella = True And umbrellaOn = True And waterfall = True Then
                ListA.Items.Insert(0, "> You have the umbrella opened.")
                dropIt = True
            ElseIf TextA.Text = "use umbrella" And umbrella = True And umbrellaOn = False And cave = True Then
                ListA.Items.Insert(0, "> You opened the umbrella.")
                umbrellaOn = True
                dropIt = True
            ElseIf TextA.Text = "use umbrella" And umbrella = True And umbrellaOn = True And cave = True Then
                ListA.Items.Insert(0, "> You have the umbrella opened.")
                dropIt = True
            ElseIf TextA.Text = "use umbrella" And umbrella = True Then
                ListA.Items.Insert(0, "> That won't help.")
                dropIt = True
            ElseIf TextA.Text = "use umbrella" And umbrella = False Then
                ListA.Items.Insert(0, "> You don't have an umbrella.")
                dropIt = True
                'LIGHTER
            ElseIf TextA.Text = "use lighter" And lighter = True And golemAlive = True And hole = True Then
                ListA.Items.Insert(0, "> Golem: NNNNNNOOOO, i'm affraid of fire.")
                ListA.Items.Insert(0, "> He left, now is your chance to get that potion.")
                golemAlive = False
                dropIt = True
            ElseIf TextA.Text = "use lighter" And lighter = True Then
                ListA.Items.Insert(0, "> That won't help.")
                dropIt = True
            ElseIf TextA.Text = "use lighter" And lighter = False Then
                ListA.Items.Insert(0, "> You don't have a lighter.")
                dropIt = True
                'KNIFE
            ElseIf TextA.Text = "swing knife" And knife = True And golemAlive = True And hole = True Then
                ListA.Items.Insert(0, "> Golem is too fast.")
                dropIt = True
            ElseIf TextA.Text = "swing knife" And knife = True And ogre = True And cpath = 3 Then
                hit = rnum.Next(1, 4)
                If hit = 1 Or hit = 3 Then
                    ListA.Items.Insert(0, "")
                    ListA.Items.Insert(0, "> You missed.")
                ElseIf hit = 2 Then
                    ogreHP -= 1
                    If ogreHP > 0 Then
                        ListA.Items.Insert(0, "")
                        ListA.Items.Insert(0, "> You got him.")
                    End If
                End If
                hit = rnum.Next(1, 4)
                If hit = 1 Or hit = 3 Then
                    ListA.Items.Insert(0, "")
                    ListA.Items.Insert(0, "> Orge: I missed.")
                ElseIf hit = 2 Then
                    plHP -= 1
                    If plHP > 0 Then
                        ListA.Items.Insert(0, "")
                        ListA.Items.Insert(0, "> Ogre: I got you.")
                    End If
                End If
                If ogreHP = 0 Then
                    ListA.Items.Insert(0, "")
                    ListA.Items.Insert(0, "> Ogre: NNNOOO!!!.")
                    ListA.Items.Insert(0, "> You beat him, there is the door to his lair.")
                    ogre = False
                End If
                If plHP = 0 Then
                    ListA.Items.Insert(0, "")
                    ListA.Items.Insert(0, "> Ogre: I win.")
                    ListA.Items.Insert(0, "> GAME OVER, you were killed by the ogre.")
                    'GAME OVER = TRUE AND DIPLAY A LABEL WITH GAME OVER
                    ogreWins = True
                    Me.Hide()
                    Form3.Show()
                End If
                dropIt = True
            ElseIf TextA.Text = "swing knife" And knife = True Then
                ListA.Items.Insert(0, "> Great, you cut air.")
                dropIt = True
            ElseIf TextA.Text = "swing knife" And knife = False Then
                ListA.Items.Insert(0, "> You don't have a knife.")
                dropIt = True
                'FISH
            ElseIf TextA.Text = "use fish" And fish = True And golemAlive = True And hole = True Then
                ListA.Items.Insert(0, "> Golem: FFFIIISSSHH")
                ListA.Items.Insert(0, "> He left, now is your chance to get that potion.")
                golemAlive = False
                fish = False
                invCount -= 1
                inventory.Remove("fish")
                dropIt = True
            ElseIf TextA.Text = "use fish" And fish = True Then
                ListA.Items.Insert(0, "> That won't help.")
                dropIt = True
            ElseIf TextA.Text = "use fish" And fish = False Then
                ListA.Items.Insert(0, "> You don't have any fish.")
                dropIt = True
                'STRING
            ElseIf TextA.Text = "use string" And fString = True Then
                ListA.Items.Insert(0, "> That won't help.")
                dropIt = True
            ElseIf TextA.Text = "use string" And fString = False Then
                ListA.Items.Insert(0, "> You don't have any string.")
                dropIt = True
                'FISHING ROD
            ElseIf TextA.Text = "use fishing rod" And fishingRod = True And river = True Then
                gotFish = rnum.Next(1, 12)
                If gotFish = 1 Or gotFish = 2 Or gotFish = 3 Or gotFish = 4 Or gotFish = 5 Then
                    ListA.Items.Insert(0, "> You didn't catch anything.")
                    'FIX THIS ORDER SO YOU SEE IF HE HAS FISH FIRST
                ElseIf gotFish = 7 Or gotFish = 8 Or gotFish = 9 Or gotFish = 10 Or gotFish = 11 Then
                    If fish = True Then
                        ListA.Items.Insert(0, "> You already have a fish.")
                    ElseIf invCount < 5 Then
                        invCount += 1
                        fish = True
                        inventory.Add("fish")
                        ListA.Items.Insert(0, "> You caught a fish.")
                    ElseIf invCount >= 5 Then
                        ListA.Items.Insert(0, "> Your inventory is full.")
                        'FIX THIS ORDER SO YOU SEE IF HE HAS FISH FIRST
                    End If
                ElseIf gotFish = 6 And invCount < 5 And key = False Then
                    invCount += 1
                    key = True
                    inventory.Add("key")
                    ListA.Items.Insert(0, "> Wow, you found the key to helicopter!")
                ElseIf gotFish = 6 And key = True Then
                    ListA.Items.Insert(0, "> You didn't catch anything.")
                ElseIf gotFish = 6 And invCount >= 5 Then
                    ListA.Items.Insert(0, "> You didn't catch anything.")
                End If
                dropIt = True
            ElseIf TextA.Text = "use fishing rod" And fishingRod = True Then
                ListA.Items.Insert(0, "> That won't help.")
                dropIt = True
            ElseIf TextA.Text = "use fishing rod" And fishingRod = False Then
                ListA.Items.Insert(0, "> You don't have a fishing rod.")
                dropIt = True
                'FISHING STICK
            ElseIf TextA.Text = "use fishing stick" And fishingStick = True Then
                ListA.Items.Insert(0, "> That won't help.")
                dropIt = True
            ElseIf TextA.Text = "use fishing stick" And fishingStick = False Then
                ListA.Items.Insert(0, "> You don't have a fishing stick.")
                dropIt = True
                'WOOD
            ElseIf TextA.Text = "use wood" And wood = True Then
                ListA.Items.Insert(0, "> That won't help, actually it won't help at all.")
                dropIt = True
            ElseIf TextA.Text = "use wood" And wood = False Then
                ListA.Items.Insert(0, "> You don't have wood.")
                dropIt = True
                'KEY
            ElseIf TextA.Text = "use key" And key = True Then
                ListA.Items.Insert(0, "> That won't help.")
                dropIt = True
            ElseIf TextA.Text = "use key" And key = False Then
                ListA.Items.Insert(0, "> You don't have a key.")
                dropIt = True
                'POTION
            ElseIf TextA.Text = "use potion" And potion = True Then
                ListA.Items.Insert(0, "> The potion only last for 3 minutes, are you sure you want to use it now?")
                dropIt = True
                confirm = True
            ElseIf TextA.Text = "use potion" And potion = False Then
                ListA.Items.Insert(0, "> You don't have a potion.")
                dropIt = True
                'PICK UP
            ElseIf TextA.Text = "pick up" Then
                ListA.Items.Insert(0, "> Pick up what.")
                dropIt = True
                'MOVE
            ElseIf TextA.Text = "move" Then
                ListA.Items.Insert(0, "> Move what.")
                dropIt = True
            ElseIf TextA.Text = "go" Then
                ListA.Items.Insert(0, "> Go where.")
                dropIt = True
                'PUT IN ENGINE
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If seconds.Text = 0 And minutes.Text = 0 Then
            challenge = False
            timerDone = True
            Me.Hide()
            Form3.Show()
        End If
        If onetime = False Then
            If seconds1.Text = 0 And minutes1.Text = 0 Then
                ListA.Items.Insert(0, "> The potion is not active anymore.")
                Label4.Visible = False
                GroupBox2.Visible = False
                minutes1.Visible = False
                seconds1.Visible = False
                potionActv = False
                onetime = True
                If pUpEngine = True Then
                    ListA.Items.Insert(0, "> You dropped the engine.")
                    pUpEngine = False
                End If
            End If
        End If

        If challenge = True Then
            seconds.Text -= 1
            If seconds.Text < 0 Then
                minutes.Text -= 1
                seconds.Text = 59
            End If
        End If

        If potionActv = True Then
            seconds1.Text -= 1
            If seconds1.Text < 0 Then
                minutes1.Text -= 1
                seconds1.Text = 59
            End If
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ListA.Size = Me.Size
        TextA.Width = ListA.Width
        TextA.Anchor = AnchorStyles.Bottom
        GroupBox1.Anchor = AnchorStyles.Right
        GroupBox2.Anchor = AnchorStyles.Right
        TextA.Left = ListA.Left
        Button1.Top = Me.Height / 2 - Button1.Height / 2
        Button1.Left = Me.Width / 2 - Button1.Width / 2
    End Sub
End Class
'     If TextBox1.Text = "hello" And count = 0 Then
'        ListBox1.Items.Insert(0, "Computer: Hello")
'        count += 1
'    ElseIf TextBox1.Text = "goodbye" And count = 1 Then
'        ListBox1.Items.Insert(0, "Computer: Goodbye")
'    End If
'    TextBox1.Text = ""
'End If