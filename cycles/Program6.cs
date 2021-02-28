using System;

namespace ConsoleApp6
{
    class Program6
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи.
            //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
            //Первое и второе считаются равными 1.

            int n = Convert.ToInt32(Console.ReadLine());
            int first = 1;
            int second = 1;
            int sum = 1;

            for(int i = 2; i < n; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
            }

            Console.WriteLine(sum);

        }
    }
}
