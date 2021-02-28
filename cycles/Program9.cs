using System;

namespace ConsoleApp8
{
    class Program9
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (num != 0)
            {
                if(num % 2 != 0)
                {
                    count++;
                }
                num /= 10;
            }
            Console.WriteLine(count);

        }
    }
}
