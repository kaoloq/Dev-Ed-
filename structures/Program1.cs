using System;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
 //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"A + B = {a + b}");
            }
            else if (a == b) 
            {
                Console.WriteLine($"A * B = {a * b}");
            }
            else
            {
                Console.WriteLine($"A - B = {a - b}");
            }

        }
    }
}
