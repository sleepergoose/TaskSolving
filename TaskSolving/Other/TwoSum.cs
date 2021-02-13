using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving.Other
{
    public static class TwoSum
    {
        public static int[] GetTwoSum(int[] numbers, int target)
        {
            int first = 0, second = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                int temp = target - numbers[j];
                int res = numbers.Where((p, i) => p == temp && i != j).FirstOrDefault();
                if (res != 0)
                {
                    first = j;
                    second = Array.IndexOf(numbers, res, j + 1);
                    return new int[] { first, second };
                }
            }
            return new int[] { 0 };
        }

        public static long digPow(int n, int p)
        {

            // long pow = (long)n.ToString().ToArray().Select(x => long.Parse(x.ToString())).Sum(y => Math.Pow(y, p++));
            long pow = (long)n.ToString().ToArray().Select(c => Math.Pow(char.GetNumericValue(c), p++)).Sum();
            long res = pow / n;
            return pow % n == 0 ? res : -1;
        }

        public static List<int> PipeFix(List<int> numbers)
        {
            int start = numbers.First();
            int count = numbers.Last() - numbers.First();

            return Enumerable.Range(start, count + 1).ToList();
        }
    }
}
