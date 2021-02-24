using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write X2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double a = (y2 - y1) / (x2 - x1);
            double b = -x1 * (y2 - y1) / (x2 - x1) + y1;

            Console.WriteLine($"Y = {a}X + ({b})");
        }
    }
}
