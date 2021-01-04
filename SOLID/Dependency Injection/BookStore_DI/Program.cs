using System;

namespace BookStore_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuthor a1 = new Author("Fyodor Dostoevsky");
            ICustomer c1 = new Customer("Ben Bajrami", "123456789");
            IBook b1 = new Book("The Idiot", a1, 12.5);
            b1.AssignAuthor("Leo Tolstoy"); 

            IStore s1 = new Store();
            s1.MakePurchase(c1, b1);

            Console.ReadLine();
        }
    }
}
