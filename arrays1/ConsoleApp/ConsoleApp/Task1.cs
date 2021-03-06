using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task1
    {
        static public int FindMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }  
    }
}
