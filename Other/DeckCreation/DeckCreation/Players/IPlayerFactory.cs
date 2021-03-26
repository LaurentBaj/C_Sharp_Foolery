namespace DeckCreation.Players
{
    public interface IPlayerFactory
    {
        Player[] Players { get; }

        void Print();
    }
}