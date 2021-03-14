using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task1Tests
    {
        [TestCase(0, 0, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(2, 3, 8)]
        [TestCase(-2, 3, -8)]
        [TestCase(-2, 4, 16)]
        [TestCase(-2, 0, 1)]
        public void PowAToBTest(int a, int b, int expected)
        {
            int actual = Task1.PowAToB(a, b);

            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(12, -5)]
        [TestCase(-12, -5)]
        public void ArgumentOutOfRangeExceptionTests(int a, int b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task1.PowAToB(a, b));
        }

    }
}