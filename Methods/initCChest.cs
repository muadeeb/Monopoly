using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Board : Form
    {

        Cards[] initCChest()
        {
            Cards[] cards = new Cards[17];

            cards[0] = new Cards("Get Out of Jail Free", 0, -1);
            cards[1] = new Cards("Advance to Go", "Collect $200", 200, 0);
            cards[2] = new Cards("Bank error in your favor", "Collect $200", 200);
            cards[3] = new Cards("Doctor's fees", "Pay $50", -50);
            cards[4] = new Cards("From sale of stock you get $50", 50);
            cards[5] = new Cards("Go to Jail-- Go Directly to Jail", "Do not pass Go, do not collect $200", 0, 104);
            cards[6] = new Cards("Grand Opera Night", "Collect $50 from each player for seats", 0);
            cards[7] = new Cards("Christmas Fund matures", "Collect $100", 100);
            cards[8] = new Cards("Income Tax Refund", "Collect $20", 20);
            cards[9] = new Cards("It's your birthday", "Collect $10 from each player", 0);
            cards[10] = new Cards("Life insurance matures", "Collect $100", 100);
            cards[11] = new Cards("Pay hospital fee of $100", 100);
            cards[12] = new Cards("Pay school tax of $150", -150);
            cards[13] = new Cards("Receive $25 consultation fee", 25);
            cards[14] = new Cards("You are assessed for street reapairs", "$40 per house, $115 per hotel",0, 106);
            cards[15] = new Cards("You won 2nd prize in a beauty contest", "Collect $10", 10);
            cards[16] = new Cards("You inherit $100", 100);

            return cards;
        }
    }
}

