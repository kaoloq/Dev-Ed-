using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task5Tests
    {
        [TestCase(0, 0, 0)]
        [TestCase(0, 7, 7)]
        [TestCase(-24, 16, -21)]
        [TestCase(3, 69, 315)]
        public void SumNumbersFromAToBTest(int a, int b, int expected)
        {
            int actual = Task5.SumNumbersFromAToB(a, b);

            Assert.AreEqual(expected, actual);
        }

    }
}