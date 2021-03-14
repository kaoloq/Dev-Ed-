using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task1Tests
    {
        [TestCase(new int[,] { { 0, 2, 4, -3, -5 }, { 4, 7, -19, 2, 3 }, { 15, 5, 11, 7, -5 } }, -19)]
        public void FindMinTest(int[,] array, int expected)
        {
            int actual 
            Assert.Pass();
        }
    }
}