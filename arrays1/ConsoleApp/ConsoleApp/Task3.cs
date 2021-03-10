using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task3
    {
        public static int FindIndexOfMin(int[] array)
        {
            int indexOfMin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[indexOfMin] > array[i])
                {
                    indexOfMin = i;
                }
            }

            return indexOfMin;
        }
    }
}
