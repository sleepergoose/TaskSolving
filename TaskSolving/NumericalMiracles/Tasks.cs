using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.NumericalMiracles
{
    public static class Tasks
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int res = p0, counter = 0;
            while (res < p)
            {
                res = (int)(res * (1 + percent / 100d) + aug);
                counter++;
            }
            return counter;
        }

        public static string WomensAge(int age)
        {
            return age % 2 == 0 ? $"{age}? That's just 20, in base {age / 2}!" : $"{age}? That's just 21, in base {(age - 1) / 2}!";
        }

        public static bool CommonOne(int a, int b) =>
            ((a & b) & ((a & b) - 1)) != 0;

    }
}
