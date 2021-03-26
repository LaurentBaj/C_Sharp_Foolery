namespace DeckCreation.Players
{
    public interface IPlayer
    {
        string[] Hand { get; set; }
        string Name { get; set; }
    }
}