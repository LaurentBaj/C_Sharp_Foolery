using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI.Implementations
{
    public class Comic : IStoreProduct
    {
        public string Name { get; }
        public double Price { get; }
        public List<IAuthor> authors;

        public Comic(string name = "Unknown", IAuthor author = null, double price = 0)
        {
            Name = name;
            Price = price;
            authors = new List<IAuthor>();
            authors.Add(author);
        }

        public void AssignAuthor(IAuthor author)
        {
            authors.Add(author);
        }

        public string GetAuthors()
        {
            string Authors = "";
            foreach (IAuthor a in authors)
            {
                Authors += a.Name + ", ";
            }
            string AuthorOutput = Authors.Substring(0, Authors.Length - 2);
            return AuthorOutput;
        }
    }
}
