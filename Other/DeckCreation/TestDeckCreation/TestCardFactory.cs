using DeckCreation;
using DeckCreation.Factory;
using NUnit.Framework;

namespace TestDeckCreation
{
    public class Tests
    {
        [TestCase(52)]
        public void TestProperAmountOfCards(int expectedCardAmount)
        {
            ICardFactory cardFactory = Factory.CreateCardFactory();
            Assert.AreEqual(expectedCardAmount, cardFactory.CardHolder.Length);
        }
    }
}