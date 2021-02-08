using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.BinaryConvertion
{
    public static class TaskForBinary
    {
        public static string EvensAndOdds(int num)
        {
            if ((num & 0b1) == 0)
                return Convert.ToString(num, 2);
            else
                return num.ToString("x");
        }
    }
}
