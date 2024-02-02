using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Player
    {
        public int Money { get; set; }
        public List<Card> Hand { get; set; }

        public Player(int money, List<Card> hand)
        {
            Money = money;
            Hand = hand;
        }

        public Player()
        {

        }
    }
}
