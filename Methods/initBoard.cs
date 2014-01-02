using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Board : Form
    {

        Property[] initBoard()
        {
            Property[] board = new Property[40];

            board[0] = new Property("Go");
            board[1] = new Property("Mediterranean Ave", 60, new int[] { 2, 10, 30, 90, 160, 250 }, 50, Color.Purple);
            board[2] = new Property("Community Chest");
            board[3] = new Property("Baltic Ave", 60, new int[] { 4, 20, 60, 180, 320, 450 }, 50, Color.Purple);
            board[4] = new Property("Income Tax");
            board[5] = new Property("Reading Railroad", 200, Color.Gray);
            board[6] = new Property("Oriental Ave", 100, new int[] { 6, 30, 90, 170, 400, 550 }, 50, Color.DarkCyan);
            board[7] = new Property("Chance");
            board[8] = new Property("Vermont Ave", 100, new int[] { 6, 30, 90, 170, 400, 550 }, 50, Color.DarkCyan);
            board[9] = new Property("Connecticut Ave", 120, new int[] { 8, 40, 100, 300, 450, 600 }, 50, Color.DarkCyan);
            board[10] = new Property("Just Visiting");
            board[11] = new Property("St. Charles Pl", 140, new int[] { 10, 50, 150, 450, 625, 750 }, 100, Color.DarkViolet);
            board[12] = new Property("Electric Company", 150, Color.White);
            board[13] = new Property("States Ave", 140, new int[] { 10, 50, 150, 450, 625, 750 }, 100, Color.DarkViolet);
            board[14] = new Property("Virginia Ave", 160, new int[] { 12, 60, 180, 500, 700, 900 }, 100, Color.DarkViolet);
            board[15] = new Property("Pennsylvania Railroad", 200, Color.Gray);
            board[16] = new Property("St. James Pl", 180, new int[] { 14, 70, 200, 550, 750, 950 }, 100, Color.Orange);
            board[17] = new Property("Community Chest");
            board[18] = new Property("Tennessee Ave", 180, new int[] { 14, 70, 200, 550, 750, 950 }, 100, Color.Orange);
            board[19] = new Property("New York Ave", 200, new int[] { 16, 80, 220, 600, 800, 1000 }, 100, Color.Orange);
            board[20] = new Property("Free Parking");
            board[21] = new Property("Kentucky Ave", 220, new int[] { 18, 90, 250, 700, 875, 1050 }, 150, Color.Red);
            board[22] = new Property("Chance");
            board[23] = new Property("Indiana Ave", 220, new int[] { 18, 90, 250, 700, 875, 1050 }, 150, Color.Red);
            board[24] = new Property("Illinois Ave", 240, new int[] { 20, 100, 300, 750, 925, 110 }, 150, Color.Red);
            board[25] = new Property("B & O Railroad", 200, Color.Gray);
            board[26] = new Property("Atlantic Ave", 260, new int[] { 22, 110, 330, 800, 975, 1150 }, 150, Color.Yellow);
            board[27] = new Property("Ventnor Ave", 260, new int[] { 22, 110, 330, 800, 975, 1150 }, 150, Color.Yellow);
            board[28] = new Property("Water Works", 150, Color.White);
            board[29] = new Property("Marvin Gardens", 280, new int[] { 24, 120, 360, 850, 1025, 1200 }, 150, Color.Yellow);
            board[30] = new Property("GO TO JAIL");
            board[31] = new Property("Pacific Ave", 300, new int[] { 26, 130, 390, 900, 1100, 1275 }, 200, Color.DarkGreen);
            board[32] = new Property("North Carolina Ave", 300, new int[] { 26, 130, 390, 900, 1100, 1275 }, 200, Color.DarkGreen);
            board[33] = new Property("Community Chest");
            board[34] = new Property("Pennsylvania Ave", 320, new int[] { 28, 150, 450, 1000, 1200, 1400 }, 200, Color.DarkGreen);
            board[35] = new Property("Short Line", 200, Color.Gray);
            board[36] = new Property("Chance");
            board[37] = new Property("Park Place", 350, new int[] { 35, 175, 500, 1100, 1300, 1500 }, 200, Color.DarkBlue);
            board[38] = new Property("Luxury Tax");
            board[39] = new Property("Boardwalk", 400, new int[] { 50, 200, 600, 1400, 1700, 2000 }, 200, Color.DarkBlue);
            
            return board;
        }
    }
}

