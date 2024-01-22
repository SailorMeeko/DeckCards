public class Deck
{
    List<Card> Cards = new List<Card>();
    Random randomizer = new Random();

    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            for (int i = 1; i <= 13; i++)
            {
                AddCard(new Card(i, suit));
            }
        }
    }
    
    public void PrintDeck()
    {
        foreach (var card in Cards)
        {
            card.DisplayCard();
        }
    }

    public Card PickRandom()
    {
        Card card = Cards.ElementAt(randomizer.Next(Cards.Count()));
        Cards.Remove(card);
        return card;
    }

    public void Shuffle()
    {
        for (int i = 0; i < Cards.Count(); i++)
        {
            var cardIndex = randomizer.Next(Cards.Count());

            Card cardA = Cards.ElementAt(i);
            Card cardB = Cards.ElementAt(cardIndex);

            Cards[i] = cardB;
            Cards[cardIndex] = cardA;
        }
    }

    private void AddCard(Card card)
    {
        Cards.Add(card);
    }
}