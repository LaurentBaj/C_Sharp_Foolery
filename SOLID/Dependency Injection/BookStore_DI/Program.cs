using System;

namespace BookStore_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = Factory.CreateCustomer("Ben Bajrami", "123456789");
            
            IAuthor author = Factory.CreateAuthor("fyodor dostoevsky");

            IBook book = Factory.CreateBook("The Idiot", author, 12.5);
            book.AssignAuthor("Leo Tolstoy"); 

            IStore store = Factory.CreateStore();
            store.MakePurchase(customer, book);

            Console.ReadLine();
        }
    }
}
