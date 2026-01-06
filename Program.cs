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
            NormalModePlay normalModePlay = new NormalModePlay();
            SuddenDeath suddenDeath = new SuddenDeath();
            HardCorePlay hardCorePlay = new HardCorePlay();
            RoundsCustom roundsCustom = new RoundsCustom();

            Console.Clear();
            outputWriter.WriteLine("=== Simple dice game ===", ConsoleColor.Green); //tutorial / popis
            outputWriter.WriteLine("You are playng agenst computer, when you roll the dice it appers number 1-6 (or something) then computer rolls", ConsoleColor.DarkRed);
            outputWriter.WriteLine("Your rolled number will count,those number will be count and bigger gets win (if count is same computer WINS :) )", ConsoleColor.DarkRed);
            outputWriter.WriteLine("First dice has maximum of 6 walls, second dice has maximum of 10 walls (totaly random generated)", ConsoleColor.Green);
            outputWriter.WriteLine("\nREADY? Lest beguin!", ConsoleColor.Red);
            outputWriter.WriteLine("Before we beguin, select your gamemode", ConsoleColor.Red);
            outputWriter.WriteLine("\n1 → Normal mode - 3 rounds of rolling");
            outputWriter.WriteLine("2 → Sudden death - who roll biguest number = wins");
            outputWriter.WriteLine("3 → HardCore - Computer gets buff all rounds");
            outputWriter.WriteLine("4 → Rounds++ - select how much rounds you want to play");
            outputWriter.Write("Your choice: ", ConsoleColor.DarkRed);
            int play = inputReader.ReadInt();
            string mode = "nothing";

            if (play == 1)
            {
                normalModePlay.play();
                mode = "Normal mode";
            }

            if (play == 2)
            {
                suddenDeath.play();
                mode = "Sudden death";
            }

            if (play == 3)
            {
                hardCorePlay.play();
                mode = "HardCore mode";
            }

            if (play == 4)
            {
                outputWriter.WriteLine("How much rounds you want to play? (3-xxx.)", ConsoleColor.Green);
                outputWriter.Write("Your choice: ", ConsoleColor.DarkRed);
                int rounds = inputReader.ReadInt();
                roundsCustom.play(rounds);
                mode = "Rounds++";
            }

            outputWriter.WriteLine($"Mode played: {mode}");
            outputWriter.WriteLine("\nThanks for plaing Roll the dice!", ConsoleColor.Green); //konec
            outputWriter.WriteLine("Made by RozbitiOkno 1/3/26/");
        }
    }
}


