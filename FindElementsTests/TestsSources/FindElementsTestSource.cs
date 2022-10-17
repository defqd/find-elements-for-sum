using System.Collections;
using System.Collections.Generic;

namespace FindElementsTests.TestsSources
{
    public class FindElementsTestSource : IEnumerable
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

            yield return new object[] { list, 1999995UL, 0, 0 }; //start будет равен 999997 и end 999999

            yield return new object[] { new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11UL, 0, 0 }; //start будет равен 5 и end 7
            yield return new object[] { new List<uint> { 4, 5, 6, 7 }, 18UL, 0, 0 }; //start будет равен 1 и end 4
            yield return new object[] { new List<uint> { 34, 2, 123, 9, 0, 5, 212, 98 }, 9UL, 0, 0 }; //start будет равен 3 и end 4
            yield return new object[] { new List<uint> { 12, 26, 3, 4, 2, 34, 2, 123, 10, 0, 5, 212, 98 }, 10UL, 0, 0 };  //1 - ый вариант: start будет равен 2 и end 3 //2 - ой вариант : start будет равен 8 и end 9
        }
    }
}