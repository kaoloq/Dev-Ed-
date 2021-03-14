using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task3Tests
    {
        [TestCase(1, 1, 2)]
        [TestCase(2, 1, 0)]
        public void FindIndexOFMinTest(int MockNumber, int expectedI, int expectedJ)
        {
            int[,] array = DoubleArrayMockTask3.GetMock(MockNumber);
            int[] actual = Task3.FindIndexOFMin(array);

            int actualI = actual[0];
            int actualJ = actual[1];

            Assert.AreEqual(expectedI, actualI);
            Assert.AreEqual(expectedJ, actualJ);
        }
    }

    public static class DoubleArrayMockTask3
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
