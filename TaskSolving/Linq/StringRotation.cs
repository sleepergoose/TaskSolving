using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSolving.Linq
{
    public static class StringRotation
    {
        // Solution of the task with extension method
        /* 
        static string vert_mirror(string str) =>
             str.Split("\n").Select(l => l.ToCharArray().Reverse().Join()).Join("\\n");

        static string hor_mirror(string str) =>
            str.Split("\n").Reverse().Join("\\n");
        */

        public static string vert_mirror(string str) =>
            string.Join("\n", str.Split("\n").Select(p => string.Concat(p.Reverse())));

        public static string hor_mirror(string str) =>
            string.Join("\n", str.Split("\n").Reverse());

        public static string rot(string s) =>
           string.Join("\n", s.Split("\n").Select(p => string.Concat(p.Reverse())).Reverse());

        public static string selfie_and_rot(string s)
        {
            var array = s.Split("\n");
            int n = array[0].Length * 2;
            var temp = array.Select(p => p.PadRight(n, '.'));
            var result = string.Join("\n", temp.Union(temp.Select(p => string.Concat(p.Reverse())).Reverse()));

            return result;
        }

        public static string diag_1_sym(string s)
        {
            return string.Join("\n", s.Split("\n").Select((p, index) => string.Concat(s.Split("\n").Select(p => p[index]))));

            string[] array = s.Split("\n"); // Devide string into string[]
            int n = array[0].Length; // Length of one of the N elements
            string res = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res += s[i + j * (n + 1)];
                }
                res += "\n";
            }

            return res.TrimEnd('\n');
        }

        public static string rot_90_clock(string s)
        {
            // return string.Join("\n", s.Split('\n').Select((x, i) => string.Concat(s.Split('\n').Select(z => z[i]).Reverse())));

            string[] array = s.Split("\n"); // Devide string into string[]
            int n = array[0].Length; // Length of one of the N elements
            string res = "";
            string part = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    part += s[i + j * (n + 1)];
                }

                res += string.Concat(part.Reverse()) + "|";
                part = "";
            }

            return res.TrimEnd('\n');
        }

        public static string selfie_and_diag1(string s)
        {
            // return string.Join("\n", s.Split('\n').Select((x, i) => x + "|" + string.Concat(s.Split('\n').Select(z => z[i]))));

            string[] array1 = s.Split("\n");
            string[] array2 = diag_1_sym(s).Split("\n");

            var res = array1.Zip(array2,
                (o, i) => { return o + "|" + i; });

            return string.Join("\n", res);
        }

        public static string oper(Func<string, string> func, string str) =>
            func(str);
    }

    // Generic extensions method for IEnumerable<T>
    static class Extensions
    {
        public static string Join<T>(this IEnumerable<T> array, string separator = null) =>
            string.Join(separator ?? "", array);
    }
}

/*
public static string Rot90Clock(string strng) =>
  string.Join("\n", strng.Split('\n').Select((x, i) => string.Concat(strng.Split('\n').Select(z => z[i]).Reverse())));

public static string Diag1Sym(string strng) =>
string.Join("\n", strng.Split('\n').Select((x, i) => string.Concat(strng.Split('\n').Select(z => z[i]))));

public static string SelfieAndDiag1(string strng) =>
string.Join("\n", strng.Split('\n').Select((x, i) => x + "|" + string.Concat(strng.Split('\n').Select(z => z[i]))));

*/