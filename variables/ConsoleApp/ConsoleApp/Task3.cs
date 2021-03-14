using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task3
    {
        public static (int, int) FindDivisionAndRemainder(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("b == 0");
            }

            int division = a / b;
            int mod = a % b;

            return (division, mod);
        }
    }
}
