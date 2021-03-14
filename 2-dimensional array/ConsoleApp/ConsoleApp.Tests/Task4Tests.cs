using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task4Tests
    {
        [TestCase(1, 2, 0)]
        [TestCase(2, 1, 1)]
        public void FindIndexOFMaxTest(int MockNumber, int expectedI, int expectedJ)
        {
            int[,] array = DoubleArrayMockTask4.GetMock(MockNumber);
            int[] actual = Task4.FindIndexOFMax(array);

            int actualI = actual[0];
            int actualJ = actual[1];

            Assert.AreEqual(expectedI, actualI);
            Assert.AreEqual(expectedJ, actualJ);
        }
    }

    public static class DoubleArrayMockTask4
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