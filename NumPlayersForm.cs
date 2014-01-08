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
    public partial class NumPlayersForm : Form
    {
        public int NumPlayers { get; set; }
        public DialogResult BtnPressed { get; set; }

        public NumPlayersForm()
        {
            InitializeComponent();
            BtnPressed = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NumPlayers = Convert.ToInt32(cmbNumPlayer.Text);
            BtnPressed = System.Windows.Forms.DialogResult.OK;
        }
    }
}
