using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Messages
    {
        public static void tryAgain()
        {
            Console.WriteLine("TRY AGAIN!"); 
        }
       public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("Choose a random number between 1 and 100: ");
        }

        public static void NotProperValue()
        {
            Console.WriteLine("The input you've entered is either too low or too large");
            tryAgain(); 
        }
        public static void AlreadyTypedNumber()
        {
            Console.WriteLine("You've already tried this number!");
        }

        public static void NumberTooSmall()
        {
            Console.WriteLine("Close, but too small");
            tryAgain();
        }

        public static void NumberTooLarge()
        {
            Console.WriteLine("Close, but too large");
            tryAgain();
        }

        public static void ExitProgram()
        {
            Console.WriteLine("Correct!");
            Console.ReadLine(); 
        }
    }
}
