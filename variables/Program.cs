using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B:");
            int b = Convert.ToInt32(Console.ReadLine());
            int division = a / b;
            int mod = a % b;

            Console.WriteLine($"Division A by B = {division}");
            Console.WriteLine($"Mod = {mod}");
        }
    }
}
