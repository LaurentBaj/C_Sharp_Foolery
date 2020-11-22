using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public interface IAquatic : IAnimals
    {
        bool HasGills { get; set; }

        string SpecialMove(); 
    }
}
