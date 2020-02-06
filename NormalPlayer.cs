using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class NormalPlayer : Player
    {
        public string Name { get => name; set => name = value; }
        public string Choice { get => choice; set => choice = value; }

        public NormalPlayer()
        {

        }
        public NormalPlayer(string _name, string _choice)
        {
            _name = name;
            _choice = choice;
        }
        
        public override Roshambo_Enum GetRoshambo()
        {
            int value = 0;
            Random rnd = new Random();
            value = rnd.Next(1, 4);
            if (value == 1)
            {
                return Roshambo_Enum.Rock;
            }
            else if (value == 2)
            {
                return Roshambo_Enum.Paper;
            }
            else if(value == 3)
            {
                return Roshambo_Enum.Scissors;
            }
            else
            {
                return Roshambo_Enum.Rock;
            }
        }

        public override Roshambo_Enum GetRoshambo(int value)
        {
            throw new NotImplementedException();
        }
    }
}
