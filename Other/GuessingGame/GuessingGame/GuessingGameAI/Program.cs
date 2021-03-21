using System;
using System.Threading;

namespace GuessingGameAI
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            Console.WriteLine("\nWrite a number between 1-1000 and the computer will guess the correct integer");
            int input = Int32.Parse(Console.ReadLine() ?? string.Empty);
            
            ProcessGuess(input, attempts, 1, 1001);
        }

        private static void ProcessGuess(int input, int attempts, int newLow, int newHigh)
        {
            int computerGuess = new Random().Next(newLow, newHigh);

            if (computerGuess == input)
            {
                Console.WriteLine("\nComputer guessed correctly!  - -  Attempts: " + attempts + "  - -  Computer guess: " + computerGuess);
                return;
            }

            Thread.Sleep(500);
            attempts++;
            
            if (computerGuess < input)
            {
                Console.WriteLine("Computer guessed: " + computerGuess + " -- Too low");
                newLow = computerGuess; 
                ProcessGuess(input, attempts, newLow + 1, newHigh);
            }
            else
            {
                Console.WriteLine("Computer guessed: " + computerGuess + " -- Too high");
                newHigh = computerGuess; 
                ProcessGuess(input, attempts, newLow, newHigh - 1);
            }
        }
        
    }
}