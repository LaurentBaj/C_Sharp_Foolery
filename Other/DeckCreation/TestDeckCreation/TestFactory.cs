using NUnit.Framework;
using DeckCreation;
using DeckCreation.Deck;
using DeckCreation.Factory;
using DeckCreation.Players;


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

        [Test]
        public void TestPlayerFactoryCount()
        {
            IPlayerFactory playerFactory = Factory.CreatePlayerFactory(4, Factory.CreateDeck());
            int playersLength = playerFactory.Players.Length;
            Assert.True(playersLength == 4);
        }

        [Test]
        public void TestPlayerFactoryNames()
        {
            IPlayerFactory playerFactory = Factory.CreatePlayerFactory(2, Factory.CreateDeck()); 
            
            Assert.AreEqual("Player 1", playerFactory.Players[0].Name);
            Assert.AreEqual("Player 2", playerFactory.Players[1].Name);
        }
        
    }
}