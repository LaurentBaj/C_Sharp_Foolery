using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class InstrumentModel : IExercises, IInstrumentModel
    {
        public string Title { get; set; }
        public bool IsExCompleted { get; private set; }
        public int AmountOfSets { get; private set; } = 5; 

        public void AddExercice(ClientModel client)
        {
            if (IsExCompleted == false)
            {
                Console.WriteLine($"Exercice: { Title } - has been added to {client.FirstName }'s email address - { client.EmailAddress }");
                AmountOfSets -= 1; 
                if (AmountOfSets < 1)
                {
                    AmountOfSets = 0; 
                    IsExCompleted = true; 
                }
            }
        }

    }
}
