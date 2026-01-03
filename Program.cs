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
            outputWriter.WriteLine("Your rolled number will count, who will have total count of 20 WINS! (if count is same computer WINS :)", ConsoleColor.DarkRed);
            outputWriter.WriteLine("\nREADY? Lest beguin!", ConsoleColor.Red); //ten překlad je na piču ja vim no :/
            int CelekHrace = 0;
            int CelekPc = 0;
            while (true)
            {
                outputWriter.WriteLine("\n\nPress enter to roll dice", ConsoleColor.Green); //loop aby neskoncil
                string LetsBeguin = Console.ReadLine();
                int HodHrace = kostka.hod(1, 6);
                outputWriter.WriteLine("You rolled " + HodHrace + " . . .", ConsoleColor.Red);
                writeDice.logo(HodHrace);
                int HodPc = kostka.hod(1, 6);
                outputWriter.WriteLine("Computer rolled " + HodPc + " . . .", ConsoleColor.Red);
                writeDice.logo(HodPc);
                CelekHrace = CelekHrace + HodHrace;
                CelekPc = CelekPc + HodPc;
                outputWriter.WriteLine("Well now its like this:"); //show score
                outputWriter.Write("COMPUTER ", ConsoleColor.DarkRed);
                outputWriter.Write("has " + CelekPc + " and ", ConsoleColor.Green);
                outputWriter.Write(" YOU ", ConsoleColor.DarkRed);
                outputWriter.Write("has " + CelekHrace, ConsoleColor.Green);
                if (CelekHrace > 20)
                {
                    outputWriter.WriteLine("\nWell you won, so congratulation I think ?!", ConsoleColor.Red); //možnost ukkoncit
                    outputWriter.WriteLine("Final score is:", ConsoleColor.Green);
                    outputWriter.WriteLine("               YOU: " + CelekHrace, ConsoleColor.Red);
                    outputWriter.WriteLine("               COMPUTER: " + CelekPc, ConsoleColor.Red);
                    break;
                }
                if (CelekPc > 20)
                {
                    outputWriter.WriteLine("\nLooks like you LOST, looser hahaha!", ConsoleColor.Red);
                    outputWriter.WriteLine("Final score is:", ConsoleColor.Green);
                    outputWriter.WriteLine("               COMPUTER: " + CelekPc, ConsoleColor.Red);
                    outputWriter.WriteLine("               YOU: " + CelekHrace, ConsoleColor.Red);
                    break;
                }

                if (CelekPc == CelekHrace && CelekHrace > 19 && CelekPc > 19)
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


