using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task10Bubble
    {
        public static int[] SortByBubble(int[] array)
        {
            int tmp;
            int j = array.Length;
            while (j != 1)
            {
                for (int i = 0; i < j - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
                j--;
            }

            return array;
        }


    }
}
