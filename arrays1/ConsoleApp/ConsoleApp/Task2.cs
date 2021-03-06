using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task2
    {
        static public int FindMax(int[] array)
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
