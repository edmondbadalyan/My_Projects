using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck(List<Card> cards)
        {
            Cards = cards;
        }
        public Deck()
        {
            Cards = new List<Card>();
        }


        public override string ToString() => $"{Cards}";

    }
}
