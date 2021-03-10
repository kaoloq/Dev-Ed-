using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task4Tests
    {
        [TestCase(new int[] { 0, 1, 3, -5 }, 2)]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 256 }, 0)]
        public void FindMinTest(int[] array, int expected)
        {
            int actual = Task4.FindIndexOfMax(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
