using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task4
    {
        public static int[] FindIndexOFMax(int[,] array)
        {
            int indexOfMax0 = 0;
            int indexOfMax1 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[indexOfMax0, indexOfMax1] < array[i, j])
                    {
                        indexOfMax0 = i;
                        indexOfMax1 = j;
                    }
                }
            }

            return new int[] { indexOfMax0, indexOfMax1 };
        }
    }
}
