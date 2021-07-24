using System;
using System.Threading;

namespace HomeWorck5
{

    class Program
    {
        static void ThrRun()
        {            
            Console.Write("Введите число: "); // Здесь 
            int n = int.Parse(Console.ReadLine());
            int result = Fact(n); // И здесь
            Console.WriteLine("факториал " + result);
            Console.ReadLine();
        }

        static int Fact(int n)
        {
            int result = 1; // Здесь можно сократить
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        static long res;
        static void Run(object o)
        {
            int n = (int)o;
            res = Fact(n);
        }

        static void Main()
        {
            int n = 5;
            //Thread newTread = new Thread(new ParameterizedThreadStart(Run));
            Thread newTread1 = new Thread(ThrRun);
            Thread newTread2 = new Thread(ThrRun);
            newTread1.Start();
            newTread2.Start();
            //Console.WriteLine(res);
        }
    }
}