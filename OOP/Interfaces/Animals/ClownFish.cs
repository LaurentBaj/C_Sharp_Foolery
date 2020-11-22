using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class ClownFish : IAnimals, IAquatic
    {
        public string Name { get; set; } = "Fish"; 

        public int Age { get; set; }

        public bool HasGills { get; set; } = true;


        public void MakeSignatureSound()
        {
            Console.WriteLine($"\nThis - { Name } - can only make 'blub-blub' sounds\n");
        }

        public string SpecialMove()
        {
            if (HasGills)
            {
                return $"\nThis - {Name} - can swim under water\n";
            }
            return $"\nThis - {Name} - cannot swim under water\n";
        }
    }
}
