using System;
using System.Threading.Channels;

namespace DecoratorImp_Pizzas
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipizza pizzaWithExtraCheese = new PlainPizzza(5, "A pizza");

            ToppingDecorator p1 = new CheeseTopping(pizzaWithExtraCheese);
            Ipizza p2 = new JalapenoTopping(pizzaWithExtraCheese);
            ToppingDecorator p3 = new MushroomTopping(pizzaWithExtraCheese);
            Ipizza p4 = new PlainPizzza(5.5);

            Console.WriteLine(p1.GetDescription());  
            Console.WriteLine(p2.GetDescription());  
            Console.WriteLine(p3.GetDescription());  
            Console.WriteLine(p4.GetDescription());  

            Console.ReadLine(); 
        }
    }
}
