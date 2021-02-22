using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskSolving.String
{
    public static class MostFrequentlyUsedWords
    {
        public static List<string> Top3(string s)
        {
            // The best:
            return Regex.Matches(s.ToLowerInvariant(), @"('*[a-z]'*)+")
                    .GroupBy(match => match.Value)
                    .OrderByDescending(g => g.Count())
                    .Select(p => p.Key)
                    .Take(3)
                    .ToList();

            var str = Regex.Replace(s, @"\s+\'*", " ");
            var res = s.ToLower()
                .Split(new char[] { ' ', '-', '!', '?', '_', ':', ';', ',', '.', '/', '\n' })
                .Where(item => item.Length != 0)
                .GroupBy(p => p)
                .OrderByDescending(p => p.Count())
                .Select(p => p.Key)
                .TakeWhile((p, i) => i < 3)
                .ToList();
        }
    }
}
