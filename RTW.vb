
Module Module1
    Dim mainmenu As Integer
    Dim p1name, p2name As String
    Dim p1HP, p1MP, p1str, p1luk, p1int, p1agi, p1def, p1class As Integer
    Dim p2HP, p2MP, p2str, p2luk, p2int, p2agi, p2def, p2class As Integer
    Dim afflic1 As Integer
    Dim afflic2 As Integer
    Dim p1bloc As Integer
    Dim p2bloc As Integer
    Dim sklsel As Integer
    Dim def1 As Integer
    Dim def2 As Integer
    Dim itemchoice1 As Integer
    Dim itemchoice2 As Integer
    Dim sklsel2 As Integer
    Dim progfrg1, progfrg2 As Integer

    Sub Main()
        Console.WriteLine("11037")
        Console.WriteLine("Please select option.")
        Console.WriteLine("1. Create characters.")
        Console.WriteLine("2. Class index.")
        mainmenu = Console.ReadLine()
        Select Case mainmenu
            Case 1
                Call charmake1()
            Case 2
                Call extra()
        End Select


    End Sub
    Sub charmake1()
        Dim charmen1 As String

        Console.Clear()
        Console.WriteLine("Please enter character name.")
        p1name = Console.ReadLine()
        Do
            Randomize()
            p1HP = Int(Rnd() * 100 + 1)
            p1MP = Int(Rnd() * 100 + 1)
            p1str = Int(Rnd() * 30 + 1)
            p1luk = Int(Rnd() * 30 + 1)
            p1int = Int(Rnd() * 30 + 1)
            p1agi = Int(Rnd() * 30 + 1)
            p1def = Int(Rnd() * 20 + 1)
            Console.WriteLine("Name: " + p1name)
            Console.WriteLine("Health: " + CStr(p1HP))
            Console.WriteLine("Mana: " + CStr(p1MP))
            Console.WriteLine("Strength: " + CStr(p1str))
            Console.WriteLine("Luck: " + CStr(p1luk))
            Console.WriteLine("Intelligence: " + CStr(p1int))
            Console.WriteLine("Agility: " + CStr(p1agi))
            Console.WriteLine("Defence: " + CStr(p1def))
            Console.WriteLine("")
            Console.WriteLine("Re-roll stats?")
            charmen1 = Console.ReadLine()
            If charmen1 = "yes" Then
                Console.WriteLine("Re-rolling stats")
                Console.Clear()
            ElseIf charmen1 = "no" Then
                Console.Clear()
                Call charmake2()
            End If
        Loop
    End Sub
    Sub charmake2()
        Dim charmen2 As String

        Console.Clear()
        Console.WriteLine("Please enter character name.")
        p2name = Console.ReadLine()
        Do
            Randomize()
            p2HP = Int(Rnd() * 100 + 1)
            p2MP = Int(Rnd() * 100 + 1)
            p2str = Int(Rnd() * 30 + 1)
            p2luk = Int(Rnd() * 30 + 1)
            p2int = Int(Rnd() * 30 + 1)
            p2agi = Int(Rnd() * 30 + 1)
            p2def = Int(Rnd() * 20 + 1)
            Console.WriteLine("Name: " + p2name)
            Console.WriteLine("Health: " + CStr(p2HP))
            Console.WriteLine("Mana: " + CStr(p2MP))
            Console.WriteLine("Strength: " + CStr(p2str))
            Console.WriteLine("Luck: " + CStr(p2luk))
            Console.WriteLine("Intelligence: " + CStr(p2int))
            Console.WriteLine("Agility: " + CStr(p2agi))
            Console.WriteLine("Defence: " + CStr(p2def))
            Console.WriteLine("")
            Console.WriteLine("Re-roll stats?")
            charmen2 = Console.ReadLine()
            If charmen2 = "yes" Then
                Console.WriteLine("Re-rolling stats")
                Console.Clear()
            ElseIf charmen2 = "no" Then
                Console.Clear()
                Call class1()
            End If
        Loop
    End Sub
    Sub class1()
        Dim illi As Integer
        Dim clamen1 As Integer
        Console.WriteLine("Player 1, please select class:")
        Console.WriteLine("1. Warrior")
        Console.WriteLine("2. Mage")
        Console.WriteLine("3. Thief")
        Console.WriteLine("4. Priest")
        Console.WriteLine("5. Ranger")
        Console.WriteLine("6. Summoner")
        Console.WriteLine("7. Dark knight")
        Console.WriteLine("8. Hacker Artist")
        clamen1 = Console.ReadLine()
        Select Case clamen1
            Case 1
                p1class = 1
                p1str = (p1str + 5)
                p1def = (p1def + 5)
            Case 2
                p1class = 2
                p1str = Int(p1str - 5)
                p1MP = (p1MP + 10)
                p1int = (p1int + 5)
            Case 3
                p1class = 3
                p1def = Int(p1def - 10)
                p1str = (p1str + 2)
                p1luk = (p1luk + 2)
                p1agi = (p1agi + 3)
            Case 4
                p1class = 4
                p1HP = (p1HP + 10)
                p1str = Int(p1str - 5)
            Case 5
                p1class = 5
                p1agi = (p1agi + 5)
            Case 6
                p1class = 6
                p1str = Int(p1str - 10)
                p1MP = (p1MP + 20)
                p1int = (p1int + 2)
            Case 7
                p1class = 7
                p1HP = (p1HP + 30)
                p1str = (p1str + 2)
            Case 8
                p1class = 8
                progfrg1 = 10
            Case 9
                Console.WriteLine("You entered an illegal command. Please execute numerical proof of execution:")
                illi = Console.ReadLine()
                If illi = 11037 Then
                    Console.WriteLine("Thank you. Let's give it all we've got! Its Punishment time!")
                    Console.ReadLine()
                    p1class = 9
                    p1HP = (p1HP + 20)
                    p1agi = (p1agi + 2)
                    p1str = (p1str + 2)
                    p1def = (p1def + 2)
                    p1int = (p1int + 2)
                    p1luk = (p1luk + 2)
                    p1MP = (p1MP + 2)
                Else
                    Console.WriteLine("UD ID failed. Resetting...")
                    Console.ReadLine()
                    Console.Clear()
                    Call class1()
                End If
            Case Else
                Console.Clear()
                Call class1()
        End Select
        Console.Clear()
        Call class2()
    End Sub
    Sub class2()
        Dim clamen2 As Integer
        Console.WriteLine("Player 2, please select class:")
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
                p2class = 1
                p2str = (p2str + 5)
                p2def = (p2def + 5)
            Case 2
                p2class = 2
                p2str = Int(p2str - 5)
                p2MP = (p2MP + 10)
                p2int = (p2int + 5)
            Case 3
                p2class = 3
                p2HP = Int(p2HP - 10)
                p2str = (p2str + 2)
                p2luk = (p2luk + 2)
                p2agi = (p2agi + 3)
            Case 4
                p2class = 4
                p2HP = (p2HP + 10)
                p2str = Int(p2str - 5)
            Case 5
                p2class = 5
                p2agi = (p2agi + 5)
            Case 6
                p2class = 6
                p2str = Int(p2str - 10)
                p2MP = (p2MP + 20)
                p2int = (p2int + 2)
            Case 7
                p2class = 7
                p2HP = (p2HP + 30)
                p2str = (p2str + 2)
            Case 8
                p2class = 9
                progfrg2 = 10
            Case 9
                Console.WriteLine("You entered an illegal command. Please execute numerical proof of execution:")
                illi = Console.ReadLine()
                If illi = 11037 Then
                    Console.WriteLine("Thank you. Let's give it all we've got! Its Punishment time!")
                    Console.ReadLine()
                    p2class = 9
                    p2HP = (p1HP + 20)
                    p2agi = (p1agi + 2)
                    p2str = (p1str + 2)
                    p2def = (p1def + 2)
                    p2int = (p1int + 2)
                    p2luk = (p1luk + 2)
                    p2MP = (p1MP + 2)
                Else
                    Console.WriteLine("UD ID failed. Resetting...")
                    Console.ReadLine()
                    Console.Clear()
                    Call class1()
            Case Else
                Console.Clear()
                Call class2()
        End Select
        Console.Clear()
        Call play1()
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
            Console.WriteLine(p1name + " relinquishes thier defence.")
            p1bloc = p1def
        End If
        Select Case afflic1
            Case 1
                'poison'
                If poicount > 4 Then
                    Console.WriteLine(p1name + " has treated the poison.")
                    poicount = 0
                    afflic1 = 0
                ElseIf poicount = 0 Then
                    poidam = Int(Rnd() * 30 + 1)
                    p1HP = (p1HP - poidam)
                    Console.WriteLine(p1name + " has taken " + CStr(poidam) + " points worth of poison damage.")
                    poicount = (poicount + 1)
                Else
                    p1HP = (p1HP - poidam)
                    Console.WriteLine(p1name + " has taken " + CStr(poidam) + " points worth of poison damage.")
                    poicount = (poicount + 1)
                End If
            Case 2
                'bleed'
                If bleecount > 4 Then
                    Console.WriteLine(p1name + " has stopped bleeding.")
                    bleecount = 0
                    afflic1 = 0
                ElseIf bleecount = 0 Then
                    bleedam = Int(Rnd() * 20 + 1)
                    p1HP = (p1HP - bleedam)
                    Console.WriteLine(p1name + " has taken " + CStr(bleedam) + " points worth of bleed damage.")
                    bleecount = (bleecount + 1)
                Else
                    p1HP = (p1HP - bleedam)
                    Console.WriteLine(p1name + " has taken " + CStr(bleedam) + " points worth of bleed damage.")
                    bleecount = (bleecount + 1)
                End If
            Case 3
                'paralasys'
                If paracount > 4 Then
                    Console.WriteLine(p1name + " has regained movement.")
                    paracount = 0
                    afflic1 = 0
                Else
                    parachance = (Rnd() * 6 + 1)
                    If parachance < 4 Then
                        Console.WriteLine(p1name + " is unable to act due to paralysis.")
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
                    Console.WriteLine(p1name + " clears thier head of confusion.")
                    confcount = 0
                    afflic1 = 0
                Else
                    confact = (Rnd() * 6 + 1)
                    Select Case confact
                        Case 1
                            Console.WriteLine(p1name + "attacks in confusion!")
                            confdam = Int((Rnd() * (p1str) + 1) - (Rnd() * p2bloc + 1))
                            Console.WriteLine(p1name + " has dealt " + CStr(confdam) + " damage to " + p2name)
                            p2HP = (p2HP - confdam)
                        Case 2
                            Console.WriteLine(p1name + " casts in confusion!")
                            sklsel = (Rnd() * 5 + 1)
                            Select Case p1class
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
                            Console.WriteLine(p1name + " uses a item in confusion!")

                        Case 4
                            Console.WriteLine(p1name + " defends in confusion!")
                            p1bloc = (p1bloc + 5)
                            def1 = 1
                        Case 5
                            Console.WriteLine(p1name + " is to confused to act!")
                        Case 6
                            Console.WriteLine(p1name + " attacks themselves in a fit of confusion!")
                            confdam = Int((Rnd() * (p1str) + 1) - (Rnd() * p1bloc + 1))
                            Console.WriteLine(p1name + " has dealt " + CStr(confdam) + " damage to themselves!")
                            p1HP = (p1HP - confdam)
                    End Select
                    confcount = (confcount + 1)
                End If
            Case 6
                'doom'
                If doomcount > 4 Then
                    p1HP = 0
                Else
                    doomcount = (doomcount + 1)
                    creepdoom = (5 - doomcount)
                    Console.WriteLine("The creeping doom approaches! It will get you in " + CStr(creepdoom) + " turns...")
                End If
            Case 7
                'Burned'
                If burcount > 4 Then
                    Console.WriteLine(p1name + " has been extinguised.")
                    p1str = (p1str + 3)
                    burcount = 0
                    afflic1 = 0
                ElseIf burcount = 0 Then
                    burdam = Int(Rnd() * 20 + 1)
                    p1HP = (p1HP - burdam)
                    p1str = (p1str - 3)
                    Console.WriteLine(p1name + " has taken " + CStr(burdam) + " points worth of burn damage.")
                    bleecount = (bleecount + 1)
                Else
                    p1HP = (p1HP - burdam)
                    Console.WriteLine(p1name + " has taken " + CStr(burdam) + " points worth of burn damage.")
                    bleecount = (bleecount + 1)
                End If
            Case 8
                'Drench'
                If drencount > 4 Then
                    Console.WriteLine(p1name + " has dried.")
                    drencount = 0
                    afflic1 = 0
                ElseIf drencount = 0 Then
                    drendra = Int(Rnd() * 30 + 1)
                    p1MP = (p1MP - drendra)
                    Console.WriteLine(p1name + " has taken " + CStr(drendra) + " mana points worth of drench damage.")
                    drencount = (drencount + 1)
                Else
                    p1MP = (p1MP - drendra)
                    Console.WriteLine(p1name + " has taken " + CStr(drendra) + " mana points worth of drench damage.")
                    drencount = (drencount + 1)
                End If
            Case 9
                'Time stop'
                If Timcount > 3 Then
                    Console.WriteLine("Time has returned for " + p1name)
                    afflic1 = 0
                    Timcount = 0
                Else
                    Console.WriteLine("Time has stopped for " + p1name)
                    Timcount = (Timcount + 1)
                End If
            Case 10
                'Soul lock'
                If SLCount > 4 Then
                    Console.WriteLine(p1name + " has broken all the Soul Locks! They are no longer Soul Locked!")
                    SLCount = 0
                    afflic1 = 0
                ElseIf SLCount < 4 Then
                    Console.WriteLine(p1name + " has broken a Soul Lock! There are " + CStr((5 - SLCount)) + " Soul Locks left!")
                    SLCount = (SLCount + 1)
                End If
            Case Else
                Call play1()
        End Select
        If p1HP <= 0 Then
            Call ending()
        End If
        Console.ReadLine()
        Call play1()
    End Sub
    Sub play1()
        Dim dam1 As Integer
        Dim menac1 As Integer
        Dim blicount As Integer
        Dim blichance As Integer
        Randomize()

        Console.WriteLine("Please select action " + p1name)
        Console.WriteLine("1. Attack")
        Console.WriteLine("2. Abilities")
        Console.WriteLine("3. Items")
        Console.WriteLine("4. Defend")
        Console.WriteLine("5. See stats")
        menac1 = Console.ReadLine()
        Select Case menac1
            Case 1
                If afflic1 = 4 Then
                    If blicount > 4 Then
                        Console.WriteLine(p1name + " recovers from blindness.")
                        blicount = 0
                        dam1 = Int((Rnd() * (p1str) + 1) - (Rnd() * p2bloc + 1))
                        Console.WriteLine(p1name + " has dealt " + CStr(dam1) + " damage to " + p2name)
                        p2HP = (p2HP - dam1)
                    Else
                        blichance = (Rnd() * 6 + 1)
                        If blichance < 4 Then
                            Console.WriteLine(p1name + " misses due to blindness!")
                            blicount = (blicount + 1)
                        Else
                            dam1 = Int((Rnd() * (p1str) + 1) - (Rnd() * p2bloc + 1))
                            Console.WriteLine(p1name + " has dealt " + CStr(dam1) + " damage to " + p2name)
                            p2HP = (p2HP - dam1)
                            blicount = (blicount + 1)
                        End If
                    End If
                Else
                    dam1 = Int((Rnd() * (p1str) + 1) - (Rnd() * p2bloc + 1))
                    Console.WriteLine(p1name + " has dealt " + CStr(dam1) + " damage to " + p2name)
                    p2HP = (p2HP - dam1)
                End If
                Console.ReadLine()
            Case 2
                Call ab1()
            Case 3
                Console.WriteLine("Please select the item you wish to use.")
                itemchoice1 = Console.ReadLine()
                Call it1()
            Case 4
                Console.WriteLine(p1name + " defends.")
                p1bloc = (p1bloc + 5)
                def1 = 1
            Case 5
                Console.WriteLine(p1name + "'s stats:")
                Console.WriteLine("Health: " + CStr(p1HP))
                Console.WriteLine("Mana: " + CStr(p1MP))
                Console.WriteLine("Strength: " + CStr(p1str))
                Console.WriteLine("Luck: " + CStr(p1luk))
                Console.WriteLine("Intelligence: " + CStr(p1int))
                Console.WriteLine("Agility: " + CStr(p1agi))
                Console.WriteLine("Defence: " + CStr(p1bloc))
                Console.ReadLine()
                Console.Clear()
                Call play1()
        End Select

        Console.Clear()
        If p2HP <= 0 Then
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
            Console.WriteLine(p2name + " relinquishes thier defence.")
            p2bloc = p2def
        End If
        Select Case afflic2
            Case 1
                'poison'
                If poicount2 > 4 Then
                    Console.WriteLine(p2name + " has treated the poison.")
                    poicount2 = 0
                    afflic2 = 0
                ElseIf poicount2 = 0 Then
                    poidam2 = Int(Rnd() * 30 + 1)
                    p2HP = (p2HP - poidam2)
                    Console.WriteLine(p2name + " has taken " + CStr(poidam2) + " points worth of poison damage.")
                    poicount2 = (poicount2 + 1)
                Else
                    p2HP = (p2HP - poidam2)
                    Console.WriteLine(p2name + " has taken " + CStr(poidam2) + " points worth of poison damage.")
                    poicount2 = (poicount2 + 1)
                End If
            Case 2
                'bleed'
                If bleecount2 > 4 Then
                    Console.WriteLine(p2name + " has stopped bleeding.")
                    bleecount2 = 0
                    afflic2 = 0
                ElseIf bleecount2 = 0 Then
                    bleedam2 = Int(Rnd() * 20 + 1)
                    p1HP = (p2HP - bleedam2)
                    Console.WriteLine(p2name + " has taken " + CStr(bleedam2) + " points worth of bleed damage.")
                    bleecount2 = (bleecount2 + 1)
                Else
                    p2HP = (p2HP - bleedam2)
                    Console.WriteLine(p2name + " has taken " + CStr(bleedam2) + " points worth of bleed damage.")
                    bleecount2 = (bleecount2 + 1)
                End If
            Case 3
                'paralasys'
                If paracount2 > 4 Then
                    Console.WriteLine(p2name + " has regained movement.")
                    paracount2 = 0
                    afflic2 = 0
                Else
                    parachance2 = (Rnd() * 6 + 1)
                    If parachance2 < 4 Then
                        Console.WriteLine(p2name + " is unable to act due to paralysis.")
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
                    Console.WriteLine(p2name + " clears thier head of confusion.")
                    confcount2 = 0
                    afflic1 = 0
                Else
                    confact2 = (Rnd() * 6 + 1)
                    Select Case confact2
                        Case 1
                            Console.WriteLine(p2name + "attacks in confusion!")
                            confdam2 = Int((Rnd() * (p2str) + 1) - (Rnd() * p1bloc + 1))
                            Console.WriteLine(p2name + " has dealt " + CStr(confdam2) + " damage to " + p1name)
                            p1HP = (p1HP - confdam2)
                        Case 2
                            Console.WriteLine(p2name + " casts in confusion!")
                            sklsel = (Rnd() * 5 + 1)
                            Select Case p2class
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
                            Console.WriteLine(p2name + " uses a item in confusion!")

                        Case 4
                            Console.WriteLine(p2name + " defends in confusion!")
                            p2bloc = (p2bloc + 5)
                            def2 = 1
                        Case 5
                            Console.WriteLine(p2name + " is to confused to act!")
                        Case 6
                            Console.WriteLine(p2name + " attacks themselves in a fit of confusion!")
                            confdam2 = Int((Rnd() * (p2str) + 1) - (Rnd() * p2bloc + 1))
                            Console.WriteLine(p2name + " has dealt " + CStr(confdam2) + " damage to themselves!")
                            p2HP = (p2HP - confdam2)
                    End Select
                    confcount2 = (confcount2 + 1)
                End If
            Case 6
                'doom'
                If doomcount2 > 4 Then
                    p1HP = 0
                Else
                    doomcount2 = (doomcount2 + 1)
                    creepdoom2 = (5 - doomcount2)
                    Console.WriteLine("The creeping doom approaches! It will get you in " + CStr(creepdoom2) + " turns...")
                End If
            Case 7
                'Burned'
                If burcount2 > 4 Then
                    Console.WriteLine(p2name + " has been extinguised.")
                    p2str = (p2str + 3)
                    burcount2 = 0
                    afflic2 = 0
                ElseIf burcount2 = 0 Then
                    burdam2 = Int(Rnd() * 20 + 1)
                    p2HP = (p2HP - burdam2)
                    p2str = (p2str - 3)
                    Console.WriteLine(p2name + " has taken " + CStr(burdam2) + " points worth of burn damage.")
                    bleecount2 = (bleecount2 + 1)
                Else
                    p2HP = (p2HP - burdam2)
                    Console.WriteLine(p2name + " has taken " + CStr(burdam2) + " points worth of burn damage.")
                    bleecount2 = (bleecount2 + 1)
                End If
            Case 8
                'Drench'
                If drencount2 > 4 Then
                    Console.WriteLine(p2name + " has dried.")
                    drencount2 = 0
                    afflic2 = 0
                ElseIf drencount2 = 0 Then
                    drendra2 = Int(Rnd() * 20 + 1)
                    p2MP = (p2MP - drendra2)
                    Console.WriteLine(p2name + " has taken " + CStr(drendra2) + " mana points worth of drench damage.")
                    drencount2 = (drencount2 + 1)
                Else
                    p2MP = (p2MP - drendra2)
                    Console.WriteLine(p2name + " has taken " + CStr(drendra2) + " mana points worth of drench damage.")
                    drencount2 = (drencount2 + 1)
                End If
            Case 9
                'Time stop'
                If Timcount2 > 3 Then
                    Console.WriteLine("Time has returned for " + p2name)
                    afflic2 = 0
                    Timcount2 = 0
                Else
                    Console.WriteLine("Time has stopped for " + p2name)
                    Timcount2 = (Timcount2 + 1)
                End If
            Case 10
                'Soul lock'
                If SLcount2 > 4 Then
                    Console.WriteLine(p2name + " has broken all the Soul Locks! They are no longer Soul Locked!")
                    SLcount2 = 0
                    afflic2 = 0
                ElseIf SLcount2 < 4 Then
                    Console.WriteLine(p2name + " has broken a Soul Lock! There are " + CStr((5 - SLcount2)) + " Soul Locks left!")
                    SLcount2 = (SLcount2 + 1)
                End If
            Case Else
                Call play2()
        End Select
        If p2HP <= 0 Then
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

        Console.WriteLine("Please select action " + p2name)
        Console.WriteLine("1. Attack")
        Console.WriteLine("2. Abilities")
        Console.WriteLine("3. Items")
        Console.WriteLine("4. Defend")
        Console.WriteLine("5. See stats")
        menac2 = Console.ReadLine()
        Select Case menac2
            Case 1
                If afflic2 = 4 Then
                    If blicount2 > 4 Then
                        Console.WriteLine(p2name + " recovers from blindness.")
                        blicount2 = 0
                        dam2 = Int((Rnd() * (p2str) + 1) - (Rnd() * p1bloc + 1))
                        Console.WriteLine(p2name + " has dealt " + CStr(dam2) + " damage to " + p1name)
                        p1HP = (p1HP - dam2)
                    Else
                        blichance2 = (Rnd() * 6 + 1)
                        If blichance2 < 4 Then
                            Console.WriteLine(p2name + " misses due to blindness!")
                            blicount2 = (blicount2 + 1)
                        Else
                            dam2 = Int((Rnd() * (p2str) + 1) - (Rnd() * p1bloc + 1))
                            Console.WriteLine(p2name + " has dealt " + CStr(dam2) + " damage to " + p1name)
                            p1HP = (p1HP - dam2)
                            blicount2 = (blicount2 + 1)
                        End If
                    End If
                Else
                    dam2 = Int((Rnd() * (p2str) + 1) - (Rnd() * p1bloc + 1))
                    Console.WriteLine(p2name + " has dealt " + CStr(dam2) + " damage to " + p1name)
                    p1HP = (p1HP - dam2)
                End If
                Console.ReadLine()
            Case 2
                Call ab2()
            Case 3
                Console.WriteLine("Please select the item you wish to use.")
                itemchoice2 = Console.ReadLine()
                Call it2()
            Case 4
                Console.WriteLine(p2name + " defends.")
                p2bloc = (p2bloc + 5)
                def2 = 1
            Case 5
                Console.WriteLine(p2name + "'s stats:")
                Console.WriteLine("Health: " + CStr(p2HP))
                Console.WriteLine("Mana: " + CStr(p2MP))
                Console.WriteLine("Strength: " + CStr(p2str))
                Console.WriteLine("Luck: " + CStr(p2luk))
                Console.WriteLine("Intelligence: " + CStr(p2int))
                Console.WriteLine("Agility: " + CStr(p2agi))
                Console.WriteLine("Defence: " + CStr(p2bloc))
                Console.ReadLine()
                Console.Clear()
                Call play2()
        End Select

        Console.Clear()
        If p1HP <= 0 Then
            Call ending()
        End If
        Call pre1()
    End Sub
    Sub ab1()
        Randomize()

        If afflic1 = 10 Then
            Console.WriteLine("The Soul Lock on you prevents you from using your abilities!")
            Console.ReadLine()
            Console.Clear()
            Call play1()
        Else
            Console.WriteLine("Current mana: " + CStr(p1MP))
            Select Case p1class
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
        If afflic2 = 10 Then
            Console.WriteLine("The Soul Locks on you prevent you from using your abilities!")
            Console.ReadLine()
            Console.Clear()
            Call play2()
        Else
            Console.WriteLine("Current mana: " + CStr(p2MP))
            Select Case p2class
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
        Select Case itemchoice1
            Case 1
                'potion'
                hprecov = (Rnd() * 30 + 1)
                p1HP = (p1HP + hprecov)
                Console.WriteLine("The potion heals " + p1name + " for " + CStr(hprecov) + " health points.")
            Case 2
                'mana potion'
                mprecov = (Rnd() * 30 + 1)
                p1MP = (p1MP + mprecov)
                Console.WriteLine("The mana potion heals " + p1name + " for " + CStr(mprecov) + " mana points.")
            Case 3
                'Refresh crystal'
                afflic1 = 0
                Console.WriteLine("The crystal heals " + p1name + " of thier status conditions.")
            Case 4
                'Mystery'
                mystery = (Rnd() * 10 + 1)
                Select Case mystery
                    Case 1
                        Console.WriteLine("The mystery was a potion!")
                        hprecov = (Rnd() * 30 + 1)
                        p1HP = (p1HP + hprecov)
                        Console.WriteLine("The potion heals " + p1name + " for " + CStr(hprecov) + " health points.")
                    Case 2
                        Console.WriteLine("The mystery was a mana potion!")
                        'mana potion'
                        mprecov = (Rnd() * 30 + 1)
                        p1MP = (p1MP + mprecov)
                        Console.WriteLine("The mana potion heals " + p1name + " for " + CStr(mprecov) + " mana points.")
                    Case 3
                        Console.WriteLine("The mystery was a refresh crystal!")
                        afflic1 = 0
                        Console.WriteLine("The crystal heals " + p1name + " of thier status conditions.")
                    Case 4
                        Console.WriteLine("The mystery was a defence up!")
                        p1def = (p1def + 2)
                    Case 4
                        Console.WriteLine("The mystery was an attack increase!")
                        p1str = (p1str + 2)
                    Case 5
                        Console.WriteLine("The mystery was a throwing bomb!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p2bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p2name)
                        p2HP = (p2HP - dam1)
                    Case 6
                        Console.WriteLine("The mystery was a trap bomb! Oh no!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p1bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p1name)
                        p1HP = (p1HP - dam1)
                    Case 7
                        Console.WriteLine("The mystery was a megalixier!")
                        mprecov = (Rnd() * 50 + 1)
                        p1MP = (p1MP + mprecov)
                        hprecov = (Rnd() * 50 + 1)
                        p1HP = (p1HP + hprecov)
                        Console.WriteLine("The megalixier healed " + p1name + " for " + CStr(hprecov) + " health points and " + CStr(mprecov) + " mana points.")
                    Case 8
                        Console.WriteLine("The mystery was a healing ring!")
                        hprecov = (Rnd() * 20 + 1)
                        p1HP = (p1HP + hprecov)
                        Console.WriteLine(p1name + " gains " + CStr(hprecov) + " health points.")
                        hprecov2 = (Rnd() * 20 + 1)
                        p2HP = (p2HP + hprecov2)
                        Console.WriteLine(p2name + " gains " + CStr(hprecov2) + " health points.")
                    Case 9
                        Console.WriteLine("The mystery was a mana ring!")
                        mprecov = (Rnd() * 20 + 1)
                        p1MP = (p1MP + mprecov)
                        Console.WriteLine(p1name + " gains " + CStr(mprecov) + " mana points.")
                        mprecov2 = (Rnd() * 20 + 1)
                        p2MP = (p2MP + mprecov2)
                        Console.WriteLine(p1name + " gains " + CStr(mprecov) + " mana points.")
                    Case 10
                        Console.WriteLine("The mystery was a random affliction bomb.")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                afflic2 = 1
                                Console.WriteLine("The bomb inflicts Poison on " + p2name)
                            Case 2
                                afflic2 = 2
                                Console.WriteLine("The bomb inflicts Bleed on " + p2name)
                            Case 3
                                afflic2 = 3
                                Console.WriteLine("The bomb inflicts Paralysis on " + p2name)
                            Case 4
                                afflic2 = 4
                                Console.WriteLine("The bomb inflicts Blind on " + p2name)
                            Case 5
                                afflic2 = 5
                                Console.WriteLine("The bomb inflicts Confusion on " + p2name)
                            Case 6
                                afflic2 = 10
                                Console.WriteLine("The bomb inflicts Soul Lock on " + p2name)
                            Case 7
                                afflic2 = 7
                                Console.WriteLine("The bomb inflicts Burn on " + p2name)
                            Case 8
                                afflic2 = 8
                                Console.WriteLine("The bomb inflicts Drench on " + p2name)
                            Case 9
                                afflic2 = 9
                                Console.WriteLine("The bomb inflicts Time Stop on " + p2name)
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
        Select Case itemchoice1
            Case 1
                'potion'
                hprecov = (Rnd() * 30 + 1)
                p2HP = (p2HP + hprecov)
                Console.WriteLine("The potion heals " + p2name + " for " + CStr(hprecov) + " health points.")
            Case 2
                'mana potion'
                mprecov = (Rnd() * 30 + 1)
                p2MP = (p2MP + mprecov)
                Console.WriteLine("The mana potion heals " + p2name + " for " + CStr(mprecov) + " mana points.")
            Case 3
                'Refresh crystal'
                afflic2 = 0
                Console.WriteLine("The crystal heals " + p2name + " of thier status conditions.")
            Case 4
                'Mystery'
                mystery = (Rnd() * 10 + 1)
                Select Case mystery
                    Case 1
                        Console.WriteLine("The mystery was a potion!")
                        hprecov = (Rnd() * 30 + 1)
                        p2HP = (p2HP + hprecov)
                        Console.WriteLine("The potion heals " + p2name + " for " + CStr(hprecov) + " health points.")
                    Case 2
                        Console.WriteLine("The mystery was a mana potion!")
                        'mana potion'
                        mprecov = (Rnd() * 30 + 1)
                        p2MP = (p2MP + mprecov)
                        Console.WriteLine("The mana potion heals " + p2name + " for " + CStr(mprecov) + " mana points.")
                    Case 3
                        Console.WriteLine("The mystery was a refresh crystal!")
                        afflic2 = 0
                        Console.WriteLine("The crystal heals " + p2name + " of thier status conditions.")
                    Case 4
                        Console.WriteLine("The mystery was a defence up!")
                        p2def = (p2def + 2)
                    Case 4
                        Console.WriteLine("The mystery was an attack increase!")
                        p2str = (p2str + 2)
                    Case 5
                        Console.WriteLine("The mystery was a throwing bomb!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p1bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p1name)
                        p1HP = (p1HP - dam1)
                    Case 6
                        Console.WriteLine("The mystery was a trap bomb! Oh no!")
                        dam1 = Int((Rnd() * (30) + 1) - (Rnd() * p2bloc + 1))
                        Console.WriteLine("The bomb has dealt " + CStr(dam1) + " damage to " + p2name)
                        p2HP = (p2HP - dam1)
                    Case 7
                        Console.WriteLine("The mystery was a megalixier!")
                        mprecov = (Rnd() * 50 + 1)
                        p2MP = (p2MP + mprecov)
                        hprecov = (Rnd() * 50 + 1)
                        p2HP = (p2HP + hprecov)
                        Console.WriteLine("The megalixier healed " + p2name + " for " + CStr(hprecov) + " health points and " + CStr(mprecov) + " mana points.")
                    Case 8
                        Console.WriteLine("The mystery was a healing ring!")
                        hprecov = (Rnd() * 20 + 1)
                        p2HP = (p2HP + hprecov)
                        Console.WriteLine(p2name + " gains " + CStr(hprecov) + " health points.")
                        hprecov2 = (Rnd() * 20 + 1)
                        p1HP = (p1HP + hprecov2)
                        Console.WriteLine(p1name + " gains " + CStr(hprecov2) + " health points.")
                    Case 9
                        Console.WriteLine("The mystery was a mana ring!")
                        mprecov = (Rnd() * 20 + 1)
                        p2MP = (p2MP + mprecov)
                        Console.WriteLine(p2name + " gains " + CStr(mprecov) + " mana points.")
                        mprecov2 = (Rnd() * 20 + 1)
                        p1MP = (p1MP + mprecov2)
                        Console.WriteLine(p1name + " gains " + CStr(mprecov2) + " mana points.")
                    Case 10
                        Console.WriteLine("The mystery was a random affliction bomb.")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                afflic1 = 1
                                Console.WriteLine("The bomb inflicts Poison on " + p1name)
                            Case 2
                                afflic1 = 2
                                Console.WriteLine("The bomb inflicts Bleed on " + p1name)
                            Case 3
                                afflic1 = 3
                                Console.WriteLine("The bomb inflicts Paralysis on " + p1name)
                            Case 4
                                afflic1 = 4
                                Console.WriteLine("The bomb inflicts Blind on " + p1name)
                            Case 5
                                afflic1 = 5
                                Console.WriteLine("The bomb inflicts Confusion on " + p1name)
                            Case 6
                                afflic1 = 10
                                Console.WriteLine("The bomb inflicts Soul Lock on " + p1name)
                            Case 7
                                afflic1 = 7
                                Console.WriteLine("The bomb inflicts Burn on " + p1name)
                            Case 8
                                afflic1 = 8
                                Console.WriteLine("The bomb inflicts Drench on " + p1name)
                            Case 9
                                afflic1 = 9
                                Console.WriteLine("The bomb inflicts Time Stop on " + p1name)
                        End Select
                End Select
        End Select
    End Sub
    Sub ending()
    End Sub
    Sub warskl1()

        Randomize()

        Select Case sklsel
            Case 1
                If p1MP > 2 Then
                    p1MP = (p1MP - 3)
                    p1str = (p1str + 2)
                    Console.WriteLine(p1name + " casts Blade up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1MP > 4 Then
                    p1MP = (p1MP - 5)
                    p1HP = (p1HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p1name + " uses Rations.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    p2HP = (p2HP - Int(Rnd() * (p1str) + Int(p1str / 4)))
                    Console.WriteLine(p1name + " uses Strong strike.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1MP > 3 Then
                    p1MP = (p1MP - 4)
                    p2str = Int(p2str - 2)
                    Console.WriteLine(p1name + " casts Defence up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1MP > 6 Then
                    p1MP = (p1MP - 7)
                    afflic2 = 2
                    Console.WriteLine(p1name + " uses Haemorrhage .")
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
                If p1MP > 2 Then
                    p1MP = (p1MP - 3)
                    p2HP = (p2HP - (Rnd() * (p1int) + 1))
                    Console.WriteLine(p1name + " casts Fireball.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1MP > 4 Then
                    p1MP = (p1MP - 5)
                    p1HP = (p1HP + (Rnd() * (p1int) + 1))
                    Console.WriteLine(p1name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    p1HP = (p1HP + (Rnd() * (p1int) + 1))
                    p2HP = (p2HP - Rnd() * (p1int) + 1)
                    Console.WriteLine(p1name + " casts Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1MP > 14 Then
                    p1MP = (p1MP - 15)
                    p1MP = (p1MP + (Rnd() * 10 + 1))
                    p2MP = (p2MP - Rnd() * 10 + 1)
                    Console.WriteLine(p1name + " casts Mana Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    p2HP = (p2HP - (p1int + (Rnd() * (p1luk) + 1)))
                    Console.WriteLine(p1name + " casts Meteor.")
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
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    afflic2 = 4
                    Console.WriteLine(p1name + " casts Invisibility.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1MP > 14 Then
                    p1MP = (p1MP - 15)
                    p2HP = (p2HP - (((Rnd() * 10 + 1) + (Rnd() * 10 + 1) + (Rnd() * 10 + 1))))
                    Console.WriteLine(p1name + " uses Blade storm.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    p2HP = (p2HP - (Rnd() * (p1luk) + 1))
                    Console.WriteLine(p1name + " casts Wave of death.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1MP > 13 Then
                    p1MP = (p1MP - 14)
                    p2HP = (p2HP - (Rnd() * 20 + 1))
                    afflic2 = 2
                    Console.WriteLine(p1name + " casts Cloak and dagger.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    p2HP = (p2HP - (Rnd() * (p1str) + 1))
                    p2str = Int(p2str - (Rnd() * 5 + 1))
                    Console.WriteLine(p1name + " uses Dark slice.")
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
                If p1MP > 4 Then
                    p1MP = (p1MP - 5)
                    p1HP = (p1HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p1name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1MP > 14 Then
                    p1MP = (p1MP - 15)
                    p1HP = (p1HP + (Rnd() * 20 + 1))
                    Console.WriteLine(p1name + " casts Greater heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    afflic1 = 0
                    Console.WriteLine(p1name + " casts Refresh.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1MP > 9 Then
                    p1MP = (p1MP - 10)
                    p2HP = (p2HP - (Rnd() * 15))
                    Console.WriteLine(p1name + " casts Purify.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1MP > 19 Then
                    p1MP = (p1MP - 20)
                    p2HP = (p2HP - (Rnd() * 20 + 1))
                    afflic2 = 4
                    Console.WriteLine(p1name + " casts Sanctify.")
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
                If p2MP > 4 Then
                    p2MP = (p2MP - 5)
                    p1luk = Int(p1luk - 1)
                    p2luk = (p2luk + 1)
                    Console.WriteLine(p2name + " casts Luck drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2MP > 6 Then
                    p2MP = (p2MP - 7)
                    p1luk = 1
                    Console.WriteLine(p2name + " casts Luck bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2MP > 11 Then
                    p2MP = (p2MP - 12)
                    p1str = 1
                    Console.WriteLine(p2name + " casts Strength bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2MP > 21 Then
                    p2MP = (p2MP - 22)
                    afflic1 = 10
                    Console.WriteLine(p2name + " casts Magic bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2MP > 29 Then
                    p2MP = (p2MP - 30)
                    p2MP = (p2MP + (Rnd() * (p2luk) + 1))
                    p2HP = (p2HP + (Rnd() * (p2luk) + 1))
                    p2str = (p2str + (Rnd() * (p2luk) + 1))
                    p2luk = (p2luk + (Rnd() * (p2luk) + 1))
                    Console.WriteLine(p2name + " casts Invoking power.")
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
                If p1MP > 19 Then
                    p1MP = (p1MP - 20)
                    p2HP = (p2HP - (20 + Rnd() * (p1int) + 1))
                    afflic2 = 7
                    Console.WriteLine(p1name + " summons Promethian.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1MP > 19 Then
                    p1MP = (p1MP - 20)
                    p2HP = (p2HP - (20 + Rnd() * (p1int) + 1))
                    afflic2 = 7
                    Console.WriteLine(p1name + " summons Girtablulu.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1MP > 19 Then
                    p1MP = (p1MP - 20)
                    p2HP = (p2HP - (20 + Rnd() * (p1int) + 1))
                    afflic2 = 7
                    Console.WriteLine(p1name + " summons Alucard.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1MP > 19 Then
                    p1MP = (p1MP - 20)
                    p2HP = (p2HP - (20 + Rnd() * (p1int) + 1))
                    afflic2 = 8
                    Console.WriteLine(p1name + " summons Ziasudra.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1MP > 19 Then
                    p1MP = (p1MP - 20)
                    p2HP = (p2HP - (20 + Rnd() * (p1int) + 1))
                    afflic2 = 9
                    Console.WriteLine(p1name + " summons Tempus.")
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
                If p1MP > 4 Then
                    p1MP = (p1MP - 5)
                    p1HP = (p1HP + (Rnd() * 20 + 1))
                    p2HP = (p2HP - (Rnd() * 20))
                    Console.WriteLine(p1name + " casts Vampire.")
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If p1HP > 14 Then
                    p1HP = (p1HP - 15)
                    p2HP = (p2HP - (Rnd() * 20 + 1))
                    Console.WriteLine(p1name + " casts Bloody strike.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 3
                If p1HP > 19 Then
                    p1HP = (p1HP - 20)
                    Console.WriteLine(p1name + " casts Blood letting.")
                    p1agi = (p1agi + 2)
                    p1def = (p1def + 2)
                    p1int = (p1int + 2)
                    p1luk = (p1luk + 2)
                    p1str = (p1str + 2)
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 4
                If p1HP > 24 Then
                    p1HP = (p1HP - 25)
                    p2agi = (p2agi - 2)
                    p2def = (p2def - 2)
                    p2int = (p2int - 2)
                    p2luk = (p2luk - 2)
                    p2str = (p2str - 2)
                    Console.WriteLine(p1name + " casts Overburden.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 5
                If p1HP > 99 Then
                    p1HP = (p1HP - 100)
                    If afflic2 = 1 Then
                        p2HP = p2HP - (Rnd() * 50 + 1)
                    End If
                    afflic2 = 6
                    Console.WriteLine(p1name + " casts Annihilation.")
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
                If p2MP > 2 Then
                    p2MP = (p2MP - 3)
                    p2str = (p2str + 2)
                    Console.WriteLine(p2name + " casts Blade up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2MP > 4 Then
                    p2MP = (p2MP - 5)
                    p2HP = (p2HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p2name + " uses Rations.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2MP > 9 Then
                    p2MP = (p2MP - 10)
                    p1HP = (p1HP - Int(Rnd() * (p2str) + Int(p2str / 4)))
                    Console.WriteLine(p2name + " uses Strong strike.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2MP > 3 Then
                    p2MP = (p2MP - 4)
                    p1str = Int(p1str - 2)
                    Console.WriteLine(p2name + " casts Defence up.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2MP > 6 Then
                    p2MP = (p2MP - 7)
                    afflic1 = 2
                    Console.WriteLine(p2name + " uses Haemorrhage .")
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
                If p2MP > 2 Then
                    p2MP = (p2MP - 3)
                    p1HP = (p1HP - (Rnd() * (p2int) + 1))
                    Console.WriteLine(p2name + " casts Fireball.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2MP > 4 Then
                    p2MP = (p2MP - 5)
                    p2HP = (p2HP + (Rnd() * (p2int) + 1))
                    Console.WriteLine(p2name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2MP > 9 Then
                    p1MP = (p2MP - 10)
                    p2HP = (p1HP + (Rnd() * (p2int) + 1))
                    p1HP = (p1HP - Rnd() * (p2int) + 1)
                    Console.WriteLine(p2name + " casts Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2MP > 14 Then
                    p2MP = (p2MP - 15)
                    p2MP = (p2MP + (Rnd() * 10 + 1))
                    p1MP = (p1MP - Rnd() * 10 + 1)
                    Console.WriteLine(p2name + " casts Mana Drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2MP > 9 Then
                    p2MP = (p2MP - 10)
                    p1HP = (p1HP - (p2int + (Rnd() * (p2luk) + 1)))
                    Console.WriteLine(p2name + " casts Meteor.")
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
                If p2MP > 9 Then
                    p2MP = (p2MP - 10)
                    afflic1 = 4
                    Console.WriteLine(p2name + " casts Invisibility.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2MP > 14 Then
                    p2MP = (p2MP - 15)
                    p1HP = (p1HP - (((Rnd() * 10 + 1) + (Rnd() * 10 + 1) + (Rnd() * 10 + 1))))
                    Console.WriteLine(p2name + " uses Blade storm.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2MP > 9 Then
                    p2MP = (p2MP - 10)
                    p1HP = (p1HP - (Rnd() * (p2luk) + 1))
                    Console.WriteLine(p2name + " casts Wave of death.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2MP > 13 Then
                    p2MP = (p2MP - 14)
                    p1HP = (p1HP - (Rnd() * 20 + 1))
                    afflic1 = 2
                    Console.WriteLine(p1name + " casts Cloak and dagger.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2MP > 9 Then
                    p2MP = (p2MP - 10)
                    p1HP = (p1HP - (Rnd() * (p2str) + 1))
                    p1str = Int(p1str - (Rnd() * 5 + 1))
                    Console.WriteLine(p2name + " uses Dark slice.")
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
                If p2MP > 4 Then
                    p2MP = (p2MP - 5)
                    p2HP = (p2HP + (Rnd() * 10 + 1))
                    Console.WriteLine(p2name + " casts Heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2MP > 14 Then
                    p2MP = (p2MP - 15)
                    p2HP = (p2HP + (Rnd() * 20 + 1))
                    Console.WriteLine(p1name + " casts Greater heal.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2MP > 9 Then
                    p2MP = (p2MP - 10)
                    afflic2 = 0
                    Console.WriteLine(p2name + " casts Refresh.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2MP > 9 Then
                    p2MP = (p2MP - 10)
                    p1HP = (p1HP - (Rnd() * 15))
                    Console.WriteLine(p2name + " casts Purify.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2MP > 19 Then
                    p2MP = (p2MP - 20)
                    p1HP = (p1HP - (Rnd() * 20 + 1))
                    afflic1 = 4
                    Console.WriteLine(p2name + " casts Sanctify.")
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
                If p1MP > 4 Then
                    p1MP = (p1MP - 5)
                    p2luk = Int(p2luk - 1)
                    p1luk = (p1luk + 1)
                    Console.WriteLine(p1name + " casts Luck drain.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p1MP > 6 Then
                    p1MP = (p1MP - 7)
                    p2luk = 1
                    Console.WriteLine(p1name + " casts Luck bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p1MP > 11 Then
                    p1MP = (p1MP - 12)
                    p2str = 1
                    Console.WriteLine(p1name + " casts Strength bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p1MP > 21 Then
                    p1MP = (p1MP - 22)
                    afflic2 = 10
                    Console.WriteLine(p1name + " casts Magic bane.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p1MP > 29 Then
                    p1MP = (p1MP - 30)
                    p1MP = (p1MP + (Rnd() * (p1luk) + 1))
                    p1HP = (p1HP + (Rnd() * (p1luk) + 1))
                    p1str = (p1str + (Rnd() * (p1luk) + 1))
                    p1luk = (p1luk + (Rnd() * (p1luk) + 1))
                    Console.WriteLine(p1name + " casts Invoking power.")
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
                If p2MP > 19 Then
                    p2MP = (p2MP - 20)
                    p1HP = (p1HP - (20 + Rnd() * (p2int) + 1))
                    afflic1 = 7
                    Console.WriteLine(p2name + " summons Promethian.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 2
                If p2MP > 19 Then
                    p2MP = (p2MP - 20)
                    p1HP = (p1HP - (20 + Rnd() * (p2int) + 1))
                    afflic1 = 7
                    Console.WriteLine(p2name + " summons Girtablulu.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 3
                If p2MP > 19 Then
                    p2MP = (p2MP - 20)
                    p1HP = (p1HP - (20 + Rnd() * (p2int) + 1))
                    afflic1 = 7
                    Console.WriteLine(p2name + " summons Alucard.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 4
                If p2MP > 19 Then
                    p2MP = (p2MP - 20)
                    p1HP = (p1HP - (20 + Rnd() * (p2int) + 1))
                    afflic1 = 8
                    Console.WriteLine(p2name + " summons Ziasudra.")
                Else
                    Console.WriteLine("You do not have enough skill points to do that.")
                End If
            Case 5
                If p2MP > 19 Then
                    p2MP = (p2MP - 20)
                    p1HP = (p1HP - (20 + Rnd() * (p2int) + 1))
                    afflic1 = 9
                    Console.WriteLine(p2name + " summons Tempus.")
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
                If p2MP > 4 Then
                    p2MP = (p2MP - 5)
                    p2HP = (p2HP + (Rnd() * 20 + 1))
                    p1HP = (p1HP - (Rnd() * 20))
                    Console.WriteLine(p2name + " casts Vampire.")
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If p2HP > 14 Then
                    p2HP = (p2HP - 15)
                    p1HP = (p1HP - (Rnd() * 20 + 1))
                    Console.WriteLine(p2name + " casts Bloody strike.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 3
                If p2HP > 19 Then
                    p2HP = (p2HP - 20)
                    Console.WriteLine(p2name + " casts Blood letting.")
                    p2agi = (p2agi + 2)
                    p2def = (p2def + 2)
                    p2int = (p2int + 2)
                    p2luk = (p2luk + 2)
                    p2str = (p2str + 2)
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 4
                If p2HP > 24 Then
                    p2HP = (p2HP - 25)
                    p1agi = (p1agi - 2)
                    p1def = (p1def - 2)
                    p1int = (p1int - 2)
                    p1luk = (p1luk - 2)
                    p1str = (p1str - 2)
                    Console.WriteLine(p2name + " casts Overburden.")
                Else
                    Console.WriteLine("You do not have enough health points to do that.")
                End If
            Case 5
                If p2HP > 99 Then
                    p2HP = (p2HP - 100)
                    If afflic1 = 1 Then
                        p1HP = p1HP - (Rnd() * 50 + 1)
                    End If
                    afflic1 = 6
                    Console.WriteLine(p2name + " casts Annihilation.")
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
                Console.WriteLine("This console is an error. Please contact your system...                         zhisfhsaieduhgfiaushgfphgasiguhpaisdug Dpeiasr! 98y4ewqp9gt3wyhugerp873yg987e3")
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
        Console.WriteLine("7. Megalixier")
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
                Console.WriteLine("One of the best items. The megalixier will heal both HP an MP with a max value  of 50.")
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
                If p1MP >= 5 Then
                    p1MP = (p1MP - 5)
                    Console.WriteLine(p1name + " investigates for Truth Bullets.")
                    Truthbullet = (Truthbullet + Int(Rnd() * 5 + 1))
                    Console.WriteLine(p1name + " now has " + CStr(Truthbullet) + " Truth bullets.")
                Else
                    Console.WriteLine("You do not have enough mana.")
                End If
            Case 2
                If Truthbullet >= 1 Then
                    Truthbullet = (Truthbullet - 1)
                    chance = (Int(Rnd() * (10 - 1) + 1))
                    Console.WriteLine(p1name + " enters a discussion.")
                    Console.ReadLine()
                    Select Case chance
                        Case Is <= 3
                            Truthbullet = (Truthbullet - 3)
                            Console.WriteLine(p1name + ": I agree with that statement!")
                            p1HP = (p1HP + 5)
                            p2HP = (p2HP + 5)
                        Case Is <= 6
                            Console.WriteLine(p1name + ": You've got that wrong!")
                            p2HP = Int(p2HP - (Rnd() * 20 + 1))
                        Case Is <= 9
                            Console.WriteLine(p1name + ": You've got that right...?")
                            p2MP = Int(p2MP - (Truthbullet * 10))
                        Case 10
                            Console.WriteLine(p1name + ": Hope will defeat Despair!")
                            p2HP = Int(p2HP - (Asc(p2name) / 2))
                    End Select
                Else
                    Console.WriteLine("You do not have the required number of Truth Bullets.")
                End If
            Case 3
                If Truthbullet >= 5 Then
                    Truthbullet = (Truthbullet - 5)
                    Console.WriteLine(p1name + " plays a game of Hangman's Gambit.")
                    Console.ReadLine()
                    chance = (Rnd() * 10 + 1)
                    If chance <= 6 Then
                        Console.WriteLine(p1name + " wins the Hangman's gambit and inflicts the opponent with a stus effect.")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                afflic2 = 1
                                Console.WriteLine("Poison on " + p2name)
                            Case 2
                                afflic2 = 2
                                Console.WriteLine("Bleed on " + p2name)
                            Case 3
                                afflic2 = 3
                                Console.WriteLine("Paralysis on " + p2name)
                            Case 4
                                afflic2 = 4
                                Console.WriteLine("Blind on " + p2name)
                            Case 5
                                afflic2 = 5
                                Console.WriteLine("Confusion on " + p2name)
                            Case 6
                                afflic2 = 10
                                Console.WriteLine("Soul Lock on " + p2name)
                            Case 7
                                afflic2 = 7
                                Console.WriteLine("Burn on " + p2name)
                            Case 8
                                afflic2 = 8
                                Console.WriteLine("Drench on " + p2name)
                            Case 9
                                afflic2 = 9
                                Console.WriteLine("Time Stop on " + p2name)
                        End Select
                    Else
                        Console.WriteLine(p1name + " lost the Hangman's Gambit and must face punishment!")
                        rndaf = (Rnd() * 9 + 1)
                        Select Case rndaf
                            Case 1
                                afflic1 = 1
                                Console.WriteLine("Poison on " + p1name)
                            Case 2
                                afflic1 = 2
                                Console.WriteLine("Bleed on " + p1name)
                            Case 3
                                afflic1 = 3
                                Console.WriteLine("Paralysis on " + p1name)
                            Case 4
                                afflic1 = 4
                                Console.WriteLine("Blind on " + p1name)
                            Case 5
                                afflic1 = 5
                                Console.WriteLine("Confusion on " + p1name)
                            Case 6
                                afflic1 = 10
                                Console.WriteLine("Soul Lock on " + p1name)
                            Case 7
                                afflic1 = 7
                                Console.WriteLine("Burn on " + p1name)
                            Case 8
                                afflic1 = 8
                                Console.WriteLine("Drench on " + p1name)
                            Case 9
                                afflic1 = 9
                                Console.WriteLine("Time Stop on " + p1name)
                        End Select
                    End If
                Else
                    Console.WriteLine("You do not have the required number of Truth Bullets.")
                End If
            Case 4
                If Truthbullet >= 10 Then
                    Truthbullet = (Truthbullet - 10)
                    Console.WriteLine(p1name + " enters a Bullet time Battle with " + p2name)
                    If p1HP > p2HP Then
                        Console.WriteLine(p1name + " wins the Bullet Time Battle! Thier argument becomes stronger!")
                        p1str = (p1str + 5)
                    Else
                        Console.WriteLine(p1name + " loses the Bullet Time battle and must face Punishment!")
                        p1HP = Int(p1HP - Rnd() * 75 + 1)
                    End If
                Else
                    Console.WriteLine("You do not have the required number of Truth Bullets!")
                End If
            Case 5
                If UHBullet = 1 Then
                    UHBullet = (UHBullet - 1)
                    Console.WriteLine("You fire the 'Ultimate Hope' Truth bullet!")
                    Console.WriteLine("")
                    Console.WriteLine(p1name + " breaks throught the despair!")
                    p1HP = (p1HP + 20)
                    p1agi = (p1agi + 10)
                    p1str = (p1str + 10)
                    p1def = (p1def + 10)
                    p1int = (p1int + 10)
                    p1luk = (p1luk + 10)
                    p1MP = (p1MP + 20)
                Else
                    Console.WriteLine("You are missing the required Truth Bullet.")
                End If
            Case 6
                If UDBullet = 1 Then
                    UDBullet = (UDBullet - 1)
                    Console.WriteLine("You fire the 'Ultimate Despair' Truth Bullet!")
                    Console.WriteLine("")
                    Console.WriteLine(p2name + " has been found Guilty! Let's give it all we've got. It's punishment time!")
                    p2HP = 0
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
                If p1MP > 4 Then
                    p1MP = (p1MP - 5)
                    progfrg1 = (progfrg1 + (Rnd() * (20 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If progfrg1 >= 50 Then
                    progfrg1 = (progfrg1 - 20)
                    p1def = (p1def + (Rnd() * (10 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 3
                If progfrg1 >= 100 Then
                    progfrg1 = (progfrg1 - 100)
                    p2HP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 4
                If progfrg1 >= 75 Then
                    progfrg1 = (progfrg1 - 75)
                    p2MP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 5
                If progfrg1 >= 200 Then
                    progfrg1 = (progfrg1 - 200)
                    p2HP = (Rnd() * (100 - 1) + 1)
                    p2agi = (Rnd() * (50 - 1) + 1)
                    p2str = (Rnd() * (50 - 1) + 1)
                    p2def = (Rnd() * (50 - 1) + 1)
                    p2int = (Rnd() * (50 - 1) + 1)
                    p2luk = (Rnd() * (50 - 1) + 1)
                    p2MP = (Rnd() * (100 - 1) + 1)
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
                If p2MP > 4 Then
                    p2MP = (p2MP - 5)
                    progfrg2 = (progfrg2 + (Rnd() * (20 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough mana points to do that.")
                End If
            Case 2
                If progfrg2 >= 50 Then
                    progfrg2 = (progfrg2 - 20)
                    p2def = (p2def + (Rnd() * (10 - 1) + 1))
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 3
                If progfrg2 >= 100 Then
                    progfrg2 = (progfrg2 - 100)
                    p1HP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 4
                If progfrg2 >= 75 Then
                    progfrg2 = (progfrg2 - 75)
                    p1MP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
            Case 5
                If progfrg2 >= 200 Then
                    progfrg2 = (progfrg2 - 200)
                    p1HP = (Rnd() * (100 - 1) + 1)
                    p1agi = (Rnd() * (50 - 1) + 1)
                    p1str = (Rnd() * (50 - 1) + 1)
                    p1def = (Rnd() * (50 - 1) + 1)
                    p1int = (Rnd() * (50 - 1) + 1)
                    p1luk = (Rnd() * (50 - 1) + 1)
                    p1MP = (Rnd() * (100 - 1) + 1)
                Else
                    Console.WriteLine("You do not have enough ProgFrags to do that.")
                End If
        End Select
        Console.ReadLine()
    End Sub
End Module




