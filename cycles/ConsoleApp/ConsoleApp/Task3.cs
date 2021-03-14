using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task3
    {
        public static int CountPositiveIntegers(int a)
        {
            //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
           
            if(a <= 0)
            {
                throw new ArithmeticException("a <= 0");
            }

            int counter = (int)Math.Sqrt(a);

            if (counter * counter == a)
                return counter - 1;

            return counter;
        }
    }
}
