using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Task7
    {
        static public int NumberOfOddElements(int[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    number++;
                }
            }

            return number;
        }
    }
}
