using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class DumbPlayer : Player
    {
        public string Name { get => name; set => name = value; }
        public string Choice { get => choice; set => choice = value; }


        public DumbPlayer(string _name, string _choice)
        {
            _name = name;
            _choice = choice;
        }

        public override Roshambo_Enum GetRoshambo()
        {

            return Roshambo_Enum.Rock;
        }

        public override Roshambo_Enum GetRoshambo(int value)
        {
            throw new NotImplementedException();
        }
    }
}
