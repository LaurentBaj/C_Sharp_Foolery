using System.Collections.Generic;

namespace DeckCreation.Factory
{
    public static class Factory
    {
        public static ICardFactory CreateCardFactory()
        {
            return new CardFactory(); 
        }

        public static IDeck CreateDeck()
        {
            return new Deck.Deck(); 
        }

        public static Stack<string> CreateStack()
        {
            return new(); 
        }
    }
}