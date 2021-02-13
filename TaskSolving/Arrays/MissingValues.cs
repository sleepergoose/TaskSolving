using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving.Arrays
{
    public static class MissingValues
    {
        // the best
        public static void Another()
        {
            int[] arr = new int[] { 1, 1, 1, 2, 2, 3 };

            var grouped = arr.GroupBy(i => i);
            var x = grouped.FirstOrDefault(g => g.Count() == 1).Key;
            var y = grouped.FirstOrDefault(g => g.Count() == 2).Key;

            int res = x * x * y;
        }

        public static int ArrayMissingValues(int[] arr)
        {
            int ones = 0;
            int twice = 0;
            int crowler = 0;

            int[] another = arr.Distinct().ToArray();

            for (int i = 0; i < another.Length; i++)
            {
                crowler = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (another[i] == arr[j])
                        crowler++;
                    if (crowler == 3)
                        break;
                }
                if (crowler == 1)
                    ones = another[i];
                else if (crowler == 2)
                    twice = another[i];
            }

            return ones * ones * twice;
        }
    }
}
