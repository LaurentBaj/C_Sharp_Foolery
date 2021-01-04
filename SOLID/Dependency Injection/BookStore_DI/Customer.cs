using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public class Customer
    {
        public string Name, PhoneNumber; 
        public Customer(string name, string phoneNum)
        {
            Name = name; 
            PhoneNumber = phoneNum; 
        }
    }
}
