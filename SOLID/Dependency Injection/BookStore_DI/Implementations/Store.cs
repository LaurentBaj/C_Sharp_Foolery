using BookStore_DI.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public class Store : IStore
    {
        public void MakePurchase(ICustomer customer, IStoreProduct product)
        {
            if (product is Book)
            {
                Console.WriteLine($"{ customer.Name } purchased { product.Name } (BOOK)" +
                $"\nAuthor: { product.GetAuthors()}" +
                $"\n- Price: { product.Price }$\n");
            } else if (product is Comic)
            {
                Console.WriteLine($"{ customer.Name } purchased { product.Name } (COMIC)" +
                $"\nAuthor/Illustrator: { product.GetAuthors()}" +
                $"\n- Price: { product.Price }$\n");
            }
        }
    }
}
