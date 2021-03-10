using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task5Tests
    {
        [TestCase(new int[] { 0, 1, 3, -5, 2, 1}, -3)]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 256 }, 0)]
        public void SumOfElementsWithOddIndexesTest(int[] array, int expected)
        {
            int actual = Task5.SumOfElementsWithOddIndexes(array);

            Assert.AreEqual(expected, actual);
        }
    }
}