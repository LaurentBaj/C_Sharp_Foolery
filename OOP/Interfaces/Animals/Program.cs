using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimals a1 = new Tiger();
            Tiger a2 = new Tiger();

            // Upcasting
            IAquatic s = new ClownFish();
            IAnimals a3 = (IAnimals)s;
            IAquatic a4 = new ClownFish(); 

            s.HasGills = true; 
            ((ClownFish)a3).HasGills = false;


            Console.WriteLine("\n");

            // Is-keyword 
            List<IAnimals> animals = new List<IAnimals>();
            animals.Add(a1); 
            animals.Add(a2); 
            animals.Add(a3);
            animals.Add(a4);
            animals.Add(s);

            foreach (IAnimals a in animals)
            {
                a.MakeSignatureSound(); 
                if(a is IAquatic aquatic)
                {
                    Console.WriteLine("This animal is aquatic");
                    Console.WriteLine(aquatic.SpecialMove());
                }
            }



            Console.ReadLine(); 
        }
    }
}
