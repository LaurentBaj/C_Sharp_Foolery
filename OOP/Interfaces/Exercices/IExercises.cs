using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IExercises
    {
        string Title { get; set; }

        bool IsExCompleted { get; }

        void AddExercice(ClientModel client); 
    }
}
