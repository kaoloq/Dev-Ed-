using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task8
    {
        public static int[] SwapHalves(int[] array)
        {
            int middle = array.Length / 2;
            if (array.Length % 2 != 0)
            {
                middle++;
            }

            int tmp;
            for (int i = 0; i + middle < array.Length; i++)
            {
                tmp = array[i];
                array[i] = array[i + middle];
                array[i + middle] = tmp;

            }

            return array;
        }
    }
}
