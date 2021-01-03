using System; 

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic(); 


            businessLogic.ProcessData();

            Console.ReadLine(); 
        }
    }
}
