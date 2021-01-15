using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public class Book : IBook
    {
        public string Name { get; }
        public double Price { get; }
        public List<IAuthor> authors;

        public Book(string name = "Unknown", IAuthor author = null, double price = 0)
        {
            if (author == null) author.Name = "Unknown";
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
