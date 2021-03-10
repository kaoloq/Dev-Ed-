using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task1
    {
         public static int FindMin(int[] array)
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
