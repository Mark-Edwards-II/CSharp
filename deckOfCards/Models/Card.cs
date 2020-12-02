namespace deckOfCards.Models
{
    public class Card
    {
        public string Value;

        public string Suit;

        public int ValueNum;

        public bool inPlay;

        public Card(string Value, string Suit, int ValueNum)
        {
            this.Value = Value;
            this.Suit = Suit;
            this.ValueNum = ValueNum;
            inPlay = false;
        }
    }
}