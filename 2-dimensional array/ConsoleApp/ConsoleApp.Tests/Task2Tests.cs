using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task2Tests
    {
        [TestCase(1, 15)]
        [TestCase(2, 36)]
        public void FindMaxTest(int MockNumber, int expected)
        {
            int[,] array = DoubleArrayMockTask2.GetMock(MockNumber);
            int actual = Task2.FindMax(array);
            Assert.AreEqual(expected, actual);
        }
    }

    public static class DoubleArrayMockTask2
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,] { { 0, 2, 4, -3, -5 }, { 4, 7, -19, 2, 3 }, { 15, 5, 11, 7, -5 } };
                    break;
                case 2:
                    result = new int[,] { { 3, 9, 10 }, { 2, 36, 2 } };
                    break;
                default:
                    break;

            }

            return result;

        }
    }
}
