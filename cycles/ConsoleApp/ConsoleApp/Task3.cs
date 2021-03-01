using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task3
    {
        public static int CountPositiveIntegers(int a)
        {
            //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
           
            if(a <= 0)
            {
                throw new Exception("a <= 0");
            }

            return (int)Math.Sqrt(a);
        }
    }
}
