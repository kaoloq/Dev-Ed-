using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task5
    {
        public static int SumNumbersFromAToB(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, 
            //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

            if (a > b)
            {
                int c = b;
                b = a;
                a = c;
            }

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            
            return sum;
        }
    }
}
