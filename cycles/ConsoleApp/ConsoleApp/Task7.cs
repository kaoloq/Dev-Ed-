using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task7
    {
        public static int FindNodByEvklid(int a, int b)
        {
            //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

            if (a == 0 || b == 0)
                return 0;

            if(a < 0)
                a = Math.Abs(a);
            if(b < 0)
                b = Math.Abs(b);

            int tmp = b;
            
            if (a < b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            while (a % b != 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            } 

            return tmp;
        }
    }
    
}
