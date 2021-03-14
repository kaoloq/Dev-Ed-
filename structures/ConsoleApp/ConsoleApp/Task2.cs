using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task2
    {
        static public int IdentifyQuarterOfPoint(double x, double y)
        {
            //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).

            if (x >= 0)
            {
                if (y >= 0)
                    return 1;
                else
                    return 4;
            }
            else
            {
                if (y >= 0)
                    return 2;
                else
                    return 3;

            }
        }
    }
}
