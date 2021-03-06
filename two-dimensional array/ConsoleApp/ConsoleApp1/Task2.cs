using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task2
    {
        public static int FindMax(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }
    }
}
