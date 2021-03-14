using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task8Tests
    {
        [TestCase(27, 3)]
        [TestCase(1, 1)]
        [TestCase(8, 2)]
        public void BisectionMethodTest(int a, int expected)
        {
            int actual = Task8.BisectionMethod(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-27)]
        public void ArgumentOutOfRangeExceptionTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task8.BisectionMethod(a));
        }

    }
}