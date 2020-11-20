using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IExercises> exercices = AddSampleExercice();
            ClientModel client = GetClient(); 

            foreach (IExercises ex in exercices)
            {
                ex.AddExercice(client);
                if (ex is IInstrumentModel instrument)
                {
                    Console.WriteLine($"For the { instrument.Title } exercise, client has: { instrument.AmountOfSets } yet");
                }
            }

            Console.ReadLine();
        }

        private static ClientModel GetClient()
        {
            return new ClientModel
            {
                FirstName = "Laurent",
                LastName = "Bajrami",
                City = "Kringsjå",
                EmailAddress = "laurent_sharpC@hotmail.com",
                PhoneNumber = "555-1212",
            };
        }

        private static List<IExercises> AddSampleExercice()
        {
            List<IExercises> output = new List<IExercises>(); 

            output.Add(new PhysicalExercice { Title = "Burpees" }); 
            output.Add(new PhysicalExercice { Title = "Pull-ups" }); 
            output.Add(new PhysicalExercice { Title = "Cardio" });
            output.Add(new InstrumentModel { Title = "Legato-runs" });

            return output; 
        }
    }
}
