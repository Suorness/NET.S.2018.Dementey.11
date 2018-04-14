namespace BinarySeekerTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BinarySearch;
    using NUnit.Framework;

    [TestFixture]
    public class BinarySearchTests
    {
        #region test source
        public static IEnumerable<TestCaseData> IntTestCaseData
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 3, 4, 5 }, 5).Returns(4);
                yield return new TestCaseData(new[] { 1, 2, 3, 4, 5 }, 1).Returns(0);
                yield return new TestCaseData(new[] { 1, 2, 3, 4, 5 }, 3).Returns(2);
                yield return new TestCaseData(new[] { 1, 2, 3, 4, 5 }, 0).Returns(-1);

                yield return new TestCaseData(Enumerable.Range(0, 999).ToArray(), 0).Returns(0);
                yield return new TestCaseData(Enumerable.Range(0, 999999).ToArray(), 1564).Returns(1564);
            }
        }

        public static IEnumerable<TestCaseData> StringTestCaseData
        {
            get
            {
                yield return new TestCaseData(new[] { "a", "aa", "aaa", "aaaa", }, "a").Returns(0);
                yield return new TestCaseData(new[] { "a", "aa", "aaa", "aaaa", }, "aaa").Returns(2);
                yield return new TestCaseData(new[] { "a", "aa", "aaa", "aaaa", }, "aaaa").Returns(3);
                yield return new TestCaseData(new[] { "a", "aa", "aaa", "aaaa", }, "aaaaa").Returns(-1);

            }
        }
        #endregion test source

        #region test-cases

        [Test, TestCaseSource(nameof(IntTestCaseData))]
        public int SearchIntTests(int[] array, int value)
        {
            return BinarySeeker.Search(array, value);
        }


        [Test, TestCaseSource(nameof(StringTestCaseData))]
        public int SearchStringTests(string[] array, string value)
        {
            return BinarySeeker.Search(array, value);
        }

        [Test]
        public void SearchTestThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => BinarySeeker.Search(null, 5));
        }

        #endregion test-cases
    }
}
