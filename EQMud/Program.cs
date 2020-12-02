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
            Console.WriteLine("******EQ MUD TITLE SCREEN******");

            // Code area for start new or continue

            // Coding for movement
            
            while(!isCampingOut)
            {
                Console.WriteLine($"Current xCoord is: {xCoord}");
                Console.WriteLine($"Current yCoord is: {yCoord}");
                CharLocation(xCoord, yCoord);
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
                        if (xCoord == 11)
                        {

                        }
                        break;

                    case "W":
                    case "WEST":
                        xCoord -= 1;
                        break;

                    case "CAMP":
                        isCampingOut = true;
                        break;



                }
            }

        }
        static void CharLocation(int xLoc, int yLoc)
        {

            if (xLoc == 10 && yLoc == 10) // Felwith Gates
            {
                Console.WriteLine("FELWITH GATES"); 
            }
            else if (xLoc == 9 && yLoc == 10) // Lesser Faydark enterance
            {
                Console.WriteLine("LESSER FAYDARK ENTERANCE");
            }
            else if (xLoc == 8 && yLoc == 10) // Wizard Combines
            {
                Console.WriteLine("WIZARD COMBINES");
            }
            else if (xLoc == 7 && yLoc == 10) // Butcherblock Enterance
            {
                Console.WriteLine("BUTCHERBLOCK MTNS ENTERANCE");
            }
            else if (xLoc == 6 && yLoc == 10) // Butcherblock Enterance
            {
                Console.WriteLine("THE ROAD TO BUTCHERBLOCK HAS A ROCK SLIDE YOUR CURRENTLY UNABLE TO PASS!");
                xLoc = 7;
            }

            else if (xLoc == 10 && yLoc == 11) // GFay Hills and Trees NFelwith
            {
                Console.WriteLine("GREATER FAYDARK HILLS NORTH OF FELWITH");
            }
            else if (xLoc == 9 && yLoc == 11) // Bandit Camp
            {
                Console.WriteLine("BANDIT CAMP");
            }
            else if (xLoc == 8 && yLoc == 11) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
            }
            else if (xLoc == 7 && yLoc == 11) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAIN VALLEY");
            }

            else if (xLoc == 10 && yLoc == 12) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
            }
            else if (xLoc == 9 && yLoc == 12) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
            }
            else if (xLoc == 8 && yLoc == 12) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
            }
            else if (xLoc == 7 && yLoc == 12) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
            }

            else if (xLoc == 10 && yLoc == 13) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
            }
            else if (xLoc == 9 && yLoc == 13) // Kelethin SE Lift
            {
                Console.WriteLine("KELETHIN SE LIFT");
            }
            else if (xLoc == 8 && yLoc == 13) // Kelethin SW Lift
            {
                Console.WriteLine("KELETHIN SW LIFT");
            }
            else if (xLoc == 7 && yLoc == 13) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
            }

            else if (xLoc == 10 && yLoc == 14) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
            }
            else if (xLoc == 9 && yLoc == 14) // GFay Forest Kelethin Above
            {
                Console.WriteLine("GREATER FAYDARK FOREST KELETHIN TOWN ABOVE");
            }
            else if (xLoc == 8 && yLoc == 14) // GFay Forest Kelethin Above
            {
                Console.WriteLine("GREATER FAYDARK FOREST KELETHIN TOWN ABOVE");
            }
            else if (xLoc == 7 && yLoc == 14) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
            }

            else if (xLoc == 10 && yLoc == 15) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
            }
            else if (xLoc == 9 && yLoc == 15) // GFay Abandoned Druid Ring
            {
                Console.WriteLine("GREATER FAYDARK ABANDONED DRUID RING");
            }
            else if (xLoc == 8 && yLoc == 15) // GFay Forest Kelethin Above
            {
                Console.WriteLine("GREATER FAYDARK FOREST KELETHIN TOWN ABOVE");
            }
            else if (xLoc == 7 && yLoc == 15) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
            }

            else if (xLoc == 10 && yLoc == 16) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
            }
            else if (xLoc == 9 && yLoc == 16) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
            }
            else if (xLoc == 8 && yLoc == 16) // GFay Forest Kelethin Northern Lift
            {
                Console.WriteLine("KELETHIN NORTHERN LIFT");
            }
            else if (xLoc == 7 && yLoc == 16) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
            }

            else if (xLoc == 10 && yLoc == 17) // GFay Forest Deep
            {
                Console.WriteLine("GREATER FAYDARK FOREST GETTING THICKER");
            }
            else if (xLoc == 9 && yLoc == 17) // GFay Forest
            {
                Console.WriteLine("GREATER FAYDARK FOREST");
            }
            else if (xLoc == 8 && yLoc == 17) // GFay Forest Road to Crushbone
            {
                Console.WriteLine("GREATER FAYDARK FOREST ROAD TO CRUSHBONE");
            }
            else if (xLoc == 7 && yLoc == 17) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
            }

            else if (xLoc == 10 && yLoc == 18) // GFay Forest Starting Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST SMALLER CLIFFS IN AREA");
            }
            else if (xLoc == 9 && yLoc == 18) // GFay Forest Smaller Orc Camps
            {
                Console.WriteLine("GREATER FAYDARK FOREST SMALL ORC HUTS IN AREA");
            }
            else if (xLoc == 8 && yLoc == 18) // GFay Forest Road to Crushbone with Easy Area
            {
                Console.WriteLine("GREATER FAYDARK FOREST ROAD TO CRUSHBONE WITH SMALLER ORC HUTS IN AREA");
            }
            else if (xLoc == 7 && yLoc == 18) // GFay Forest Mtns
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS");
            }

            else if (xLoc == 10 && yLoc == 19) // GFay Forest Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST EXTREAM CLIFF FACES");
            }
            else if (xLoc == 9 && yLoc == 19) // GFay Forest Medium Orc Camps
            {
                Console.WriteLine("GREATER FAYDARK FOREST MEDIUM ORC HUTS IN AREA");
            }
            else if (xLoc == 8 && yLoc == 19) // GFay Forest Road to Crushbone with Hard Area
            {
                Console.WriteLine("GREATER FAYDARK FOREST ROAD TO CRUSHBONE WITH MAJOR ORC CAMP IN AREA");
            }
            else if (xLoc == 7 && yLoc == 19) // GFay Forest Mtns With Medium Orc Camps
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MEDIUM ORC HUTS IN AREA");
            }

            else if (xLoc == 10 && yLoc == 20) // GFay Forest Cliffs North and East
            {
                Console.WriteLine("GREATER FAYDARK FOREST EXTREAM CLIFF FACES ON TWO SIDES OF YOU");
            }
            else if (xLoc == 9 && yLoc == 20) // GFay Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST MERGING TO SHARP CLIFF FACE");
            }
            else if (xLoc == 8 && yLoc == 20) // GFay Crushbone Enterance
            {
                Console.WriteLine("GREATER FAYDARK WITH CRUSHBONE ENTERANCE GUARDED");
            }
            else if (xLoc == 7 && yLoc == 20) // GFay Forest Mtns Merging with Cliffs
            {
                Console.WriteLine("GREATER FAYDARK FOREST BOARDING MOUNTAINS AND MERGING WITH CLIFFS");
            }
        }
    }
}
