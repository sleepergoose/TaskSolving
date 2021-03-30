using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskSolving.Other
{
    class Tasks
    {
        // Bouncing Balls
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
                return -1;
            int res = 1;
            while (h * bounce > window)
            {
                res += 2;
                h = h * bounce;
            }
            return res;
        }


        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash) =>
            string.Join(",", hash.Select(p => $"{p.Key} = {p.Value}"));
    }
}
