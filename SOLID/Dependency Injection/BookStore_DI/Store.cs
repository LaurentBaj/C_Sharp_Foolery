using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public class Store
    {
        public void MakePurchase(Customer customer, Book book)
        {
            Console.WriteLine($"{ customer.Name } purchased { book.Name }" +
                $"\nAuthor: { book.GetAuthors()}" +
                $"\n- Price: { book.Price }");
        }
    }
}
