using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task4Tests
    {
        [TestCase(1, 4, 2, new double[] { -0.59, - 3.41})]
        [TestCase(2, 4, 2, new double[] { -1})]
        [TestCase(4, 0, 0, new double[] { 0})]
        [TestCase(4, 5, 1, new double[] { -0.25, - 1})]
        public void SolveSquareEquationTests(double a, double b, double c, double[] expected)
        {
            double[] actual = Task4.SolveSquareEquation(a, b, c);
            double delta = 0.01;

            if (expected.Length != actual.Length)
                Assert.Fail();

            for(int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], delta);
            }

        }

        [TestCase(0, 2, 3)]
        public static void DivideByZeroExceptionTest(double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(() => Task4.SolveSquareEquation(a, b, c));
        }  
        
        [TestCase(10, 2, 5)]
        public static void ArithmeticExceptionTest(double a, double b, double c)
        {
            Assert.Throws<ArithmeticException>(() => Task4.SolveSquareEquation(a, b, c));
        }



    }
}
