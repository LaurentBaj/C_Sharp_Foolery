using System;
using System.Collections; 

namespace SharpCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Create random number
            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            // Print randomNumber for testing 
            Console.WriteLine(randomNumber);

            // Store each wrong attempt 
            ArrayList numbersAlreadyTyped = new ArrayList(); 
            
            // Welcome message
            Console.WriteLine("Welcome to the guessing game");
            Console.WriteLine("Choose a random number between one and four: ");

            int userInput; // Local: so Do-While can reach it 

            do // while: Number is not within the game rules, typed before, too low or to high
            {
                userInput = Convert.ToInt32(Console.ReadLine()); // user input

                if (userInput < 0 || userInput > 4)
                {
                    Console.WriteLine("The input you've entered is either too low or too large");
                    Console.WriteLine("Try again");
                }
                else if (numbersAlreadyTyped.Contains(userInput))
                {
                    Console.WriteLine("You've already tried this number");
                    Console.WriteLine("Try again");

                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine("Close, but too small");
                    Console.WriteLine("Try again");
                    numbersAlreadyTyped.Add(userInput);
                }
                else if (userInput > randomNumber)
                {
                    Console.WriteLine("Close, but too high");
                    Console.WriteLine("Try again");
                    numbersAlreadyTyped.Add(userInput);
                }
            } while (userInput != randomNumber);

            Console.WriteLine("Correct!");
        }
    }
}
