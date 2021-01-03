using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson("Laurent", "Bajrami", "12345678", "laurent_baj@hotmail.com");

            IChore chore = Factory.CreateChore("Do the dishes", owner);

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
