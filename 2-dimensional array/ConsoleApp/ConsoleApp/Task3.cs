using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task3
    {
        public static int[] FindIndexOFMin(int[,] array)
        {
            int indexOfMin0 = 0;
            int indexOfMin1 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[indexOfMin0, indexOfMin1] > array[i, j])
                    {
                        indexOfMin0 = i;
                        indexOfMin1 = j;
                    }
                }
            }

            return new int[] { indexOfMin0, indexOfMin1 };
        }
    }
}
