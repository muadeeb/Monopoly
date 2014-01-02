using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Board : Form
    {

        Cards[] initChance()
        {
            Cards[] cards = new Cards[17];

            cards[0] = new Cards("Get Out of Jail Free", 0, -1);
            cards[1] = new Cards("Advance to Go", "Collect $200", 200, 0);
            cards[2] = new Cards("Advance to Illinois Ave", "If you pass Go, collect $200", 0, 24);
            cards[3] = new Cards("Advance to St. Charles Pl", "If you pass Go, collect $200", 0, 11);
            cards[4] = new Cards("Advance token to nearest Utility", "If unowned, you may buy it.\nIf owned, Roll dice and pay owner 10x the amount thrown", 0, 102);
            cards[5] = new Cards("Advance token to nearest Railroad", "If owned, pay owner 2x the rent they are entitled to", 0, 103);
            cards[6] = new Cards("Bank pays you dividend of $50", 50);
            cards[7] = new Cards("Advance token to nearest Railroad", "If owned, pay owner 2x the rent they are entitled to", 0, 103);
            cards[8] = new Cards("Go Back 3 Spaces", 0, -3);
            cards[9] = new Cards("Go to Jail -- Go Directly to Jail", "Do not pass Go, do not collect $200", 0, 104);
            cards[10] = new Cards("Make repairs on all your properties", "$25 per house, $100 per hotel", 0, 105);
            cards[11] = new Cards("Pay speeding ticket of $15", -15);
            cards[12] = new Cards("Take a trip on the Reading", "If you pass GO, collect $200", 0, 5);
            cards[13] = new Cards("Take a walk on Boardwalk", 0, 39);
            cards[14] = new Cards("You're elected Chairman of the Board", "Pay each player $50", -50);
            cards[15] = new Cards("Your investments mature", "Collect $150", 150);
            cards[16] = new Cards("You won a crossword competition", "Collect $100", 100);

            return cards;
        }
    }
}

