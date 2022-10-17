using System.Collections;
using System.Collections.Generic;

namespace FindElementsTests.TestsSources
{
    public class NotFoundIndexesTestSource : IEnumerable
    {
        public List<uint> GenerateList()
        {
            List<uint> list = new List<uint>();

            for (uint i = 0; i < 1000000; i++)
                list.Add(i);

            return list;
        }
        public IEnumerator GetEnumerator()
        {
            var list = GenerateList();

            yield return new object[] { list, 1000000000000000UL, 0, 0 }; //start будет равен 0 и end 0

            yield return new object[] { new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88UL, 0, 0 };  //start будет равен 0 и end 0
            yield return new object[] { new List<uint> { 10, 1, 2, 3, 4, 5, 6, 7 }, 89UL, 0, 0 };  //start будет равен 0 и end 0
            yield return new object[] { new List<uint> { 120, 1, 2, 3, 4, 5, 6, 7 }, 90UL, 0, 0 };  //start будет равен 0 и end 0
            yield return new object[] { new List<uint> { 34, 2, 123, 9, 0, 5, 212, 98 }, 10000UL, 0, 0 }; //start будет равен 0 и end 0
        }
    }
}