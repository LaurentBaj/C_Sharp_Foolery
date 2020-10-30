using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class NumberHandler
    {
        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            return randomNumber;
        }       

    }
}
