namespace deckOfCards.Models
{
    public class Card
    {
        public string Value;

        public string Suit;

        public int ValueNum;

        public Card(string Value, string Suit, int ValueNum)
        {
            this.Value = Value;
            this.Suit = Suit;
            this.ValueNum = ValueNum;
        }
    }
}