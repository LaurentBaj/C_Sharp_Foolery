using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_DI
{
    public class Customer : ICustomer
    {
        public string Name { get; set; } 
        public string PhoneNumber { get; set; }  
        public Customer(string name, string phoneNum)
        {
            Name = name; 
            PhoneNumber = phoneNum; 
        }
    }
}
