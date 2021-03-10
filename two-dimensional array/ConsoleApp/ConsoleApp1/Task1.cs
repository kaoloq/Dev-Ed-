using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Task1
    {
        public static int FindMin(int[,] array) 
        {
            int min = array[0, 0];
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }

            return min;
        }
    }
}
