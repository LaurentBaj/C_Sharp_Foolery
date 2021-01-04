namespace BookStore_DI
{
    public class Author
    {
        public string Name { get; set; }

        public Author(string name = "Unknown")
        {
            Name = name; 
        }
    }
}