using System.Security.Principal;
using CalculatorApp;

namespace DiceGame
{
    class Program

    {
        static void Main()
        {
            OutputWriter outputWriter = new OutputWriter(); //objekty
            InputReader inputReader = new InputReader();
            DiceLogo diceLogo = new DiceLogo();
            Dice dice = new Dice();

            Console.Clear();
            outputWriter.WriteLine("=== Simple dice game ===", ConsoleColor.Green); //tutorial / popis
            outputWriter.WriteLine("You are plaing agenst computer, when you roll the dice it appers number 1-6 (or something) then computer rolls", ConsoleColor.DarkRed);
            outputWriter.WriteLine("Your rolled number will count,those number will be count and bigger gets win (if count is same computer WINS :) )", ConsoleColor.DarkRed);
            outputWriter.WriteLine("First dice has maximum of 6 walls, second dice has maximum of 10 walls (totaly random generated)", ConsoleColor.Green);
            outputWriter.WriteLine("\nREADY? Lest beguin!", ConsoleColor.Red);
            int CelekHrace = 0;
            int CelekPc = 0;
            int actualround = 0;
            int pcwins = 0;
            int yourwins = 0;
            while (true)
            {
                actualround++;
                outputWriter.WriteLine("\n\nPress enter to roll dice", ConsoleColor.Green); //loop aby neskoncil
                string LetsBeguin = Console.ReadLine();
                Console.Clear();
                int HodHrace = dice.hod();
                outputWriter.WriteLine("You rolled " + HodHrace + " . . .", ConsoleColor.Magenta);
                diceLogo.Logo(HodHrace);
                int HodPc = dice.hod();
                outputWriter.WriteLine("Computer rolled " + HodPc + " . . .", ConsoleColor.Red);
                diceLogo.Logo(HodPc);
                CelekHrace = CelekHrace + HodHrace;
                CelekPc = CelekPc + HodPc;
                int HodHrace2 = dice.hod(10);
                outputWriter.WriteLine("You rolled " + HodHrace2 + " . . .", ConsoleColor.Magenta);
                diceLogo.Logo(HodHrace2);
                int HodPc2 = dice.hod(10);
                outputWriter.WriteLine("Computer rolled " + HodPc2 + " . . .", ConsoleColor.Red);
                diceLogo.Logo(HodPc2);
                outputWriter.Write("Score now YOU: " + HodHrace + " + " + HodHrace2 + " = ");
                outputWriter.WriteLine((HodHrace + HodHrace2).ToString());
                outputWriter.Write("          PC: " + HodPc + " + " + HodPc2 + " = ");
                outputWriter.WriteLine((HodPc + HodPc2).ToString());

                if (HodHrace+HodHrace2 > HodPc+HodPc2)
                {
                    yourwins++;
                }
                else
                {
                    pcwins++;
                }

                if (actualround == 3)
                {
                    if (yourwins > pcwins)
                    {
                        outputWriter.WriteLine("Well you won!");
                        outputWriter.WriteLine($"Final score was: YOU: {yourwins} PC: {pcwins} - thanks for plaing");
                        break;
                    }
                    else
                    {
                        outputWriter.WriteLine("Its look like you lost!");
                        outputWriter.WriteLine($"Final score was: YOU: {yourwins} PC: {pcwins} - thanks for plaing");
                        break;
                    }
                    
                }
                else
                {
                    continue;
                }

                

                
            }

            outputWriter.WriteLine("\nThanks for plaing Roll the dice!", ConsoleColor.Green); //konec
            outputWriter.WriteLine("Made by RozbitiOkno 1/3/26/");
        }
    }
}


