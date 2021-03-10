using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task2
    {
        public static int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
