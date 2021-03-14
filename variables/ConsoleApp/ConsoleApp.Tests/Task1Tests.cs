using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task1Tests
    {
        [TestCase(2, 3, 19)]
        [TestCase(-10.3829, 0.8261, -4.5706)]
        [TestCase(4, -7, -6.2727)]
        public void SolveEquationTest(double a, double b, double expected)
        {
            double actual = Task1.SolveEquation(a, b);
            double delta = 0.0001;

            Assert.AreEqual(expected, actual, delta);
        }


        [TestCase(3, 3)]
        [TestCase(0, 0)]
        public void DivideByZeroExceptionTest(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => Task1.SolveEquation(a, b));
        }
    }
}