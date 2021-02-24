using System;

namespace ConsoleApp4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write C:");
            int c = Convert.ToInt32(Console.ReadLine());

            double x = (c - b) / a;

            Console.WriteLine($"X = {x}");
        }
    }
}
