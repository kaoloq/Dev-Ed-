using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task9Tests
    {
        [TestCase(0, 0)]
        [TestCase(7, 1)]
        [TestCase(1, 1)]
        [TestCase(-25802751, 4)]
        [TestCase(24680642, 0)]
        [TestCase(13245, 3)]
        public void CountOddDigitsOfIntTest(int a, int expected)
        {
            int actual = Task9.CountOddDigitsOfInt(a);

            Assert.AreEqual(expected, actual);
        }

    }
}
