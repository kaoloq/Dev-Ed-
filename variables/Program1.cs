using System;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = (5 * a + b * b) / (b - a);

            Console.WriteLine($"result = {result}");
        }
    }
}
