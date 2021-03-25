using DeckCreation;
using DeckCreation.Factory;
using NUnit.Framework;

namespace TestDeckCreation
{
    public class TestDeck
    {
        [TestCase(52)]
        public void TestDeckSize(int expectedAmountOfCards)
        {
            IDeck deck = Factory.CreateDeck();
            Assert.AreEqual( expectedAmountOfCards, deck._deckStack.Count);
        }

        [TestCase(26, 26)]
        public void PullCardsFromDeck(int pullAmount, int cardsRemaining)
        {
            IDeck deck = Factory.CreateDeck(); // Can't have global deck - test methods would affect global deck

            for (int i = 0; i < pullAmount; i++)
            {
                deck._deckStack.Pop(); 
            }
            
            Assert.AreEqual(cardsRemaining, deck._deckStack.Count);
        }

    }
}