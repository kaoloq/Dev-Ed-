using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task4
    {
        public static double[] SolveSquareEquation(double a, double b, double c)
        {
            if(a == 0)
            {
                throw new Exception("a = 0");

            }

            double d = FindDiscriminant(a, b, c);

            if (d < 0)
            {
                throw new Exception("Discriminant d < 0");
            }
            else if (d == 0)
            { 
                return FindOneX(a, b);
            }
            else
            {
                return FindTwoX(a, b, d);
            }

        }

        private static double FindDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        private static double[] FindOneX(double a, double b)
        {
            if(a == 0)
            {
                throw new Exception("Divider a = 0");
            }

            return new double[] { -b / (2 * a) };
        }

        private static double[] FindTwoX(double a, double b, double d)
        {
            if (a == 0)
            {
                throw new Exception("Divider a = 0");
            }

            if(d < 0)
            {
                throw new Exception("Discriminant d = 0");
            }

            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);

            return new double[] { x1, x2 };
        }
    }
}
