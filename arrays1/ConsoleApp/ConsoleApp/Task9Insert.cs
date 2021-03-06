using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task9Insert
    {
        static public int[] SortByInsert(int[] array)
        {
            int tmp;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                    else
                        break;
                }
            }

            return array;
        }
    }
}
