using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    public class Task5Tests
    {
        [TestCase(21, "Двадцать один")]
        [TestCase(12, "Двенадцать")]
        [TestCase(10, "Десять")]
        [TestCase(55, "Пятьдесят пять")]
        public void ConvertToLetterTests(int a, string expected)
        {
            string actual = Task5.ConvertToLetter(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(105)]
        [TestCase(7)]
        [TestCase(-105)]
        public static void ArgumentOutOfRangeExceptionTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task5.ConvertToLetter(a));
        }
    }
}