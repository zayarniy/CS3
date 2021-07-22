using System;
using System.Threading;

namespace Listing04
{
    class Data
    {
        public int Num { get; set; }
        public int Delay { get; set; }
    }

    class MyThread
    {
        public int Count;
        public Thread Thrd;
        public MyThread(string name, Data data)
        {
            Count = 1;

            // Explicitly invoke ParameterizedThreadStart constructor 
            // for the sake of illustration. 
            // Для иллюстрации явно вызываем ParameterizedThreadStart контруктор,

            Thrd = new Thread(new ParameterizedThreadStart(this.Run));

            Thrd.Name = name;
            //Data data = new Data() { Delay = 500, Num = 10 };
            // Here, Start() is passed num as an argument. 
            Thrd.Start(data);
        }
        void Run(object data)
        {
            Console.WriteLine(Thrd.Name +
                              " starting with count of " + (data as Data).Num);

            do
            {
                Thread.Sleep((data as Data).Delay);
                Console.WriteLine("In " + Thrd.Name +
                                  ", Count is " + Count);
                Count++;
            } while (Count <= (data as Data).Num);

            Console.WriteLine(Thrd.Name + " terminating.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread("Child #1", new Data() { Delay = 500, Num = 10 });
            MyThread mt2 = new MyThread("Child #2", new Data() { Delay = 1000, Num = 7 });
            mt.Thrd.Join();
            mt2.Thrd.Join();
            Console.WriteLine("Main thread ending.");

            Console.Read();

        }
    }
}

