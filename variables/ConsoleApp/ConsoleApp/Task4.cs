using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task4
    {
        public static double SolveLinearEquation(int a, int b, int c)
        {
            if (a == 0)
                throw new DivideByZeroException("a == 0");

             return (double)(c - b) / (double)a;
        }
    }
}
