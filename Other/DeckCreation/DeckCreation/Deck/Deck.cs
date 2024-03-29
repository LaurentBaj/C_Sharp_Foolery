﻿using System;
using System.Collections.Generic;

namespace DeckCreation.Deck
{
    public class Deck : IDeck
    {
        public Stack<string> _deckStack { get; }

        public Deck() // Fill stack with shuffled cards + Print
        {
            _deckStack = Factory.Factory.CreateStack(); 

            foreach (string card in Factory.Factory.CreateCardFactory().CardHolder)
            {
                _deckStack.Push(card);
            }
        }
        
        private void Print() // Print entire deck from top to bottom
        {
            Console.WriteLine("\n");
            
            foreach (var card in _deckStack)
            {
                Console.WriteLine(card);
            }
        }
        
        public string PullCard()
        {
            return _deckStack.Pop(); 
        }
    }
}