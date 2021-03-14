using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task5
    {
        public static string WriteLinearEquationByLetters(int x1, int y1, int x2, int y2)
        {
            if (x2 - x1 == 0)
                throw new DivideByZeroException("x2 - x1 == 0");

            double a = Math.Round((double)(y2 - y1) / (double)(x2 - x1), 2);

            double b = Math.Round((double)-x1 * (y2 - y1) / (double)(x2 - x1) + y1, 2);

            return ($"Y = {a}X + ({b})");
        }
    
    }
}
