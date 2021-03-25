using System;
using System.Collections;

namespace DeckCreation
{
    public class CardFactory : ICardFactory
    { 
        public string[] CardHolder { get; }
        private int CardCounter { get; set; }

        public CardFactory() // Create a full container of shuffled cards
        {
            CardHolder = new string[52];
            CreateCards();
            ShuffleCards();
        }

        private void CreateCards()
        {
            foreach (var suit in Card.suits)
            {
                for (int j = 0; j < Card.ranks.Length; j++)
                {
                    CardHolder[CardCounter] = Card.ranks[j] + " of " + suit;
                    CardCounter++;
                }
            }
        }
        
        // Shuffle Cards - swap card with card of random index (Deck.size times) 
        private void ShuffleCards()
        {
            foreach (var t in CardHolder)
            {
                for (int j = 0; j < CardHolder.Length; j++)
                {
                    Swap(j, out var random, out var currentCard);
                }
            }
        }
        
        private void Swap(int j, out int random, out string currentCard)
        {
            random = new Random().Next(0, 51);

            currentCard = CardHolder[j];
            CardHolder[j] = CardHolder[random];
            CardHolder[random] = currentCard;
        }
    }
    
}