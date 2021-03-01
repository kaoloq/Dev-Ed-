using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task9 
    {
        public static int CountOddDigitsOfInt(int num)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

            if (num < 0)
            {
                num = Math.Abs(num);
            }

            int counter = 0;
            while (num != 0)
            {
                if (num % 2 != 0)
                {
                    counter++;
                }
                num /= 10;
            }
            
            return counter;

        }
    }
}
