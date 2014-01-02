using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
            Cards[] Chance = new Cards[17];
            Cards[] CChest = new Cards[17];
            Property[] GameBoard = new Property[40];
            Chance = initChance();
            CChest = initCChest();
            GameBoard = initBoard();
        }
    }
}
