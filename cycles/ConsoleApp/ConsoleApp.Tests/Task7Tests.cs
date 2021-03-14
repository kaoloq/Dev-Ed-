using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task7Tests
    {
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(2, 3, 1)]
        [TestCase(16, -8, 8)]
        [TestCase(24, -24, 24)]
        [TestCase(81, 54, 27)]
        public void FindNodByEvklidTest(int a, int b, int expected)
        {
            int actual = Task7.FindNodByEvklid(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
