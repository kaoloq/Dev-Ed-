using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task3
    {
        static public int FindIndexOfMin(int[] array)
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
