using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task6
    {
        static public int[] Reverse(int[] array)
        {
            int tmp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmp;
            }

            return array;
        }
    }
}
