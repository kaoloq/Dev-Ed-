using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task1
    {
        public static double SolveEquation(double a, double b)
        {
            if ((b - a) == 0)
                throw new DivideByZeroException("(b - a) == 0");

            return (5 * a + b * b) / (b - a);
        }

    }
}
