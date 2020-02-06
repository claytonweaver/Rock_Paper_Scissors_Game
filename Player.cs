using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    abstract class Player
    {
        protected string name;
        protected string choice;


        public Player()
        {

        }     
        Player(string _name, string _choice)
        {
            name = _name;
            choice = _choice;
        }

        public abstract Roshambo_Enum GetRoshambo();
        public abstract Roshambo_Enum GetRoshambo(int value);
        



    }
}
