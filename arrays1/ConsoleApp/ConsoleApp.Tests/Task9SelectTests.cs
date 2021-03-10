using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task9SelectTests
    {
        [TestCase(new int[] { 0, 1, 3, -5 }, new int[] { -5, 0, 1, 3 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 256, -25, 3, 0, 0 }, new int[] { -25, 0, 0, 3, 256 })]
        public void FindMinTest(int[] array, int[] expected)
        {
            int[] actual = Task9Select.SortBySelect(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
