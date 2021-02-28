using System;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x >= 0)
            {
                if (y >= 0)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("4");
            }
            else
            {
                if (y >= 0)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");

            }
        }
    }
}
