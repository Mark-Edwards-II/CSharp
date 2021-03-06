using System.Collections.Generic;
using System.Linq;
using System;

namespace deckOfCards.Models
{
    public class Deck
    {

        public List<Card> Looked = new List<Card>();

        public Deck()
        {
            Reset();
        }

        public Card Deal()
        {
            Card selectedCard = Looked[0];
            Looked.RemoveAt(0);
            return selectedCard;
            ;
        }

        public void Shuffle()
        {
            Looked = Looked.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public void Reset()
        {
            Looked.Clear();
            Looked = new List<Card>(){
                    new Card("Ace", "Clubs", 1),
                    new Card("2", "Clubs", 2),
                    new Card("3", "Clubs", 3),
                    new Card("4", "Clubs", 4),
                    new Card("5", "Clubs", 5),
                    new Card("6", "Clubs", 6),
                    new Card("7", "Clubs", 7),
                    new Card("8", "Clubs", 8),
                    new Card("9", "Clubs", 9),
                    new Card("10", "Clubs", 10),
                    new Card("Jack", "Clubs", 11),
                    new Card("Queen", "Clubs", 12),
                    new Card("King", "Clubs", 13),
                    new Card("Ace", "Spades", 1),
                    new Card("2", "Spades", 2),
                    new Card("3", "Spades", 3),
                    new Card("4", "Spades", 4),
                    new Card("5", "Spades", 5),
                    new Card("6", "Spades", 6),
                    new Card("7", "Spades", 7),
                    new Card("8", "Spades", 8),
                    new Card("9", "Spades", 9),
                    new Card("10", "Spades", 10),
                    new Card("Jack", "Spades", 11),
                    new Card("Queen", "Spades", 12),
                    new Card("King", "Spades", 13),
                    new Card("Ace", "Hearts", 1),
                    new Card("2", "Hearts", 2),
                    new Card("3", "Hearts", 3),
                    new Card("4", "Hearts", 4),
                    new Card("5", "Hearts", 5),
                    new Card("6", "Hearts", 6),
                    new Card("7", "Hearts", 7),
                    new Card("8", "Hearts", 8),
                    new Card("9", "Hearts", 9),
                    new Card("10", "Hearts", 10),
                    new Card("Jack", "Hearts", 11),
                    new Card("Queen", "Hearts", 12),
                    new Card("King", "Hearts", 13),
                    new Card("Ace", "Diamonds", 1),
                    new Card("2", "Diamonds", 2),
                    new Card("3", "Diamonds", 3),
                    new Card("4", "Diamonds", 4),
                    new Card("5", "Diamonds", 5),
                    new Card("6", "Diamonds", 6),
                    new Card("7", "Diamonds", 7),
                    new Card("8", "Diamonds", 8),
                    new Card("9", "Diamonds", 9),
                    new Card("10", "Diamonds", 10),
                    new Card("Jack", "Diamonds", 11),
                    new Card("Queen", "Diamonds", 12),
                    new Card("King", "Diamonds", 13),
        };
        }
    }
}