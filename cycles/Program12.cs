using System;

namespace ConsoleApp12
{
    class Program12
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int rememberB = b;
            int tmpA, tmpB;
            bool flag = false;

            while (a != 0)
            {
                tmpA = a % 10;
                 while(b != 0)
                {
                    tmpB = b % 10;
                    b /= 10;
                    if (tmpA == tmpB)
                        flag = true;
                }
                b = rememberB;
                a /= 10;
            }

            if(flag)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
