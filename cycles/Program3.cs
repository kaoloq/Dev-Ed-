using System;

namespace ConsoleApp3
{
    class Program3
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            int a = Convert.ToInt32(Console.ReadLine());

            double sqrtA = Math.Sqrt(a);
            for(int i = 1; i < sqrtA; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
