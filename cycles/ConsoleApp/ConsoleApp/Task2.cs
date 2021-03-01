using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task2
    {
        //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

        public static int[] FindNumbersWithoutRemainder(int a)
        {
            if(a < 1 || a > 1000)
            {
                throw new Exception("Out of range");
            }

            int[] array = new int[1000 / a];
            int aOld = a;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a;
                a = a + aOld;
            }

            return array;
        }
}
}
