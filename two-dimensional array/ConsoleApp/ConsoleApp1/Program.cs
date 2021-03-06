using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[,] array = CreatArray(n, m);

            WriteArray(array);

            TestTask1(array);
            TestTask2(array);
            TestTask3(array);
            TestTask4(array);
            TestTask5(array);
            TestTask6(array);
           
        }

        private static int[,] CreatArray(int n, int m)
        {
            if(n <=0 || m <= 0)
            {
                throw new Exception("Out of range");
            }

            Random random = new Random();
            int[,] array = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    array[i,j] = random.Next(-20, 20);
                }
            }

            return array;
        }

        private static void TestTask1(int[,] array)
        {
            Console.WriteLine($"Test task#1 : {Task1.FindMin(array)}");
        }

        private static void TestTask2(int[,] array)
        {
            Console.WriteLine($"Test task#2 : {Task2.FindMax(array)}");
        }

        private static void TestTask3(int[,] array)
        {
            int[] result = Task3.FindIndexOFMin(array);
            Console.WriteLine($"Test task #3: i = {result[0]} j = {result[1]}");
        }

        private static void TestTask4(int[,] array)
        {
            int[] result = Task4.FindIndexOFMax(array);
            Console.WriteLine($"Test task #4: i = {result[0]} j = {result[1]}");
        }
        
        private static void TestTask5(int[,] array)
        {
            Console.WriteLine($"Test task #5: {Task5.CountElementsBiggerThanNeib(array)}");
        }
        
        private static void TestTask6(int[,] array)
        {
            Console.WriteLine("Test task#6:");
            WriteArray(Task6.Transpose(array));
        }

        private static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
