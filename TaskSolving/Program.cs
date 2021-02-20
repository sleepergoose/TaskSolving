using System;
using System.Linq;
//using TaskSolving.BinaryConvertion;
//using TaskSolving.Other;
//using TaskSolving.NumericalMiracles;
using TaskSolving.String;
using TaskSolving.Linq;
//using TaskSolving.Algorithms;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
//using System.Net;
//using System.Collections;




namespace TaskSolving
{
    public static class Program
    {

        static Action<object> Write = (text) => Console.WriteLine(text);

        static void Main(string[] args)
        {
            Dinglemouse dinglemouse = new Dinglemouse(" Ivan ", "  Pavel   ");
            Write(dinglemouse.FullName);

        }

        public static List<string> Top3(string text)
        {

            string text2 = string.Join("\n", new string[]{"I?n a village? //'/of La Mancha, the name        of which I have no desire to call to",
                  "mind, there lived not long since one of those  gentlemen  that keep    ///a////   lance",
                  "in the lance-rack, an old buckler,    '''a //lean hack, and a greyhound for",
                  "coursing....  An oll'a ///...///of   ''''  rather more beef than    mutton, a salad on most",
                  "nights, scraps   on Saturdays, lentils     'on Fridays,,,, and    a pigeon or so extra",
                  "on Sundays, made  away with  three-quarters //of his income." });


            Scramblies.Scramble("rkqodlw", "world");

            // string.Concat(p.ToCharArray().Select())
            Console.WriteLine("");

            var res = text.ToLower()
                    .Split(" ")
                    .Where(p => string.IsNullOrWhiteSpace(p) != true && string.IsNullOrEmpty(p) != true)
                    .Select(h =>
                    {
                        return string.Concat(h.ToCharArray()
                            .Select(ch => ch)
                            .Where((ch, index) => char.IsLetterOrDigit(ch) || (ch == '\'' && h[index == 0 ? index : index - 1] != '\'')));
                    })
                    .GroupBy(p => p)
                    .OrderByDescending(p => p.Count())
                    .TakeWhile((p, index) => index < 3)
                    .Select(p => p.Key)
                    .ToList();

            return text.ToLower()
                     .Split(" ")
                     .Select(h =>
                     {
                         return string.Concat(h.ToCharArray()
                             .Select(ch => ch)
                             .Where((ch, index) => char.IsLetterOrDigit(ch) || (ch == '\'' && h[index == 0 ? index : index - 1] != '\'')));
                     })
                     .Where(p => string.IsNullOrWhiteSpace(p) != true && string.IsNullOrEmpty(p) != true)
                     .GroupBy(p => p)
                     .OrderByDescending(p => p.Count())
                     .TakeWhile((p, index) => index < 3)
                     .Select(p => p.Key)
                     .ToList();
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