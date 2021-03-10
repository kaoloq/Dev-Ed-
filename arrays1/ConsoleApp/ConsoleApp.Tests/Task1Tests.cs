using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task1Tests
    {
        [TestCase(new int[] {0, 1, 3, -5}, -5)]
        [TestCase(new int[] {0, 0, 0, 0, 0}, 0)]
        [TestCase(new int[] {256}, 256)]
        public void FindMinTest(int[] array, int expected)
        {
            int actual = Task1.FindMin(array);

            Assert.AreEqual(expected, actual);
        }
    }
}