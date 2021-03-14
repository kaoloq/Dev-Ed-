using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task2
    {
        public static void SwapAB(ref double a, ref double b)
        {
            double c = b;
            b = a;
            a = c;
        }
    }
}
