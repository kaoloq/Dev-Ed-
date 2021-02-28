using System;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int num = 1;
            for(int i = 0; i < b; i++)
            {
                num *= a; 
            }

            Console.WriteLine($"{a} ^ {b} = {num}");
        }
    }
}
