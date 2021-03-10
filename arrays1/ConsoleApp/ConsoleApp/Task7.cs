using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task7
    {
        public static int CountOfOddElements(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
