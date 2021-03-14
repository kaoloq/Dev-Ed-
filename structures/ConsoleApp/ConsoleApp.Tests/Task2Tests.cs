using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task2Tests
    {
        [TestCase(3, 7, 1)]
        [TestCase(-3, 7, 2)]
        [TestCase(-3, -10, 3)]
        [TestCase(3, -10, 4)]
        [TestCase(0, 0, 1)]
        public void IdentifyQuarterOfPointTests(double x, double y, int expected)
        {
            int actual = Task2.IdentifyQuarterOfPoint(x, y);

            Assert.AreEqual(expected, actual);

        }
    }
}