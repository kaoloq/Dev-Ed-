using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task8
    {
        public static int BisectionMethod(int num)
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N. 
            //Найдите число N методом половинного деления.
            
            if(num < 1)
            {
                throw new ArgumentOutOfRangeException("a < 1");
            }

            int a = 1;
            int b = num / 2;
            int x = 1;
            /// x ^3 - n = 0
            while (Math.Pow(x, 3) - num != 0)
            {
                x = (a + b) / 2;
                double fX = Math.Pow(x, 3) - num;
                double fA = Math.Pow(a, 3) - num;

                if (fA < 0 && fX < 0)
                    a = x;
                else
                    b = x;

            }

            return x;
        }
    }
}
