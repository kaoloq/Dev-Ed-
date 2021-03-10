using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task5
    {
        public static int SumOfElementsWithOddIndexes(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
