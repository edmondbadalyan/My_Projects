using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Game
    {
        public Deck CreateDeck()
        {
            Deck deck = new Deck();
            string[] suits = { "♠", "♥", "♦", "♣" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    deck.Cards.Add(new Card(suit, value));
                }
            }

            return deck;
        }

        public void ShuffleDeck(Deck deck)
        {
            Random rng = new Random();
            int n = deck.Cards.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck.Cards[k];
                deck.Cards[k] = deck.Cards[n];
                deck.Cards[n] = value;
            }
        }

        public void DealCards(Player player, Deck deck, int count)
        {
            player.Hand.AddRange(deck.Cards.Take(count));
            deck.Cards.RemoveRange(0, count);
        }

        public string DetermineHand(Player player)
        {
            List<Card> cards = player.Hand.OrderBy(c => c.Value).ToList();

            if (IsRoyalFlush(cards))
            {
                return "Роял-флеш";
            }

            if (IsStraightFlush(cards))
            {
                return "Стрит-флеш";
            }

            if (IsFourOfAKind(cards))
            {
                return "Каре";
            }

            if (IsFullHouse(cards))
            {
                return "Фулл-хаус";
            }

            if (IsFlush(cards))
            {
                return "Флеш";
            }

            if (IsStraight(cards))
            {
                return "Стрит";
            }

            if (IsThreeOfAKind(cards))
            {
                return "Сет";
            }

            if (IsTwoPair(cards))
            {
                return "Две пары";
            }

            if (IsOnePair(cards))
            {
                return "Пара";
            }

            return "Старшая карта";
        }

        private bool IsRoyalFlush(List<Card> cards)
        {
            return cards.All(c => c.Suit == cards[0].Suit) &&
                   cards.Select(c => c.Value).SequenceEqual(new List<string> { "10", "J", "Q", "K", "A" });
        }

        private bool IsStraightFlush(List<Card> cards)
        {
            return cards.All(c => c.Suit == cards[0].Suit) &&
                   cards.Select(c => c.Value).SequenceEqual(new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" });
        }

        private bool IsFourOfAKind(List<Card> cards)
        {
            return cards.GroupBy(c => c.Value).Any(g => g.Count() == 4);
        }

        private bool IsFullHouse(List<Card> cards)
        {
            return cards.GroupBy(c => c.Value).Count() == 2;
        }

        private bool IsFlush(List<Card> cards)
        {
            return cards.All(c => c.Suit == cards[0].Suit);
        }

        private bool IsStraight(List<Card> cards)
        {
            return cards.Select(c => c.Value).SequenceEqual(new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" });
        }

        private bool IsThreeOfAKind(List<Card> cards)
        {
            return cards.GroupBy(c => c.Value).Any(g => g.Count() == 3);
        }

        private bool IsTwoPair(List<Card> cards)
        {
            return cards.GroupBy(c => c.Value).Count() == 3;
        }

        private bool IsOnePair(List<Card> cards)
        {
            return cards.GroupBy(c => c.Value).Any(g => g.Count() == 2);
        }

        public int Payout(Player player, int amount)
        {
            return player.Money += amount;
        }

        public void DetermineHandAndDisplay(Player player)
        {
            string hand = DetermineHand(player);

            Console.WriteLine($"Your hand is: {string.Join(", ", player.Hand.Select(card => card.Value + card.Suit))}");
            Console.WriteLine($"Combination: {hand}");
        }
    }
}
