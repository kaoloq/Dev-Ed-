using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task1Tests
    {
        [TestCase(3, 7, -4)]
        [TestCase(3, -10, -7)]
        [TestCase(20, 3, 23)]
        [TestCase(3, 3, 9)]
        public void CountTests(double a, double b, double expected)
        {
            double actual = Task1.Count(a, b);
            double delta = 0.01;

            Assert.AreEqual(expected, actual, delta);

        }
    }
}