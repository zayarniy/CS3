using System;
using System.Collections.Generic;
using System.Text;

namespace Mailer.Model
{
    public class Calculation
    {
        public static int Sum(int a, int b)
        {
            return a+b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static string Sum(string a, string b)
        {
            return a + b;
        }


    }
}
