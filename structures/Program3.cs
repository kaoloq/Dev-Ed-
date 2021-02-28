using System;

namespace ConsoleApp3
{
    class Program3
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if(a > b)
            {
                if (b > c)
                    Console.WriteLine($"{a} {b} {c}");
                else
                    Console.WriteLine($"{a} {c} {b}");
            }
            else if(b > c)
            {
                if (a > c)
                    Console.WriteLine($"{b} {a} {c}");
                else
                    Console.WriteLine($"{b} {c} {a}");      
            }
            else
            {
                if (a > b)
                    Console.WriteLine($"{c} {a} {b}");
                else
                    Console.WriteLine($"{c} {b} {a}");
            }
        }
    }
}
