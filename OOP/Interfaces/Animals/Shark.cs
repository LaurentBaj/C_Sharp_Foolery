using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Shark : IAquatic
    {
        public string Name { get; set; } = "Shark";

        public int Age { get; set; }

        public bool HasGills { get; set; } = true;


        public void MakeSignatureSound()
        {
            Console.WriteLine($"\nThis - { Name } - is a silent killer. Hence, it does not make any sound\n");
        }

        public string SpecialMove()
        {
            if (HasGills)
            {
                return $"\nThis - {Name} - can tear its prey apart\n";
            }
            return $"\nThis - {Name} - can tear its prey apart\n"; 
        }
    }
}
