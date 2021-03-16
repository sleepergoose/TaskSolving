﻿using System.Linq;
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

        public static string Rot13(string message)
        {
            string res = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    if ((message[i] > 64 && message[i] < 78) || (message[i] > 96 && message[i] < 110))
                        res += (char)(message[i] + 13);
                    else
                        res += (char)(message[i] - 13);
                }
                else
                {
                    res += message[i];
                }
            }
            return res;
        }


        public static string Decode(string morseCode)
        {
            return string.Join(" ", morseCode.Split("   ").Select(p => string.Concat(p.Split()
                .Select(c => MorseTo[c]))));
        }

        static Dictionary<string, string> ToMorse = new Dictionary<string, string>
        {
            ["A"] = ".-",
            ["B"] = "−...",
            ["C"] = "−.−.",
            ["D"] = "-..",
            ["E"] = ".",
            ["F"] = "..-.",
            ["G"] = "--.",
            ["H"] = "....",
            ["I"] = "..",
            ["J"] = ".---",
            ["K"] = "-.-",
            ["L"] = ".-..",
            ["M"] = "--",
            ["N"] = "-.",
            ["O"] = "---",
            ["P"] = ".--.",
            ["Q"] = "--.-",
            ["R"] = ".-.",
            ["S"] = "...",
            ["T"] = "-",
            ["U"] = "..-",
            ["V"] = "...-",
            ["W"] = ".--",
            ["X"] = "-..-",
            ["Y"] = "-.--",
            ["Z"] = "--.."
        };
        static Dictionary<string, string> MorseTo = new Dictionary<string, string>
        {
            [".-"] = "A",
            ["−..."] = "B",
            ["−.−."] = "C",
            ["-.."] = "D",
            ["."] = "E",
            ["..-."] = "F",
            ["--."] = "G",
            ["...."] = "H",
            [".."] = "I",
            [".---"] = "J",
            ["-.-"] = "K",
            [".-.."] = "L",
            ["--"] = "M",
            ["-."] = "N",
            ["---"] = "O",
            [".--."] = "P",
            ["--.-"] = "Q",
            [".-."] = "R",
            ["..."] = "S",
            ["-"] = "T",
            ["..-"] = "U",
            ["...-"] = "V",
            [".--"] = "W",
            ["-..-"] = "X",
            ["-.--"] = "Y",
            ["--.."] = "Z"
        };


        public static int DescendingOrder(int num) =>
            int.Parse(string.Concat(num.ToString().OrderByDescending(p => p)));

        public static string OddOrEven(int[] array) =>
            (array.Sum() & 0b1) == 1 ? "odd" : "even";

        public static string boolToWord(bool word) => word ? "Yes" : "No";
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            return birds.Except(geese);
        }

        public static string ToCamelCase(string str)
        {
            // The Best
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());

            string temp = Regex.Replace(str, @"[_-]\w", ch => ch.ToString().ToUpper());
            return Regex.Replace(temp, @"[_-]", "");
        }


        public static string CreatePassword(int length)
        {
            string members = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(members[random.Next(0, members.Length)]);
            }
            return result.ToString();
        }


        // var res = ValidParentheses("(())((()())())");
        // res = ValidParentheses("(ff)( )(dd )(  dd)( d()d)d");
        public static bool ValidParentheses(string input)
        {
            if (input.Contains('(') == false && input.Contains(')') == false)
                return false;

            Stack<char> stack = new Stack<char>(100);
            try
            {
                foreach (var ch in input)
                {
                    if (ch == '(')
                        stack.Push(ch);
                    else if (ch == ')')
                        stack.Pop();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return stack.Count == 0 ? true : false;
        }


        public static string Switcher(string[] x)
        {
            string array = " ?!zyxwvutsrqponmlkjihgfedcba";
            string result = "";
            for (int i = 0; i < x.Length; i++)
            {
                result += array[int.Parse(x[i])];
            }
            return result;
        }



        /* ======= */
        public static string FormatTime(int hour)
        {
            if (hour > 9999 || hour < 100)
                throw new Exception();
            string temp = hour.ToString();
            return temp.Insert(temp.Length - 2, ":");
        }
        // Solving from community:
        public static string FormatTimeFromComunity(int hour)
        {
            if (hour < 100 || hour > 9999)
            {
                throw new ArgumentException();
            }
            return $"{hour:##:##}";
        }
        /* ======= */



        public static string[] Solution(string str)
        {
            List<string> result = new List<string>();
            if (str.Length % 2 != 0)
                str = str + "_";
            for (int i = 0; i < str.Length / 2; i++)
                result.Add(str.Substring(i * 2, 2));
            return result.ToArray();
        }


        // UpperCase every words in 'title' excluding words in 'minorWords' and the first word
        public static string TitleCase(string title, string minorWords = "")
        {
            if (title == "")
                return "";
            if (minorWords == null)
                minorWords = "";
            var minors = minorWords.ToLower().Split(" ");
            var titles = title.ToLower().Split(" ").Select((word, index) => {
                if (minors.Contains(word) == false)
                    word = char.ToUpper(word[0]) + word[1..];
                else if (minors.Contains(word) == true && index == 0)
                    word = char.ToUpper(word[0]) + word[1..];
                return word;
            });
            return string.Join(" ", titles);
        }



        /* ======= */
        // Break camelCase
        public static string BreakCamelCase(string str)
        {
            //var indexes = str.Select((p, index) => new { p, index }).Where(tuple => char.IsUpper(tuple.p));
            StringBuilder result = new StringBuilder();
            foreach (char ch in str)
            {
                if (char.IsUpper(ch) == true)
                    result.Append(" " + ch);
                else
                    result.Append(ch);
            }
            return result.ToString();
        }
        // from Community
        public static string BreakCamelCase1(string str) =>
              new Regex("([A-Z])").Replace(str, " $1");
        public static string BreakCamelCase2(string str)
        {
            return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }
        /* ======= */



        // RGB To Hex Conversion
        public static string Rgb(int r, int g, int b)
        {
            int R = r > 255 ? 255 : r < 0 ? 0 : r;
            int G = g > 255 ? 255 : g < 0 ? 0 : g;
            int B = b > 255 ? 255 : b < 0 ? 0 : b;
            return R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
            // Solving from community:
            // return Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");
            // return $"{(r > 255 ? 255 : r < 0 ? 0 : r):X2}" +
            //   $"{(g > 255 ? 255 : g < 0 ? 0 : g):X2}" +
            //   $"{(b > 255 ? 255 : b < 0 ? 0 : b):X2}";
        }
    }
}
