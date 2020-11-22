using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public interface IAnimals
    {
        string Name { get; set;  }
        int Age { set; }

        void MakeSignatureSound(); 
    }
}
