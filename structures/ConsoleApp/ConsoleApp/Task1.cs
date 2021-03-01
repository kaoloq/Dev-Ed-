using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task1
    {
        static public double Count(double a, double b)
        {
            if (a > b)
            {
               return a + b;
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }
    }
}
