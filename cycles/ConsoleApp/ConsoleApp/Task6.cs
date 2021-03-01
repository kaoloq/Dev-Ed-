using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task6
    {
        public static int Fibonacci(int n)
        {
            //Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи.
            //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
            //Первое и второе считаются равными 1.

            if(n <= 0)
            {
                throw new Exception("n < 0");
            }

            int first = 1;
            int second = 1;
            int sum = 1;

            for (int i = 2; i < n; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
            }

            return sum;
        }
    }
}
