using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task6
    {
        public static int[] Reverse(int[] array)
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
