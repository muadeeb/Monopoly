using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    class Player
    {
        private int Cash = 1500;

        public Player() {}

        int getCash() { return Cash; }

        void setCash(int amount)
        {
            Cash += amount;
        }
    }
}
