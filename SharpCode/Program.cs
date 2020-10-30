using GuessingGame;
using System;
using System.Collections; 

namespace SharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage(); 

            // while: Number is not within the game rules, typed before, too low or to high
            Validate.ValidateInput(NumberHandler.GenerateRandomNumber()); 

            Messages.ExitProgram();
        }
    }
}
