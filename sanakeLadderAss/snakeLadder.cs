using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanakeLadderAss
{
    internal class snakeLadder
    {
        public void snakeLadderG()
        {
            {
                int Position1 = 0; //------------------------------------------------------------uc1
                int Position2 = 0;

                int count1 = 0;
                int count2 = 0;

                Random random = new Random();
                while (Position1 != 100 || Position2 != 100)// ---------------------------------uc4
                {
                    Console.WriteLine("Player 1 turn");

                    
                    
                    int DieNumber1 = random.Next(1, 7);//-----------------------------------------uc2
                    Console.WriteLine("Player rolled the Die ....");
                    Console.WriteLine("Dies turns to, " + DieNumber1);
                    int Option1 = random.Next(1, 4);

                    switch (Option1)//------------------------------------------------------------uc3      
                    {
                        case 1:

                            Console.WriteLine("you are at No Play option");
                            Console.WriteLine("Current Position: " + Position1);//----------------uc6
                            break;

                        case 2:
                            Console.WriteLine("you Get Move Ahead option");
                            Console.WriteLine("Great! You get to Move Ahead, By " + DieNumber1);
                            Position1 = Position1 + DieNumber1;
                            Console.WriteLine("Current Position: " + Position1);

                            break;
                        case 3:
                            Console.WriteLine("But you get Move back option");
                            Console.WriteLine("Oops! you Need to Move Back, By" + DieNumber1);
                            Position1 = Position1 - DieNumber1;
                            Console.WriteLine("Current Position: " + Position1);

                            break;
                    }

                    if (Position1 < 0)
                    {

                        Console.WriteLine("Please Restart");
                        Position1 = 0;
                        continue;
                    }
                    if (Position1 == 100)//---------------------------------------------------uc5 + uc7
                    {
                        Console.WriteLine("Player One wins");
                        break;
                    }
                   


                    Console.WriteLine("Player 2 turn");
                    int DieNumber2 = random.Next(1, 7);
                    Console.WriteLine("Player rolled the Die ....");
                    Console.WriteLine("Dies turns to, " + DieNumber2);
                    int Option2 = random.Next(1, 4);

                    switch (Option2)
                    {
                        case 1:

                            Console.WriteLine("you are at No Play option");
                            Console.WriteLine("Current Position: " + Position2);
                            break;

                        case 2:
                            Console.WriteLine("you Get Move Ahead option");
                            Console.WriteLine("Great! You get to Move Ahead, By " + DieNumber2);
                            Position2 = Position2 + DieNumber2;
                            Console.WriteLine("Current Position: " + Position2);

                            break;
                        case 3:
                            Console.WriteLine("But you get Move back option");
                            Console.WriteLine("Oops! you Need to Move Back, By" + DieNumber2);
                            Position2 = Position2 - DieNumber2;
                            Console.WriteLine("Current Position: " + Position2);

                            break;
                    }

                    if (Position2 < 0)
                    {

                        Console.WriteLine("Please Restart");
                        Position2 = 0;
                        continue;
                    }

                    if (Position2 == 100)
                    {
                        Console.WriteLine("Player Two wins");
                        break;
                    }
                }
            }
        }
    }
}
