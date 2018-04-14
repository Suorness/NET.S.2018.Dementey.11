namespace FibanacciNumbers.Tests
{
    /// TODO
    using System;
    using System.Collections.Generic;
    using FibonacciNumbers;
    using NUnit.Framework;
    using System.Linq;
    using System.Collections;

    [TestFixture]
    public class FibanacciNumbersCalulatorTests
    {

        public static IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData(0).Returns(new uint[] {});
                yield return new TestCaseData(2).Returns(new uint[] { 1, 1 });
                yield return new TestCaseData(8).Returns(new uint[] { 1, 1, 2, 3, 5, 8, 13, 21 });
                yield return new TestCaseData(11).Returns(new uint[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 });
                yield return new TestCaseData(21).Returns(new uint[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946 });
            }
        }

        [Test, TestCaseSource(nameof(TestData))]
        public IEnumerable<uint> GetNumbersTest(int count)
        {
            return FibonacciNumbersCalculator.GetNumbers(count).ToArray();
        }
    }
}
