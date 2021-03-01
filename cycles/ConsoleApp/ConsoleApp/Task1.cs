using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task1
    {
        public static int PowAToB(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

            if (b < 0) {
                throw new Exception("b < 0");
            }

            int num = 1;
            for (int i = 0; i < b; i++)
            {
                num *= a;
            }

            return num;
        }
    }
}
