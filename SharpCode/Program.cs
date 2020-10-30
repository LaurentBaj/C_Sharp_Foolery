using GuessingGame;
using System;
using System.Collections; 

namespace SharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create random number
            int randomNumber = NumberHandler.GenerateRandomNumber(); 

            // Print randomNumber for testing 
            Console.WriteLine(randomNumber);

            // Store each wrong attempt 
            ArrayList numbersAlreadyTyped = new ArrayList();

            // Welcome message
            Messages.WelcomeMessage(); 

            int userInput; // Local: so Do-While can reach it 

            // while: Number is not within the game rules, typed before, too low or to high
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine()); // user input

                if (userInput < 0 || userInput > 4)
                {
                    Messages.NotProperValue(); 
                }
                else if (numbersAlreadyTyped.Contains(userInput))
                {
                    Messages.AlreadyTypedNumber(); 
                }
                else if (userInput < randomNumber)
                {
                    Messages.NumberTooSmall(); 
                    numbersAlreadyTyped.Add(userInput);
                }
                else if (userInput > randomNumber)
                {
                    Messages.NumberTooLarge(); 
                    numbersAlreadyTyped.Add(userInput);
                }
            } while (userInput != randomNumber);

            Messages.ExitProgram();
        }
    }
}
