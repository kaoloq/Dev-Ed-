using System;

namespace ConsoleApp4
{
    class Program4
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения
            //стандартного вида, где AX2+BX+C=0.

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if(d < 0)
            {
                Console.WriteLine("empty");
            }
            else if(d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"x = {x}");                
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / ( 2 * a);
                double x2 = (-b - Math.Sqrt(d)) / ( 2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");                
            }

        }
    }
}
