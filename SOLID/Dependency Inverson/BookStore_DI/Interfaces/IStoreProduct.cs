namespace BookStore_DI
{
    public interface IStoreProduct 
    {
        string Name { get; }
        double Price { get; }

        void AssignAuthor(IAuthor author);
        string GetAuthors();
    }
}