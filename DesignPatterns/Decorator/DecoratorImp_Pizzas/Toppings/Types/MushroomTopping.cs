using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorImp_Pizzas
{
    public class MushroomTopping : ToppingDecorator
    {
        public MushroomTopping(Ipizza plainPizza) 
            : base(plainPizza) { 
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with mushrooms";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 2.3;
        }
    }
}
