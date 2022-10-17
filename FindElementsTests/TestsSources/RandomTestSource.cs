using System;
using System.Collections;
using System.Collections.Generic;

namespace FindElementsTests.TestsSources
{
    public class RandomTestSource : IEnumerable
    {
        public List<uint> GenerateList()
        {
            List<uint> list = new List<uint>();
            Random rand = new Random();

            for (uint i = 0; i < 3000000; i++)
                list.Add((uint)rand.Next(1, 100));

            return list;
        }
        public IEnumerator GetEnumerator()
        {
            var list = GenerateList();

            yield return new object[] { list, 1999995UL, 0, 0 };
            yield return new object[] { list, 10000UL, 0, 0 };
            yield return new object[] { list, 105UL, 0, 0 };
            yield return new object[] { list, 2000UL, 0, 0 };
            yield return new object[] { list, 23124UL, 0, 0 };
            yield return new object[] { list, 6587897568UL, 0, 0 };
            yield return new object[] { list, 456546UL, 0, 0 };
            yield return new object[] { list, 213213123213213213UL, 0, 0 };
            yield return new object[] { list, 999999999999999999UL, 0, 0 };
            yield return new object[] { list, 980988080989809UL, 0, 0 };
        }
    }
}