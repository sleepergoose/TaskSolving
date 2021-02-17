using System;
using System.Linq;
//using TaskSolving.BinaryConvertion;
//using TaskSolving.Other;
//using TaskSolving.NumericalMiracles;
//using TaskSolving.String;
//using TaskSolving.Algorithms;
//using System.Numerics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
//using System.Net;
//using System.Collections;




namespace TaskSolving
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string test = string.Join("\n", new string[]{"In a village? //'/of La Mancha, the name        of which I have no desire to call to",
                  "mind, there lived not long since one of those  gentlemen  that keep    ///a////   lance",
                  "in the lance-rack, an old buckler,    '''a //lean hack, and a greyhound for",
                  "coursing....  An oll'a ///...///of   ''''  rather more beef than    mutton, a salad on most",
                  "nights, scraps   on Saturdays, lentils     'on Fridays,,,, and    a pigeon or so extra",
                  "on Sundays, made  away with  three-quarters //of his income." });

            List<string> str = new List<string> { test };



            foreach (var item in str)
            {
                var res = Top3(item);
                Console.WriteLine(res);
            }
            Console.WriteLine();
        }

        public static List<string> Top3(string s)
        {
            s = Regex.Replace(s, @"\s'+", " ");
            s = Regex.Replace(s, @"\s\s+", " ");
            s = Regex.Replace(s, @"/*", "");
            s = Regex.Replace(s, @"\.*", "");
            s = Regex.Replace(s, @",*", "");
            s = Regex.Replace(s, @"?*", "");
            s = Regex.Replace(s, @"\n*", "");

            var res = s.Trim('?', '!', '/', '*', '^', '\n', '\r')
                    .ToLower()
                    .Split(' ')
                    .Where(p => string.IsNullOrWhiteSpace(p) != true)
                    .GroupBy(p => p)
                    .ToList();

            return new List<string>();
                  //.OrderByDescending(p => p.Count()).ThenByDescending(p => p.Count())
                  //.Where((p, i) => i < 3)
                  //.Select(p => p.Key)
                  //.ToList();

            //var str = s.Trim(new char[] { ',', '.', '/' }).ToLower().Split(' ');



            //var r0 = str.Where(p => string.IsNullOrWhiteSpace(p) != true);
            //var r1 = r0.GroupBy(p => p);
            //var r2 = r1.OrderByDescending(p => p.Count());
            //var r3 = r2.TakeWhile((p, i) => i < 3);
            //var r4 = r3.Select(p => p.Key);
            //var r5 = r4.ToList();
            //return r5;
        }
    }
}


/* 
            return s.Trim( '.', ',' )
                  .ToLower()
                  .Split(' ')
                  .Where(p => string.IsNullOrWhiteSpace(p) != true)
                  .GroupBy(p => p)
                  .OrderByDescending(p => p.Count()).ThenByDescending(p => p.Count())
                  .TakeWhile((p, i) => i < 3)
                  .Select(p => p.Key)
                  .ToList();

   int number = 209917;

            var arr = number.ToString().ToCharArray();

            char min = arr.Min();
            int dest = 0, source = 0;
            if (arr[0] == min)
            {
                min = arr[1..arr.Length].Min();
                dest = 1;
            }
            for (int i = dest; i < arr.Length; i++)
            {
                if (arr[i] == min)
                    source = i;
            }

            for (int i = source; i > dest; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[dest] = min;
            long[] res;
            if (dest < 2 && source < 2)
                res =  new long[3] { long.Parse(string.Concat(arr)), dest, source };
            else
                res = new long[3] { long.Parse(string.Concat(arr)), source, dest };



            Console.WriteLine($"number: {number}");
            Console.WriteLine($"res: {string.Join("|", res)}");
 */