using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTask1();
            TestTask2();
            TestTask3();
            TestTask4();
            TestTask5();
        }

        public static void TestTask1()
        {
            Console.WriteLine("Test task #1");
            Console.WriteLine("Write A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Task1.SolveEquation(a, b));
        }

        public static void TestTask2()
        {
            Console.WriteLine("Test task #2");
            Console.WriteLine("Write A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Task2.SwapAB(a, b));
        }


        public static void TestTask3()
        {
            Console.WriteLine("Test task #3");
            Console.WriteLine("Write A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Task3.FindDivisionAndRemainder(a, b));
        }

        public static void TestTask4()
        {
            Console.WriteLine("Test task #4");
            Console.WriteLine("Write A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write C:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Task4.SolveLinearEquation(a, b, c));
        }

        public static void TestTask5()
        {
            Console.WriteLine("Test task #5");
            Console.WriteLine("Write X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write X2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Task5.WriteLinearEquationByLetters(x1, y1, x2, y2));
        }

    }
}
