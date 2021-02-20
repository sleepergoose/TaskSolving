using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TaskSolving.Linq
{
    public static class Level8th
    {
        //331
        public static int Grow(int[] x)
        {
            return x.Aggregate((x, y) => x * y);
        }

        public static int[] Maps(int[] array) => array.Select(p => p * 2).ToArray();

        public static int RentalCarCost(int d)
        {
            int EveryDayRent = 40;
            if (d < 3)
                return d * EveryDayRent;
            else if (d >= 3 && d < 7)
                return d * EveryDayRent - 20;
            else if (d >= 7)
                return d * EveryDayRent - 50;
            else
                return 0;
        }


        public static int СenturyFromYear(int year)
        {
            int res = year / 100;
            return res * 100 < year ? res + 1 : res;
        }

        public static string Spoonerize(string str)
        {
            var t = str.Split();

            int i = str.IndexOf(' ') + 1;
            var array = str.ToCharArray();
            (array[0], array[i]) = (array[i], array[0]);

            return string.Concat(array);
        }


        public static string Vowel2Index(string str)
        {
            // The best solving from Codewars
            return Regex.Replace(str, "[aeiou]", x => (x.Index + 1).ToString());
            return string.Concat(str.Select((c, i) => "aeiou".Contains(c) ? $"{i + 1}" : $"{c}"));

            char[] arr = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string result = "";
            for (int i = 0, n = str.Length; i < n; i++)
            {
                result += (arr.Contains(str[i]) == true ? (i + 1).ToString() : str[i].ToString());
            }
            return result;
        }

        public static long[] Seven(long number)
        {
            long counter = 0;
            while (number > 99)
            {
                counter++;
                long sub = long.Parse(number.ToString()[0..^1]) - (number.ToString()[^1] - '0') * 2;
                number = sub;
            } 
            return new long[] { number, counter };
        }

        public static string TwoToOne(string s1, string s2)
        {
            // the most efficient way
            return string.Concat((s1 + s2).Distinct().OrderBy(p => p));

            return string.Concat(s1.ToCharArray().Union(s2.ToCharArray()).Distinct().OrderBy(p => p));
        }


        public static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            var result = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string.Concat(Enumerable.Range(start, end - start + 1)
                .Select(p => p.ToString()))
                .GroupBy(p => p)
                .OrderBy(p => p.Key)
                .ToList().ForEach(p => result[p.Key - '0'] = p.Count());
            return result;
        }

    }
}
