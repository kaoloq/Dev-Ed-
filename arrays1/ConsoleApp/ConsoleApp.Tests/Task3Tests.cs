using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task3Tests
    {
        [TestCase(new int[] { 0, 1, 3, -5 }, 3)]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 256 }, 0)]
        public void FindIndexOfMinTest(int[] array, int expected)
        {
            int actual = Task3.FindIndexOfMin(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
