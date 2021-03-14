using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task6
    {
        public static int[,] Transpose(int[,] array)
        {
            int[,] transposeArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    transposeArray[j, i] = array[i, j];
                }
            }

            return transposeArray;

        }
    }
}