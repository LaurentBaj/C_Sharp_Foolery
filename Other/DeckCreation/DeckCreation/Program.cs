using System;
using System.Collections.Generic;
using DeckCreation.Players;

namespace DeckCreation
{
    internal static class Program
    {
        public static void Main(string[] args)
        { 
            
            IPlayerFactory playerFactory = Factory.Factory.CreatePlayerFactory(2, Factory.Factory.CreateDeck()); 
            playerFactory.Print();
        }
    }
}