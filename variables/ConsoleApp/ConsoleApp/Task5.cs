using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task5
    {
        public static string WriteLinearEquationByLetters(int x1, int y1, int x2, int y2)
        {
            if (x2 - x1 == 0)
                throw new Exception("x2 - x1 = 0");

            double a = (y2 - y1) / (x2 - x1);
            double b = -x1 * (y2 - y1) / (x2 - x1) + y1;

            return ($"Y = {a}X + ({b})");
        }
    
    }
}
