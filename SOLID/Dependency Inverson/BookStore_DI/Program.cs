using BookStore_DI.Implementations;
using System;
using System.Collections.Generic;

namespace BookStore_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = Factory.CreateCustomer("Ben Bajrami", "123456789");
            
            IAuthor author1 = Factory.CreateAuthor("Fyodor Dostoevsky");
            IAuthor illustrator1 = Factory.CreateAuthor("Jon Gisle");

            IStoreProduct comic1 = Factory.CreateComic("The Adventures of Donald Duck", illustrator1, 24.2);
            IStoreProduct book1 = Factory.CreateBook("The Idiot", author1, 12.5);

            book1.AssignAuthor(Factory.CreateAuthor("Leo Tolstoy"));  
            book1.AssignAuthor(Factory.CreateAuthor("Haruki Murakami"));

            // Print Receit 
            IStore store = Factory.CreateStore();
            store.MakePurchase(customer, book1);
            store.MakePurchase(customer, comic1);



            //// OUTPUT: 
            ///
            // Ben Bajrami purchased The Idiot(BOOK)
            // Author: Fyodor Dostoevsky, Leo Tolstoy, Haruki Murakami
            // -Price: 12,5$

            // Ben Bajrami purchased The Adventures of Donald Duck(COMIC)
            // Author / Illustrator: Jon Gisle
            // -Price: 24,2$

            //========================================================\\


            // Ex2: Code now also follows O/C-Principle
            IAuthor author2 = Factory.CreateAuthor("Dale Carniege");
            IAuthor illustrator2 = Factory.CreateAuthor("Robert E. Howard");

            IStoreProduct comic2 = Factory.CreateComic("Conan the Barbarian", illustrator2, 24.2);
            IStoreProduct book2 = Factory.CreateBook("How to win friends and influence people", author2, 12.5);

            List<IStoreProduct> products = new List<IStoreProduct>();
            products.Add(comic2);
            products.Add(book2);

            foreach (IStoreProduct p in products)
            {
                Console.WriteLine(p.GetAuthors());
                if (p is IComic c)
                {
                    Console.WriteLine("This is a comic!");
                }
            }

            //// OUTPUT: 
            ///
            // Robert E. Howard    
            // This is a comic!
            // Dale Carniege





            Console.ReadLine();
        }
    }
}
