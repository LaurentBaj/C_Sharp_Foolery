namespace BookStore_DI
{
    public interface IBook
    {
        string Name { get; }
        double Price { get; }

        void AssignAuthor(string name);
        string GetAuthors();
    }
}