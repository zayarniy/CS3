using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Sample
{
    class Program
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask() starting");

            //Выполняет работу в потоке
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("In MyTask(), count is " + count);
            }

            Console.WriteLine("MyTask terminating");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            // Construct a task. 


            //Создаем задачу
            Task tsk = new Task(MyTask);
            tsk.Start();
            
            // Keep Main() alive until MyTask() finishes. 
            for (int i = 0; i < 40; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Main thread ending.");
            
        }
    }
}
