using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorImp_Pizzas
{
    public abstract class ToppingDecorator : Ipizza
    {
        private readonly Ipizza _plainPizza; 

        public ToppingDecorator(Ipizza plainPizza)
        {
            _plainPizza = plainPizza; 
        }
        public virtual string GetDescription()
        {
            return _plainPizza.GetDescription(); 
        }

        public virtual double GetPrice()
        {
            return _plainPizza.GetPrice(); 
        }
    }
}
