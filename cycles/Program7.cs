using System;

namespace ConsoleApp7
{
    class Program7
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int tmp;

            if (a < b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            while(a % b != 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }

            Console.WriteLine(b);
        }
    }
}
