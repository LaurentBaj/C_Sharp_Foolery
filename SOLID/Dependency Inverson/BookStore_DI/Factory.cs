﻿using BookStore_DI.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public static class Factory
    {
        public static IAuthor CreateAuthor(string name)
        {
            return new Author(name);
        }

        public static IStoreProduct CreateBook(string name, IAuthor author, double price)
        {
            return new Book(name, author, price);
        }

        public static IStoreProduct CreateComic(string name, IAuthor author, double price)
        {
            return new Comic(name, author, price);
        }

        public static IStore CreateStore()
        {
            return new Store();
        }

        public static ICustomer CreateCustomer(string name, string number)
        {
            return new Customer(name, number);
        }
    }
}
