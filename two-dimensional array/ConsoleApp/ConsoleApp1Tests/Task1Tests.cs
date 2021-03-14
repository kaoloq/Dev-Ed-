using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task1Tests
    {
        [TestCase(1, -19)]
        public void FindMinTest(int MockNumber, int expected)
        {
            int actual = Task1.
            Assert.Pass();
        }
    }

    public static class DoubleArrayMock
    {
        public static int[] GetMock(int number)
        {
            int[,] result;
            switch (number)
            {
                case 1:
                    result = new int[,] { { 0, 2, 4, -3, -5 }, { 4, 7, -19, 2, 3 }, { 15, 5, 11, 7, -5 } };
                    break;
                default;
                    break;

            }

            return result;

        } 
    }
}