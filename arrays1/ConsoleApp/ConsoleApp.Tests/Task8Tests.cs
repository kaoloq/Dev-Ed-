using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task8Tests
    {
        [TestCase(new int[] { 0, 1, 3, -5 }, new int[] { 3, -5, 0, 1})]
        [TestCase(new int[] { -2, 0, 2, 5, 3}, new int[] { 5, 3, 2, -2, 0})]
        [TestCase(new int[] { 256 }, new int[] { 256})]
        public void SwapHalvesTest(int[] array, int[] expected)
        {
            int[] actual = Task8.SwapHalves(array);

            Assert.AreEqual(expected, actual);
        }
    }
}