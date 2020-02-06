using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class UserPlayer : Player
    {
        private int wins;
        private int losses;

        public string Name { get => name; set => name = value; }
        public string Choice { get => choice; set => choice = value; }
        public int Wins { get => wins; set => wins = value; }
        public int Losses { get => losses; set => losses = value; }


        public UserPlayer(string _name, string _choice, int _wins)
        {
            _name = name;
            _choice = choice;
            _wins = wins;
        }

        public override Roshambo_Enum GetRoshambo()
        {
            throw new NotImplementedException();
        }
        public override Roshambo_Enum GetRoshambo(int value)
        {
            if (value == 1)
            {
                return Roshambo_Enum.Rock;
            }
            else if (value == 2)
            {
                return Roshambo_Enum.Paper;
            }
            else if (value == 3)
            {
                return Roshambo_Enum.Scissors;
            }
            else
            {
                return Roshambo_Enum.Rock;
            }
        }

        
    }
}
