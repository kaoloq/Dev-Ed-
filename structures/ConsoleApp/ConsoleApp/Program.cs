using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            (double a1, double b1) = ReadTask1();
            Console.WriteLine($"Test task #1 : {Task1.Count(a1, b1)}");

            (double x, double y) = ReadTask2();
            Console.WriteLine($"Test task #2 : {Task2.IdentifyQuarterOfPoint(x, y)}");

            (double a3, double b3, double c3) = ReadTask3();
            double[] result3 = Task3.SortToBigger(a3, b3, c3);
            PrintArray(result3, 3);

            (double a4, double b4, double c4) = ReadTask4();
            double[] result4 = Task4.SolveSquareEquation(a4, b4, c4);
            PrintArray(result4, 4);

            int num = ReadTask5();
            Console.WriteLine($"Test task #5 : {Task5.ConvertToLetter(num)}");
        }

        private static (double, double) ReadTask1()
        {
            Console.WriteLine("Task #1");
            Console.Write("Write A : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write B : ");
            double b = Convert.ToDouble(Console.ReadLine());
            return (a, b);
        }

        private static (double, double) ReadTask2()
        {
            Console.WriteLine("Task #2");
            Console.Write("Write X : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write Y : ");
            double y = Convert.ToDouble(Console.ReadLine());
            return (x, y);
        }

        private static (double, double, double) ReadTask3()
        {
            Console.WriteLine("Task #3");
            Console.Write("Write A : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write B : ");
            double b = Convert.ToDouble(Console.ReadLine());      
            Console.Write("Write C : ");
            double c = Convert.ToDouble(Console.ReadLine());
            return (a, b, c);
        }

        private static (double, double, double) ReadTask4()
        {
            Console.WriteLine("Task #4");
            Console.Write("Write A : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write B : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write C : ");
            double c = Convert.ToDouble(Console.ReadLine());
            return (a, b, c);
        }

        private static int ReadTask5()
        {
            Console.WriteLine("Task #5");
            Console.Write("Write number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        static private void PrintArray(double[] array, int numberOfTask)
        {
            Console.Write("Test task #3 : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}
