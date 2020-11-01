using System;
using System.Threading.Channels;

namespace DecoratorImp_Pizzas
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipizza plainPizza = new PlainPizzza(5, "A pizza");

            ToppingDecorator p1 = new CheeseTopping(plainPizza);
            Ipizza p2 = new JalapenoTopping(plainPizza);
            ToppingDecorator p3 = new MushroomTopping(plainPizza);
            Ipizza p4 = new PlainPizzza(5.5);

            Console.WriteLine(p1.GetDescription() + " : " + p1.GetPrice());  
            Console.WriteLine(p2.GetDescription() + " : " + p2.GetPrice());  
            Console.WriteLine(p3.GetDescription() + " : " + p3.GetPrice());  
            Console.WriteLine(p4.GetDescription() + " : " + p4.GetPrice());  

            Console.ReadLine(); 
        }
    }
}
