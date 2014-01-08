using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    class Bank
    {
        public int Houses { get; set; }                 //remaining houses
        public int Hotels { get; set; }                 //remaining hotels
        private List<int> Chance = new List<int>();     //list of used Chance cards
        private List<int> CChest = new List<int>();     //list of used Community Chest cards    
        private List<int> Morgaged = new List<int>();   //list of Morgaged properties     
        private List<int> Available = new List<int>();  //list of available properties
        private bool FreeParking = true;                //rule to allow free parking donations
        public int FreeParkingMoney { get; set; }       //amount of money on FP
        private int ccJailOwner = -1;                   //Player # Owner of Comunity Chest get out of jail card
        private int chJailOwner = -1;                   //Player # Owner of Chance get out of jail card

        public Bank()
        {
            Available.Add(1);
            Available.Add(3);
            Available.Add(5);
            Available.Add(6);
            Available.Add(8);
            Available.Add(9);
            Available.Add(11);
            Available.Add(12);
            Available.Add(13);
            Available.Add(14);
            Available.Add(15);
            Available.Add(16);
            Available.Add(18);
            Available.Add(19);
            Available.Add(21);
            Available.Add(23);
            Available.Add(24);
            Available.Add(25);
            Available.Add(26);
            Available.Add(27);
            Available.Add(28);
            Available.Add(29);
            Available.Add(31);
            Available.Add(32);
            Available.Add(34);
            Available.Add(35);
            Available.Add(37);
            Available.Add(39);

            FreeParkingMoney = 0;
            Houses = 32;
            Hotels = 12;
        }

        public bool PropertyAvailable(int p)
        {
            foreach (int i in Available)
                if (i == p) return true;
            return false;
        }

        public bool isMorgaged(int p)
        {
            foreach (int i in Morgaged)
                if (i == p) return true;
            return false;
        }

        public bool isUsed(int deck, int c)
        { 
            List<int> foo = new List<int>();
            if (deck == 1) foo = Chance;
            else foo = CChest;

            foreach (int i in foo)
                if (i == c) return true;
            return false;
        }

        public bool ownsJail(int p)
        {
            if (ccJailOwner == p) return true;
            if (chJailOwner == p) return true;
            return false;
        }

        public void PropertyMorgaged(int p)
        {
            if (!isMorgaged(p))
                Morgaged.Add(p);
        }

        public void PropertySold(int p)
        {
            if (PropertyAvailable(p))
                Available.Remove(p);
        }

        public void ruleSet(bool fp)
        {
            FreeParking = fp;
        }
    }
}
