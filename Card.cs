public class Card
{
    int Value { get; set; }
    Suit Suit { get; set;}


    public Card(int value, Suit suit)
    {
        Value = value;
        Suit = suit;
    }

    public void DisplayCard()
    {
        Console.WriteLine("{0} of {1}", ConvertCardValue(Value), Suit);
    }

    private string ConvertCardValue(int value)
    {
        switch (value)
        {
            case 1: return "Ace";
            case 11: return "Jack";
            case 12: return "Queen";
            case 13: return "King";
        }

        return value.ToString();
    }
}
