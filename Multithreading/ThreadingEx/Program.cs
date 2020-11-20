using System;
using System.Threading;

namespace ThreadingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            BanckAccount banckAccount = new BanckAccount(1000);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main"; 

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(banckAccount.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t; 
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive : {1}", 
                    threads[i].Name,
                    threads[i].IsAlive);

                threads[i].Start();
                
                Console.WriteLine("Thread {0} Alive : {1}",
                        threads[i].Name,
                        threads[i].IsAlive);
            }

            Console.WriteLine("Current Priority : {0}",
                Thread.CurrentThread.Priority);

            Console.WriteLine("Thread : {0} Ending",
               Thread.CurrentThread.Name);



            Console.ReadKey(); 
        }
    }



    public class BanckAccount
    {
        private Object _lock = new Object(); 
        double Balance { set; get; }

        public BanckAccount(double balance)
        {
            Balance = balance; 
        }

        public double Withdraw(double amount)
        {
            if ((Balance - amount) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }

            lock (_lock)
            {
                if (Balance >= amount)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account",
                        amount, (Balance - amount));
                    Balance -= amount;
                }
                return Balance;
            }
        }

            public void IssueWithdraw()
            {
                Withdraw(121); 
            }

        }
}
