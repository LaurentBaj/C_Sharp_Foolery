namespace DeckCreation.Players
{
    public class Player : IPlayer
    {
        private string _name;
        private string[] _hand;

        public string[] Hand
        {
            get => _hand;
            set => _hand = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public Player(string name = "Unknown")
        {
            _hand = new string[4]; 
            _name = name;
        }
    }
}