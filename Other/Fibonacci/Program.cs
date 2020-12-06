using System;
using System.Collections;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput; 
            Console.WriteLine("Enter number");

            userInput = Convert.ToInt32((Console.ReadLine())); 

            Console.WriteLine(Recursive(userInput));
            Console.WriteLine(Factorial(userInput));

            Console.ReadLine();
        }

        public static int Recursive(int number)
        {
            if (number <= 2)
            {
                return 1;
            }
            else
            {
                return Recursive(number - 1) + Recursive(number - 2);   
            }
        }

        public static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }


    }
}
