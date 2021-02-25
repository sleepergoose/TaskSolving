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

    }
}
