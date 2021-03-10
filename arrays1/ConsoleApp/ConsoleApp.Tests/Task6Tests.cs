using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task6Tests
    {
        [TestCase(new int[] { 0, 1, 3, -5 }, new int[] {-5, 3, 1, 0 })]
        [TestCase(new int[] { -2, 0, 2, 5, 3}, new int[] { 3, 5, 2, 0, -2})]
        [TestCase(new int[] { 256 }, new int[] { 256 })]
        public void ReverseTest(int[] array, int[] expected)
        {
            int[] actual = Task6.Reverse(array);

            Assert.AreEqual(expected, actual);
        }
    }
}