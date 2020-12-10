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
            bool possibleMobs = false;
            bool prevMobs = false;
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
            var genCreature = new List<string>();
            //var holdGenCreature = new List<string>();
            int mob1HP = 0;
            int mob1AC = 0;
            int mob1DmgMin= 0;
            int mob1DmgMax = 0;
            int mob2HP = 0;
            int mob2AC = 0;
            int mob2DmgMin = 0;
            int mob2DmgMax = 0;
            int mob3HP = 0;
            int mob3AC = 0;
            int mob3DmgMin = 0;
            int mob3DmgMax = 0;
            int mob4HP = 0;
            int mob4AC = 0;
            int mob4DmgMin = 0;
            int mob4DmgMax = 0;




            Console.WriteLine("******EQ MUD TITLE SCREEN******");

            // Code area for start new or continue

            // Coding for movement
            

            while (!isCampingOut)
            {
                Console.WriteLine("\n\n");
                bool north = true;
                bool south = true;
                bool east = true;
                bool west = true;
                Console.WriteLine(genCreature.Count());
                
                

                CharLocation(xCoord, yCoord, ref currentXPosition, ref currentYPosition, ref mobType1, ref mobType2, ref mobType3, ref mobNum, ref numMobDiffTypes, ref mobChance,
                                    ref possibleMobs, ref prevMobs,ref north, ref south, ref east, ref west);
                xCoord = currentXPosition;
                yCoord = currentYPosition;


                Console.WriteLine($"Current xCoord is: {xCoord}");
                Console.WriteLine($"Current yCoord is: {yCoord}\n");
                


                if (prevMobs)
                {
                    
                    CharMovement(genCreature, ref isCampingOut, ref xCoord, ref yCoord, ref mob1HP, ref mob1AC, ref mob1DmgMin, ref mob1DmgMax, ref mob2HP, ref mob2AC,
                                   ref mob2DmgMin, ref mob2DmgMax, ref mob3HP, ref mob3AC, ref mob3DmgMin, ref mob3DmgMax, ref mob4HP, ref mob4AC, ref mob4DmgMin, ref mob4DmgMax,
                                   ref north, ref south, ref east, ref west, ref prevMobs);
                }
                else if (possibleMobs)
                {
                    

                    genCreature.Clear();

                    CreatureGen(mobType1, mobType2, mobType3, mobNum, numMobDiffTypes, mobChance, genCreature, ref possibleMobs, ref prevMobs); // need to assign another var to skip this if it already gen creatures
                    

                    MobStats(genCreature);

                    MobStatAssign(genCreature, ref mob1HP, ref mob1AC, ref mob1DmgMin, ref mob1DmgMax, ref mob2HP, ref mob2AC, ref mob2DmgMin, ref mob2DmgMax, 
                                    ref mob3HP, ref mob3AC, ref mob3DmgMin, ref mob3DmgMax, ref mob4HP, ref mob4AC, ref mob4DmgMin, ref mob4DmgMax);

                    CharMovement(genCreature, ref isCampingOut, ref xCoord, ref yCoord, ref mob1HP, ref mob1AC, ref mob1DmgMin, ref mob1DmgMax, ref mob2HP, ref mob2AC,
                                   ref mob2DmgMin, ref mob2DmgMax, ref mob3HP, ref mob3AC, ref mob3DmgMin, ref mob3DmgMax, ref mob4HP, ref mob4AC, ref mob4DmgMin, ref mob4DmgMax,
                                   ref north, ref south, ref east, ref west, ref prevMobs);




                    
                }
                else
                {
                   
                    
                    CharMovement(genCreature, ref isCampingOut, ref xCoord, ref yCoord, ref mob1HP, ref mob1AC, ref mob1DmgMin, ref mob1DmgMax, ref mob2HP, ref mob2AC,
                                   ref mob2DmgMin, ref mob2DmgMax, ref mob3HP, ref mob3AC, ref mob3DmgMin, ref mob3DmgMax, ref mob4HP, ref mob4AC, ref mob4DmgMin, ref mob4DmgMax,
                                   ref north, ref south, ref east, ref west, ref prevMobs);
                }
                
            }

        }

        static void CharMovement(List<string>genCreature, ref bool isCampingOut, ref int xCoord, ref int yCoord, ref int mob1HP, ref int mob1AC, 
                                        ref int mob1DmgMin, ref int mob1DmgMax, ref int mob2HP, ref int mob2AC, ref int mob2DmgMin, ref int mob2DmgMax, ref int mob3HP, ref int mob3AC, 
                                        ref int mob3DmgMin, ref int mob3DmgMax, ref int mob4HP, ref int mob4AC, ref int mob4DmgMin, ref int mob4DmgMax, ref bool north, ref bool south, 
                                        ref bool east, ref bool west, ref bool prevMobs)
        {
            DiscribeArea:

            string playerChoice = Console.ReadLine();
            playerChoice = playerChoice.ToUpper();
            switch (playerChoice)
            {
                case "N":
                case "NORTH":
                    if (!north)
                    {
                        Console.WriteLine("You are unable to mobe in that direction!");
                        break;
                    }
                    
                    else
                    {
                        yCoord += 1;
                    }
                    break;

                case "S":
                case "SOUTH":
                    if (!south)
                    {
                        Console.WriteLine("You are unable to mobe in that direction!");
                        break;
                    }
                    else
                    {
                        yCoord -= 1;
                    }
                    break;

                case "E":
                case "EAST":
                    if (!east)
                    {
                        Console.WriteLine("You are unable to mobe in that direction!");
                        break;
                    }
                    else
                    {
                        xCoord += 1;
                    }
                    break;

                case "W":
                case "WEST":
                    if (!west)
                    {
                        Console.WriteLine("You are unable to mobe in that direction!");
                        break;
                    }
                    else
                    {
                        xCoord -= 1;
                    }
                    break;

                case "DISC":
                case "DISCRIBE":
                    Console.WriteLine("The following is in this area:");
                    int mobCount = genCreature.Count();
                    if (mobCount > 1)
                    {
                        Console.WriteLine($"a {genCreature[0]}");

                        if (mobCount > 5)
                        {
                            Console.WriteLine($"a {genCreature[5]}");

                            if (mobCount > 10)
                            {
                                Console.WriteLine($"a {genCreature[10]}");

                                if (mobCount > 15)
                                {
                                    Console.WriteLine($"a {genCreature[15]} appears!");
                                }
                            }
                        }
                    }
                    goto DiscribeArea;
                    

                case "P":
                    Console.WriteLine("******genCreature********");

                    foreach (string x in genCreature)
                    {
                        Console.WriteLine(x);
                    }
                    Console.WriteLine("**************");
                    Console.WriteLine("MOB 1 STATS");
                    Console.WriteLine($"1hp = {mob1HP}");
                    Console.WriteLine($"1AC = {mob1AC}");
                    Console.WriteLine($"1min = {mob1DmgMin}");
                    Console.WriteLine($"1max = {mob1DmgMax}");
                    Console.WriteLine("MOB 2 STATS");
                    Console.WriteLine($"2hp = {mob2HP}");
                    Console.WriteLine($"2AC = {mob2AC}");
                    Console.WriteLine($"2min = {mob2DmgMin}");
                    Console.WriteLine($"2max = {mob2DmgMax}");
                    Console.WriteLine("MOB 3 STATS");
                    Console.WriteLine($"3hp = {mob3HP}");
                    Console.WriteLine($"3AC = {mob3AC}");
                    Console.WriteLine($"3min = {mob3DmgMin}");
                    Console.WriteLine($"3max = {mob3DmgMax}");
                    Console.WriteLine("MOB 4 STATS");
                    Console.WriteLine($"4hp = {mob4HP}");
                    Console.WriteLine($"4AC = {mob4AC}");
                    Console.WriteLine($"4min = {mob4DmgMin}");
                    Console.WriteLine($"4max = {mob4DmgMax}");
                    
                    goto DiscribeArea;


                default:
                    Console.WriteLine("Please enter a correct command!");
                    goto DiscribeArea;

                case "CAMP":
                    isCampingOut = true;
                    break;



            }

        }

        static void CreatureGen(string mobType1, string mobType2, string mobType3, int mobTotalNumber, int totalNumMobDiffTypes, int mobPercentChance,
                                            List<string> genCreature, ref bool possibleAreMobs, ref bool prevMobs)
        {
            Random rnd = new Random();
            //genCreature.Clear();

            while (mobTotalNumber > 0)
            {
                //int baseChance = 1;
                int baseChance = rnd.Next(1, 101);
                Console.WriteLine(baseChance);

                if (baseChance < mobPercentChance)
                {
                    int rndMobType = rnd.Next(1, totalNumMobDiffTypes);
                    //Console.WriteLine($"which of the 3 mobs in area are going to spawn{rndMobType}");

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

            if (genCreature.Count() > 1)
            {
                possibleAreMobs = false;
                prevMobs = true;
            }


        }



        static void MobStats(List<string> genCreature)
        {

            int numMob = genCreature.Count();
            Console.WriteLine(numMob);

            int indexCount = 0;

            while (indexCount < numMob)
            {
                numMob = genCreature.Count();
                //Console.WriteLine(numMob);

                if (genCreature[indexCount] == "bandit")
                {
                    indexCount += 1;
                    genCreature.Insert(indexCount, "5");
                    genCreature.Insert(indexCount, "2");
                    genCreature.Insert(indexCount, "8");
                    genCreature.Insert(indexCount, "10");

                }
                else if (genCreature[indexCount] == "bat")
                {
                    indexCount += 1;
                    genCreature.Insert(indexCount, "3");
                    genCreature.Insert(indexCount, "1");
                    genCreature.Insert(indexCount, "4");
                    genCreature.Insert(indexCount, "6");

                }
                else if (genCreature[indexCount] == "bee")
                {
                    indexCount += 1;
                    genCreature.Insert(indexCount, "4");
                    genCreature.Insert(indexCount, "1");
                    genCreature.Insert(indexCount, "5");
                    genCreature.Insert(indexCount, "4");

                }
                else if (genCreature[indexCount] == "fairy")
                {
                    indexCount += 1;
                    genCreature.Insert(indexCount, "6");
                    genCreature.Insert(indexCount, "3");
                    genCreature.Insert(indexCount, "10");
                    genCreature.Insert(indexCount, "10");

                }
                else
                {
                    indexCount += 1;
                }


            }

        }


        static void MobStatAssign(List<string> genCreature, ref int mob1HP, ref int mob1AC, ref int mob1DmgMin, ref int mob1DmgMax, ref int mob2HP, ref int mob2AC, ref int mob2DmgMin, 
                                    ref int mob2DmgMax, ref int mob3HP, ref int mob3AC, ref int mob3DmgMin, ref int mob3DmgMax, ref int mob4HP, ref int mob4AC, 
                                    ref int mob4DmgMin, ref int mob4DmgMax)
        {
            int mobCount = genCreature.Count();

        
            Console.WriteLine("The following is in the area:");



            if (mobCount > 1)
            {
                Console.WriteLine($"a {genCreature[0]} appears!");
                mob1HP = Convert.ToInt32(genCreature[1]);
                mob1AC = Convert.ToInt32(genCreature[2]);
                mob1DmgMin = Convert.ToInt32(genCreature[3]);
                mob1DmgMax = Convert.ToInt32(genCreature[4]);

                if (mobCount > 5)
                {
                    Console.WriteLine($"a {genCreature[5]} appears!");
                    mob2HP = Convert.ToInt32(genCreature[6]);
                    mob2AC = Convert.ToInt32(genCreature[7]);
                    mob2DmgMin = Convert.ToInt32(genCreature[8]);
                    mob2DmgMax = Convert.ToInt32(genCreature[9]);

                    if (mobCount > 10)
                    {
                        Console.WriteLine($"a {genCreature[10]} appears!");
                        mob3HP = Convert.ToInt32(genCreature[11]);
                        mob3AC = Convert.ToInt32(genCreature[12]);
                        mob3DmgMin = Convert.ToInt32(genCreature[13]);
                        mob3DmgMax = Convert.ToInt32(genCreature[14]);

                        if (mobCount > 15)
                        {
                            Console.WriteLine($"a {genCreature[15]} appears!");
                            mob4HP = Convert.ToInt32(genCreature[16]);
                            mob4AC = Convert.ToInt32(genCreature[17]);
                            mob4DmgMin = Convert.ToInt32(genCreature[18]);
                            mob4DmgMax = Convert.ToInt32(genCreature[19]);

                        }
                    }

                }
            }
        }
            


        



        static void CharLocation(int xLoc, int yLoc, ref int currentXPosition, ref int currentYPosition, ref string mobType1, ref string mobType2, ref string mobType3, ref int currentMobNum, 
                                    ref int currentNumMobDiffTypes, ref int currentMobChance, ref bool possibleAreMobs, ref bool prevMobs, ref bool north, ref bool south, ref bool east, ref bool west) // Character locations with descriptions
        {
            

            
            if (xLoc == 10 && yLoc == 10) // Felwith Gates
            {
                Console.WriteLine("FELWITH GATES");
                currentXPosition = 10;
                currentYPosition = 10;
                east = false;
                south = false;
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
                east = false;
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
                east = false;
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



            else if (xLoc == 9 && yLoc == 10) // Lesser Faydark enterance
            {
                Console.WriteLine("LESSER FAYDARK ENTERANCE");
                currentXPosition = 9;
                currentYPosition = 10;
                south = false;
            }
            else if (xLoc == 8 && yLoc == 10) // Wizard Combines
            {
                Console.WriteLine("WIZARD COMBINES");
                currentXPosition = 8;
                currentYPosition = 10;
                south = false;
            }
            else if (xLoc == 7 && yLoc == 10) // Butcherblock Enterance
            {
                Console.WriteLine("BUTCHERBLOCK MTNS ENTERANCE");
                currentXPosition = 7;
                currentYPosition = 10;
                west = false;
                south = false;
            }
            else if (xLoc == 6 && yLoc == 10) // Butcherblock UNABLE TO ENTER
            {
                currentXPosition = 7;
                currentYPosition = 10;
            }
            else if (xLoc == 11 && yLoc == 10) // Felwith Gates CLOSED
            {
                currentXPosition = 10;
                currentYPosition = 10;
            }
            else if (xLoc == 10 && yLoc == 9) // lesser faydark south, terrain too rough
            {
                currentXPosition = 10;
                currentYPosition = 10;
            }
            else if (xLoc == 9 && yLoc == 9) // lesser faydark south, road closed
            {
                currentXPosition = 9;
                currentYPosition = 10;
            }
            else if (xLoc == 8 && yLoc == 9) // lesser faydark south, terrain too rough
            {
                currentXPosition = 8;
                currentYPosition = 10;
            }
            else if (xLoc == 7 && yLoc == 9) // lesser faydark south, terrain too rough
            {
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 11) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 11;
            }
            else if (xLoc == 11 && yLoc == 11) // Gfay forest too dense to pass
            {
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 12) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 12;
            }
            else if (xLoc == 11 && yLoc == 12) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 12;
            }



            else if (xLoc == 10 && yLoc == 13) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 13;
                east = false;
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 13) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 13;
            }
            else if (xLoc == 11 && yLoc == 13) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 13;
            }



            else if (xLoc == 10 && yLoc == 14) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 14;
                east = false;
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 14) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 14;
            }
            else if (xLoc == 11 && yLoc == 14) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 14;
            }



            else if (xLoc == 10 && yLoc == 15) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 15;
                east = false;
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 15) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 15;
            }
            else if (xLoc == 11 && yLoc == 15) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 15;
            }



            else if (xLoc == 10 && yLoc == 16) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 16;
                east = false;
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 16) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 16;
            }
            else if (xLoc == 11 && yLoc == 16) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 16;
            }



            else if (xLoc == 10 && yLoc == 17) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
                currentXPosition = 10;
                currentYPosition = 17;
                east = false;
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 17) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 17;
            }
            else if (xLoc == 11 && yLoc == 17) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 17;
            }



            else if (xLoc == 10 && yLoc == 18) // GFay Forest Starting Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST SMALLER CLIFFS IN AREA");
                currentXPosition = 10;
                currentYPosition = 18;
                east = false;
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 18) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 18;
            }
            else if (xLoc == 11 && yLoc == 18) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 18;
            }



            else if (xLoc == 10 && yLoc == 19) // GFay Forest Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST EXTREAM CLIFF FACES");
                currentXPosition = 10;
                currentYPosition = 19;
                east = false;
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
                west = false;
            }
            else if (xLoc == 6 && yLoc == 19) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 19;
            }
            else if (xLoc == 11 && yLoc == 19) // Gfay forest, cliffs impassible
            {
                currentXPosition = 10;
                currentYPosition = 19;
            }



            else if (xLoc == 10 && yLoc == 20) // GFay Forest Cliffs North and East
            {
                Console.WriteLine("GREATER FAYDARK FOREST EXTREAM CLIFF FACES ON TWO SIDES OF YOU");
                currentXPosition = 10;
                currentYPosition = 20;
                east = false;
                north = false;
            }
            else if (xLoc == 9 && yLoc == 20) // GFay Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST MERGING TO SHARP CLIFF FACE");
                currentXPosition = 9;
                currentYPosition = 20;
                north = false;
            }
            else if (xLoc == 8 && yLoc == 20) // GFay Crushbone Enterance
            {
                Console.WriteLine("GREATER FAYDARK WITH CRUSHBONE ENTERANCE GUARDED");
                currentXPosition = 8;
                currentYPosition = 20;
                north = false;
            }
            else if (xLoc == 7 && yLoc == 20) // GFay Forest Mtns Merging with Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MERGING WITH CLIFFS");
                currentXPosition = 7;
                currentYPosition = 20;
                west = false;
                north = false;
            }
            else if (xLoc == 6 && yLoc == 20) // Butcherblock to the west, mtns impassible
            {
                currentXPosition = 7;
                currentYPosition = 20;
            }
            else if (xLoc == 11 && yLoc == 20) // Gfay forest too dense to pass
            {
                currentXPosition = 10;
                currentYPosition = 20;
            }



            else if (xLoc == 7 && yLoc == 21) // Crushbone north, cliffs impassible
            {
                currentXPosition = 7;
                currentYPosition = 20;
            }
            else if (xLoc == 10 && yLoc == 21) // Crushbone north, cliffs impassible
            {
                currentXPosition = 10;
                currentYPosition = 20;
            }
            else if (xLoc == 8 && yLoc == 21) // Crushbone north, enterance guarded
            {
                currentXPosition = 8;
                currentYPosition = 20;
            }
            else if (xLoc == 9 && yLoc == 21) // Crushbone north, cliffs impassible
            {
                currentXPosition = 9;
                currentYPosition = 20;
            }
        }
    }
}
