using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Messages
    {
       public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the guessing game");
            Console.WriteLine("Choose a random number between one and four: ");
        }

        public static void NotProperValue()
        {
            Console.WriteLine("The input you've entered is either too low or too large");
            Console.WriteLine("Try again");
        }
        public static void AlreadyTypedNumber()
        {
            Console.WriteLine("You've already tried this number");
            Console.WriteLine("Try again");
        }

        public static void NumberTooSmall()
        {
            Console.WriteLine("Close, but too small");
            Console.WriteLine("Try again");
        }

        public static void NumberTooLarge()
        {
            Console.WriteLine("Close, but too large");
            Console.WriteLine("Try again");
        }

        public static void ExitProgram()
        {
            Console.WriteLine("Correct!");
            Console.ReadLine(); 
        }
    }
}
