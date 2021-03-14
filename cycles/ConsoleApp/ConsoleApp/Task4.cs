using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task4
    {
        public static int FindNOD(int a)
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            if (a < 0)
            {
                a = Math.Abs(a);
            }

            if(a == 0 || a == 1)
            {
                return 0;
            }

            for (int i = a / 2; a > 0; i--)
            {
                if (a % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
