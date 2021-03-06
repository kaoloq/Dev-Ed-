using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task4
    {
        static public int FindIndexOfMax(int[] array)
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
