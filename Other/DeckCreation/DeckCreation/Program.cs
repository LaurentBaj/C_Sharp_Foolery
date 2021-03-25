using System;
using System.Collections.Generic;

namespace DeckCreation
{
    internal static class Program
    {
        public static void Main(string[] args)
        { 
            IDeck deck = Factory.Factory.CreateDeck(); // Create deck + print its cards
        }
    }
}