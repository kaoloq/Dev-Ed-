using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
//            TestTask1();
//            TestTask2();
//           TestTask3();
//            TestTask4();
//            TestTask5();
//            TestTask6();
//            TestTask7();
//            TestTask8();
            TestTask9();
        }

        public static void TestTask1()
        {
            Console.WriteLine("Test task #1");
            Console.WriteLine("Write A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A ^ B = {Task1.PowAToB(a, b)}");
        }

        public static void TestTask2()
        {
            Console.WriteLine("Test task #2");
            Console.WriteLine("Write A from 1 to 1000: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = Task2.FindNumbersWithoutRemainder(a);
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
        
        public static void TestTask3()
        {
            Console.WriteLine("Test task #3");
            Console.WriteLine("Write A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Task3.CountPositiveIntegers(a));
        }

        public static void TestTask4()
        {
            Console.WriteLine("Test task #4");
            Console.WriteLine("Write A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"NOD(A) = {Task4.FindNOD(a)}");
        }

        public static void TestTask5()
        {
            Console.WriteLine("Test task #5");
            Console.WriteLine("Write A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"SumNumbersFromAToB = {Task5.SumNumbersFromAToB(a, b)}");
        }

        public static void TestTask6()
        {
            Console.WriteLine("Test task #6");
            Console.WriteLine("Write N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Task6.Fibonacci(n)}");
        }

        public static void TestTask7()
        {
            Console.WriteLine("Test task #7");
            Console.WriteLine("Write A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"NOD(A, B) by Evklid = {Task7.FindNodByEvklid(a, b)}");
        }

        public static void TestTask8()
        {
            Console.WriteLine("Test task #8");
            Console.WriteLine("Write an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"num ^ (1/3) = {Task8.BisectionMethod(num)}");
        }

        public static void TestTask9()
        {
            Console.WriteLine("Test task #9");
            Console.WriteLine("Write an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Task9.CountOddDigitsOfInt(num)}");
        }
    }
}
