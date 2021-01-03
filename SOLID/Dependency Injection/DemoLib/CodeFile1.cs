using DemoLib;
using System;
using System.Collections.Generic;
using System.Text;
public class CodeFile1
{
    static void Main(string[] args)
    {
        BusinessLogic businessLogic = new BusinessLogic();

        businessLogic.ProcessData();

        Console.ReadLine(); 
    }
}