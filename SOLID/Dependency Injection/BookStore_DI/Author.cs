namespace BookStore_DI
{
    public class Author : IAuthor
    {
        public string Name { get; set; }

        public Author(string name = "Unknown")
        {
            Name = name;
        }
    }
}