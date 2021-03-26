using System;

namespace DeckCreation.Players
{
    public class PlayerFactory : IPlayerFactory
    {
        public Player[] Players { get; } 

        public PlayerFactory(int playerCount, IDeck deck)
        {
            Players = new Player[playerCount];
            ProvidePlayerNames();
            FillPlayerHands(deck);
        }
        
        private void ProvidePlayerNames()
        {
            for (var i = 0; i < Players.Length; i++)
            {
                Players[i] = (Player) Factory.Factory.CreatePlayer("Player " + (i + 1));
            }
        }
        
        private void FillPlayerHands(IDeck deck)
        {
            for (int i = 0; i < Players.Length; i++)
            {
                Players[i].Name = "Player " + (i + 1);
                
                for (int j = 0; j < Players[i].Hand.Length; j++)
                {
                    Players[i].Hand[j] = deck.PullCard();
                }
            }
        }
        
        public void Print()
        {
            Console.WriteLine("\n");
            
            foreach (var player in Players)
            {
                Console.WriteLine(player.Name);
                Console.WriteLine("[" + player.Hand[0] + ", "+ player.Hand[1] + ", "
                                  + player.Hand[2] + ", "+ player.Hand[3] + "]\n\n");
            }
        }
        
    }
}