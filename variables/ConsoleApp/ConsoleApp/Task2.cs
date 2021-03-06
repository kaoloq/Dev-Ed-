using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task2
    {
        public static (double, double) SwapAB(double a, double b)
        {
            double c = b;
            b = a;
            a = c;

            return (a, b);
        }
    }
}
