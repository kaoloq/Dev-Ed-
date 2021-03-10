using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task4
    {
        public static int FindIndexOfMax(int[] array)
        { 
            int indexOfMax = 0;
            for (int i = 1; i<array.Length; i++)
            {
                if (array[indexOfMax] < array[i])
                {
                    indexOfMax = i;
                }
            }

            return indexOfMax;
        }
    }
}
