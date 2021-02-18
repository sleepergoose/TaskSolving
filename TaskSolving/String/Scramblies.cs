using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskSolving.String
{
    public static class Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < str2.Length; i++)
            {
                if (dict.ContainsKey(str2[i]))
                    dict[str2[i]] += 1;
                else
                    dict.Add(str2[i], 1);
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (dict.ContainsKey(str1[i]))
                    dict[str1[i]] -= 1;
                else
                    dict.Add(str2[i], 1);
            }
            return false;
        }
    }
}
