using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task4Tests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(226, 113)]
        [TestCase(343, 49)]
        [TestCase(-25, 5)]
        [TestCase(-163, 1)]
        public void FindNODTest(int a, int expected)
        {
            int actual = Task4.FindNOD(a);

            Assert.AreEqual(expected, actual);
        }

    }
}
