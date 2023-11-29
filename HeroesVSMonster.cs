using System;
namespace GameProject
{
    class LiQihangCode
    {
        static void Main()
        {
            //ASSIGNMENT OF CONSTANT STRING
            //Message for user:
            const string MsgGameMenu = "WELCOME TO HERO VS MONSTER! \nWhat do you want to do? \n1 - Play \n0 - Exit";
            const string MsgStartCreation = "Perfect! Let's create the characters:";
            const string MsgWrongValue = "The value is not valid.";
            const string MsgEndAttempt = "You have run out of attempts, Goodbye.";
            const string MsgIntroduceValue = "Introduce the next values:";
            const string MsgStartBattle = "The battle begins!";
            const string MsgSelectAction = "Select the action:";
            const string MsgBattleOptions = "1. Attack \n2. Protect \n3. Special ability";
            const string MsgTurnIndicator = "IT'S TURN: ";
            const string MsgVictoryFor = "The VICTORY is for the ";
            const string MsgHeroesTeam = "HEROES";
            const string MsgMonsterTeam = "MONSTER";
            //Battle registration message:
            const string MsgAttackTo = " attacks ";
            const string MsgReceiveDmg = " defends himself and takes only: ";
            const string MsgRemainingLife = "The Remaining life of ";
            const string MsgDamageUnit = " damage";
            const string MsgHealthUnit = " health";
            const string MsgProtectMe = " protects itself from the monster and doubles its damage reduction on the next attack.";
            const string MsgMonsterAttacksAll = "The Monster attacks all the heroes:";
            const string MsgOnCooldown = "The special ability is on cooldown. Remaining TURNS: ";
            const string MsgReselect = "Reselect an action: ";
            const string MsgDead = " is DEAD.";
            const string MsgFullHealth = "All the heroes are full of HEALTH. You can't USE IT.";
            const string MsgHeal = " heal +500 of Health to all the Heroes: ";
            const string MsgFullDmgRed = " have 100% of Damage Reduction during 3 TURNS. ";
            const string MsgKnockout = " knockout the Monster for 2 TURNS.";
            //Archer attributes:
            const string OutFirstChar = "1 - First character: ";
            const string OutArcherHealth = "Health [1500-2000]: ";
            const string OutArcherDmg = "Damage [180-300]: ";
            const string OutArcherDmgRed = "Damage reduction (percentage value) [25-40]%:";
            const string ArcherName = "Archer";
            //Barbarian attributes:
            const string OutSecondChar = "2 - Second character: ";
            const string OutBarbarianHealth = "Health [3000-3750]: ";
            const string OutBarbarianDmg = "Damage [150-250]: ";
            const string OutBarbarianDmgRed = "Damage reduction (percentage value) [35-45]%:";
            const string BarbarianName = "Barbarian";
            //Wizard attributes:
            const string OutThirdChar = "3 - Third character: ";
            const string OutWizardHealth = "Health [1000-1500]: ";
            const string OutWizardDmg = "Damage [300-350]: ";
            const string OutWizardDmgRed = "Damage reduction (percentage value) [20-35]%:";
            const string WizardName = "Wizard";
            //Druid attributes:
            const string OutFourthChar = "4 - Fourth character: ";
            const string OutDruidHealth = "Health [2000-2500]: ";
            const string OutDruidDmg = "Damage [70-120]: ";
            const string OutDruidDmgRed = "Damage reduction (percentage value) [25-40]%:";
            const string DruidName = "Druid";
            //Monster attributes:
            const string OutFifthChar = "5 - Now it's the turn of the ";
            const string OutMonsterHealth = "Health [9000-12000]: ";
            const string OutMonsterDmg = "Damage [250-400]: ";
            const string OutMonsterDmgRed = "Damage reduction (percentage value) [20-30]%:";
            const string MonsterName = "Monster";

            //ASSIGNMENT OF CONSTANT VALUES
            //Rest of constants:
            const int PlayGame = 1, ExitGame = 0, OFFSET = 1, StartZero = 0, StartOne = 1, MAXError = 3, Percentage = 100, DoubleDef = 2, AbilityCooldown = 5, LifeValidator = 0;
            const int ArcherAbility = 2, FullDefense = 100, BarbarianAbility = 3, WizardAbility = 3, DruidHeal = 500;
            const int ArcherAttributePoint = 1, BarbarianAttributePoint = 5, WizardAttributePoint = 9, DruidAttributePoint = 13, MonsterAttributePoint = 17;
            //Minimums and maximums values of the attributes:
            const int ArcherHealthMIN = 1500, ArcherHealthMAX = 2000, ArcherDmgMIN = 180, ArcherDmgMAX = 300, ArcherDmgRedMIN = 25, ArcherDmgRedMAX = 40,
                      BarbarianHealthMIN = 3000, BarbarianHealthMAX = 3750, BarbarianDmgMIN = 150, BarbarianDmgMAX = 250, BarbarianDmgRedMIN = 35, BarbarianDmgRedMAX = 45,
                      WizardHealthMIN = 1000, WizardHealthMAX = 1500, WizardDmgMIN = 300, WizardDmgMAX = 350, WizardDmgRedMIN = 20, WizardDmgRedMAX = 35,
                      DruidHealthMIN = 2000, DruidHealthMAX = 2500, DruidDmgMIN = 70, DruidDmgMAX = 120, DruidDmgRedMIN = 25, DruidDmgRedMAX = 40,
                      MonsterHealthMIN = 9000, MonsterHealthMAX = 12000, MonsterDmgMIN = 250, MonsterDmgMAX = 400, MonsterDmgRedMIN = 20, MonsterDmgRedMAX = 30;

            //DECLARATION AND ASSIGNMENT OF VARIABLES
            //Menu variable:
            decimal UserIntput;
            int IntputError = 0;
            bool Play = true, EnterCreation = false, EnterBattle = false;
            //Creation variable:
            int AttributeAttempts = 0, CharacterAttempts, CharacterCreation, CaseMove = 1, LeaveCharacterCreation = 0;
            //Battle variable:
            int TurnNumber, KnockoutTurn = 0, FullDefenseTurn = 0, ArcherCooldownTurn = 0, BarbarianCooldownTurn = 0, WizardCooldownTurn = 0, DruidCooldownTurn = 0;
            bool ArcherTurn = false, BarbarianTurn = false, WizardTurn = false, DruidTurn = false, MonsterTurn = false, ArcherDead = false, BarbarianDead = false, WizardDead = false, DruidDead = false, MonsterDead = false;
            //Character attribute:
            decimal ArcherHealth = 0, ArcherDmg = 0, ArcherDmgRed = 0, BarbarianHealth = 0, BarbarianDmg = 0, BarbarianDmgRed = 0,
                WizardHealth = 0, WizardDmg = 0, WizardDmgRed = 0, DruidHealth = 0, DruidDmg = 0, DruidDmgRed = 0, MonsterHealth = 0, MonsterDmg = 0, MonsterDmgRed = 0,
                ArcherBattleDmgRed = 0, BarbarianBattleDmgRed = 0, WizardBattleDmgRed = 0, DruidBattleDmgRed = 0,
                ArcherStartHealth = 0, BarbarianStartHealth = 0, WizardStartHealth = 0, DruidStartHealth = 0;

            while (Play)
            {
                //MENU SELECTION
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(MsgGameMenu);
                Console.ForegroundColor = ConsoleColor.Gray;
                UserIntput = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();
                if (UserIntput == PlayGame)
                {
                    Play = true;
                    EnterCreation = true; //For "enter" to the while loop of character attributes assignation
                }
                else if (UserIntput == ExitGame)
                {
                    Play = false; //Close the game
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MsgWrongValue);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    IntputError++;
                    if (IntputError == MAXError)
                    {
                        Play = false; //Close the game
                    }

                }

                //BEGINNING OF CHARACTER CREATION LOOP
                CharacterAttempts = StartZero;
                CharacterCreation = StartOne;
                if(EnterCreation)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(MsgStartCreation);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
                    
                while (EnterCreation)
                {
                    switch (CharacterCreation)
                    {
                        //Archer Startpoint
                        case 1:
                            Console.WriteLine(OutFirstChar + ArcherName);
                            Console.WriteLine(MsgIntroduceValue);
                            CharacterCreation = CharacterCreation + CaseMove;
                            break;
                        case 2:
                            Console.WriteLine(OutArcherHealth);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= ArcherHealthMIN && UserIntput <= ArcherHealthMAX)
                            {
                                ArcherHealth = UserIntput;
                                ArcherStartHealth = UserIntput; //In the Druid special ability section, we will require it to make conditions
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = ArcherAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine(OutArcherDmg);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= ArcherDmgMIN && UserIntput <= ArcherDmgMAX)
                            {
                                ArcherDmg = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = ArcherAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine(OutArcherDmgRed);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= ArcherDmgRedMIN && UserIntput <= ArcherDmgRedMAX)
                            {
                                ArcherDmgRed = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = ArcherAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        //Barbarian Startpoint
                        case 5: 
                            Console.WriteLine(OutSecondChar + BarbarianName);
                            Console.WriteLine(MsgIntroduceValue);
                            CharacterCreation = CharacterCreation + CaseMove;
                            break;
                        case 6:
                            Console.WriteLine(OutBarbarianHealth);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= BarbarianHealthMIN && UserIntput <= BarbarianHealthMAX)
                            {
                                BarbarianHealth = UserIntput;
                                BarbarianStartHealth = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = BarbarianAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 7:
                            Console.WriteLine(OutBarbarianDmg);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= BarbarianDmgMIN && UserIntput <= BarbarianDmgMAX)
                            {
                                BarbarianDmg = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = BarbarianAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 8:
                            Console.WriteLine(OutBarbarianDmgRed);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= BarbarianDmgRedMIN && UserIntput <= BarbarianDmgRedMAX)
                            {
                                BarbarianDmgRed = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = BarbarianAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        //Wizard Startpoint
                        case 9: 
                            Console.WriteLine(OutThirdChar + WizardName);
                            Console.WriteLine(MsgIntroduceValue);
                            CharacterCreation = CharacterCreation + CaseMove;
                            break;
                        case 10:
                            Console.WriteLine(OutWizardHealth);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= WizardHealthMIN && UserIntput <= WizardHealthMAX)
                            {
                                WizardHealth = UserIntput;
                                WizardStartHealth = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = WizardAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 11:
                            Console.WriteLine(OutWizardDmg);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= WizardDmgMIN && UserIntput <= WizardDmgMAX)
                            {
                                WizardDmg = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = WizardAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 12:
                            Console.WriteLine(OutWizardDmgRed);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= WizardDmgRedMIN && UserIntput <= WizardDmgRedMAX)
                            {
                                WizardDmgRed = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = WizardAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        //Druid Startpoint
                        case 13: 
                            Console.WriteLine(OutFourthChar + DruidName);
                            Console.WriteLine(MsgIntroduceValue);
                            CharacterCreation = CharacterCreation + CaseMove;
                            break;
                        case 14:
                            Console.WriteLine(OutDruidHealth);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= DruidHealthMIN && UserIntput <= DruidHealthMAX)
                            {
                                DruidHealth = UserIntput;
                                DruidStartHealth = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = DruidAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 15:
                            Console.WriteLine(OutDruidDmg);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= DruidDmgMIN && UserIntput <= DruidDmgMAX)
                            {
                                DruidDmg = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = DruidAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 16:
                            Console.WriteLine(OutDruidDmgRed);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= DruidDmgRedMIN && UserIntput <= DruidDmgRedMAX)
                            {
                                DruidDmgRed = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = DruidAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        //Monster Startpoint
                        case 17: 
                            Console.WriteLine(OutFifthChar + MonsterName);
                            Console.WriteLine(MsgIntroduceValue);
                            CharacterCreation = CharacterCreation + CaseMove;
                            break;
                        case 18:
                            Console.WriteLine(OutMonsterHealth);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= MonsterHealthMIN && UserIntput <= MonsterHealthMAX)
                            {
                                MonsterHealth = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = MonsterAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 19:
                            Console.WriteLine(OutMonsterDmg);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= MonsterDmgMIN && UserIntput <= MonsterDmgMAX)
                            {
                                MonsterDmg = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = MonsterAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        case 20:
                            Console.WriteLine(OutMonsterDmgRed);
                            UserIntput = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine();
                            if (UserIntput >= MonsterDmgRedMIN && UserIntput <= MonsterDmgRedMAX)
                            {
                                MonsterDmgRed = UserIntput;
                                CharacterCreation = CharacterCreation + CaseMove;
                                AttributeAttempts = StartZero;
                                EnterCreation = false; //With that condition we can LEAVE the CREATION LOOP without the ERROR message
                                EnterBattle = true; //With that condition we can ENTER to the BATTLE LOOP
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                AttributeAttempts++;
                                if (AttributeAttempts == MAXError)
                                {
                                    CharacterCreation = MonsterAttributePoint;
                                    CharacterAttempts++;
                                    AttributeAttempts = StartZero;
                                    if (CharacterAttempts == MAXError)
                                    {
                                        CharacterCreation = LeaveCharacterCreation;
                                    }
                                }
                            }
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(MsgEndAttempt);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            EnterCreation = false;
                            break;
                    }
                }

                //BEGINNING OF THE BATTLE LOOP
                TurnNumber = StartOne;
                while (EnterBattle)
                {
                    if (TurnNumber == StartOne)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(MsgStartBattle);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(MsgTurnIndicator + TurnNumber);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();

                    //Archer turn:
                    if (ArcherDead)
                        BarbarianTurn = true;
                    
                    ArcherTurn = true;
                    IntputError = StartZero;
                    while (ArcherTurn && !ArcherDead)
                    {
                        Console.WriteLine(ArcherName + ". " + MsgSelectAction);
                        Console.WriteLine(MsgBattleOptions);
                        UserIntput = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine();
                        switch (UserIntput)
                        {
                            case 1:
                                MonsterHealth = MonsterHealth - (ArcherDmg - (ArcherDmg * (MonsterDmgRed / Percentage)));
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(ArcherName + MsgAttackTo + MonsterName + ": " + ArcherDmg + MsgDamageUnit);
                                Console.WriteLine(MonsterName + MsgReceiveDmg + (ArcherDmg - (ArcherDmg * (MonsterDmgRed / Percentage))) + MsgDamageUnit);
                                Console.WriteLine(MsgRemainingLife + MonsterName + ": " + MonsterHealth + MsgHealthUnit);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();

                                if (MonsterHealth <= LifeValidator)
                                {
                                    MonsterDead = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MonsterName + MsgDead);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else
                                {
                                    BarbarianTurn = true;
                                }
                                ArcherBattleDmgRed = ArcherDmgRed;
                                ArcherTurn = false;
                                break;
                            case 2:
                                ArcherBattleDmgRed = ArcherDmgRed * DoubleDef;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(ArcherName + MsgProtectMe);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                ArcherTurn = false;
                                BarbarianTurn = true;
                                break;
                            case 3:
                                if (ArcherCooldownTurn <= TurnNumber)
                                {
                                    KnockoutTurn = TurnNumber + ArcherAbility;
                                    ArcherCooldownTurn = TurnNumber + AbilityCooldown + OFFSET; //The turn which the player use the ability it doesn't count, so we add "OFFSET"

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(ArcherName + MsgKnockout);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();

                                    ArcherTurn = false;
                                    BarbarianTurn = true;
                                } else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MsgOnCooldown + (ArcherCooldownTurn - TurnNumber));
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();
                                    Console.WriteLine(MsgReselect);
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                IntputError++;
                                break;
                        }
                        if (MonsterDead || IntputError == MAXError)
                        {
                            ArcherTurn = false;
                            EnterBattle = false;
                        }
                    }

                    //Barbarian turn:
                    if (BarbarianDead)
                        WizardTurn = true;

                    IntputError = StartZero;
                    while (BarbarianTurn && !BarbarianDead)
                    {
                        Console.WriteLine(BarbarianName + ". " + MsgSelectAction);
                        Console.WriteLine(MsgBattleOptions);
                        UserIntput = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine();
                        switch (UserIntput)
                        {
                            case 1:
                                MonsterHealth = MonsterHealth - (BarbarianDmg - (BarbarianDmg * (MonsterDmgRed / Percentage)));
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(BarbarianName + MsgAttackTo + MonsterName + ": " + BarbarianDmg + MsgDamageUnit);
                                Console.WriteLine(MonsterName + MsgReceiveDmg + (BarbarianDmg - (BarbarianDmg * (MonsterDmgRed / Percentage))) + MsgDamageUnit);
                                Console.WriteLine(MsgRemainingLife + MonsterName + ": " + MonsterHealth + MsgHealthUnit);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                
                                if (MonsterHealth <= LifeValidator)
                                {
                                    MonsterDead = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MonsterName + MsgDead);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else
                                {
                                    WizardTurn = true;
                                }

                                if (FullDefenseTurn <= TurnNumber)
                                {
                                    BarbarianBattleDmgRed = BarbarianDmgRed;
                                }
                                BarbarianTurn = false;
                                break;
                            case 2:
                                BarbarianBattleDmgRed = BarbarianDmgRed * DoubleDef;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(BarbarianName + MsgProtectMe);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                BarbarianTurn = false;
                                WizardTurn = true;
                                break;
                            case 3:
                                if (BarbarianCooldownTurn <= TurnNumber)
                                {
                                    BarbarianBattleDmgRed = FullDefense;
                                    FullDefenseTurn = TurnNumber + BarbarianAbility;

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(BarbarianName + MsgFullDmgRed);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();

                                    BarbarianCooldownTurn = TurnNumber + AbilityCooldown + OFFSET;
                                    BarbarianTurn = false;
                                    WizardTurn = true;
                                } else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MsgOnCooldown + (BarbarianCooldownTurn - TurnNumber));
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();
                                    Console.WriteLine(MsgReselect);
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                IntputError++;
                                break;
                        }
                        if (MonsterDead || IntputError == MAXError)
                        {
                            BarbarianTurn = false;
                            EnterBattle = false;
                        }
                    }

                    //Wizard turn:
                    if (WizardDead)
                        DruidTurn = true;

                    IntputError = StartZero;
                    while (WizardTurn && !WizardDead)
                    {
                        Console.WriteLine(WizardName + ". " + MsgSelectAction);
                        Console.WriteLine(MsgBattleOptions);
                        UserIntput = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine();
                        switch (UserIntput)
                        {
                            case 1:
                                MonsterHealth = MonsterHealth - (WizardDmg - (WizardDmg * (MonsterDmgRed / Percentage)));
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(WizardName + MsgAttackTo + MonsterName + ": " + WizardDmg + MsgDamageUnit);
                                Console.WriteLine(MonsterName + MsgReceiveDmg + (WizardDmg - (WizardDmg * (MonsterDmgRed / Percentage))) + MsgDamageUnit);
                                Console.WriteLine(MsgRemainingLife + MonsterName + ": " + MonsterHealth + MsgHealthUnit);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();

                                if (MonsterHealth <= LifeValidator)
                                {
                                    MonsterDead = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MonsterName + MsgDead);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else
                                {
                                    DruidTurn = true;
                                }
                                WizardBattleDmgRed = WizardDmgRed;
                                WizardTurn = false;
                                break;
                            case 2:
                                WizardBattleDmgRed = WizardDmgRed * DoubleDef;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(WizardName + MsgProtectMe);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                WizardTurn = false;
                                DruidTurn = true;
                                break;
                            case 3:
                                if (WizardCooldownTurn <= TurnNumber)
                                {
                                    MonsterHealth = MonsterHealth - ((WizardDmg - (WizardDmg * (MonsterDmgRed / Percentage))) * WizardAbility);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(WizardName + MsgAttackTo + MonsterName + ": " + (WizardDmg * WizardAbility) + MsgDamageUnit);
                                    Console.WriteLine(MonsterName + MsgReceiveDmg + ((WizardDmg - (WizardDmg * (MonsterDmgRed / Percentage))) * WizardAbility) + MsgDamageUnit);
                                    Console.WriteLine(MsgRemainingLife + MonsterName + ": " + MonsterHealth + MsgHealthUnit);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();
                                    WizardCooldownTurn = TurnNumber + AbilityCooldown + OFFSET;
                                    WizardTurn = false;
                                    DruidTurn = true;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MsgOnCooldown + (WizardCooldownTurn - TurnNumber));
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine();
                                    Console.WriteLine(MsgReselect);
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                IntputError++;
                                break;
                        }
                        if (MonsterDead || IntputError == MAXError)
                        {
                            WizardTurn = false;
                            EnterBattle = false;
                        }
                    }

                    //Druid turn:
                    if (DruidDead)
                        MonsterTurn = true;

                    IntputError = StartZero;
                    while (DruidTurn && !DruidDead)
                    {
                        Console.WriteLine(DruidName + ". " + MsgSelectAction);
                        Console.WriteLine(MsgBattleOptions);
                        UserIntput = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine();
                        switch (UserIntput)
                        {
                            case 1:
                                MonsterHealth = MonsterHealth - (DruidDmg - (DruidDmg * (MonsterDmgRed / Percentage)));
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(DruidName + MsgAttackTo + MonsterName + ": " + DruidDmg + MsgDamageUnit);
                                Console.WriteLine(MonsterName + MsgReceiveDmg + (DruidDmg - (DruidDmg * (MonsterDmgRed / Percentage))) + MsgDamageUnit);
                                Console.WriteLine(MsgRemainingLife + MonsterName + ": " + MonsterHealth + MsgHealthUnit);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();

                                if (MonsterHealth <= LifeValidator)
                                {
                                    MonsterDead = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MonsterName + MsgDead);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else
                                {
                                    MonsterTurn = true;
                                }
                                DruidBattleDmgRed = DruidDmgRed;
                                DruidTurn = false;
                                break;
                            case 2:
                                DruidBattleDmgRed = DruidDmgRed * DoubleDef;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(DruidName + MsgProtectMe);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                DruidTurn = false;
                                MonsterTurn = true;
                                break;
                            case 3:
                                if (DruidCooldownTurn <= TurnNumber)
                                {
                                    if ((ArcherHealth != ArcherStartHealth) && (BarbarianHealth != BarbarianStartHealth) && (WizardHealth != WizardStartHealth) && (DruidHealth != DruidStartHealth))
                                    {
                                        ArcherHealth = ArcherHealth + DruidHeal;
                                        BarbarianHealth = BarbarianHealth + DruidHeal;
                                        WizardHealth = WizardHealth + DruidHeal;
                                        DruidHealth = DruidHealth + DruidHeal;

                                        //Druid cannot heal more health than they have assigned
                                        if (ArcherHealth > ArcherStartHealth)
                                            ArcherHealth = ArcherStartHealth;
                                        if (BarbarianHealth > BarbarianStartHealth)
                                            BarbarianHealth = BarbarianStartHealth;
                                        if (WizardHealth > WizardStartHealth)
                                            WizardHealth = WizardStartHealth;
                                        if (DruidHealth > DruidStartHealth)
                                            DruidHealth = DruidStartHealth;

                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(DruidName + MsgHeal);
                                        Console.WriteLine();
                                        if (!ArcherDead)
                                            Console.WriteLine(ArcherName + ": " + ArcherHealth + MsgHealthUnit);
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(ArcherName + MsgDead);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                        }
                                        if (!BarbarianDead)
                                            Console.WriteLine(BarbarianName + ": " + BarbarianHealth + MsgHealthUnit);
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(BarbarianName + MsgDead);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                        }
                                        if (!WizardDead)
                                            Console.WriteLine(WizardName + ": " + WizardHealth + MsgHealthUnit);
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(WizardName + MsgDead);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                        }
                                        if (!DruidDead)
                                            Console.WriteLine(DruidName + ": " + DruidHealth + MsgHealthUnit);
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(DruidName + MsgDead);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                        }
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine();

                                        DruidCooldownTurn = TurnNumber + AbilityCooldown + OFFSET;
                                        DruidTurn = false;
                                        MonsterTurn = true;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(MsgFullHealth);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine();
                                        Console.WriteLine(MsgReselect);
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(MsgOnCooldown + (DruidCooldownTurn - TurnNumber));
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine(MsgReselect);
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(MsgWrongValue);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine();
                                IntputError++;
                                break;
                        }
                        if (MonsterDead || IntputError == MAXError)
                        {
                            DruidTurn = false;
                            EnterBattle = false;
                        }
                    }

                    //Monster turn:
                    if (KnockoutTurn > TurnNumber)
                    {
                        MonsterTurn = false;
                    }
                    while (MonsterTurn && !MonsterDead)
                    {
                        //Make the damage
                        ArcherHealth = ArcherHealth - (MonsterDmg - (MonsterDmg * (ArcherBattleDmgRed / Percentage)));
                        BarbarianHealth = BarbarianHealth - (MonsterDmg - (MonsterDmg * (BarbarianBattleDmgRed / Percentage)));
                        WizardHealth = WizardHealth - (MonsterDmg - (MonsterDmg * (WizardBattleDmgRed / Percentage)));
                        DruidHealth = DruidHealth - (MonsterDmg - (MonsterDmg * (DruidBattleDmgRed / Percentage)));

                        //Print all the results
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(MsgMonsterAttacksAll);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                         
                        if (!ArcherDead) //Print: ARCHER information, if she is alive
                        {
                            Console.WriteLine(MonsterName + MsgAttackTo + ArcherName + ": " + MonsterDmg + MsgDamageUnit);
                            Console.WriteLine(ArcherName + MsgReceiveDmg + (MonsterDmg - (MonsterDmg * (ArcherBattleDmgRed / Percentage))) + MsgDamageUnit);
                            Console.WriteLine(MsgRemainingLife + ArcherName + ": " + ArcherHealth + MsgHealthUnit);
                            Console.WriteLine();
                        } else //Print: She is dead, if his health is below than 0
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ArcherName + MsgDead);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                        }

                        if(!BarbarianDead)
                        {
                            Console.WriteLine(MonsterName + MsgAttackTo + BarbarianName + ": " + MonsterDmg + MsgDamageUnit);
                            Console.WriteLine(BarbarianName + MsgReceiveDmg + (MonsterDmg - (MonsterDmg * (BarbarianBattleDmgRed / Percentage))) + MsgDamageUnit);
                            Console.WriteLine(MsgRemainingLife + BarbarianName + ": " + BarbarianHealth + MsgHealthUnit);
                            Console.WriteLine();
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(BarbarianName + MsgDead);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                        }

                        if (!WizardDead)
                        {
                            Console.WriteLine(MonsterName + MsgAttackTo + WizardName + ": " + MonsterDmg + MsgDamageUnit);
                            Console.WriteLine(WizardName + MsgReceiveDmg + (MonsterDmg - (MonsterDmg * (WizardBattleDmgRed / Percentage))) + MsgDamageUnit);
                            Console.WriteLine(MsgRemainingLife + WizardName + ": " + WizardHealth + MsgHealthUnit);
                            Console.WriteLine();
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(WizardName + MsgDead);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                        }

                        if (!DruidDead)
                        {
                            Console.WriteLine(MonsterName + MsgAttackTo + DruidName + ": " + MonsterDmg + MsgDamageUnit);
                            Console.WriteLine(DruidName + MsgReceiveDmg + (MonsterDmg - (MonsterDmg * (DruidBattleDmgRed / Percentage))) + MsgDamageUnit);
                            Console.WriteLine(MsgRemainingLife + DruidName + ": " + DruidHealth + MsgHealthUnit);
                            Console.WriteLine();
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(DruidName + MsgDead);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;

                        //Validate if they are dead or not
                        if (ArcherHealth <= LifeValidator)
                            ArcherDead = true;
                        if (BarbarianHealth <= LifeValidator)
                            BarbarianDead = true;
                        if (WizardHealth <= LifeValidator)
                            WizardDead = true;
                        if (DruidHealth <= LifeValidator)
                            DruidDead = true;

                        MonsterTurn = false;
                    }
                    if (ArcherDead && BarbarianDead && WizardDead && DruidDead) //Monster WIN if all heroes die
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(MsgVictoryFor + MsgMonsterTeam);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        EnterBattle = false;
                    } else if (MonsterDead) //Heroes WIN if the Monster die
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(MsgVictoryFor + MsgHeroesTeam);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        EnterBattle = false;
                    }
                    TurnNumber++;
                }
            }
        }
    }
}