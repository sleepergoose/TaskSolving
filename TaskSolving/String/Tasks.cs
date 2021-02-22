using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System;

namespace TaskSolving.String
{
    public static class Tasks
    {
        public static string AlphabetWar(string fight)
        {
            string left = "sbpw";
            string right = "zdqm";

            int leftSum = 0, rightSum = 0;

            for (int i = 0, n = fight.Length; i < n; i++)
            {
                if (left.Contains(fight[i]))
                    leftSum += left.IndexOf(fight[i]) + 1;
                else
                    rightSum += right.IndexOf(fight[i]) + 1;
            }

            if (leftSum == rightSum)
                return "Let's fight again!";
            else if (leftSum < rightSum)
                return "Right side wins!";
            else
                return "Left side wins!";
        }

        public static string Limit(string text, int limit)
        {
            if (text.Length > limit)
                return text[0..limit] + "...";
            else
                return text;
        }
        public static int WordsToMarks(string str)
        {
            // from Codewars: str.Sum(p => p - 96);
            return str.Select(p => p - ('a' - 1)).Sum();
        }

        public static int SquareDigits(int n)
        {
            string res = "";
            n.ToString().ToList().ForEach(ch => res += Math.Pow(ch - '0', 2));
            return int.Parse(res);
        }
    }
}
