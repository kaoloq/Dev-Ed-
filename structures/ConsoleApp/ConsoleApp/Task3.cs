using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task3
    {
        static public double[] SortToBigger(double a = 7, double b = -4, double c = 10)
        {
            if (a > b && a > c)
            {
                if (b > c)
                    return new double[] { c, b, a };
                else
                    return new double[] { b, c, a };
            }
            else if (b > c && b > a)
            {
                if (a > c)
                    return new double[] { c, a, b };
                else
                    return new double[] { a, c, b };
            }
            else
            {
                if (a > b)
                    return new double[] { b, a, c };
                else
                    return new double[] { a, b, c};
            }
        }
    }
}
