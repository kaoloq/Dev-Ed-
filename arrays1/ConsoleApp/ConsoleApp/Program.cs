using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"test task #1 : {Task1.FindMin(array)}");
           Console.WriteLine($"test task #2 : {Task2.FindMax(array)}");
            Console.WriteLine($"test task #3 : {Task3.FindIndexOfMin(array)}");
            Console.WriteLine($"test task #4 : {Task4.FindIndexOfMax(array)}");
            Console.WriteLine($"test task #5 : {Task5.SumOfElementsWithOddIndexes(array)}");
            Console.Write("test task #5: ");
            PrintArray(Task6.Reverse(array));
            Console.WriteLine($"test task #7 : {Task7.CountOfOddElements(array)}");
            Console.Write("test task #8 : ");
            PrintArray(Task8.SwapHalves(array));
            Console.Write("test task #9 Select: ");
            PrintArray(Task9Select.SortBySelect(array));
            Console.Write("test task #9 Insert: ");
            PrintArray(Task9Insert.SortByInsert(array));
            Console.Write("test task #10 Buble: ");
            PrintArray(Task10Bubble.SortByBubble(array));

        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}
