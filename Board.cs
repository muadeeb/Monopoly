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
            Chance = initChance();
            CChest = initCChest();
            GameBoard = initBoard();
             
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool allowNew = true;

            if (inprogress)
            {
                allowNew = false;
                if (DialogResult.Yes == MessageBox.Show("Do you wish to start a new Game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    allowNew = true;
            }
            if (allowNew)
            {
                NumPlayersForm Form1 = new NumPlayersForm();
                if (Form1.BtnPressed == DialogResult.OK)
                {
                    int newPlayers = Form1.NumPlayers;

                }
            }
        }
    }
}
