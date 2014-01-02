using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Board : Form
    {
        static Random _r = new Random();

        static public int Roll()
        {
            int d1 = _r.Next(1, 7);
            int d2 = _r.Next(1, 7);
            return d1 + d2;
        }
    }
}
