using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class RoshamboApp
    {

        DumbPlayer dumbPlayer = new DumbPlayer("Dumb Player", "");
        NormalPlayer normalPlayer = new NormalPlayer("Normal Player", "");
        UserPlayer userPlayer = new UserPlayer("Default", "",0);

        public void PlayDumbRockOpponent()
        {


            if (userPlayer.Choice == "Rock")
            {
                Console.WriteLine("It's a tie!");
                ShowScore();
            }
            else if (userPlayer.Choice == "Paper")
            {
                Console.WriteLine($"The player used rock and you used {userPlayer.Choice}");
                YouWin();
            }
            else if (userPlayer.Choice == "Scissors")
            {
                Console.WriteLine($"The player used rock and you used {userPlayer.Choice}");
                YouWin();
            }
        }
        public void PlayRockOpponent()
        {
            if (userPlayer.Choice == "Rock")
            {
                Console.WriteLine("It's a tie! Try again.");
                ShowScore();
            }
            else if (userPlayer.Choice == "Paper")
            {
                Console.WriteLine($"The player used rock and you used {userPlayer.Choice}");
                YouWin();
            }
            else if (userPlayer.Choice == "Scissors")
            {
                Console.WriteLine($"The player used rock and you used {userPlayer.Choice}");
                YouLose();
            }
        }
        public void PlayPaperOpponent()
        {
            if (userPlayer.Choice == "Rock")
            {
                Console.WriteLine($"The player used paper and you used {userPlayer.Choice}");
                YouLose();
            }
            else if (userPlayer.Choice == "Paper")
            {
                Console.WriteLine("It's a tie! Try again.");
                ShowScore();

            }
            else if (userPlayer.Choice == "Scissors")
            {
                Console.WriteLine($"The player used Paper and you used {userPlayer.Choice}"); 
                YouWin();
            }
        }
        public void PlayScissorsOpponent()
        {
            if (userPlayer.Choice == "Rock")
            {
                Console.WriteLine($"The player used scissors and you used {userPlayer.Choice}");
                YouWin();
            }
            else if (userPlayer.Choice == "Paper")
            {
                Console.WriteLine($"The player used scissors and you used {userPlayer.Choice}"); 
                YouLose();
            }
            else if (userPlayer.Choice == "Scissors")
            {
                Console.WriteLine("It's a tie! Try again.");
                ShowScore();

            }
        }
        public void GetUserWeapon()
        {
            int userChoice = int.Parse(Program.GetUserInput("What's your weapon of choice? \n 1. Rock \n 2. Paper \n 3. Scissors"));
            if (userChoice == 1)
            {
                userPlayer.Choice = Roshambo_Enum.Rock.ToString();
            }
            if (userChoice == 2)
            {
                userPlayer.Choice = Roshambo_Enum.Paper.ToString();
            }
            if (userChoice == 3)
            {
                userPlayer.Choice = Roshambo_Enum.Scissors.ToString();
            }



        }
        public void Game()
        {
            GetUserWeapon();
            string opponentChoice = normalPlayer.GetRoshambo().ToString();

            if (opponentChoice == "Rock")
            {
                PlayRockOpponent();
            }
            else if (opponentChoice == "Paper")
            {
                PlayPaperOpponent();
            }
            else if (opponentChoice == "Scissors")
            {
                PlayScissorsOpponent();
            }

        }
        public void YouWin()
        {
            Console.WriteLine($"You've won, {userPlayer.Name}!");
            userPlayer.Wins++;
            ShowScore();

        }
        public void YouLose()
        {
            Console.WriteLine($"You've lost, {userPlayer.Name}...");
            userPlayer.Losses++;
            ShowScore();
        }
        public void DumbGame()
        {
            GetUserWeapon();

            string dumbChoice = dumbPlayer.GetRoshambo().ToString();

            PlayRockOpponent();

        }
        public void SetUserName()
        {
            
            string lastUsedName = userPlayer.Name;
            if (userPlayer.Name != lastUsedName || userPlayer.Name == null)
            {
                string input = Program.GetUserInput("What would you like your name to be?");
                userPlayer.Name = input;
            }
            
        }

        public void ShowScore()
        {
            int wins = userPlayer.Wins;
            int losses = userPlayer.Losses;
            Console.WriteLine($"{userPlayer.Name}'s score is {wins} wins and {losses} losses.");

        }











    }
}
