using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    class Player
    {
        private int Cash = 1500;
        private List<int> Owned = new List<int>();

        public Player() {}

        public void addOwned(int p)
        {
            if (!isOwned(p)) Owned.Add(p);
        }

        public int getCash() 
        { 
            return Cash; 
        }

        public bool isOwned(int p)
        {
            foreach (int i in Owned)
                if (i == p) return true;
            return false;
        }

        public void Sell(int p)
        {
            Owned.Remove(p);
        }

        public void setCash(int amount)
        {
            Cash += amount;
        }
    }
}
