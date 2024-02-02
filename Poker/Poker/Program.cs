using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker;
public class Program
{
    public static void Main(string[] args)
    {
        Game game = new Game();
        Player player = new() { Money = 100, Hand = new List<Card>() };

        while (true)
        {
            Console.WriteLine("Your current balance is: " + player.Money);
            Console.WriteLine("Enter your bet or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (!int.TryParse(input, out int bet))
            {
                Console.WriteLine("Invalid input. Please enter a valid bet.");
                continue;
            }

            if (bet > player.Money)
            {
                Console.WriteLine("You don't have enough money.");
                continue;
            }

            Deck deck = game.CreateDeck();
            game.ShuffleDeck(deck);
            game.DealCards(player, deck, 5);

            game.DetermineHandAndDisplay(player);
            int payout = game.Payout(player, bet);

            Console.WriteLine($"You won: {payout}");
        }
    }
}
