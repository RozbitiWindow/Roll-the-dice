using CalculatorApp;
using logo;


namespace kostka
{
    class Program

    {
        static void Main()
        {
            OutputWriter outputWriter = new OutputWriter(); //no tak zařazení - jasny
            InputReader inputReader = new InputReader();
            Kostka kostka = new Kostka();
            WriteDice writeDice = new WriteDice();

            Console.Clear();
            outputWriter.WriteLine("=== Simple dice game ===", ConsoleColor.Green); //tutorial / popis
            outputWriter.WriteLine("You are plaing agenst computer, when you roll the dice it appers number 1-6 (or something) then computer rolls", ConsoleColor.DarkRed);
            outputWriter.WriteLine("Your rolled number will count, who will have total count of 40 WINS! (if count is same computer WINS :) )", ConsoleColor.DarkRed);
            outputWriter.WriteLine("First dice has maximum of 6 walls, second dice has maximum of 10 walls (totaly random generated)", ConsoleColor.Green);
            outputWriter.WriteLine("\nREADY? Lest beguin!", ConsoleColor.Red); //ten překlad je na piču ja vim no :/
            int CelekHrace = 0;
            int CelekPc = 0;
            while (true)
            {
                outputWriter.WriteLine("\n\nPress enter to roll dice", ConsoleColor.Green); //loop aby neskoncil
                string LetsBeguin = Console.ReadLine();
                Console.Clear();
                int HodHrace = kostka.hod(6);
                outputWriter.WriteLine("You rolled " + HodHrace + " . . .", ConsoleColor.Magenta);
                writeDice.Logo(HodHrace);
                int HodPc = kostka.hod(6);
                outputWriter.WriteLine("Computer rolled " + HodPc + " . . .", ConsoleColor.Red);
                writeDice.Logo(HodPc);
                CelekHrace = CelekHrace + HodHrace;
                CelekPc = CelekPc + HodPc;
                int HodHrace2 = kostka.hod(10);
                outputWriter.WriteLine("You rolled " + HodHrace2 + " . . .", ConsoleColor.Magenta);
                writeDice.Logo(HodHrace2);
                int HodPc2 = kostka.hod(10);
                outputWriter.WriteLine("Computer rolled " + HodPc2 + " . . .", ConsoleColor.Red);
                writeDice.Logo(HodPc2);
                CelekHrace = CelekHrace + HodHrace2;
                CelekPc = CelekPc + HodPc2;
                outputWriter.WriteLine("Well now its like this:"); //show score
                outputWriter.Write("COMPUTER ", ConsoleColor.DarkRed);
                outputWriter.Write("has " + CelekPc + " and ", ConsoleColor.Green);
                outputWriter.Write(" YOU ", ConsoleColor.DarkRed);
                outputWriter.Write("has " + CelekHrace, ConsoleColor.Green);
                if (CelekHrace > 40)
                {
                    outputWriter.WriteLine("\nWell you won, so congratulation I think ?!", ConsoleColor.Red); //možnost ukkoncit
                    outputWriter.WriteLine("Final score is:", ConsoleColor.Green);
                    outputWriter.WriteLine("               YOU: " + CelekHrace, ConsoleColor.Red);
                    outputWriter.WriteLine("               COMPUTER: " + CelekPc, ConsoleColor.Red);
                    break;
                }
                if (CelekPc > 40)
                {
                    outputWriter.WriteLine("\nLooks like you LOST, looser hahaha!", ConsoleColor.Red);
                    outputWriter.WriteLine("Final score is:", ConsoleColor.Green);
                    outputWriter.WriteLine("               COMPUTER: " + CelekPc, ConsoleColor.Red);
                    outputWriter.WriteLine("               YOU: " + CelekHrace, ConsoleColor.Red);
                    break;
                }

                if (CelekPc == CelekHrace && CelekHrace > 39 && CelekPc > 39)
                {
                    outputWriter.WriteLine("\nLooks like you LOST, looser hahaha!", ConsoleColor.Red);
                    outputWriter.WriteLine("Final score is:", ConsoleColor.Green);
                    outputWriter.WriteLine("               COMPUTER: " + CelekPc, ConsoleColor.Red);
                    outputWriter.WriteLine("               YOU: " + CelekHrace, ConsoleColor.Red);
                    outputWriter.WriteLine("\nLike we said if count is same YOU LOST!", ConsoleColor.Red);
                    break;
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


