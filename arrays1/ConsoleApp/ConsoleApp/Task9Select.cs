using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task9Select
    {
        static public int[] SortBySelect(int[] array)
        {
            int tmp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }

            return array;
        }
    }
}
