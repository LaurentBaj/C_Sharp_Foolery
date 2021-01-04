namespace BookStore_DI
{
    public interface IBook : IStoreProduct
    {
        void AssignAuthor(IAuthor author);
        string GetAuthors();
    }
}