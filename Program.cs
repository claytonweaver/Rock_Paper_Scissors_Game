using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain = "Would you like to try again? (y/n)";

            RoshamboApp app = new RoshamboApp();

            bool resume = false;

            do
            {
                try
                {
                    ShowMainMenu();
                    int input = int.Parse(GetUserInput(""));
                    if (input == 1)
                    {
                        
                        app.SetUserName();

                        int opponentChoice = AskWhichOpponentToFight();

                        if (opponentChoice == 1)
                        {

                            app.DumbGame();
                            resume = AskToTryAgain(GetUserInput(tryAgain));

                        }
                        else if (opponentChoice == 2)
                        {
                            app.Game();
                            resume = AskToTryAgain(GetUserInput(tryAgain));
                        }
                        else if (AskWhichOpponentToFight() != 1 && AskWhichOpponentToFight() != 2)
                        {
                            resume = AskToTryAgain(GetUserInput(tryAgain));
                        }

                    }
                    else if (input == 2)
                    {
                        resume = false;
                    }
                    else if (input != 2 || input != 1)
                    {
                        resume = AskToTryAgain(GetUserInput(tryAgain));
                    }
                }
                catch (Exception)
                {

                    resume = AskToTryAgain(GetUserInput(tryAgain));
                }
            } while (resume == true);


        }

        public static void ShowMainMenu()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Quit");
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool AskToTryAgain(string input)
        {
            try
            {
                if (input.ToLower()[0] == 'y')
                    return true;
                else if (input.ToLower()[0] == 'n')
                    return false;
                else
                    Console.WriteLine("Wrong input. Would you like to try again? (y/n)");
                string input2 = Console.ReadLine();
                AskToTryAgain(input2);
            }
            catch (StackOverflowException)
            {
                string userError = GetUserInput("That's not right. Try again: 'y' or 'n'");
                AskToTryAgain(userError);
            }
            return true;
        }

        public static int AskWhichOpponentToFight()
        {
            try
            {
                return int.Parse(GetUserInput("Which opponent would you like to fight? \n 1. Rock Guy \n 2. Normal Guy"));

            }
            catch (Exception)
            {

               return AskWhichOpponentToFight();

            }
        }
    }
}
