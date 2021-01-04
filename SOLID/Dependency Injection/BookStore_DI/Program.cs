using BookStore_DI.Implementations;
using System;

namespace BookStore_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = Factory.CreateCustomer("Ben Bajrami", "123456789");
            
            IAuthor author = Factory.CreateAuthor("Fyodor Dostoevsky");
            IAuthor illustrator = Factory.CreateAuthor("Jon Gisle");

            IStoreProduct comic = Factory.CreateComic("The Adventures of Donald Duck", illustrator, 24.2);
            IStoreProduct book = Factory.CreateBook("The Idiot", author, 12.5);

            book.AssignAuthor(Factory.CreateAuthor("Leo Tolstoy"));  
            book.AssignAuthor(Factory.CreateAuthor("Haruki Murakami"));

            // Create store + output receit 
            IStore store = Factory.CreateStore();
            store.MakePurchase(customer, book);
            store.MakePurchase(customer, comic);

            

            Console.ReadLine();


            //// OUTPUT:

            // Ben Bajrami purchased The Idiot(BOOK)
            // Author: Fyodor Dostoevsky, Leo Tolstoy, Haruki Murakami
            // -Price: 12,5$

            // Ben Bajrami purchased The Adventures of Donald Duck(COMIC)
            // Author / Illustrator: Jon Gisle
            // -Price: 24,2$

        }
    }
}
