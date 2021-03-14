using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task6Tests
    {
        [TestCase(13, 233)]
        [TestCase(6, 8)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        public void FibonacciTest(int a, int expected)
        {
            int actual = Task6.Fibonacci(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-12)]
        [TestCase(0)]
        public void ArgumentOutOfRangeExceptionTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task6.Fibonacci(a));
        }

    }
}
