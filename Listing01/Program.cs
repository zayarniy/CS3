using System;
using System.Threading;

namespace Listing01
{
    class Program
    {
        static string thrdName;
        static int Count;
        static public void Run()
        {
            Console.WriteLine(thrdName + " starting.");
            do
            {
                Thread.Sleep(1000);
                Console.WriteLine("In " + thrdName +
                                  ", Count is " + Count);
                Count++;
            } while (Count < 20);

            Console.WriteLine(thrdName + " terminating.");
        }

        static void Main(string[] args)
        {
            Thread newThrd = new Thread(Run);
            newThrd.Start();
            Thread.Sleep(5000);

            Console.WriteLine("Main thread is ending!");
            newThrd.IsBackground = true;
        }
    }
}
