using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLib
{
    public class BusinessLogic
    {

        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("Starting processing of data");
            Console.WriteLine("Processing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessedInfo");
            logger.Log("Finished processing of the data"); 
        }

    }
}
