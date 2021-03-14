using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task3Tests
    {
        [TestCase(2, 3, 0, 2)]
        [TestCase(5, 3, 1, 2)]
        [TestCase(-7, 3, -2, -1)]
        [TestCase(7, -3, -2, 1)]
        [TestCase(0, -3, 0, 0)]
        public void FindDivisionAndRemainderTest(int a, int b, int expectedDivision, int expectedRemainder)
        {
            double actualDivision;
            double actualRemainder;
            (actualDivision, actualRemainder) = Task3.FindDivisionAndRemainder(a, b);

            Assert.AreEqual(expectedDivision, actualDivision);
            Assert.AreEqual(expectedRemainder, actualRemainder);
        }


        [TestCase(2, 0)]
        public void DivideByZeroExceptionTest(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => Task3.FindDivisionAndRemainder(a, b));
        }

    }
}