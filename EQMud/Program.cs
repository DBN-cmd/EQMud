using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQMud
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCampingOut = false;
            int xCoord = 10;
            int yCoord = 10;
            int currentXPosition = 10;
            int currentYPosition = 10;
            string mobType1 = "";
            string mobType2 = "";
            string mobType3 = "";
            int mobNum = 0;
            int numMobDiffTypes = 0;
            int mobChance = 0;
            var genCreture = new List<string>();
            


            Console.WriteLine("******EQ MUD TITLE SCREEN******");

            // Code area for start new or continue

            // Coding for movement

            while (!isCampingOut)
            {
                Console.WriteLine("\n\n");
                bool possibleAreMobs = false;
                CharLocation(xCoord, yCoord, ref currentXPosition, ref currentYPosition, ref mobType1, ref mobType2, ref mobType3, ref mobNum, ref numMobDiffTypes, ref mobChance, ref possibleAreMobs);
                xCoord = currentXPosition;
                yCoord = currentYPosition;
                Console.WriteLine($"Current xCoord is: {xCoord}");
                Console.WriteLine($"Current yCoord is: {yCoord}\n");
                Console.WriteLine(mobType1);
                Console.WriteLine(mobType2);
                Console.WriteLine(mobType3);
                


                if (possibleAreMobs)
                {
                    CreatureGen(mobType1, mobType2, mobType3, mobNum, numMobDiffTypes, mobChance, genCreture); // need to assign another var to skip this if it already gen creatures
                    foreach (var mob in genCreture)
                    {
                        Console.WriteLine(mob);
                        //MobTypes(genCreture, mobType1);
                    }
                    string playerChoice = Console.ReadLine();
                    playerChoice = playerChoice.ToUpper();
                    switch (playerChoice)
                    {
                        case "N":
                        case "NORTH":
                            yCoord += 1;
                            genCreture.Clear();
                            break;

                        case "S":
                        case "SOUTH":
                            yCoord -= 1;
                            genCreture.Clear();
                            break;

                        case "E":
                        case "EAST":
                            xCoord += 1;
                            genCreture.Clear();
                            break;

                        case "W":
                        case "WEST":
                            xCoord -= 1;
                            genCreture.Clear();
                            break;

                        case "ATK":
                        case "ATTACK":


                        case "CAMP":
                            isCampingOut = true;
                            break;



                    }
                }
                else
                {
                    string playerChoice = Console.ReadLine();
                    playerChoice = playerChoice.ToUpper();
                    switch (playerChoice)
                    {
                        case "N":
                        case "NORTH":
                            yCoord += 1;
                            break;

                        case "S":
                        case "SOUTH":
                            yCoord -= 1;
                            break;

                        case "E":
                        case "EAST":
                            xCoord += 1;
                            break;

                        case "W":
                        case "WEST":
                            xCoord -= 1;
                            break;

                        case "ATK":
                        case "ATTACK":


                        case "CAMP":
                            isCampingOut = true;
                            break;



                    }
                }
                
            }

        }



        static void CharLocation(int xLoc, int yLoc, ref int currentXPosition, ref int currentYPosition, ref string mobType1, ref string mobType2, ref string mobType3, ref int currentMobNum, ref int currentNumMobDiffTypes, ref int currentMobChance, ref bool possibleAreMobs) // Character locations with descriptions
        {
            

            
            if (xLoc == 10 && yLoc == 10) // Felwith Gates
            {
                Console.WriteLine("FELWITH GATES");
                currentXPosition = 10;
                currentYPosition = 10;
            }
            else if (xLoc == 9 && yLoc == 10) // Lesser Faydark enterance
            {
                Console.WriteLine("LESSER FAYDARK ENTERANCE");
                currentXPosition = 9;
                currentYPosition = 10;
            }
            else if (xLoc == 8 && yLoc == 10) // Wizard Combines
            {
                Console.WriteLine("WIZARD COMBINES");
                currentXPosition = 8;
                currentYPosition = 10;
            }
            else if (xLoc == 7 && yLoc == 10) // Butcherblock Enterance
            {
                Console.WriteLine("BUTCHERBLOCK MTNS ENTERANCE");
                currentXPosition = 7;
                currentYPosition = 10;
            }
            else if (xLoc == 6 && yLoc == 10) // Butcherblock UNABLE TO ENTER
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE ROAD TO BUTCHERBLOCK HAS A ROCK SLIDE YOUR CURRENTLY UNABLE TO PASS!");
                Console.WriteLine("BUTCHERBLOCK MTNS ENTERANCE");
                currentXPosition = 7;
                currentYPosition = 10;

            }
            else if (xLoc == 11 && yLoc == 10) // Felwith Gates CLOSED
            {
                Console.WriteLine("UNABLE TO MOVE EAST! FELWITH GATES ARE CURRENTLY CLOSE! TRY AT LATER TIME");
                Console.WriteLine("FELWITH GATES");
                currentXPosition = 10;
                currentYPosition = 10;

            }
            else if (xLoc == 10 && yLoc == 9) // lesser faydark south, terrain too rough
            {
                Console.WriteLine("UNABLE TO MOVE SOUTH! THE TERRAIN TO THE SOUTH IS TOO ROUGH TO PASS");
                Console.WriteLine("FELWITH GATES");
                currentXPosition = 10;
                currentYPosition = 10;

            }
            else if (xLoc == 9 && yLoc == 9) // lesser faydark south, road closed
            {
                Console.WriteLine("UNABLE TO MOVE SOUTH! THE ROAD TO LESSER FAYDARK IS SEALED");
                Console.WriteLine("LESSER FAYDARK ENTERANCE");
                currentXPosition = 9;
                currentYPosition = 10;

            }
            else if (xLoc == 8 && yLoc == 9) // lesser faydark south, terrain too rough
            {
                Console.WriteLine("UNABLE TO MOVE SOUTH! THE TERRAIN TO THE SOUTH IS TOO ROUGH TO PASS");
                Console.WriteLine("WIZARD COMBINES");
                currentXPosition = 8;
                currentYPosition = 10;

            }
            else if (xLoc == 7 && yLoc == 9) // lesser faydark south, terrain too rough
            {
                Console.WriteLine("UNABLE TO MOVE SOUTH! THE TERRAIN TO THE SOUTH IS TOO ROUGH TO PASS");
                Console.WriteLine("BUTCHERBLOCK MTNS ENTERANCE");
                currentXPosition = 7;
                currentYPosition = 10;

            }

            //// replace gfay hills and trees Nfelwith here
            

            ///// replace bandit camp here


            else if (xLoc == 8 && yLoc == 11) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
                currentXPosition = 8;
                currentYPosition = 11;
            }
            else if (xLoc == 7 && yLoc == 11) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAIN VALLEY");
                currentXPosition = 7;
                currentYPosition = 11;
            }
            else if (xLoc == 6 && yLoc == 11) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAIN VALLEY");
                currentXPosition = 7;
                currentYPosition = 11;

            }
            else if (xLoc == 11 && yLoc == 11) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK HILLS NORTH OF FELWITH");
                currentXPosition = 10;
                currentYPosition = 11;

            }

            //// replace GFay forest deep 10,12
            
            else if (xLoc == 9 && yLoc == 12) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
                currentXPosition = 9;
                currentYPosition = 12;
            }
            else if (xLoc == 8 && yLoc == 12) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
                currentXPosition = 8;
                currentYPosition = 12;
            }
            else if (xLoc == 7 && yLoc == 12) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 12;
            }
            else if (xLoc == 6 && yLoc == 12) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 12;

            }
            else if (xLoc == 11 && yLoc == 12) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 12;

            }




            else if (xLoc == 10 && yLoc == 13) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 13;
            }
            else if (xLoc == 9 && yLoc == 13) // Kelethin SE Lift
            {
                Console.WriteLine("KELETHIN SE LIFT");
                currentXPosition = 9;
                currentYPosition = 13;
            }
            else if (xLoc == 8 && yLoc == 13) // Kelethin SW Lift
            {
                Console.WriteLine("KELETHIN SW LIFT");
                currentXPosition = 8;
                currentYPosition = 13;
            }
            else if (xLoc == 7 && yLoc == 13) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 13;
            }
            else if (xLoc == 6 && yLoc == 13) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 13;

            }
            else if (xLoc == 11 && yLoc == 13) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 13;

            }





            else if (xLoc == 10 && yLoc == 14) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 14;
            }
            else if (xLoc == 9 && yLoc == 14) // GFay Forest Kelethin Above
            {
                Console.WriteLine("GREATER FAYDARK FOREST KELETHIN TOWN ABOVE");
                currentXPosition = 9;
                currentYPosition = 14;
            }
            else if (xLoc == 8 && yLoc == 14) // GFay Forest Kelethin Above
            {
                Console.WriteLine("GREATER FAYDARK FOREST KELETHIN TOWN ABOVE");
                currentXPosition = 8;
                currentYPosition = 14;
            }
            else if (xLoc == 7 && yLoc == 14) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 14;
            }
            else if (xLoc == 6 && yLoc == 14) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 14;

            }
            else if (xLoc == 11 && yLoc == 14) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 14;

            }




            else if (xLoc == 10 && yLoc == 15) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 15;
            }
            else if (xLoc == 9 && yLoc == 15) // GFay Abandoned Druid Ring
            {
                Console.WriteLine("GREATER FAYDARK ABANDONED DRUID RING");
                currentXPosition = 9;
                currentYPosition = 15;
            }
            else if (xLoc == 8 && yLoc == 15) // GFay Forest Kelethin Above
            {
                Console.WriteLine("GREATER FAYDARK FOREST KELETHIN TOWN ABOVE");
                currentXPosition = 8;
                currentYPosition = 15;
            }
            else if (xLoc == 7 && yLoc == 15) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 15;
            }
            else if (xLoc == 6 && yLoc == 15) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 15;

            }
            else if (xLoc == 11 && yLoc == 15) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 15;

            }




            else if (xLoc == 10 && yLoc == 16) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 16;
            }
            else if (xLoc == 9 && yLoc == 16) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
                currentXPosition = 9;
                currentYPosition = 16;
            }
            else if (xLoc == 8 && yLoc == 16) // GFay Forest Kelethin Northern Lift
            {
                Console.WriteLine("KELETHIN NORTHERN LIFT");
                currentXPosition = 8;
                currentYPosition = 16;
            }
            else if (xLoc == 7 && yLoc == 16) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 16;
            }
            else if (xLoc == 6 && yLoc == 16) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 16;

            }
            else if (xLoc == 11 && yLoc == 16) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 16;

            }




            else if (xLoc == 10 && yLoc == 17) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 17;
            }
            else if (xLoc == 9 && yLoc == 17) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
                currentXPosition = 9;
                currentYPosition = 17;
            }
            else if (xLoc == 8 && yLoc == 17) // GFay Forest Road to Crushbone
            {
                Console.WriteLine("GREATER FAYDARK FOREST ROAD TO CRUSHBONE");
                currentXPosition = 8;
                currentYPosition = 17;
            }
            else if (xLoc == 7 && yLoc == 17) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 17;
            }
            else if (xLoc == 6 && yLoc == 17) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 17;

            }
            else if (xLoc == 11 && yLoc == 17) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 17;

            }





            else if (xLoc == 10 && yLoc == 18) // GFay Forest Starting Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST SMALLER CLIFFS IN AREA");
                currentXPosition = 10;
                currentYPosition = 18;
            }
            else if (xLoc == 9 && yLoc == 18) // GFay Forest Smaller Orc Camps
            {
                Console.WriteLine("GREATER FAYDARK FOREST SMALL ORC HUTS IN AREA");
                currentXPosition = 9;
                currentYPosition = 18;
            }
            else if (xLoc == 8 && yLoc == 18) // GFay Forest Road to Crushbone with Easy Area
            {
                Console.WriteLine("GREATER FAYDARK FOREST ROAD TO CRUSHBONE WITH SMALLER ORC HUTS IN AREA");
                currentXPosition = 8;
                currentYPosition = 18;
            }
            else if (xLoc == 7 && yLoc == 18) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 18;
            }
            else if (xLoc == 6 && yLoc == 18) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
                currentXPosition = 7;
                currentYPosition = 18;

            }
            else if (xLoc == 11 && yLoc == 18) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! THE FOREST IS TOO DENSE, YOU'D PROBABLY GET LOST!");
                Console.WriteLine("GREATER FAYDARK FOREST SMALLER CLIFFS IN AREA");
                currentXPosition = 10;
                currentYPosition = 18;

            }




            else if (xLoc == 10 && yLoc == 19) // GFay Forest Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST EXTREAM CLIFF FACES");
                currentXPosition = 10;
                currentYPosition = 19;
            }
            else if (xLoc == 9 && yLoc == 19) // GFay Forest Medium Orc Camps
            {
                Console.WriteLine("GREATER FAYDARK FOREST MEDIUM ORC HUTS IN AREA");
                currentXPosition = 9;
                currentYPosition = 19;
            }
            else if (xLoc == 8 && yLoc == 19) // GFay Forest Road to Crushbone with Hard Area
            {
                Console.WriteLine("GREATER FAYDARK FOREST ROAD TO CRUSHBONE WITH MAJOR ORC CAMP IN AREA");
                currentXPosition = 8;
                currentYPosition = 19;
            }
            else if (xLoc == 7 && yLoc == 19) // GFay Forest Mtns With Medium Orc Camps
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MEDIUM ORC HUTS IN AREA");
                currentXPosition = 7;
                currentYPosition = 19;
            }
            else if (xLoc == 6 && yLoc == 19) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MEDIUM ORC HUTS IN AREA");
                currentXPosition = 7;
                currentYPosition = 19;

            }
            else if (xLoc == 11 && yLoc == 19) // Gfay forest, cliffs impassible
            {
                Console.WriteLine("UNABLE TO MOVE EAST! IMPASSIBLE CLIFFS!");
                Console.WriteLine("GREATER FAYDARK FOREST EXTREAM CLIFF FACES");
                currentXPosition = 10;
                currentYPosition = 19;

            }




            else if (xLoc == 10 && yLoc == 20) // GFay Forest Cliffs North and East
            {
                Console.WriteLine("GREATER FAYDARK FOREST EXTREAM CLIFF FACES ON TWO SIDES OF YOU");
                currentXPosition = 10;
                currentYPosition = 20;
            }
            else if (xLoc == 9 && yLoc == 20) // GFay Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST MERGING TO SHARP CLIFF FACE");
                currentXPosition = 9;
                currentYPosition = 20;
            }
            else if (xLoc == 8 && yLoc == 20) // GFay Crushbone Enterance
            {
                Console.WriteLine("GREATER FAYDARK WITH CRUSHBONE ENTERANCE GUARDED");
                currentXPosition = 8;
                currentYPosition = 20;
            }
            else if (xLoc == 7 && yLoc == 20) // GFay Forest Mtns Merging with Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MERGING WITH CLIFFS");
                currentXPosition = 7;
                currentYPosition = 20;
            }
            else if (xLoc == 6 && yLoc == 20) // Butcherblock to the west, mtns impassible
            {
                Console.WriteLine("UNABLE TO MOVE WEST! THE MOUNTAINS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MERGING WITH CLIFFS");
                currentXPosition = 7;
                currentYPosition = 20;

            }
            else if (xLoc == 11 && yLoc == 20) // Gfay forest too dense to pass
            {
                Console.WriteLine("UNABLE TO MOVE EAST! IMPASSIBLE CLIFFS!");
                Console.WriteLine("GREATER FAYDARK FOREST EXTREME CLIFF FACES ON TWO SIDES OF YOU");
                currentXPosition = 10;
                currentYPosition = 20;
            }
            else if (xLoc == 7 && yLoc == 21) // Crushbone north, cliffs impassible
            {
                Console.WriteLine("UNABLE TO MOVE NORTH! THE CLIFFS ARE IMPASSIBLE!");
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MERGING WITH CLIFFS");
                currentXPosition = 7;
                currentYPosition = 20;

            }
            else if (xLoc == 10 && yLoc == 21) // Crushbone north, cliffs impassible
            {
                Console.WriteLine("UNABLE TO MOVE NORTH! IMPASSIBLE CLIFFS!");
                Console.WriteLine("GREATER FAYDARK FOREST EXTREME CLIFF FACES ON TWO SIDES OF YOU");
                currentXPosition = 10;
                currentYPosition = 20;
            }
            else if (xLoc == 8 && yLoc == 21) // Crushbone north, enterance guarded
            {
                Console.WriteLine("UNABLE TO MOVE NORTH! THE ENTERANCE TO CRUSHBONE IN GUARDED BY MANY ORCS!");
                Console.WriteLine("GREATER FAYDARK WITH CRUSHBONE ENTERANCE GUARDED");
                currentXPosition = 8;
                currentYPosition = 20;

            }
            else if (xLoc == 9 && yLoc == 21) // Crushbone north, cliffs impassible
            {
                Console.WriteLine("UNABLE TO MOVE NORTH! IMPASSIBLE CLIFFS!");
                Console.WriteLine("GREATER FAYDARK FOREST WITH EXTREME CLIFF FACE TO THE NORTH");
                currentXPosition = 9;
                currentYPosition = 20;
            }



            else if (xLoc == 10 && yLoc == 12) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 12;
                mobType1 = "fairy"; // fairy mob
                mobType2 = ""; // bee mob
                mobType3 = ""; // not possible for 3rd type in this area
                currentMobNum = 4; // total number that can spawn in area
                currentNumMobDiffTypes = 1; // how many different types of mobs in area
                currentMobChance = 75;
                possibleAreMobs = true;
            }

            else if (xLoc == 10 && yLoc == 11) // GFay Hills and Trees NFelwith
            {
                Console.WriteLine("GREATER FAYDARK HILLS NORTH OF FELWITH");
                currentXPosition = 10;
                currentYPosition = 11;
                mobType1 = "bat"; // bat mob
                mobType2 = "bee"; // bee mob
                mobType3 = ""; // not possible for 3rd type in this area
                currentMobNum = 2; // total number that can spawn in area
                currentNumMobDiffTypes = 3; // how many different types of mobs in area
                currentMobChance = 75;
                possibleAreMobs = true;
            }

            else if (xLoc == 9 && yLoc == 11) // Bandit Camp
            {
                Console.WriteLine("BANDIT CAMP");
                currentXPosition = 9;
                currentYPosition = 11;
                mobType1 = "bandit"; // bandit mob
                mobType2 = ""; // no second mob type
                mobType3 = ""; // no third mob type
                currentMobNum = 3; // total number that can spawn in area
                currentNumMobDiffTypes = 1; // how many different types of mobs in area
                currentMobChance = 75;
                possibleAreMobs = true;
            }

        }

               
        static void CreatureGen(string mobType1, string mobType2, string mobType3, int mobTotalNumber, int totalNumMobDiffTypes, int mobPercentChance, List<string>genCreature)
        {
            Random rnd = new Random();
            

            while(mobTotalNumber > 0)
            {
                int baseChance = 1;
                //int baseChance = rnd.Next(1, 101);
                Console.WriteLine(baseChance);

                if (baseChance < mobPercentChance)
                {
                    int rndMobType = rnd.Next(1, totalNumMobDiffTypes);
                    Console.WriteLine($"which of the 3 mobs in area are going to spawn{rndMobType}");

                    switch (rndMobType)
                    {
                        case 1:
                            genCreature.Add(mobType1);
                            mobPercentChance /= 2;
                            mobTotalNumber -= 1;

                            break;

                        case 2:
                            genCreature.Add(mobType2);
                            mobPercentChance /= 2;
                            mobTotalNumber -= 1;

                            break;

                        case 3:
                            genCreature.Add(mobType3);
                            mobPercentChance /= 2;
                            mobTotalNumber -= 1;

                            break;

                    }

                    
                }
                else
                {
                    break;
                }


            }
            
            

        }
        //static void MobTypes(List<string>genCreature, int mobType1)
        //{
        //    int checkMob = genCreature.Count();
        //    int mobCount = 0;

        //    while(mobCount < checkMob)
        //    {
        //        if (genCreature[mobCount] == "genType1")
        //        {
        //            int checkMobType = 1;
        //            while (checkMobType <= 4)
        //            {
        //                if (mobType1 == 1)
        //                {
        //                    Console.WriteLine("a Bandit appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //                else if (mobType1 == 2)
        //                {
        //                    Console.WriteLine("a bat appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //                else if (mobType1 == 3)
        //                {
        //                    Console.WriteLine("a bee appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //            }
        //        }
        //        else if (genCreature[mobCount] == "genType2")
        //        {
        //            int checkMobType = 1;
        //            while (checkMobType <= 4)
        //            {
        //                if (mobType1 == 1)
        //                {
        //                    Console.WriteLine("a Bandit appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //                else if (mobType1 == 2)
        //                {
        //                    Console.WriteLine("a bat appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //                else if (mobType1 == 3)
        //                {
        //                    Console.WriteLine("a bee appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //            }
        //        }
        //        else if (genCreature[mobCount] == "genType3")
        //        {
        //            int checkMobType = 1;
        //            while (checkMobType <= 4)
        //            {
        //                if (mobType1 == 1)
        //                {
        //                    Console.WriteLine("a Bandit appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //                else if (mobType1 == 2)
        //                {
        //                    Console.WriteLine("a bat appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //                else if (mobType1 == 3)
        //                {
        //                    Console.WriteLine("a bee appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //                else if (mobType1 == 4)
        //                {
        //                    Console.WriteLine("a fairy appears!");
        //                    checkMobType += 1;
        //                    mobCount += 1;
        //                }
        //            }
        //        }
        //        else
        //        {
                    
        //            break;
        //        }
        //    }


            //if (genCreature[0] == "genType1" && mobType1 == 1)
            //{
            //    Console.WriteLine("a Bandit appears!");
            //}

            //if (actMobName == "genType1") 
            //{
            //    Console.WriteLine("a Bandit appears!");
            //    int trueMobName = 1;
            //    // ref out hp/ac/dmg rang of mob
            //    return trueMobName;
            //}
            //else if (actMobName == "genType2")
            //{
            //    Console.WriteLine("a Bat appears!");
            //    int trueMobName = 2;
            //    // ref out hp/ac/dmg rang of mob
            //    return trueMobName;
            //}
            //else if (actMobName == "genType3")
            //{
            //    Console.WriteLine("a Bee appears!");
            //    int trueMobName = 3;
            //    // ref out hp/ac/dmg rang of mob
            //    return trueMobName;
            //}
            //else if (actMobName == "genType4")
            //{
            //    Console.WriteLine("a Fariy appears!");
            //    int trueMobName = 4;
            //    // ref out hp/ac/dmg rang of mob
            //    return trueMobName;
            //}
            //else
            //{
            //    return 0;
            //}
        //}



        
    }
}
