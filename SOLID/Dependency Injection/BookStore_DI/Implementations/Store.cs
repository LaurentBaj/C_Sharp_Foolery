using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public class Store : IStore
    {
        public void MakePurchase(ICustomer customer, IBook book)
        {
            Console.WriteLine($"{ customer.Name } purchased { book.Name }" +
                $"\nAuthor: { book.GetAuthors()}" +
                $"\n- Price: { book.Price }$");
        }
    }
}
