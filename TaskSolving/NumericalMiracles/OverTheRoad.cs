using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving.NumericalMiracles
{
    public static class OverTheRoad
    {
        public static long overTheRoad(long address, long n)
        {
            if ((address & 0b1) == 1)
                return 2 * n - address + 1;
            else
                return 2 * n + 1 - address;
        }
    }

    public static class RearangeNumberToGetItsMaximum
    {
        public static int? MaxRedigit(int num)
        {
            if (num > 1000 || num < 100)
                return null;
            else
                return int.Parse(string.Concat(num.ToString().ToCharArray().OrderByDescending(p => p)));
        }
    }
}
