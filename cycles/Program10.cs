using System;

namespace ConsoleApp10
{
    class Program10
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр
            //заданного числа, например, задано число 123, вывести 321.
            int num = Convert.ToInt32(Console.ReadLine());

            while(num != 0)
            {
                Console.Write(num % 10);
                num /= 10;
            }
        }
    }
}
