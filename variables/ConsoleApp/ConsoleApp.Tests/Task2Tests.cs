using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task2Tests
    {
        [TestCase(2, 3, 3, 2)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(-10, -7, -7, -10)]
        public void SwapABTests(double a, double b, double expectedA, double expectedB)
        {
            Task2.SwapAB(ref a, ref b);

            double actualA = a;
            double actualB = b;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

    }
}