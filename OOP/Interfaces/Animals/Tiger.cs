using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tiger : IAnimals
    {
        public string Name { get; set; } = "Tiger";

        public int Age { set { Age = 3; } }

        public void MakeSignatureSound()
        {
            Console.WriteLine($"\nThe - { Name } - performs a thunderous RAWR!\n"); 
        }
    }
}
