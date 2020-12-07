using System.Collections.Generic;
using System;

namespace deckOfCards.Models
{
    public class Player
    {
        public string Name;

        public List<Card> Hand;

        public Player(string Name)
        {
            this.Name = Name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck deckName)
        {
            Card selectedCard = deckName.Deal();
            Console.WriteLine($"{Name} drew {selectedCard.Value} of {selectedCard.Suit}.");
            Hand.Add(selectedCard);
            return selectedCard;
        }

        public Card Discard(int idx)
        {
            if (idx > Hand.Count || idx < 0)
            {
                Console.WriteLine("There is not that many cards!");
                return null;
            }
            else
            {
                var removedCard = Hand[idx];
                Console.WriteLine($"{Name} removed {removedCard.Value} of {removedCard.Suit} at the {idx} position.");
                Hand.RemoveAt(idx);
                return removedCard;
            }
        }

        public void DisplayHand()
        {
            foreach (Card CCard in Hand)
            {
                Console.WriteLine($"{CCard.Value} of {CCard.Suit}");
            };
        }

    }
}