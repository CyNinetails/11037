Imports System.IO

Class _11038Player
    Public name As String
    Public HP, MP, str, luk, int, agi, def, classtype As Integer
    Public afflic, bloc, itemchoice As Integer
End Class

Class _11038SaveData
    Public saveversion As Integer
    Public savename As String
    Public s1name, s2name As String
    Public s1(8) As Integer
    Public s2(8) As Integer
End Class

Module _11038IO

    Function convertGameToSaveData(ByVal p1 As _11038Player, ByVal p2 As _11038Player)

        Dim save As New _11038SaveData

        save.savename = "11038"
        save.saveversion = 1

        save.s1(0) = p1.HP
        save.s1(1) = p1.MP
        save.s1(2) = p1.str
        save.s1(3) = p1.luk
        save.s1(4) = p1.int
        save.s1(5) = p1.agi
        save.s1(6) = p1.def
        save.s1(7) = p1.classtype

        save.s2(0) = p2.HP
        save.s2(1) = p2.MP
        save.s2(2) = p2.str
        save.s2(3) = p2.luk
        save.s2(4) = p2.int
        save.s2(5) = p2.agi
        save.s2(6) = p2.def
        save.s2(7) = p2.classtype

        save.s1name = p1.name
        save.s2name = p2.name

        Return save

    End Function
    Sub convertSaveDataToGame(ByVal saveobj As _11038SaveData, ByVal p1 As _11038Player, ByVal p2 As _11038Player)

        If saveobj.saveversion = 1 Then
            p1.HP = saveobj.s1(0)
            p1.MP = saveobj.s1(1)
            p1.str = saveobj.s1(2)
            p1.luk = saveobj.s1(3)
            p1.int = saveobj.s1(4)
            p1.agi = saveobj.s1(5)
            p1.def = saveobj.s1(6)
            p1.classtype = saveobj.s1(7)
            
            p1.name = saveobj.s1name
            p2.name = saveobj.s2name

            p2.HP = saveobj.s2(0)
            p2.MP = saveobj.s2(1)
            p2.str = saveobj.s2(2)
            p2.luk = saveobj.s2(3)
            p2.int = saveobj.s2(4)
            p2.agi = saveobj.s2(5)
            p2.def = saveobj.s2(6)
            p2.classtype = saveobj.s2(7)
            Console.WriteLine("Save loaded...")
            Console.Read()
        Else
            Console.WriteLine("This save is from a more recent version of the game.")
            Console.Read()
        End If

    End Sub

    Sub writeSaveData(ByVal obj As _11038SaveData, ByVal name As String)
        Dim f As StreamWriter = New StreamWriter(name + ".11038")
        f.WriteLine(obj.savename)
        f.WriteLine(obj.saveversion)
        f.WriteLine(obj.s1name)
        f.WriteLine(obj.s2name)

        f.WriteLine(obj.s1(0)) 'HP
        f.WriteLine(obj.s1(1)) ' MP
        f.WriteLine(obj.s1(2)) ' strength
        f.WriteLine(obj.s1(3)) ' luck
        f.WriteLine(obj.s1(4)) ' intel.
        f.WriteLine(obj.s1(5)) ' agi.
        f.WriteLine(obj.s1(6)) ' def.
        f.WriteLine(obj.s1(7)) ' class type

        f.WriteLine(obj.s2(0)) 'HP
        f.WriteLine(obj.s2(1)) ' MP
        f.WriteLine(obj.s2(2)) ' strength
        f.WriteLine(obj.s2(3)) ' luck
        f.WriteLine(obj.s2(4)) ' intel.
        f.WriteLine(obj.s2(5)) ' agi.
        f.WriteLine(obj.s2(6)) ' def.
        f.WriteLine(obj.s2(7)) ' class type

        f.Close()
    End Sub

    Function loadSaveData(ByVal name As String)
        Dim obj As New _11038SaveData
        If File.Exists(name + ".11038") Then
            Dim f As StreamReader = New StreamReader(name + ".11038")
            Dim t(20) As String
            Dim i As Integer
            Do While f.Peek() <> -1
                t(i) = f.ReadLine()
                i += 1
            Loop

            obj.savename = t(0)
            obj.saveversion = t(1)
            obj.s1name = t(2)
            obj.s2name = t(3)

            obj.s1(0) = t(4)
            obj.s1(1) = t(5)
            obj.s1(2) = t(6)
            obj.s1(3) = t(7)
            obj.s1(4) = t(8)
            obj.s1(5) = t(9)
            obj.s1(6) = t(10)
            obj.s1(7) = t(11)

            obj.s2(0) = t(12)
            obj.s2(1) = t(13)
            obj.s2(2) = t(14)
            obj.s2(3) = t(15)
            obj.s2(4) = t(16)
            obj.s2(5) = t(17)
            obj.s2(6) = t(18)
            obj.s2(7) = t(19)

            Return obj
        Else
            Console.WriteLine("Error: file not found")
        End If

    End Function

End Module

Module _11038Program
    Dim mainmenu As String
    Dim illi As Integer
    Dim sklsel As Integer
    Dim def1 As Integer
    Dim def2 As Integer
    Dim sklsel2 As Integer
    Dim progfrg1, progfrg2 As Integer
    Dim p1 As New _11038Player
    Dim p2 As New _11038Player

    
    Function returnPlayerObjectData(ByVal obj As _11038Player)
        Return {obj.HP, obj.MP, obj.str, obj.luk, obj.int, obj.agi, obj.def, obj.classtype}
    End Function

    Sub Main()
        Console.WriteLine("11038")
        Console.WriteLine("Please select option.")
        Console.WriteLine("1: New Game")
        Console.WriteLine("2: Load Game")
        Console.WriteLine("3: Information Index")
        mainmenu = Console.ReadLine()
        Select Case mainmenu
            Case 1
                newCharacter(1, p1)
                newCharacter(2, p2)
                Console.Clear()
                Call play1()
            Case 2
                Console.WriteLine("Enter save game name: ")
                Dim t As New _11038SaveData
                Dim a As String = Console.ReadLine()
                If File.Exists(a + ".11038") Then
                    t = loadSaveData(a)
                    convertSaveDataToGame(t, p1, p2)
                    Console.Clear()
                    Call play1()
                Else
                    Console.WriteLine("Error: file not found")
                    Console.Read()
                    Console.Clear()
                    Main()
                End If
            Case 3
                Console.Clear()
                Call extra()
            Case Else
                Console.Clear()
                Main()
        End Select


    End Sub

    Sub assignCharacterInformation(ByVal obj As _11038Player, ByVal a() As Integer)
        obj.HP = a(0)
        obj.MP = a(1)
        obj.str = a(2)
        obj.luk = a(3)
        obj.int = a(4)
        obj.def = a(5)
    End Sub

    Sub displayCharacterInformation(ByVal obj As _11038Player)
        Console.WriteLine("Name: " + obj.name)
        Console.WriteLine("Health: " + CStr(obj.HP))
        Console.WriteLine("Mana: " + CStr(obj.MP))
        Console.WriteLine("Strength: " + CStr(obj.str))
        Console.WriteLine("Luck: " + CStr(obj.luk))
        Console.WriteLine("Intelligence: " + CStr(obj.int))
        Console.WriteLine("Agility: " + CStr(obj.agi))
        Console.WriteLine("Defence: " + CStr(obj.def))
    End Sub

    Function randomNumber(ByVal bound As Integer)
        Randomize()
        Return Int(Rnd() * bound + 1)
    End Function

    Sub newCharacter(ByVal no As Integer, ByVal obj As _11038Player)
        Console.WriteLine("player " + no.ToString + ", please enter your character name.")
        obj.name = Console.ReadLine()
        Do
            Console.Clear()
            assignCharacterInformation(p1, {
                                                randomNumber(100),
                                                randomNumber(100),
                                                randomNumber(30),
                                                randomNumber(30),
                                                randomNumber(30),
                                                randomNumber(20)
                                            })
            displayCharacterInformation(p1)
            Console.WriteLine("Re-roll stats? (type 'yes' to reroll)")
            If Console.ReadLine() = "yes" Then
                Console.WriteLine("Re-rolling stats")
                Console.Clear()
            Else
                Console.Clear()
                Exit Do
            End If
        Loop
        Do
            Dim clamen2 As String
            Console.WriteLine("player " + no.ToString + ", please select class:")
            Console.WriteLine("1. Warrior")
            Console.WriteLine("2. Mage")
            Console.WriteLine("3. Thief")
            Console.WriteLine("4. Priest")
            Console.WriteLine("5. Ranger")
            Console.WriteLine("6. Summoner")
            Console.WriteLine("7. Dark knight")
            Console.WriteLine("8. Hacker Artist")
            clamen2 = Console.ReadLine()
            Select Case clamen2
                Case 1
                    obj.classtype = 1
                    obj.str = (obj.str + 5)
                    obj.def = (obj.def + 5)
                    Exit Do
                Case 2
                    obj.classtype = 2
                    obj.str = Int(obj.str - 5)
                    obj.MP = (obj.MP + 10)
                    obj.int = (obj.int + 5)
                    Exit Do
                Case 3
                    obj.classtype = 3
                    obj.HP = Int(obj.HP - 10)
                    obj.str = (obj.str + 2)
                    obj.luk = (obj.luk + 2)
                    obj.agi = (obj.agi + 3)
                    Exit Do
                Case 4
                    obj.classtype = 4
                    obj.HP = (obj.HP + 10)
                    obj.str = Int(obj.str - 5)
                    Exit Do
                Case 5
                    obj.classtype = 5
                    obj.agi = (obj.agi + 5)
                    Exit Do
                Case 6
                    obj.classtype = 6
                    obj.str = Int(obj.str - 10)
                    obj.MP = (obj.MP + 20)
                    obj.int = (obj.int + 2)
                    Exit Do
                Case 7
                    obj.classtype = 7
                    obj.HP = (obj.HP + 30)
                    obj.str = (obj.str + 2)
                    Exit Do
                Case 8
                    obj.classtype = 9
                    progfrg2 = 10
                    Exit Do
                Case 9
                    Console.WriteLine("You entered an illegal command. Please execute numerical proof of execution:")
                    illi = Console.ReadLine()
                    If illi = 11037 Then
                        Console.WriteLine("Thank you. Let's give it all we've got! Its Punishment time!")
                        Console.ReadLine()
                        obj.classtype = 9
                        obj.HP = (obj.HP + 20)
                        obj.agi = (obj.agi + 2)
                        obj.str = (obj.str + 2)
                        obj.def = (obj.def + 2)
                        obj.int = (obj.int + 2)
                        obj.luk = (obj.luk + 2)
                        obj.MP = (obj.MP + 2)
                    Else
                        Console.WriteLine("UD ID failed. Resetting...")
                        Console.ReadLine()
                        Console.Clear()
                    End If
                Case Else
                    Console.Clear()
            End Select
        Loop
        Console.Clear()
    End Sub
    Sub pre1()
        Dim bleedam As Integer
        Dim bleecount As Integer
        Dim paracount As Integer
        Dim parachance As Integer
        Dim confcount As Integer
        Dim confact As Integer
        Dim confdam As Integer
        Dim poidam As Integer
        Dim poicount As Integer
        Dim doomcount As Integer
        Dim creepdoom As Integer
        Dim burcount As Integer
        Dim burdam As Integer
        Dim drencount As Integer
        Dim drendra As Integer
        Dim Timcount As Integer
        Dim SLCount As Integer
        Randomize()
        If def1 = 1 Then
            Console.WriteLine(p1.name + " relinquishes thier defence.")
            p1.bloc = p1.def
        End If
        Select Case p1.afflic
            Case 1
                'poison'
                If poicount > 4 Then
                    Console.WriteLine(p1.name + " has treated the poison.")
                    poicount = 0
                    p1.afflic = 0
                ElseIf poicount = 0 Then
                    poidam = Int(Rnd() * 30 + 1)
                    p1.HP = (p1.HP - poidam)
                    Console.WriteLine(p1.name + " has taken " + CStr(poidam) + " points worth of poison damage.")
                    poicount = (poicount + 1)
                Else
                    p1.HP = (p1.HP - poidam)
                    Console.WriteLine(p1.name + " has taken " + CStr(poidam) + " points worth of poison damage.")
                    poicount = (poicount + 1)
                End If
            Case 2
                'bleed'
                If bleecount > 4 Then
                    Console.WriteLine(p1.name + " has stopped bleeding.")
                    bleecount = 0
                    p1.afflic = 0
                ElseIf bleecount = 0 Then
                    bleedam = Int(Rnd() * 20 + 1)
                    p1.HP = (p1.HP - bleedam)
                    Console.WriteLine(p1.name + " has taken " + CStr(bleedam) + " points worth of bleed damage.")
                    bleecount = (bleecount + 1)
                Else
                    p1.HP = (p1.HP - bleedam)
                    Console.WriteLine(p1.name + " has taken " + CStr(bleedam) + " points worth of bleed damage.")
                    bleecount = (bleecount + 1)
                End If
            Case 3
                'paralasys'
                If paracount > 4 Then
                    Console.WriteLine(p1.name + " has regained movement.")
                    paracount = 0
                    p1.afflic = 0
                Else
                    parachance = (Rnd() * 6 + 1)
                    If parachance < 4 Then
                        Console.WriteLine(p1.name + " is unable to act due to paralysis.")
                        Console.ReadLine()
                        Call pre2()
                        paracount = (paracount + 1)
                    Else
                        paracount = (paracount + 1)
                        Call play1()
                    End If
                End If
            Case 5
                'confusion'
                If confcount > 4 Then
                    Console.WriteLine(p1.name + " clears thier head of confusion.")
                    confcount = 0
                    p1.afflic = 0
                Else
                    confact = (Rnd() * 6 + 1)
                    Select Case confact
                        Case 1
                            Console.WriteLine(p1.name + "attacks in confusion!")
                            confdam = Int((Rnd() * (p1.str) + 1) - (Rnd() * p2.bloc + 1))
                            Console.WriteLine(p1.name + " has dealt " + CStr(confdam) + " damage to " + p2.name)
                            p2.HP = (p2.HP - confdam)
                        Case 2
                            Console.WriteLine(p1.name + " casts in confusion!")
                            sklsel = (Rnd() * 5 + 1)
                            Select Case p1.classtype
                                Case 1
                                    Call warskl1()
                                Case 2
                                    Call magskl1()
                                Case 3
                                    Call thfskl1()
                                Case 4
                                    Call pstskl1()
                                Case 5
                                    Call rngskl1()
                                Case 6
                                    Call smnskl1()
                                Case 7
                                    Call dktskl1()
                            End Select
                        Case 3
                            Console.WriteLine(p1.name + " uses a item in confusion!")

                        Case 4
                            Console.WriteLine(p1.name + " defends in confusion!")
                            p1.bloc = (p1.bloc + 5)
                            def1 = 1
                        Case 5
                            Console.WriteLine(p1.name + " is to confused to act!")
                        Case 6
                            Console.WriteLine(p1.name + " attacks themselves in a fit of confusion!")
                            confdam = Int((Rnd() * (p1.str) + 1) - (Rnd() * p1.bloc + 1))
                            Console.WriteLine(p1.name + " has dealt " + CStr(confdam) + " damage to themselves!")
                            p1.HP = (p1.HP - confdam)
                    End Select
                    confcount = (confcount + 1)
                End If
            Case 6
                'doom'
                If doomcount > 4 Then
                    p1.HP = 0
                Else
                    doomcount = (doomcount + 1)
                    creepdoom = (5 - doomcount)
                    Console.WriteLine("The creeping doom approaches! It will get you in " + CStr(creepdoom) + " turns...")
                End If
            Case 7
                'Burned'
                If burcount > 4 Then
                    Console.WriteLine(p1.name + " has been extinguised.")
                    p1.str = (p1.str + 3)
                    burcount = 0
                    p1.afflic = 0
                ElseIf burcount = 0 Then
                    burdam = Int(Rnd() * 20 + 1)
                    p1.HP = (p1.HP - burdam)
                    p1.str = (p1.str - 3)
                    Console.WriteLine(p1.name + " has taken " + CStr(burdam) + " points worth of burn damage.")
                    bleecount = (bleecount + 1)
                Else
                    p1.HP = (p1.HP - burdam)
                    Console.WriteLine(p1.name + " has taken " + CStr(burdam) + " points worth of burn damage.")
                    bleecount = (bleecount + 1)
                End If
            Case 8
                'Drench'
                If drencount > 4 Then
                    Console.WriteLine(p1.name + " has dried.")
                    drencount = 0
                    p1.afflic = 0
                ElseIf drencount = 0 Then
                    drendra = Int(Rnd() * 30 + 1)
                    p1.MP = (p1.MP - drendra)
                    Console.WriteLine(p1.name + " has taken " + CStr(drendra) + " mana points worth of drench damage.")
                    drencount = (drencount + 1)
                Else
                    p1.MP = (p1.MP - drendra)
                    Console.WriteLine(p1.name + " has taken " + CStr(drendra) + " mana points worth of drench damage.")
                    drencount = (drencount + 1)
                End If
            Case 9
                'Time stop'
                If Timcount > 3 Then
                    Console.WriteLine("Time has returned for " + p1.name)
                    p1.afflic = 0
                    Timcount = 0
                Else
                    Console.WriteLine("Time has stopped for " + p1.name)
                    Timcount = (Timcount + 1)
                End If
            Case 10
                'Soul lock'
                If SLCount > 4 Then
                    Console.WriteLine(p1.name + " has broken all the Soul Locks! They are no longer Soul Locked!")
                    SLCount = 0
                    p1.afflic = 0
                ElseIf SLCount < 4 Then
                    Console.WriteLine(p1.name + " has broken a Soul Lock! There are " + CStr((5 - SLCount)) + " Soul Locks left!")
                    SLCount = (SLCount + 1)
                End If
            Case Else
                Call play1()
        End Select
        If p1.HP <= 0 Then
            Call ending()
        End If
        Console.ReadLine()
        Call play1()
    End Sub
    Sub play1()
        Dim dam1 As Integer
        Dim menac1 As String
        Dim blicount As Integer
        Dim blichance As Integer
        Randomize()

        Console.WriteLine("Please select action " + p1.name)
        Console.WriteLine("1. Attack")
        Console.WriteLine("2. Abilities")
        Console.WriteLine("3. Items")
        Console.WriteLine("4. Defend")
        Console.WriteLine("5. See stats")
        Console.WriteLine("6. Save Game")
        menac1 = Console.ReadLine()
        Select Case menac1
            Case 1
                If p1.afflic = 4 Then
                    If blicount > 4 Then
                        Console.WriteLine(p1.name + " recovers from blindness.")
                        blicount = 0
                        dam1 = Int((Rnd() * (p1.str) + 1) - (Rnd() * p2.bloc + 1))
                        Console.WriteLine(p1.name + " has dealt " + CStr(dam1) + " damage to " + p2.name)
                        p2.HP = (p2.HP - dam1)
                    Else
                        blichance = (Rnd() * 6 + 1)
                        If blichance < 4 Then
                            Console.WriteLine(p1.name + " misses due to blindness!")
                            blicount = (blicount + 1)
                        Else
                            dam1 = Int((Rnd() * (p1.str) + 1) - (Rnd() * p2.bloc + 1))
                            Console.WriteLine(p1.name + " has dealt " + CStr(dam1) + " damage to " + p2.name)
                            p2.HP = (p2.HP - dam1)
                            blicount = (blicount + 1)
                        End If
                    End If
                Else
                    dam1 = Int((Rnd() * (p1.str) + 1) - (Rnd() * p2.bloc + 1))
                    Console.WriteLine(p1.name + " has dealt " + CStr(dam1) + " damage to " + p2.name)
                    p2.HP = (p2.HP - dam1)
                End If
                Console.ReadLine()
            Case 2
                Call ab1()
            Case 3
                Console.WriteLine("Please select the item you wish to use.")
                p1.itemchoice = Console.ReadLine()
                Call it1()
            Case 4
                Console.WriteLine(p1.name + " defends.")
                p1.bloc = (p1.bloc + 5)
                def1 = 1
            Case 5
                Console.WriteLine(p1.name + "'s stats:")
                Console.WriteLine("Health: " + CStr(p1.HP))
                Console.WriteLine("Mana: " + CStr(p1.MP))
                Console.WriteLine("Strength: " + CStr(p1.str))
                Console.WriteLine("Luck: " + CStr(p1.luk))
                Console.WriteLine("Intelligence: " + CStr(p1.int))
                Console.WriteLine("Agility: " + CStr(p1.agi))
                Console.WriteLine("Defence: " + CStr(p1.bloc))
                Console.ReadLine()
                Console.Clear()
                Call play1()
            Case 6
                Console.WriteLine("What do you want to call the file?")
                Dim sdata As New _11038SaveData
                Dim n As String = Console.ReadLine()
                sdata = convertGameToSaveData(p1, p2)
                _11038IO.writeSaveData(sdata, n)
                If File.Exists(n + ".11038") Then
                    Console.WriteLine("File written.")
                    Console.ReadLine()
                Else
                    Console.WriteLine("Error: File not found, even though it should have been written.")
                    Console.ReadLine()
                End If
        End Select

        Console.Clear()
        If p2.HP <= 0 Then
            Call ending()
        End If
        Call pre2()
    End Sub
    Sub pre2()
        Dim bleedam2 As Integer
        Dim bleecount2 As Integer
        Dim paracount2 As Integer
        Dim parachance2 As Integer
        Dim confcount2 As Integer
        Dim confact2 As Integer
        Dim confdam2 As Integer
        Dim poidam2 As Integer
        Dim poicount2 As Integer
        Dim doomcount2 As Integer
        Dim creepdoom2 As Integer
        Dim burcount2 As Integer
        Dim burdam2 As Integer
        Dim drencount2 As Integer
        Dim drendra2 As Integer
        Dim Timcount2 As Integer
        Dim SLcount2 As Integer
        Randomize()
        If def2 = 1 Then
            Console.WriteLine(p2.name + " relinquishes thier defence.")
            p2.bloc = p2.def
        End If
        Select Case p2.afflic
            Case 1
                'poison'
                If poicount2 > 4 Then
                    Console.WriteLine(p2.name + " has treated the poison.")
                    poicount2 = 0
                    p2.afflic = 0
                ElseIf poicount2 = 0 Then
                    poidam2 = Int(Rnd() * 30 + 1)
                    p2.HP = (p2.HP - poidam2)
                    Console.WriteLine(p2.name + " has taken " + CStr(poidam2) + " points worth of poison damage.")
                    poicount2 = (poicount2 + 1)
                Else
                    p2.HP = (p2.HP - poidam2)
                    Console.WriteLine(p2.name + " has taken " + CStr(poidam2) + " points worth of poison damage.")
                    poicount2 = (poicount2 + 1)
                End If
            Case 2
                'bleed'
                If bleecount2 > 4 Then
                    Console.WriteLine(p2.name + " has stopped bleeding.")
                    bleecount2 = 0
                    p2.afflic = 0
                ElseIf bleecount2 = 0 Then
                    bleedam2 = Int(Rnd() * 20 + 1)
                    p1.HP = (p2.HP - bleedam2)
                    Console.WriteLine(p2.name + " has taken " + CStr(bleedam2) + " points worth of bleed damage.")
                    bleecount2 = (bleecount2 + 1)
                Else
                    p2.HP = (p2.HP - bleedam2)
                    Console.WriteLine(p2.name + " has taken " + CStr(bleedam2) + " points worth of bleed damage.")
                    bleecount2 = (bleecount2 + 1)
                End If
            Case 3
                'paralasys'
                If paracount2 > 4 Then
                    Console.WriteLine(p2.name + " has regained movement.")
                    paracount2 = 0
                    p2.afflic = 0
                Else
                    parachance2 = (Rnd() * 6 + 1)
                    If parachance2 < 4 Then
                        Console.WriteLine(p2.name + " is unable to act due to paralysis.")
                        Console.ReadLine()
                        Call pre1()
                        paracount2 = (paracount2 + 1)
                    Else
                        paracount2 = (paracount2 + 1)
                        Call play2()
                    End If
                End If
            Case 5
                'confusion'
                If confcount2 > 4 Then
                    Console.WriteLine(p2.name + " clears thier head of confusion.")
                    confcount2 = 0
                    p1.afflic = 0
                Else
                    confact2 = (Rnd() * 6 + 1)
                    Select Case confact2
                        Case 1
                            Console.WriteLine(p2.name + "attacks in confusion!")
                            confdam2 = Int((Rnd() * (p2.str) + 1) - (Rnd() * p1.bloc + 1))
                            Console.WriteLine(p2.name + " has dealt " + CStr(confdam2) + " damage to " + p1.name)
                            p1.HP = (p1.HP - confdam2)
                        Case 2
                            Console.WriteLine(p2.name + " casts in confusion!")
                            sklsel = (Rnd() * 5 + 1)
                            Select Case p2.classtype
                                Case 1
                                    Call warskl2()
                                Case 2
                                    Call magskl2()
                                Case 3
                                    Call thfskl2()
                                Case 4
                                    Call pstskl2()
                                Case 5
                                    Call rngskl2()
                                Case 6
                                    Call smnskl2()
                                Case 7
                                    Call dktskl2()
                            End Select
                        Case 3
                            Console.WriteLine(p2.name + " uses a item in confusion!")

                        Case 4
                            Console.WriteLine(p2.name + " defends in confusion!")
                            p2.bloc = (p2.bloc + 5)
                            def2 = 1
                        Case 5
                            Console.WriteLine(p2.name + " is to confused to act!")
                        Case 6
                            Console.WriteLine(p2.name + " attacks themselves in a fit of confusion!")
                            confdam2 = Int((Rnd() * (p2.str) + 1) - (Rnd() * p2.bloc + 1))
                            Console.WriteLine(p2.name + " has dealt " + CStr(confdam2) + " damage to themselves!")
                            p2.HP = (p2.HP - confdam2)
                    End Select
                    confcount2 = (confcount2 + 1)
                End If
            Case 6
                'doom'
                If doomcount2 > 4 Then
                    p1.HP = 0
                Else
                    doomcount2 = (doomcount2 + 1)
                    creepdoom2 = (5 - doomcount2)
                    Console.WriteLine("The creeping doom approaches! It will get you in " + CStr(creepdoom2) + " turns...")
                End If
            Case 7
                'Burned'
                If burcount2 > 4 Then
                    Console.WriteLine(p2.name + " has been extinguised.")
                    p2.str = (p2.str + 3)
                    burcount2 = 0
                    p2.afflic = 0
                ElseIf burcount2 = 0 Then
                    burdam2 = Int(Rnd() * 20 + 1)
                    p2.HP = (p2.HP - burdam2)
                    p2.str = (p2.str - 3)
                    Console.WriteLine(p2.name + " has taken " + CStr(burdam2) + " points worth of burn damage.")
                    bleecount2 = (bleecount2 + 1)
                Else
                    p2.HP = (p2.HP - burdam2)
                    Console.WriteLine(p2.name + " has taken " + CStr(burdam2) + " points worth of burn damage.")
                    bleecount2 = (bleecount2 + 1)
                End If
            Case 8
                'Drench'
                If drencount2 > 4 Then
                    Console.WriteLine(p2.name + " has dried.")
                    drencount2 = 0
                    p2.afflic = 0
                ElseIf drencount2 = 0 Then
                    drendra2 = Int(Rnd() * 20 + 1)
                    p2.MP = (p2.MP - drendra2)
                    Console.WriteLine(p2.name + " has taken " + CStr(drendra2) + " mana points worth of drench damage.")
                    drencount2 = (drencount2 + 1)
                Else
                    p2.MP = (p2.MP - drendra2)
                    Console.WriteLine(p2.name + " has taken " + CStr(drendra2) + " mana points worth of drench damage.")
                    drencount2 = (drencount2 + 1)
                End If
            Case 9
                'Time stop'
                If Timcount2 > 3 Then
                    Console.WriteLine("Time has returned for " + p2.name)
                    p2.afflic = 0
                    Timcount2 = 0
                Else
                    Console.WriteLine("Time has stopped for " + p2.name)
                    Timcount2 = (Timcount2 + 1)
                End If
            Case 10
                'Soul lock'
                If SLcount2 > 4 Then
                    Console.WriteLine(p2.name + " has broken all the Soul Locks! They are no longer Soul Locked!")
                    SLcount2 = 0
                    p2.afflic = 0
                ElseIf SLcount2 < 4 Then
                    Console.WriteLine(p2.name + " has broken a Soul Lock! There are " + CStr((5 - SLcount2)) + " Soul Locks left!")
                    SLcount2 = (SLcount2 + 1)
                End If
            Case Else
                Call play2()
        End Select
        If p2.HP <= 0 Then
            Call ending()
        End If
        Console.ReadLine()
        Call play2()
    End Sub
    Sub play2()
        Dim dam2 As Integer
        Dim menac2 As Integer
        Dim blicount2 As Integer
        Dim blichance2 As Integer
        Randomize()

        Console.WriteLine("Please select action " + p2.name)
        Console.WriteLine("1. Attack")
        Console.WriteLine("2. Abilities")
        Console.WriteLine("3. Items")
        Console.WriteLine("4. Defend")
        Console.WriteLine("5. See stats")
        Console.WriteLine("6. Save Game")
        menac2 = Console.ReadLine()
        Select Case menac2
            Case 1
                If p2.afflic = 4 Then
                    If blicount2 > 4 Then
                        Console.WriteLine(p2.name + " recovers from blindness.")
                        blicount2 = 0
                        dam2 = Int((Rnd() * (p2.str) + 1) - (Rnd() * p1.bloc + 1))
                        Console.WriteLine(p2.name + " has dealt " + CStr(dam2) + " damage to " + p1.name)
                        p1.HP = (p1.HP - dam2)
                    Else
                        blichance2 = (Rnd() * 6 + 1)
                        If blichance2 < 4 Then
                            Console.WriteLine(p2.name + " misses due to blindness!")
                            blicount2 = (blicount2 + 1)
                        Else
                            dam2 = Int((Rnd() * (p2.str) + 1) - (Rnd() * p1.bloc + 1))
                            Console.WriteLine(p2.name + " has dealt " + CStr(dam2) + " damage to " + p1.name)
                            p1.HP = (p1.HP - dam2)
                            blicount2 = (blicount2 + 1)
                        End If
                    End If
                Else
                    dam2 = Int((Rnd() * (p2.str) + 1) - (Rnd() * p1.bloc + 1))
                    Console.WriteLine(p2.name + " has dealt " + CStr(dam2) + " damage to " + p1.name)
                    p1.HP = (p1.HP - dam2)
                End If
                Console.ReadLine()
            Case 2
                Call ab2()
            Case 3
                Console.WriteLine("Please select the item you wish to use.")
                p2.itemchoice = Console.ReadLine()
                Call it2()
            Case 4
                Console.WriteLine(p2.name + " defends.")
                p2.bloc = (p2.bloc + 5)
                def2 = 1
            Case 5
                Console.WriteLine(p2.name + "'s stats:")
                Console.WriteLine("Health: " + CStr(p2.HP))
                Console.WriteLine("Mana: " + CStr(p2.MP))
                Console.WriteLine("Strength: " + CStr(p2.str))
                Console.WriteLine("Luck: " + CStr(p2.luk))
                Console.WriteLine("Intelligence: " + CStr(p2.int))
                Console.WriteLine("Agility: " + CStr(p2.agi))
                Console.WriteLine("Defence: " + CStr(p2.bloc))
                Console.ReadLine()
                Console.Clear()
                Call play2()
            Case 6
                Console.WriteLine("What do you want to call the file?")
                Dim sdata As New _11038SaveData
                Dim n As String = Console.ReadLine()
                sdata = convertGameToSaveData(p1, p2)
                _11038IO.writeSaveData(sdata, n)
                If File.Exists(n + ".11038") Then
                    Console.WriteLine("File written.")
                    Console.ReadLine()
                Else
                    Console.WriteLine("Error: File not found, even though it should have been written.")
                    Console.ReadLine()
                End If
        End Select

        Console.Clear()
        If p1.HP <= 0 Then
            Call ending()
        End If
        Call pre1()
    End Sub
    Sub ab1()
        Randomize()

        If p1.afflic = 10 Then
            Console.WriteLine("The Soul Lock on you prevents you from using your abilities!")
            Console.ReadLine()
            Console.Clear()
            Call play1()
        Else
            Console.WriteLine("Current mana: " + CStr(p1.MP))
            Select Case p1.classtype
                Case 1
                    Console.WriteLine("1. Blade Up")
                    Console.WriteLine("2. Rations")
                    Console.WriteLine("3. Strong Strike")
                    Console.WriteLine("4. Defence Up")
                    Console.WriteLine("5. Haemorrhage")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel = Console.ReadLine()
                    Call warskl1()
                Case 2
                    Console.WriteLine("1. Fireball")
                    Console.WriteLine("2. Heal")
                    Console.WriteLine("3. Drain")
                    Console.WriteLine("4. Mana Drain")
                    Console.WriteLine("5. Meteor")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel = Console.ReadLine()
                    Call magskl1()
                Case 3
                    Console.WriteLine("1. Invisibility")
                    Console.WriteLine("2. Blade storm")
                    Console.WriteLine("3. Wave of death")
                    Console.WriteLine("4. Cloak and dagger")
                    Console.WriteLine("5. Dark Slice")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel = Console.ReadLine()
                    Call thfskl1()
                Case 4
                    Console.WriteLine("1. Heal")
                    Console.WriteLine("2. Greater Heal")
                    Console.WriteLine("3. Refresh")
                    Console.WriteLine("4. Purity")
                    Console.WriteLine("5. Sanctify")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel = Console.ReadLine()
                    Call pstskl1()
                Case 5
                    Console.WriteLine("1. Luck Drain")
                    Console.WriteLine("2. Luck Bane")
                    Console.WriteLine("3. Strength Bane")
                    Console.WriteLine("4. Magic Bane")
                    Console.WriteLine("5. Invoking power")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel = Console.ReadLine()
                    Call rngskl1()
                Case 6
                    Console.WriteLine("1. Promethian")
                    Console.WriteLine("2. Girtablulu")
                    Console.WriteLine("3. Alucard")
                    Console.WriteLine("4. Ziasudra")
                    Console.WriteLine("5. Tempus")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel = Console.ReadLine()
                    Call smnskl1()
                Case 7
                    Console.WriteLine("1. Vampire")
                    Console.WriteLine("2. Bloody Strike")
                    Console.WriteLine("3. Blood Letting")
                    Console.WriteLine("4. Over Burden")
                    Console.WriteLine("5. Annhialation")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel = Console.ReadLine()
                    Call dktskl1()
                Case 9
                    Console.WriteLine("1. Investigation")
                    Console.WriteLine("2. Discussion Break")
                    Console.WriteLine("3. Hangman's Gambit")
                    Console.WriteLine("4. Bullet Time Battle")
                    Console.WriteLine("5. Ultimate Hope")
                    Console.WriteLine("6. Ultimate Despair")
                    Console.ReadLine()
                    Call SuperDuper()
                Case 8
                    progfrg1 = (progfrg1 + (Rnd() * (10 - 1) + 1))
                    Console.WriteLine("You currently have " + CStr(progfrg1) + " ProgFrags.")
                    Console.WriteLine("")
                    Console.WriteLine("1. Run.defrag()")
                    Console.WriteLine("2. Run.FirWal()")
                    Console.WriteLine("3. Run.VrlBrk()")
                    Console.WriteLine("4. Run.Tchorl()")
                    Console.WriteLine("5. Hack.exe; 'The Glitch to end them all.'")
                    Console.ReadLine()
                    Call Hakrskl1()
            End Select
        End If
    End Sub
    Sub ab2()
        If p2.afflic = 10 Then
            Console.WriteLine("The Soul Locks on you prevent you from using your abilities!")
            Console.ReadLine()
            Console.Clear()
            Call play2()
        Else
            Console.WriteLine("Current mana: " + CStr(p2.MP))
            Select Case p2.classtype
                Case 1
                    Console.WriteLine("1. Blade Up")
                    Console.WriteLine("2. Rations")
                    Console.WriteLine("3. Strong Strike")
                    Console.WriteLine("4. Defence Up")
                    Console.WriteLine("5. Haemorrhage")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel2 = Console.ReadLine()
                    Call warskl2()
                Case 2
                    Console.WriteLine("1. Fireball")
                    Console.WriteLine("2. Heal")
                    Console.WriteLine("3. Drain")
                    Console.WriteLine("4. Mana Drain")
                    Console.WriteLine("5. Meteor")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel2 = Console.ReadLine()
                    Call magskl2()
                Case 3
                    Console.WriteLine("1. Invisibility")
                    Console.WriteLine("2. Blade storm")
                    Console.WriteLine("3. Wave of death")
                    Console.WriteLine("4. Cloak and dagger")
                    Console.WriteLine("5. Dark Slice")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel2 = Console.ReadLine()
                    Call thfskl2()
                Case 4
                    Console.WriteLine("1. Heal")
                    Console.WriteLine("2. Greater Heal")
                    Console.WriteLine("3. Refresh")
                    Console.WriteLine("4. Purity")
                    Console.WriteLine("5. Sanctify")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel2 = Console.ReadLine()
                    Call pstskl2()
                Case 5
                    Console.WriteLine("1. Luck Drain")
                    Console.WriteLine("2. Luck Bane")
                    Console.WriteLine("3. Strength Bane")
                    Console.WriteLine("4. Magic Bane")
                    Console.WriteLine("5. Invoking power")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel2 = Console.ReadLine()
                    Call rngskl2()
                Case 6
                    Console.WriteLine("1. Promethian")
                    Console.WriteLine("2. Girtablulu")
                    Console.WriteLine("3. Alucard")
                    Console.WriteLine("4. Ziasudra")
                    Console.WriteLine("5. Tempus")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel2 = Console.ReadLine()
                    Call smnskl2()
                Case 7
                    Console.WriteLine("1. Vampire")
                    Console.WriteLine("2. Bloody Strike")
                    Console.WriteLine("3. Blood Letting")
                    Console.WriteLine("4. Over Burden")
                    Console.WriteLine("5. Annhialation")
                    Console.WriteLine("")
                    Console.WriteLine("Please enter the selection of skill.")
                    sklsel2 = Console.ReadLine()
                    Call dktskl2()
                Case 9
                    progfrg1 = (progfrg1 + (Rnd() * (10 - 1) + 1))
                    Console.WriteLine("You currently have " + CStr(progfrg1) + " ProgFrags.")
                    Console.WriteLine("")
                    Console.WriteLine("1. Run.defrag()")
                    Console.WriteLine("2. Run.FirWal()")
                    Console.WriteLine("3. Run.VrlBrk()")
                    Console.WriteLine("4. Run.Tchorl()")
                    Console.WriteLine("5. Hack.exe; 'The Glitch to end them all.'")
                    Console.ReadLine()
                    Call Hakrskl1()
            End Select
        End If
    End Sub
    Sub it1()
        Dim mystery As Integer
        Dim hprecov As Integer
        Dim hprecov2 As Integer
        Dim mprecov As Integer
        Dim mprecov2 As Integer
        Dim dam1 As Integer
        Dim rndaf As Integer
        Select Case p1.itemchoice
            Case 1
                'potion'
                hprecov = (Rnd() * 30 + 1)
                p1.HP = (p1.HP + hprecov)
                Console.WriteLine("The potion heals " + p1.name + " for " + CStr(hprecov) + " health points.")
            Case 2
                'mana potion'
                mprecov = (Rnd() * 30 + 1)
                p1.MP = (p1.MP + mprecov)
                Console.WriteLine("The mana potion heals " + p1.name + " for " + CStr(mprecov) + " mana points.")
            Case 3
                'Refresh crystal'
                p1.afflic = 0
                Console.WriteLine("The crystal heals " + p1.name + " of thier status conditions.")
            Case 4
                'Mystery'
                mystery = (Rnd() * 10 + 1)
                Select Case mystery
                    Case 1
                        Console.WriteLine("The mystery was a potion!")
                        hprecov = (Rnd() * 30 + 1)
                        p1.HP = (p1.HP + hprecov)
                        Console.WriteLine("The potion heals " + p1.name + " for " + CStr(hprecov) + " health points.")
                    Case 2
                        Console.WriteLine("The mystery was a mana potion!")
                        'mana potion'
                        mprecov = (Rnd() * 30 + 1)
                        p1.MP = (p1.MP + mprecov)
                        Console.WriteLine("The mana potion heals " + p1.name + " for " + CStr(mprecov) + " mana points.")
                    Case 3
                        Console.WriteLine("The mystery was a refresh crystal!")
                        p1.afflic = 0
                        Console.WriteLine("The crystal heals " + p1.name + " of thier status conditions.")
                    Case 4
                        Console.WriteLine("The mystery was a defence up!")
                        p1.def = (p1.def + 2)
                    Case 4
                        Console.WriteLine("The mystery was an attack increase!")
                        p1.str = (p1.str + 2)
                    Case 5
                        Console.WriteLine("The mystery was a throwing bomb!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p2.bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p2.name)
                        p2.HP = (p2.HP - dam1)
                    Case 6
                        Console.WriteLine("The mystery was a trap bomb! Oh no!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p1.bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p1.name)
                        p1.HP = (p1.HP - dam1)
                    Case 7
                        Console.WriteLine("The mystery was a mega-elixir!")
                        mprecov = (Rnd() * 50 + 1)
                        p1.MP = (p1.MP + mprecov)
                        hprecov = (Rnd() * 50 + 1)
                        p1.HP = (p1.HP + hprecov)
                        Console.WriteLine("The mega-elixir healed " + p1.name + " for " + CStr(hprecov) + " health points and " + CStr(mprecov) + " mana points.")
                    Case 8
                        Console.WriteLine("The mystery was a healing ring!")
                        hprecov = (Rnd() * 20 + 1)
                        p1.HP = (p1.HP + hprecov)
                        Console.WriteLine(p1.name + " gains " + CStr(hprecov) + " health points.")
                        hprecov2 = (Rnd() * 20 + 1)
                        p2.HP = (p2.HP + hprecov2)
                        Console.WriteLine(p2.name + " gains " + CStr(hprecov2) + " health points.")
                    Case 9
                        Console.WriteLine("The mystery was a mana ring!")
                        mprecov = (Rnd() * 20 + 1)
                        p1.MP = (p1.MP + mprecov)
                        Console.WriteLine(p1.name + " gains " + CStr(mprecov) + " mana points.")
                        mprecov2 = (Rnd() * 20 + 1)
                        p2.MP = (p2.MP + mprecov2)
                        Console.WriteLine(p1.name + " gains " + CStr(mprecov) + " mana points.")
                    Case 10
                        Console.WriteLine("The mystery was a random affliction bomb.")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                p2.afflic = 1
                                Console.WriteLine("The bomb inflicts Poison on " + p2.name)
                            Case 2
                                p2.afflic = 2
                                Console.WriteLine("The bomb inflicts Bleed on " + p2.name)
                            Case 3
                                p2.afflic = 3
                                Console.WriteLine("The bomb inflicts Paralysis on " + p2.name)
                            Case 4
                                p2.afflic = 4
                                Console.WriteLine("The bomb inflicts Blind on " + p2.name)
                            Case 5
                                p2.afflic = 5
                                Console.WriteLine("The bomb inflicts Confusion on " + p2.name)
                            Case 6
                                p2.afflic = 10
                                Console.WriteLine("The bomb inflicts Soul Lock on " + p2.name)
                            Case 7
                                p2.afflic = 7
                                Console.WriteLine("The bomb inflicts Burn on " + p2.name)
                            Case 8
                                p2.afflic = 8
                                Console.WriteLine("The bomb inflicts Drench on " + p2.name)
                            Case 9
                                p2.afflic = 9
                                Console.WriteLine("The bomb inflicts Time Stop on " + p2.name)
                        End Select
                End Select
        End Select
        Console.ReadLine()
    End Sub
    Sub it2()
        Dim mystery As Integer
        Dim hprecov As Integer
        Dim hprecov2 As Integer
        Dim mprecov As Integer
        Dim mprecov2 As Integer
        Dim dam1 As Integer
        Dim rndaf As Integer
        Select Case p1.itemchoice
            Case 1
                'potion'
                hprecov = (Rnd() * 30 + 1)
                p2.HP = (p2.HP + hprecov)
                Console.WriteLine("The potion heals " + p2.name + " for " + CStr(hprecov) + " health points.")
            Case 2
                'mana potion'
                mprecov = (Rnd() * 30 + 1)
                p2.MP = (p2.MP + mprecov)
                Console.WriteLine("The mana potion heals " + p2.name + " for " + CStr(mprecov) + " mana points.")
            Case 3
                'Refresh crystal'
                p2.afflic = 0
                Console.WriteLine("The crystal heals " + p2.name + " of thier status conditions.")
            Case 4
                'Mystery'
                mystery = (Rnd() * 10 + 1)
                Select Case mystery
                    Case 1
                        Console.WriteLine("The mystery was a potion!")
                        hprecov = (Rnd() * 30 + 1)
                        p2.HP = (p2.HP + hprecov)
                        Console.WriteLine("The potion heals " + p2.name + " for " + CStr(hprecov) + " health points.")
                    Case 2
                        Console.WriteLine("The mystery was a mana potion!")
                        'mana potion'
                        mprecov = (Rnd() * 30 + 1)
                        p2.MP = (p2.MP + mprecov)
                        Console.WriteLine("The mana potion heals " + p2.name + " for " + CStr(mprecov) + " mana points.")
                    Case 3
                        Console.WriteLine("The mystery was a refresh crystal!")
                        p2.afflic = 0
                        Console.WriteLine("The crystal heals " + p2.name + " of thier status conditions.")
                    Case 4
                        Console.WriteLine("The mystery was a defence up!")
                        p2.def = (p2.def + 2)
                    Case 4
                        Console.WriteLine("The mystery was an attack increase!")
                        p2.str = (p2.str + 2)
                    Case 5
                        Console.WriteLine("The mystery was a throwing bomb!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p1.bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p1.name)
                        p1.HP = (p1.HP - dam1)
                    Case 6
                        Console.WriteLine("The mystery was a trap bomb! Oh no!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p2.bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p2.name)
                        p2.HP = (p2.HP - dam1)
                    Case 7
                        Console.WriteLine("The mystery was a mega-elixir!")
                        mprecov = (Rnd() * 50 + 1)
                        p2.MP = (p2.MP + mprecov)
                        hprecov = (Rnd() * 50 + 1)
                        p2.HP = (p2.HP + hprecov)
                        Console.WriteLine("The mega-elixir healed " + p2.name + " for " + CStr(hprecov) + " health points and " + CStr(mprecov) + " mana points.")
                    Case 8
                        Console.WriteLine("The mystery was a healing ring!")
                        hprecov = (Rnd() * 20 + 1)
                        p2.HP = (p2.HP + hprecov)
                        Console.WriteLine(p2.name + " gains " + CStr(hprecov) + " health points.")
                        hprecov2 = (Rnd() * 20 + 1)
                        p1.HP = (p1.HP + hprecov2)
                        Console.WriteLine(p1.name + " gains " + CStr(hprecov2) + " health points.")
                    Case 9
                        Console.WriteLine("The mystery was a mana ring!")
                        mprecov = (Rnd() * 20 + 1)
                        p2.MP = (p2.MP + mprecov)
                        Console.WriteLine(p2.name + " gains " + CStr(mprecov) + " mana points.")
                        mprecov2 = (Rnd() * 20 + 1)
                        p1.MP = (p1.MP + mprecov2)
                        Console.WriteLine(p1.name + " gains " + CStr(mprecov2) + " mana points.")
                    Case 10
                        Console.WriteLine("The mystery was a random affliction bomb.")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                p1.afflic = 1
                                Console.WriteLine("The bomb inflicts Poison on " + p1.name)
                            Case 2
                                p1.afflic = 2
                                Console.WriteLine("The bomb inflicts Bleed on " + p1.name)
                            Case 3
                                p1.afflic = 3
                                Console.WriteLine("The bomb inflicts Paralysis on " + p1.name)
                            Case 4
                                p1.afflic = 4
                                Console.WriteLine("The bomb inflicts Blind on " + p1.name)
                            Case 5
                                p1.afflic = 5
                                Console.WriteLine("The bomb inflicts Confusion on " + p1.name)
                            Case 6
                                p1.afflic = 10
                                Console.WriteLine("The bomb inflicts Soul Lock on " + p1.name)
                            Case 7
                                p1.afflic = 7
                                Console.WriteLine("The bomb inflicts Burn on " + p1.name)
                            Case 8
                                p1.afflic = 8
                                Console.WriteLine("The bomb inflicts Drench on " + p1.name)
                            Case 9
                                p1.afflic = 9
                                Console.WriteLine("The bomb inflicts Time Stop on " + p1.name)
                        End Select
                End Select
        End Select
    End Sub
    Sub ending()
        Console.Clear()
        If p1.HP <= 0 Then
            Console.WriteLine("RIP Player 1...")
            Console.ReadLine()
            Console.Clear()
            Module1.main()
        ElseIf p2.HP <= 0 Then
            Console.WriteLine("RIP Player 2...")
            Console.ReadLine()
            Console.Clear()
            Module1.main()
        End If
    End Sub
    Sub warskl1()

        Randomize()

        Select Case sklsel
            Case 1
                If p1.MP > 2 Then
                    p1.MP = (p1.MP - 3)
                    p1.str = (p1.str + 2)
                    Console.WriteLine(p1.name + " casts Blade up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1.MP > 4 Then
                    p1.MP = (p1.MP - 5)
                    p1.HP = (p1.HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p1.name + " uses Rations.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p2.HP = (p2.HP - Int(Rnd() * (p1.str) + Int(p1.str / 4)))
                    Console.WriteLine(p1.name + " uses Strong strike.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1.MP > 3 Then
                    p1.MP = (p1.MP - 4)
                    p2.str = Int(p2.str - 2)
                    Console.WriteLine(p1.name + " casts Defence up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1.MP > 6 Then
                    p1.MP = (p1.MP - 7)
                    p2.afflic = 2
                    Console.WriteLine(p1.name + " uses Haemorrhage .")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub magskl1()
        Randomize()
        Select Case sklsel
            Case 1
                If p1.MP > 2 Then
                    p1.MP = (p1.MP - 3)
                    p2.HP = (p2.HP - (Rnd() * (p1.int) + 1))
                    Console.WriteLine(p1.name + " casts Fireball.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1.MP > 4 Then
                    p1.MP = (p1.MP - 5)
                    p1.HP = (p1.HP + (Rnd() * (p1.int) + 1))
                    Console.WriteLine(p1.name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p1.HP = (p1.HP + (Rnd() * (p1.int) + 1))
                    p2.HP = (p2.HP - Rnd() * (p1.int) + 1)
                    Console.WriteLine(p1.name + " casts Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1.MP > 14 Then
                    p1.MP = (p1.MP - 15)
                    p1.MP = (p1.MP + (Rnd() * 10 + 1))
                    p2.MP = (p2.MP - Rnd() * 10 + 1)
                    Console.WriteLine(p1.name + " casts Mana Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p2.HP = (p2.HP - (p1.int + (Rnd() * (p1.luk) + 1)))
                    Console.WriteLine(p1.name + " casts Meteor.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub thfskl1()
        Randomize()
        Select Case sklsel
            Case 1
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p2.afflic = 4
                    Console.WriteLine(p1.name + " casts Invisibility.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1.MP > 14 Then
                    p1.MP = (p1.MP - 15)
                    p2.HP = (p2.HP - (((Rnd() * 10 + 1) + (Rnd() * 10 + 1) + (Rnd() * 10 + 1))))
                    Console.WriteLine(p1.name + " uses Blade storm.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p2.HP = (p2.HP - (Rnd() * (p1.luk) + 1))
                    Console.WriteLine(p1.name + " casts Wave of death.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1.MP > 13 Then
                    p1.MP = (p1.MP - 14)
                    p2.HP = (p2.HP - (Rnd() * 20 + 1))
                    p2.afflic = 2
                    Console.WriteLine(p1.name + " casts Cloak and dagger.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p2.HP = (p2.HP - (Rnd() * (p1.str) + 1))
                    p2.str = Int(p2.str - (Rnd() * 5 + 1))
                    Console.WriteLine(p1.name + " uses Dark slice.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub pstskl1()
        Randomize()
        Select Case sklsel
            Case 1
                If p1.MP > 4 Then
                    p1.MP = (p1.MP - 5)
                    p1.HP = (p1.HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p1.name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1.MP > 14 Then
                    p1.MP = (p1.MP - 15)
                    p1.HP = (p1.HP + (Rnd() * 20 + 1))
                    Console.WriteLine(p1.name + " casts Greater heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p1.afflic = 0
                    Console.WriteLine(p1.name + " casts Refresh.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1.MP > 9 Then
                    p1.MP = (p1.MP - 10)
                    p2.HP = (p2.HP - (Rnd() * 15))
                    Console.WriteLine(p1.name + " casts Purify.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1.MP > 19 Then
                    p1.MP = (p1.MP - 20)
                    p2.HP = (p2.HP - (Rnd() * 20 + 1))
                    p2.afflic = 4
                    Console.WriteLine(p1.name + " casts Sanctify.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub rngskl2()
        Randomize()
        Select Case sklsel2
            Case 1
                If p2.MP > 4 Then
                    p2.MP = (p2.MP - 5)
                    p1.luk = Int(p1.luk - 1)
                    p2.luk = (p2.luk + 1)
                    Console.WriteLine(p2.name + " casts Luck drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2.MP > 6 Then
                    p2.MP = (p2.MP - 7)
                    p1.luk = 1
                    Console.WriteLine(p2.name + " casts Luck bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2.MP > 11 Then
                    p2.MP = (p2.MP - 12)
                    p1.str = 1
                    Console.WriteLine(p2.name + " casts Strength bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2.MP > 21 Then
                    p2.MP = (p2.MP - 22)
                    p1.afflic = 10
                    Console.WriteLine(p2.name + " casts Magic bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2.MP > 29 Then
                    p2.MP = (p2.MP - 30)
                    p2.MP = (p2.MP + (Rnd() * (p2.luk) + 1))
                    p2.HP = (p2.HP + (Rnd() * (p2.luk) + 1))
                    p2.str = (p2.str + (Rnd() * (p2.luk) + 1))
                    p2.luk = (p2.luk + (Rnd() * (p2.luk) + 1))
                    Console.WriteLine(p2.name + " casts Invoking power.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub smnskl1()
        Randomize()
        Select Case sklsel
            Case 1
                If p1.MP > 19 Then
                    p1.MP = (p1.MP - 20)
                    p2.HP = (p2.HP - (20 + Rnd() * (p1.int) + 1))
                    p2.afflic = 7
                    Console.WriteLine(p1.name + " summons Promethian.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1.MP > 19 Then
                    p1.MP = (p1.MP - 20)
                    p2.HP = (p2.HP - (20 + Rnd() * (p1.int) + 1))
                    p2.afflic = 7
                    Console.WriteLine(p1.name + " summons Girtablulu.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1.MP > 19 Then
                    p1.MP = (p1.MP - 20)
                    p2.HP = (p2.HP - (20 + Rnd() * (p1.int) + 1))
                    p2.afflic = 7
                    Console.WriteLine(p1.name + " summons Alucard.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1.MP > 19 Then
                    p1.MP = (p1.MP - 20)
                    p2.HP = (p2.HP - (20 + Rnd() * (p1.int) + 1))
                    p2.afflic = 8
                    Console.WriteLine(p1.name + " summons Ziasudra.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1.MP > 19 Then
                    p1.MP = (p1.MP - 20)
                    p2.HP = (p2.HP - (20 + Rnd() * (p1.int) + 1))
                    p2.afflic = 9
                    Console.WriteLine(p1.name + " summons Tempus.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub dktskl1()
        Randomize()
        Select Case sklsel
            Case 1
                If p1.MP > 4 Then
                    p1.MP = (p1.MP - 5)
                    p1.HP = (p1.HP + (Rnd() * 20 + 1))
                    p2.HP = (p2.HP - (Rnd() * 20))
                    Console.WriteLine(p1.name + " casts Vampire.")
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If p1.HP > 14 Then
                    p1.HP = (p1.HP - 15)
                    p2.HP = (p2.HP - (Rnd() * 20 + 1))
                    Console.WriteLine(p1.name + " casts Bloody strike.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 3
                If p1.HP > 19 Then
                    p1.HP = (p1.HP - 20)
                    Console.WriteLine(p1.name + " casts Blood letting.")
                    p1.agi = (p1.agi + 2)
                    p1.def = (p1.def + 2)
                    p1.int = (p1.int + 2)
                    p1.luk = (p1.luk + 2)
                    p1.str = (p1.str + 2)
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 4
                If p1.HP > 24 Then
                    p1.HP = (p1.HP - 25)
                    p2.agi = (p2.agi - 2)
                    p2.def = (p2.def - 2)
                    p2.int = (p2.int - 2)
                    p2.luk = (p2.luk - 2)
                    p2.str = (p2.str - 2)
                    Console.WriteLine(p1.name + " casts Overburden.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 5
                If p1.HP > 99 Then
                    p1.HP = (p1.HP - 100)
                    If p2.afflic = 1 Then
                        p2.HP = p2.HP - (Rnd() * 50 + 1)
                    End If
                    p2.afflic = 6
                    Console.WriteLine(p1.name + " casts Annihilation.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub warskl2()

        Randomize()

        Select Case sklsel2
            Case 1
                If p2.MP > 2 Then
                    p2.MP = (p2.MP - 3)
                    p2.str = (p2.str + 2)
                    Console.WriteLine(p2.name + " casts Blade up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2.MP > 4 Then
                    p2.MP = (p2.MP - 5)
                    p2.HP = (p2.HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p2.name + " uses Rations.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2.MP > 9 Then
                    p2.MP = (p2.MP - 10)
                    p1.HP = (p1.HP - Int(Rnd() * (p2.str) + Int(p2.str / 4)))
                    Console.WriteLine(p2.name + " uses Strong strike.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2.MP > 3 Then
                    p2.MP = (p2.MP - 4)
                    p1.str = Int(p1.str - 2)
                    Console.WriteLine(p2.name + " casts Defence up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2.MP > 6 Then
                    p2.MP = (p2.MP - 7)
                    p1.afflic = 2
                    Console.WriteLine(p2.name + " uses Haemorrhage .")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub magskl2()
        Randomize()
        Select Case sklsel2
            Case 1
                If p2.MP > 2 Then
                    p2.MP = (p2.MP - 3)
                    p1.HP = (p1.HP - (Rnd() * (p2.int) + 1))
                    Console.WriteLine(p2.name + " casts Fireball.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2.MP > 4 Then
                    p2.MP = (p2.MP - 5)
                    p2.HP = (p2.HP + (Rnd() * (p2.int) + 1))
                    Console.WriteLine(p2.name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2.MP > 9 Then
                    p1.MP = (p2.MP - 10)
                    p2.HP = (p1.HP + (Rnd() * (p2.int) + 1))
                    p1.HP = (p1.HP - Rnd() * (p2.int) + 1)
                    Console.WriteLine(p2.name + " casts Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2.MP > 14 Then
                    p2.MP = (p2.MP - 15)
                    p2.MP = (p2.MP + (Rnd() * 10 + 1))
                    p1.MP = (p1.MP - Rnd() * 10 + 1)
                    Console.WriteLine(p2.name + " casts Mana Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2.MP > 9 Then
                    p2.MP = (p2.MP - 10)
                    p1.HP = (p1.HP - (p2.int + (Rnd() * (p2.luk) + 1)))
                    Console.WriteLine(p2.name + " casts Meteor.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub thfskl2()
        Randomize()
        Select Case sklsel2
            Case 1
                If p2.MP > 9 Then
                    p2.MP = (p2.MP - 10)
                    p1.afflic = 4
                    Console.WriteLine(p2.name + " casts Invisibility.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2.MP > 14 Then
                    p2.MP = (p2.MP - 15)
                    p1.HP = (p1.HP - (((Rnd() * 10 + 1) + (Rnd() * 10 + 1) + (Rnd() * 10 + 1))))
                    Console.WriteLine(p2.name + " uses Blade storm.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2.MP > 9 Then
                    p2.MP = (p2.MP - 10)
                    p1.HP = (p1.HP - (Rnd() * (p2.luk) + 1))
                    Console.WriteLine(p2.name + " casts Wave of death.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2.MP > 13 Then
                    p2.MP = (p2.MP - 14)
                    p1.HP = (p1.HP - (Rnd() * 20 + 1))
                    p1.afflic = 2
                    Console.WriteLine(p1.name + " casts Cloak and dagger.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2.MP > 9 Then
                    p2.MP = (p2.MP - 10)
                    p1.HP = (p1.HP - (Rnd() * (p2.str) + 1))
                    p1.str = Int(p1.str - (Rnd() * 5 + 1))
                    Console.WriteLine(p2.name + " uses Dark slice.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub pstskl2()
        Randomize()
        Select Case sklsel2
            Case 1
                If p2.MP > 4 Then
                    p2.MP = (p2.MP - 5)
                    p2.HP = (p2.HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p2.name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2.MP > 14 Then
                    p2.MP = (p2.MP - 15)
                    p2.HP = (p2.HP + (Rnd() * 20 + 1))
                    Console.WriteLine(p1.name + " casts Greater heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2.MP > 9 Then
                    p2.MP = (p2.MP - 10)
                    p2.afflic = 0
                    Console.WriteLine(p2.name + " casts Refresh.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2.MP > 9 Then
                    p2.MP = (p2.MP - 10)
                    p1.HP = (p1.HP - (Rnd() * 15))
                    Console.WriteLine(p2.name + " casts Purify.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2.MP > 19 Then
                    p2.MP = (p2.MP - 20)
                    p1.HP = (p1.HP - (Rnd() * 20 + 1))
                    p1.afflic = 4
                    Console.WriteLine(p2.name + " casts Sanctify.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub rngskl1()
        Randomize()
        Select Case sklsel
            Case 1
                If p1.MP > 4 Then
                    p1.MP = (p1.MP - 5)
                    p2.luk = Int(p2.luk - 1)
                    p1.luk = (p1.luk + 1)
                    Console.WriteLine(p1.name + " casts Luck drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1.MP > 6 Then
                    p1.MP = (p1.MP - 7)
                    p2.luk = 1
                    Console.WriteLine(p1.name + " casts Luck bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1.MP > 11 Then
                    p1.MP = (p1.MP - 12)
                    p2.str = 1
                    Console.WriteLine(p1.name + " casts Strength bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1.MP > 21 Then
                    p1.MP = (p1.MP - 22)
                    p2.afflic = 10
                    Console.WriteLine(p1.name + " casts Magic bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1.MP > 29 Then
                    p1.MP = (p1.MP - 30)
                    p1.MP = (p1.MP + (Rnd() * (p1.luk) + 1))
                    p1.HP = (p1.HP + (Rnd() * (p1.luk) + 1))
                    p1.str = (p1.str + (Rnd() * (p1.luk) + 1))
                    p1.luk = (p1.luk + (Rnd() * (p1.luk) + 1))
                    Console.WriteLine(p1.name + " casts Invoking power.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub smnskl2()
        Randomize()
        Select Case sklsel2
            Case 1
                If p2.MP > 19 Then
                    p2.MP = (p2.MP - 20)
                    p1.HP = (p1.HP - (20 + Rnd() * (p2.int) + 1))
                    p1.afflic = 7
                    Console.WriteLine(p2.name + " summons Promethian.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2.MP > 19 Then
                    p2.MP = (p2.MP - 20)
                    p1.HP = (p1.HP - (20 + Rnd() * (p2.int) + 1))
                    p1.afflic = 7
                    Console.WriteLine(p2.name + " summons Girtablulu.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2.MP > 19 Then
                    p2.MP = (p2.MP - 20)
                    p1.HP = (p1.HP - (20 + Rnd() * (p2.int) + 1))
                    p1.afflic = 7
                    Console.WriteLine(p2.name + " summons Alucard.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2.MP > 19 Then
                    p2.MP = (p2.MP - 20)
                    p1.HP = (p1.HP - (20 + Rnd() * (p2.int) + 1))
                    p1.afflic = 8
                    Console.WriteLine(p2.name + " summons Ziasudra.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2.MP > 19 Then
                    p2.MP = (p2.MP - 20)
                    p1.HP = (p1.HP - (20 + Rnd() * (p2.int) + 1))
                    p1.afflic = 9
                    Console.WriteLine(p2.name + " summons Tempus.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub dktskl2()
        Randomize()
        Select Case sklsel2
            Case 1
                If p2.MP > 4 Then
                    p2.MP = (p2.MP - 5)
                    p2.HP = (p2.HP + (Rnd() * 20 + 1))
                    p1.HP = (p1.HP - (Rnd() * 20))
                    Console.WriteLine(p2.name + " casts Vampire.")
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If p2.HP > 14 Then
                    p2.HP = (p2.HP - 15)
                    p1.HP = (p1.HP - (Rnd() * 20 + 1))
                    Console.WriteLine(p2.name + " casts Bloody strike.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 3
                If p2.HP > 19 Then
                    p2.HP = (p2.HP - 20)
                    Console.WriteLine(p2.name + " casts Blood letting.")
                    p2.agi = (p2.agi + 2)
                    p2.def = (p2.def + 2)
                    p2.int = (p2.int + 2)
                    p2.luk = (p2.luk + 2)
                    p2.str = (p2.str + 2)
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 4
                If p2.HP > 24 Then
                    p2.HP = (p2.HP - 25)
                    p1.agi = (p1.agi - 2)
                    p1.def = (p1.def - 2)
                    p1.int = (p1.int - 2)
                    p1.luk = (p1.luk - 2)
                    p1.str = (p1.str - 2)
                    Console.WriteLine(p2.name + " casts Overburden.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 5
                If p2.HP > 99 Then
                    p2.HP = (p2.HP - 100)
                    If p1.afflic = 1 Then
                        p1.HP = p1.HP - (Rnd() * 50 + 1)
                    End If
                    p1.afflic = 6
                    Console.WriteLine(p2.name + " casts Annihilation.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub extra()
        Dim extmenu As Integer
        Console.WriteLine("Please select the sub-section you wish to view.")
        Console.WriteLine("1. Classes")
        Console.WriteLine("2. Items")
        Console.WriteLine("3. Status ailments.")
        Console.WriteLine("4. Return to the main menu")
        extmenu = Console.ReadLine()
        Select Case extmenu
            Case 1
                Console.Clear()
                Call chardex()
            Case 2
                Console.Clear()
                Call itemdex()
            Case 3
                Console.Clear()
                Call aflicdex()
            Case 4
                Console.Clear()
                Call Main()
        End Select
    End Sub
    Sub chardex()
        Dim charmendex As Integer
        Console.WriteLine("Please select a class to hear its description.")
        Console.WriteLine("1. Warrior")
        Console.WriteLine("2. Mage")
        Console.WriteLine("3. Thief")
        Console.WriteLine("4. Priest")
        Console.WriteLine("5. Ranger")
        Console.WriteLine("6. Summoner")
        Console.WriteLine("7. Dark knight")
        Console.WriteLine("8. Hacker Artist")
        Console.WriteLine("9. ERROR")
        Console.WriteLine("10. Return to the previous menu")
        charmendex = Console.ReadLine()
        Select Case charmendex
            Case 1
                Console.WriteLine("The warrior is your basic class. The warrior gets buffed stats in strength and  defence. There is a good range of abilities offered from this class.")
            Case 2
                Console.WriteLine("Phisically the mage lacks a bit but it makes up for it with the strong offensive arsenal of spells. It even has a few other spells mixed in...")
            Case 3
                Console.WriteLine("The thief is an interesting class. They have lower defences than most classes   but make up for it with better attacks and faster speed.")
            Case 4
                Console.WriteLine("Like the mage, the priest has lower attack than most classes. However the priest has healing and the ability to remove affliction. If the attack down thing     worries you then there are also a few attack spells.")
            Case 5
                Console.WriteLine("The ranger is a powerful class but somewhat difficult to use. The main abilities of the class relate around lowering the opponent's stats. However luck plays a slight part of the abilities.")
            Case 6
                Console.WriteLine("Summoners can call the aid of the Jorn. These summons do strong damage and      inflict a status condition relating to thier respective element. The problem is    that these summons take up a lot of mana.")
            Case 7
                Console.WriteLine("The dark knight is by far the strongest but riskiest of classes. The dark knight has strong attacks and abilities but nearly all of the abilities require a cost of HP.")
            Case 8
                Console.WriteLine("The Hacker Artist is a tricky class. They produce a random number of Program    Fragments or ProgFrags and can spend them to hack the console and change a few  of the values.")
            Case 9
                Console.WriteLine("VGhlIEVycm9yIGNsYXNzIGlzIGEgbXlzdGVyeS4gSXQncyBhIHNocm91ZGVkIHNlY3JldC4gQXBwYXJlbnRseS4gdW1tIHVtbSB1bW0gYmFuYW5h Dpeiasr!")
            Case 10
                Console.Clear()
                Call extra()
        End Select
        Console.ReadLine()
        Console.Clear()
        Call chardex()
    End Sub
    Sub itemdex()
        Dim itmendex As Integer
        Console.WriteLine("Please select an item to hear what it does.")
        Console.WriteLine("1. Potion")
        Console.WriteLine("2. Mana potion")
        Console.WriteLine("3. Refresh crystal")
        Console.WriteLine("4. Mystery")
        Console.WriteLine("5. Bombs")
        Console.WriteLine("6. Healing and mana rings")
        Console.WriteLine("7. Mega Elixir")
        Console.WriteLine("8. Stat up")
        Console.WriteLine("9. R.A.B")
        Console.WriteLine("10. Return to the previous menu")
        itmendex = Console.ReadLine()
        Select Case itmendex
            Case 1
                Console.WriteLine("The potion is a usual healing potion. It heals for a random amount between 1 and 30")
            Case 2
                Console.WriteLine("The mana potion works like the regular potion but heals between 1 and 30 mana.")
            Case 3
                Console.WriteLine("This crystal will heal any status conditions. It will only do that though.")
            Case 4
                Console.WriteLine("A mystery is a mystery. It will provide you with a random item every time you   use it.")
            Case 5
                Console.WriteLine("There are 2 types of bombs. The throwing bomb is used to attack with a base     attack of 30.")
                Console.WriteLine("The other is the trap bomb. Its a trap! It will explode and deal damage to you   with a base attack of 30.")
                Console.WriteLine("These items can only be obtained in a mystery.")
            Case 6
                Console.WriteLine("These rings are a double edged sword. They will both heal like thier respective potions but will heal both players.")
                Console.WriteLine("These items can only be obtained in a mystery.")
            Case 7
                Console.WriteLine("One of the best items. The mega-elixir will heal both HP an MP with a max value  of 50.")
                Console.WriteLine("This item can only be obtained in a mystery.")
            Case 8
                Console.WriteLine("There are 2 stat ups that can be obtained. Sterngth up and attack up. They are  self explainitory.")
                Console.WriteLine("These items can only be obtained in a mystery.")
            Case 9
                Console.WriteLine("The RAB stands for Random affliction bomb. This will inflict a random status    effect on the opponent.")
                Console.WriteLine("This item is only obtained in a mystery.")
            Case 10
                Console.Clear()
                Call extra()
        End Select
        Console.ReadLine()
        Console.Clear()
        Call itemdex()
    End Sub
    Sub aflicdex()
        Dim afmendex As Integer
        Console.WriteLine("1. Poison")
        Console.WriteLine("2. Bleed")
        Console.WriteLine("3. Paralysis")
        Console.WriteLine("4. Confusion")
        Console.WriteLine("5. Doom")
        Console.WriteLine("6. Blind")
        Console.WriteLine("7. Burned")
        Console.WriteLine("8. Drench")
        Console.WriteLine("9. Time stop")
        Console.WriteLine("10. Soul Lock")
        Console.WriteLine("11. Back to the previous menu.")
        afmendex = Console.ReadLine()
        Select Case afmendex
            Case 1
                Console.WriteLine("Poison will deal damage before you act for 5 turns. The damage can be between 1 and 30 damage.")
            Case 2
                Console.WriteLine("Bleed will deal damage before you act for 5 turns. The damage can be between 1  and 20 damage.")
            Case 3
                Console.WriteLine("Paralysis causes you to be unable to act every once in a while for 5 turns.")
            Case 4
                Console.WriteLine("Confusion will cause you to preform random actions. This can range from         attacking to using an item. You can also attack yourself or do nothing. This will happen for 5 turns.")
            Case 5
                Console.WriteLine("Doom is one of the worst status ailments. Every turn the 'creeping doom' will   get closer. Let the ailment reach 5 turns and you will lose all of your health.   The count ticks before you act.")
            Case 6
                Console.WriteLine("Blind causes you to miss on your regular attacks sometimes. Spells and other    actions are unaffected though. This lasts for 5 turns.")
            Case 7
                Console.WriteLine("Burned causes you to lose HP before you act for 5 turns. The damage ranges from between 1 and 20. It also lowers your attack while it is active.")
            Case 8
                Console.WriteLine("The drench ailment will cause your mana to drain away for 5 turns. This drain   will be between 1 and 30 mana damage every turn.")
            Case 9
                Console.WriteLine("Time stop is one of the worst status ailments. This ailment will cause you to be completely unable to act for 3 turns.")
            Case 10
                Console.WriteLine("Soul Lock is one of the worst status ailments. This ailment locks the targets   soul, preventing them from using any abilities for 4 turns.")
            Case 11
                Console.Clear()
                Call extra()
        End Select
        Console.ReadLine()
        Console.Clear()
        Call aflicdex()
    End Sub
    Sub SuperDuper()
        Randomize()
        Dim UHBullet As Integer
        Dim UDBullet As Integer
        Dim Truthbullet As Integer
        Dim invest As Integer
        Dim choice As Integer
        Dim chance As Integer
        Dim rndaf As Integer
        invest = (Int(Rnd() * (100 - 1) + 1))
        Console.WriteLine(CStr(invest))
        If invest >= 90 Then
            If UHBullet = 0 Then
                Console.WriteLine("You obtained 'The Ultimate Hope' Truth Bullet!")
                UHBullet = (UHBullet + 1)
            Else
                Console.WriteLine("You obtained a Truth Bullet.")
                Truthbullet = (Truthbullet + 1)
            End If
        ElseIf invest <= 5 Then
            If UDBullet = 0 Then
                Console.WriteLine("You obtained 'The Ultimate Despair' Truth Bullet!")
                UDBullet = (UDBullet + 1)
            Else
                Console.WriteLine("You obtained a Truth Bullet.")
                Truthbullet = (Truthbullet + 1)
            End If
        Else
            Console.WriteLine("You obtained a Truth Bullet.")
            Truthbullet = (Truthbullet + 1)
        End If
        Console.ReadLine()
        Console.WriteLine("You currently have " + CStr(Truthbullet) + " Truth Bullets.")
        Console.WriteLine("Please select a skill:")
        choice = Console.ReadLine()
        Select Case choice
            Case 1
                If p1.MP >= 5 Then
                    p1.MP = (p1.MP - 5)
                    Console.WriteLine(p1.name + " investigates for Truth Bullets.")
                    Truthbullet = (Truthbullet + Int(Rnd() * 5 + 1))
                    Console.WriteLine(p1.name + " now has " + CStr(Truthbullet) + " Truth bullets.")
                Else
                    Console.WriteLine("You do not have enough mana.")
                End If
            Case 2
                If Truthbullet >= 1 Then
                    Truthbullet = (Truthbullet - 1)
                    chance = (Int(Rnd() * (10 - 1) + 1))
                    Console.WriteLine(p1.name + " enters a discussion.")
                    Console.ReadLine()
                    Select Case chance
                        Case Is <= 3
                            Truthbullet = (Truthbullet - 3)
                            Console.WriteLine(p1.name + ": I agree with that statement!")
                            p1.HP = (p1.HP + 5)
                            p2.HP = (p2.HP + 5)
                        Case Is <= 6
                            Console.WriteLine(p1.name + ": You've got that wrong!")
                            p2.HP = Int(p2.HP - (Rnd() * 20 + 1))
                        Case Is <= 9
                            Console.WriteLine(p1.name + ": You've got that right...?")
                            p2.MP = Int(p2.MP - (Truthbullet * 10))
                        Case 10
                            Console.WriteLine(p1.name + ": Hope will defeat Despair!")
                            p2.HP = Int(p2.HP - (Asc(p2.name) / 2))
                    End Select
                Else
                    Console.WriteLine("You do not have the required number of Truth Bullets.")
                End If
            Case 3
                If Truthbullet >= 5 Then
                    Truthbullet = (Truthbullet - 5)
                    Console.WriteLine(p1.name + " plays a game of Hangman's Gambit.")
                    Console.ReadLine()
                    chance = (Rnd() * 10 + 1)
                    If chance <= 6 Then
                        Console.WriteLine(p1.name + " wins the Hangman's gambit and inflicts the opponent with a stus effect.")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                p2.afflic = 1
                                Console.WriteLine("Poison on " + p2.name)
                            Case 2
                                p2.afflic = 2
                                Console.WriteLine("Bleed on " + p2.name)
                            Case 3
                                p2.afflic = 3
                                Console.WriteLine("Paralysis on " + p2.name)
                            Case 4
                                p2.afflic = 4
                                Console.WriteLine("Blind on " + p2.name)
                            Case 5
                                p2.afflic = 5
                                Console.WriteLine("Confusion on " + p2.name)
                            Case 6
                                p2.afflic = 10
                                Console.WriteLine("Soul Lock on " + p2.name)
                            Case 7
                                p2.afflic = 7
                                Console.WriteLine("Burn on " + p2.name)
                            Case 8
                                p2.afflic = 8
                                Console.WriteLine("Drench on " + p2.name)
                            Case 9
                                p2.afflic = 9
                                Console.WriteLine("Time Stop on " + p2.name)
                        End Select
                    Else
                        Console.WriteLine(p1.name + " lost the Hangman's Gambit and must face punishment!")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                p1.afflic = 1
                                Console.WriteLine("Poison on " + p1.name)
                            Case 2
                                p1.afflic = 2
                                Console.WriteLine("Bleed on " + p1.name)
                            Case 3
                                p1.afflic = 3
                                Console.WriteLine("Paralysis on " + p1.name)
                            Case 4
                                p1.afflic = 4
                                Console.WriteLine("Blind on " + p1.name)
                            Case 5
                                p1.afflic = 5
                                Console.WriteLine("Confusion on " + p1.name)
                            Case 6
                                p1.afflic = 10
                                Console.WriteLine("Soul Lock on " + p1.name)
                            Case 7
                                p1.afflic = 7
                                Console.WriteLine("Burn on " + p1.name)
                            Case 8
                                p1.afflic = 8
                                Console.WriteLine("Drench on " + p1.name)
                            Case 9
                                p1.afflic = 9
                                Console.WriteLine("Time Stop on " + p1.name)
                        End Select
                    End If
                Else
                    Console.WriteLine("You do not have the required number of Truth Bullets.")
                End If
            Case 4
                If Truthbullet >= 10 Then
                    Truthbullet = (Truthbullet - 10)
                    Console.WriteLine(p1.name + " enters a Bullet time Battle with " + p2.name)
                    If p1.HP > p2.HP Then
                        Console.WriteLine(p1.name + " wins the Bullet Time Battle! Thier argument becomes stronger!")
                        p1.str = (p1.str + 5)
                    Else
                        Console.WriteLine(p1.name + " loses the Bullet Time battle and must face Punishment!")
                        p1.HP = Int(p1.HP - Rnd() * 75 + 1)
                    End If
                Else
                    Console.WriteLine("You do not have the required number of Truth Bullets!")
                End If
            Case 5
                If UHBullet = 1 Then
                    UHBullet = (UHBullet - 1)
                    Console.WriteLine("You fire the 'Ultimate Hope' Truth bullet!")
                    Console.WriteLine("")
                    Console.WriteLine(p1.name + " breaks throught the despair!")
                    p1.HP = (p1.HP + 20)
                    p1.agi = (p1.agi + 10)
                    p1.str = (p1.str + 10)
                    p1.def = (p1.def + 10)
                    p1.int = (p1.int + 10)
                    p1.luk = (p1.luk + 10)
                    p1.MP = (p1.MP + 20)
                Else
                    Console.WriteLine("You are missing the required Truth Bullet.")
                End If
            Case 6
                If UDBullet = 1 Then
                    UDBullet = (UDBullet - 1)
                    Console.WriteLine("You fire the 'Ultimate Despair' Truth Bullet!")
                    Console.WriteLine("")
                    Console.WriteLine(p2.name + " has been found Guilty! Let's give it all we've got. It's punishment time!")
                    p2.HP = 0
                    Call ending()
                Else
                    Console.WriteLine("You are missing the required Truth Bullet.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub Hakrskl1()
        Randomize()
        Select Case sklsel
            Case 1
                If p1.MP > 4 Then
                    p1.MP = (p1.MP - 5)
                    progfrg1 = (progfrg1 + (Rnd() * (20 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If progfrg1 >= 50 Then
                    progfrg1 = (progfrg1 - 20)
                    p1.def = (p1.def + (Rnd() * (10 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 3
                If progfrg1 >= 100 Then
                    progfrg1 = (progfrg1 - 100)
                    p2.HP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 4
                If progfrg1 >= 75 Then
                    progfrg1 = (progfrg1 - 75)
                    p2.MP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 5
                If progfrg1 >= 200 Then
                    progfrg1 = (progfrg1 - 200)
                    p2.HP = (Rnd() * (100 - 1) + 1)
                    p2.agi = (Rnd() * (50 - 1) + 1)
                    p2.str = (Rnd() * (50 - 1) + 1)
                    p2.def = (Rnd() * (50 - 1) + 1)
                    p2.int = (Rnd() * (50 - 1) + 1)
                    p2.luk = (Rnd() * (50 - 1) + 1)
                    p2.MP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
    Sub Hkrskl2()
        Randomize()
        Select Case sklsel2
            Case 1
                If p2.MP > 4 Then
                    p2.MP = (p2.MP - 5)
                    progfrg2 = (progfrg2 + (Rnd() * (20 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If progfrg2 >= 50 Then
                    progfrg2 = (progfrg2 - 20)
                    p2.def = (p2.def + (Rnd() * (10 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 3
                If progfrg2 >= 100 Then
                    progfrg2 = (progfrg2 - 100)
                    p1.HP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 4
                If progfrg2 >= 75 Then
                    progfrg2 = (progfrg2 - 75)
                    p1.MP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 5
                If progfrg2 >= 200 Then
                    progfrg2 = (progfrg2 - 200)
                    p1.HP = (Rnd() * (100 - 1) + 1)
                    p1.agi = (Rnd() * (50 - 1) + 1)
                    p1.str = (Rnd() * (50 - 1) + 1)
                    p1.def = (Rnd() * (50 - 1) + 1)
                    p1.int = (Rnd() * (50 - 1) + 1)
                    p1.luk = (Rnd() * (50 - 1) + 1)
                    p1.MP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
End Module

Module Module1
    Sub main()
        _11038Program.Main()
    End Sub
End Module