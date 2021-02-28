using System;

namespace ConsoleApp5
{
    class Program5
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, 
            //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                int c = b;
                b = a;
                a = c;
            }

            int sum = 0;
            for(int i = a; i <= b; i++)
            {
                if(i % 7 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
