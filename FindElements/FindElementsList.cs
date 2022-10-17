namespace FindElements
{
    public static class FindElementsList
    {
        public static void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            start = 0;
            end = 0;

            int resultStart = 0;
            int resultEnd = 0;

            var currentSum = list[0];

            while (start != list.Count - 1)
            {
                if (currentSum == sum)
                {
                    resultStart = start;
                    resultEnd = end;

                    if (start == list.Count - 2 || end == list.Count - 1)
                        break;

                    currentSum -= list[start];
                    start++;
                    end++;
                    currentSum += list[end];
                }

                if (currentSum > sum)
                {
                    currentSum -= list[start];
                    start++;
                }

                if (currentSum < sum)
                {
                    end++;
                    if (end == list.Count)
                        break;
                    currentSum += list[end];
                }
            }
            start = resultStart;
            end = resultEnd == 0 ? resultEnd : resultEnd + 1;
        }
    }
}