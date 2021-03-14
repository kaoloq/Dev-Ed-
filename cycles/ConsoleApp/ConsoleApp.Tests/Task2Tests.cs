using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task2Tests
    {
        [TestCase(250,  new int[] {250, 500, 750, 1000})]
        [TestCase(345, new int[] { 345, 690})]
        public void PowAToBTest(int a,  int[] expected)
        {
            int[] actual = Task2.FindNumbersWithoutRemainder(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-22)]
        [TestCase(-1267)]
        public void ArgumentOutOfRangeExceptionTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task2.FindNumbersWithoutRemainder(a));
        }

    }
}
