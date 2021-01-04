using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public class Book
    {
        public string Name { get; }
        public double Price { get; }
        public List<Author> authors;

        public Book(string name = "Unknown", Author author = null, double price = 0)
        {
            if (author == null) author.Name = "Unknown"; 
            Name = name;
            Price = price;
            authors = new List<Author>();
            authors.Add(author); 
        }

        public void AssignAuthor(string name)
        {
            Author author = new Author(name); 
            authors.Add(author); 
        }

        public string GetAuthors()
        {
            string Authors = "";  
            foreach (Author a in authors)
            {
                Authors += a.Name + ", "; 
            }
            string AuthorOutput = Authors.Substring(0, Authors.Length - 2); 
            return AuthorOutput; 
        }
    }
}
