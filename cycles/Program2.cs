using System;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i = a; i < 1000; i =  i + a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
