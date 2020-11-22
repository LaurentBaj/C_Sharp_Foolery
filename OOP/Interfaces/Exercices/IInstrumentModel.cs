using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IInstrumentModel : IExercises
    {
        int AmountOfSets { get; }
    }
}
