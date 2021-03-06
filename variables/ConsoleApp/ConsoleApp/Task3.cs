using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task3
    {
        public static (int, int) FindDivisionAndRemainder(int a, int b)
        {
            int division = a / b;
            int mod = a % b;

            return (division, mod);
        }
    }
}
