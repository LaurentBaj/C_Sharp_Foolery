using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Validate
    {
        public static void ValidateInput(int randomNumber)
        {
            int userInput;
            ArrayList numbersAlreadyTyped = new ArrayList();
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine());   

                if (userInput < 0 || userInput > 100)
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
        }
    }
}
