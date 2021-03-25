using NUnit.Framework;
using DeckCreation;
using DeckCreation.Deck;
using DeckCreation.Factory;


namespace TestDeckCreation
{
    public class TestFactory
    {

        [Test]
        public void TestDeckCreation()
        {
            IDeck deck = Factory.CreateDeck();
            Assert.True(deck is Deck);
        }
        
        [Test]
        public void TestCardFactoryCreation()
        {
            ICardFactory iCardFactory = Factory.CreateCardFactory();
            Assert.True(iCardFactory is CardFactory);
        }
        
    }
}