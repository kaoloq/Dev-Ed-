using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task3Tests
    {
        [TestCase(10, 7, -4, new double[] { -4, 7, 10 })]
        [TestCase(10, -4, 7, new double[] { -4, 7, 10 })]
        [TestCase(-4, 10, 7, new double[] { -4, 7, 10 })]
        [TestCase(7, 10, -4, new double[] { -4, 7, 10 })]
        [TestCase(-4, 7, 10, new double[] { -4, 7, 10 })]
        [TestCase(7, -4, 10, new double[] { -4, 7, 10 })]
        [TestCase(7, 7, 7, new double[] { 7, 7, 7})]
        public void SortToBiggerTests(double a, double b, double c, double[] expected)
        {
            double[] actual = Task3.SortToBigger(a, b, c);

            Assert.AreEqual(expected, actual);

        }
    }
}