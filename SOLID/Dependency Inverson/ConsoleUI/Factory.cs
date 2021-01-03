using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Factory
    {
        public static IPerson CreatePerson(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            return new Person(firstName, lastName, phoneNumber, emailAddress); 
        }

        public static IChore CreateChore(string ownerName, IPerson p)
        {
            return new Chore(CreateLogger(), CreateMessageSender(), ownerName, p); 
        }

        public static ILogger CreateLogger()
        {
            return new Logger(); 
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Texter(); 
            // return new Emailer() - Changes the output, hence the power of DI
        }
    }
}
