using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorImp_Pizzas
{
    public class CheeseTopping : ToppingDecorator
    {
        public CheeseTopping(Ipizza plainPizza) 
            : base(plainPizza) {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 1.19;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with extra cheese";
        }
    }
}
