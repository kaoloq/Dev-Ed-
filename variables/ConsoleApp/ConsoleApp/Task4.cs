using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task4
    {
        public static double SolveLinearEquation(int a, int b, int c)
        {
            if (a == 0)
                throw new Exception("a = 0");

            return (c - b) / a;
        }
    }
}
