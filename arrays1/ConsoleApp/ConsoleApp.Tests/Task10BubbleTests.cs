using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task10BubbleTests
    {
        [TestCase(new int[] { 0, 1, 3, -5 }, new int[] { 3, 1, 0, -5 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 256, -25, 3, 0, 0 }, new int[] { 256, 3, 0, 0, -25 })]
        public void FindMinTest(int[] array, int[] expected)
        {
            int[] actual = Task10Bubble.SortByBubble(array);

            Assert.AreEqual(expected, actual);
        }
    }
}