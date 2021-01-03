using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLib
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging { message }");
        }
    }
}
