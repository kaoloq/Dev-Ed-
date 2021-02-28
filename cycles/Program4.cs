using System;

namespace ConsoleApp4
{
    class Program4
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i = a / 2; a > 0; i--)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
