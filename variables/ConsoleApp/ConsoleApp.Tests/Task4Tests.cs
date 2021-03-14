using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task4Tests
    {
        [TestCase(2, 3, 19, 8)]
        [TestCase(-4, 0, 7, -1.75)]
        [TestCase(-1, -7, -6, -1)]
        public void SolveLinearEquationTest(int a, int b, int c, double expected)
        {
            double actual = Task4.SolveLinearEquation(a, b, c);
            double delta = 0.0001;

            Assert.AreEqual(expected, actual, delta);
        }


        [TestCase(0, 4, 7)]
        [TestCase(0, 0, 0)]
        public void DivideByZeroExceptionTest(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() => Task4.SolveLinearEquation(a, b, c));
        }
    }
}