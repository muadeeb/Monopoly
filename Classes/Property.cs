using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Monopoly
{

    //Color Gray = Railroad
    //Color White = Utility
    //Color Pink = undef

    //owner -1 = unowned, but ownable
    //owner 100 = unownable (corners, tax, CC, Chance)

    class Property
    {
        private string PropertyName;
        private int PropertyPrice = 0;
        private int PropertyOwner = -1;
        private int PropertyMortgage = 0;
        private int PropertyHouses = 0;
        private int[] PropertyRent = new int[6] {0, 0, 0, 0, 0, 0};
        private int PropertyImprovementCost = 0;
        private bool PropertyMonopoly = false;
        private Color PropertyColor = Color.Pink;

        public Property(string name)
        {
            PropertyName = name;
            PropertyOwner = 100;    //owner 100 = unownable
        }

        //Utility and RR
        public Property(string name, int price, Color clr)
        {
            this.PropertyName = name;
            this.PropertyPrice = price;
            if (clr == Color.Gray)
            {
                PropertyRent[0] = 25;
                PropertyRent[0] = 50;
                PropertyRent[0] = 100;
                PropertyRent[0] = 200;
            }
        }

        // Normal property
        public Property(string name, int price, int[] rent, int improvement, Color clr)
        {
            PropertyName = name;
            PropertyPrice = price;
            PropertyOwner = -1;     //owner -1 = unowned but ownable
            PropertyMortgage = price / 2;
            PropertyRent = rent;
            PropertyImprovementCost = improvement;
            PropertyColor = clr;
        }

        public Color color() { return this.PropertyColor; }
        
        public bool isMonopoly() { return this.PropertyMonopoly; }

        public bool isRR()
        {
            if (this.PropertyColor == Color.Gray)
                return true;
            else return false;
        }

        public bool isUtility()
        {
            if (this.PropertyColor == Color.White)
                return true;
            else return false;
        }
        
    }
}
