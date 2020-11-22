using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Hedgehog : IAnimals
    {
        public string Name { get; set; } = "Hedgehog";

        public int Age { set { Age = 0; } }

        public void MakeSignatureSound()
        {
            Console.WriteLine($"The - { Name } - performs a frail little squick");
        }
    }
}
