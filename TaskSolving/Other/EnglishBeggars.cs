using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving.Other
{
    public static class EnglishBeggars
    {
        public static int[] GotOffers(int[] values, int n)
        {
            var beggars = Enumerable.Range(0, n);
            var res = beggars.Select(b => values.Where((p, i) => (i % n) == b).Sum()).ToArray();

            return res;
        }
    }
}
