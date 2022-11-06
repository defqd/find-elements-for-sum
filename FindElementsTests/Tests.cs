using FindElements;
using FindElementsTests.TestsSources;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FindElementsTests
{
    [TestFixture]
    public class Tests
    {
        [TestCaseSource(typeof(FindElementsTestSource))]
        public void FindElementsTest(List<uint> list, ulong sum, int start, int end)
        {
            FindElementsList.FindElementsForSum(list, sum, out start, out end);
            Assert.AreEqual(sum, list.Skip(start).Take(end - start).Sum(x => x));
        }

        [TestCaseSource(typeof(NotFoundIndexesTestSource))]
        public void NotFoundIndexesTest(List<uint> list, ulong sum, int start, int end)
        {
            FindElementsList.FindElementsForSum(list, sum, out start, out end);
            Assert.AreNotEqual(sum, list.Skip(start).Take(end - start).Sum(x => x));
        }

        [TestCaseSource(typeof(RandomTestSource))]
        public void RandomTest(List<uint> list, ulong sum, int start, int end)
        {
            FindElementsList.FindElementsForSum(list, sum, out start, out end);
            Assert.AreEqual(sum, list.Skip(start).Take(end - start).Sum(x => x));
        }
    }
}