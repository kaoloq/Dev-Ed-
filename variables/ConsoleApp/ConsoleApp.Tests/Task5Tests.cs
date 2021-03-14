using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task5Tests
    {
        [TestCase(2, 3, -7, 4, "Y = -0,11X + (3,22)")]
        [TestCase(-10, 0, 4, 6, "Y = 0,43X + (4,29)")]
        [TestCase(4, -7, -6, 0, "Y = -0,7X + (-4,2)")]
        public void WriteLinearEquationByLettersTest(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = Task5.WriteLinearEquationByLetters(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(3, 3, 3, 6)]
        [TestCase(0, 0, 0, -4)]
        public void DivideByZeroExceptionTest(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<DivideByZeroException>(() => Task5.WriteLinearEquationByLetters(x1, y1, x2, y2));
        }
    }
}
