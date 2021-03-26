using DeckCreation.Players;
using NUnit.Framework;

namespace TestDeckCreation
{
    public class TestPlayer
    {
        
        [TestCase("Laurent")]
        [TestCase("Henrik")]
        public void TestCtor(string name)
        {
            Player player = new Player(name); 
            Assert.AreEqual(name, player.Name);
        }

        [Test]
        public void TestBeginnerHandEmpty()
        {
            Player player = new Player();
            int handCount = player.Hand.Length;
            Assert.AreEqual(4, handCount);
        }
        
    }
}