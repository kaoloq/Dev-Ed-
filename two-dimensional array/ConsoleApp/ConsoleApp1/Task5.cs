using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task5
    {
        public static int CountElementsBiggerThanNeib(int[,] array)
        {
            int counter = 0;

            int min = Task1.FindMin(array);

            int[,] newArray = FillMin(array.GetLength(0) + 2, array.GetLength(1) + 2, min);

            newArray = PushArray(newArray, array);

            for (int i = 1; i < newArray.GetLength(0) - 1; i ++)
            {
                for (int j = 1; j < newArray.GetLength(1) - 1; j++)
                {
                    if (newArray[i, j] > newArray[i, j - 1]
                        && newArray[i, j] > newArray[i, j + 1]
                        && newArray[i, j] > newArray[i + 1, j]
                        && newArray[i, j] > newArray[i - 1, j])
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        private static int[,] FillMin(int n, int m, int min)
        {
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = min;
                }
            }

            return array;
        }

        private static int[,] PushArray(int[,] newArray, int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i + 1, j + 1] = array[i, j];
                }
            }

            return newArray;
        }


    }
}
