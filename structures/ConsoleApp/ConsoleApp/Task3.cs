using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task3
    {
        static public double[] SortToBigger(double a, double b, double c)
        {
            if (a > b)
            {
                if (b > c)
                    return new double[] { c, b, a };
                else
                    return new double[] { b, c, a };
            }
            else if (b > c)
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
