using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task7Tests
    {
        [TestCase(new int[] { 0, 1, 3, -5 }, 3)]
        [TestCase(new int[] { -2, 0, 2, 5, 3, 2, 6, 2, -4 }, 2)]
        [TestCase(new int[] { 256 }, 0)]
        public void CountOfOddElementsTest(int[] array, int expected)
        {
            int actual = Task7.CountOfOddElements(array);

            Assert.AreEqual(expected, actual);
        }
    }
}