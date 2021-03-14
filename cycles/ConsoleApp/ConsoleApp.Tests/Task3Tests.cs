using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task3Tests
    {
        [TestCase(20, 4)]
        [TestCase(11, 3)]
        [TestCase(25, 4)]
        [TestCase(81, 8)]
        public void CountPositiveIntegersTest(int a, int expected)
        {
            int actual = Task3.CountPositiveIntegers(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-81)]
        public void ArithmeticExceptionTests(int a)
        {
            Assert.Throws<ArithmeticException>(() => Task3.CountPositiveIntegers(a));
        }

    }
}
