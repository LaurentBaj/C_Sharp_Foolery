using System.Collections.Generic;
using DeckCreation.Players;

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

        public static IPlayer CreatePlayer(string name)
        {
            return new Player(name); 
        }

        public static IPlayerFactory CreatePlayerFactory(int count, IDeck deck)
        {
            return new PlayerFactory(count, deck); 
        }
    }
}