using System;

namespace ConsoleApp11
{
    class Program11
    {
        static void Main(string[] args)
        {
            //Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N,
            //сумма четных цифр которых больше суммы нечетных. 
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
