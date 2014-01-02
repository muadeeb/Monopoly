using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    class Cards
    {
        private bool used = false;
        private int cash = 0;
        private int destination = 101;
        private string title;
        private string flavor;

        public Cards()
        { }

        public Cards(string t, string f, int c, int d)
        {
            this.title = t;
            this.flavor = f;
            this.cash = c;
            this.destination = d;
        }

        public Cards(string t, int c, int d)
        {
            this.title = t;
            this.cash = c;
            this.destination = d;
        }

        public Cards(string t, string f, int c)
        {
            this.title = t;
            this.flavor = f;
            this.cash = c;
        }

        public Cards(string t, int c)
        {
            this.title = t;
            this.cash = c;
        }

        public void clearUsed() { used = false; }
        
        public bool isUsed() { return used; }

    }
}
