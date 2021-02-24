using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write B:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = b;
            b = a;
            a = c;
           
        }
    }
}
