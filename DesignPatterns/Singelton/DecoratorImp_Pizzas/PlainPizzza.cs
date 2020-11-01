using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorImp_Pizzas
{
    class PlainPizzza : Ipizza
    {
        private readonly double _price;
        private readonly string _description;

        public PlainPizzza(double price, string description = "A Pizza")
        {
            _price = price;
            _description = description; 
        }
        public virtual string GetDescription()
        {
            return _description;
        }

        public double GetPrice()
        {
            return _price; 
        }
    }
}
