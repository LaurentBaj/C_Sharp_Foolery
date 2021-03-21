using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(1, 100);
            Console.WriteLine(random);
            int attempts = 0; 

            Console.WriteLine("\nGuess a number between 1 and 100");

            InputProcess(random, attempts);
        }

        private static void InputProcess(int random, int attempts)
        {
            int input = Int32.Parse(Console.ReadLine() ?? string.Empty);

            if (input == random)
            {
                attempts++; 
                Console.WriteLine("\nCorrect!  -  Attempts: " + attempts);
                return;
            }

            attempts++; 
            Console.WriteLine(input < random ? "Too low! Try again!" : "Too high! Try again");
            InputProcess(random, attempts);
        }
        
    }
}