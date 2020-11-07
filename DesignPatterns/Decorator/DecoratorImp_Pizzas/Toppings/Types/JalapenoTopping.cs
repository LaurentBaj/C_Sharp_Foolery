using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorImp_Pizzas
{
    public class JalapenoTopping : ToppingDecorator
    {
        public JalapenoTopping(Ipizza plainPizza) : base(plainPizza)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.7;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with jalapeno";
        }
    }
}
