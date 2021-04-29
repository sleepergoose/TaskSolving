using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System;
using System.Diagnostics.CodeAnalysis;

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


        /* ===ROT13 ===  */
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

        public static string Rot13_2(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if ((input[i] > 64 && input[i] < 78) || (input[i] > 96 && input[i] < 110))
                        sb.Append((char)(input[i] + 13));
                    else
                        sb.Append((char)(input[i] - 13));
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            return sb.ToString();
        }
        /* From community:
           public static string Rot13(string input) =>
                Regex.Replace(input, "[a-zA-Z]", new MatchEvaluator(c => ((char)(c.Value[0] + (Char.ToLower(c.Value[0]) >= 'n' ? -13 : 13))).ToString()));

           return new string(input.Select(x =>
                char.IsLetter(x) ? (char)((int)x + (char.ToUpper(x) < 'N' ? 13 : -13)) : x).ToArray());  
        */

        /* =====  */

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


        // Where my anagrams at?
        // SequenceEqual
        public static List<string> Anagrams(string word, List<string> words)
        {
            return words?.Where(w => w.OrderBy(p => p).SequenceEqual(word.OrderBy(p => p))).ToList();
            // my old: words.Where(w => string.Concat(w.OrderBy(p => p)) == string.Concat(word.OrderBy(p => p))).ToList();
            // from community:
            // return words?.Where(w => w.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c))).ToList();
        }




        public static string PigIt(string str)
        {
            // from Community:
            // return Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");
            // return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
            var array = str.Split(" ").Select(word => {
                if (Regex.IsMatch(word, "[a-z]", RegexOptions.IgnoreCase))
                    return word[1..word.Length] + word[0] + "ay";
                else
                    return word;
            });
            return string.Join(" ", array);
            /*
            List<string> list = new List<string>();
            var array = str.Split(" ");
            string word = "";
            foreach (string item in array)
            {
                if (item.Length > 1)
                    word = item[1..item.Length] + item[0] + "ay";
                else
                    word = item;
                list.Add(word);
            }
            return string.Join(" ", list);
            */
        }

        // Human Readable Time
        static string Readable(int seconds)
        {
            int h = seconds / 3600;
            int m = (seconds - h * 3600) / 60;
            int s = seconds - h * 3600 - m * 60;
            return $"{h:00}:{m:00}:{s:00}";
        }
        // return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        // var t = TimeSpan.FromSeconds(seconds);
        // return string.Format("{0:00}:{1:00}:{2:00}", (int) t.TotalHours, t.Minutes, t.Seconds);


        // Numbers seted bit in binary view of integer
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Where(p => p == '1').Count();
        }

        // Group Text Representation of Integer By Commas
        public static string GroupByCommas(int n)
        {
            return $"{n:###,###,###,###}";
            // return String.Format("{0:n0}", n);
            // return n.ToString("N0");
            // return n.ToString("#,#");
        }

        // Christmas Tree
        public static string ChristmasTree(int height)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < height; i++)
            {
                int count = 2 * i + 1;
                int max = 2 * (height - 1) + 1;
                int sider = (max - count) / 2;
                string unit = string.Concat(Enumerable.Range(1, count).Select(p => "*"));
                string res = unit.PadLeft(sider + count, ' ').PadRight(max, ' ');

                list.Add(res);
            }
            return string.Join("\n", list);
        }


        // Valid brackets, parentheses
        public static bool validBraces(string braces)
        {
            Stack<char> s = new Stack<char>();
            foreach (var c in braces)
            {
                if ("([{".Contains(c) == true)
                    s.Push(c);
                else if (")]}".Contains(c) == true)
                {
                    char value = '*';
                    bool pop = s.TryPop(out value);
                    if (pop == false)
                        return false;
                    if (value != c - 2 && value != c - 1)
                        return false;
                }
            }
            return s.Count() == 0 ? true : false;
        }


        // Replaces duplicate chars to ')', unique chars to '('
        public static string DuplicateEncode(string word)
        {
            var dict = word.ToLower().GroupBy(p => p).ToDictionary(key => key.Key, value => value.Count() > 1 ? ")" : "(");
            return string.Concat(word.ToLower().Select(p => dict[p]));
        }

        // Largest 5 digit number in a series
        public static int GetNumber(string str)
        {
            string str1 = "585988826913520113758731278518956108784329076030743842274461930896731132833866514787410492432238827929850190930795725337634970";
            int max = 0;
            for (int i = 0, n = str1.Length; i < n - 5; i++)
            {
                int temp = int.Parse(str1.Substring(i, 5));
                if (temp > max)
                    max = temp;
            }
            return max;
            return Enumerable.Range(0, str1.Length - 4).Select(i => int.Parse(str1.Substring(i, 5))).Max(p => p);
        }



        /* ************* */
        // Diagonal Strings
        public static string[] DiagonalsOfSquare(string[] array)
        {
            if (array.Length == 0 || array == null || array.Length != array[0].Length || array.Any(p => p.Length != array.Length))
                return null;

            int len = array.Length;
            string[] result = new string[len];
            StringBuilder sb = new StringBuilder();
            Dictionary<int, string> dict = new Dictionary<int, string>();

            for (int i = 0; i < len; i++)
                dict.Add(i, array[i]);
            int[] indexes = dict.OrderBy(p => p.Value).Select(p => p.Key).ToArray<int>();
            string str = string.Concat(dict.Values.OrderBy(p => p));

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                    sb.Append(str[(i * len + j * (len + 1)) % (str.Length)]);
                result[indexes[i]] = sb.ToString();
                sb.Clear();
            }
            return result;
        }


        public class comp : IComparer<string>
        {
            public int Compare([AllowNull] string x, [AllowNull] string y)
            {
                if (char.IsLetter(x[0]) && char.IsLetter(y[0]))
                    return string.Compare(x, y);
                else if (char.IsDigit(x[0]) && char.IsLetter(y[0]))
                    return 1;
                else if (char.IsLetter(x[0]) && char.IsDigit(y[0]))
                    return -1;
                else
                    return string.Compare(x, y);
            }
        }
        /* ************* */

        // Build Tower
        public static string[] TowerBuilder(int nFloors)
        {
            string[] res = new string[nFloors];
            int max = 2 * (nFloors - 1) + 1;
            for (int i = 0; i < nFloors; i++)
            {
                int num = 2 * i + 1;
                res[i] = string.Concat(Enumerable.Range(1, num).Select(p => "*"))
                               .PadLeft((max + num) / 2, ' ').PadRight(max, ' ');
            }
            return res;
        }


        // String brackers
        public static string StringBreakers(int n, string str)
        {
            Regex regex = new Regex(@"\s*");
            string temp = regex.Replace(str, "");
            int len = temp.Length;
            int sub = (int)Math.Floor((double)len / n);
            List<string> result = Enumerable.Range(0, sub).Select(p => temp.Substring(p * n, n)).ToList();
            if (sub * n < len)
                result.Add(temp.Substring(sub * n, len - sub * n));
            return string.Join("\n", result);
        }

        // Black Or White Sqare on the Cheese Board
        public static bool ChessBoardCellColor(string cell1, string cell2) => (cell1 + cell2).Sum(ch => ch) % 2 == 0;

        // Histogram - V1
        //Console.WriteLine(Histogram(new int[] { 10, 6, 5, 4, 12, 13 }));
        //Console.WriteLine(Histogram(new int[] { 7, 3, 10, 1, 0, 5 }));
        //var res = Histogram(new int[] { 0, 0, 0, 0, 0, 0 });
        // Console.WriteLine(Histogram(new int[] { 0,0,0,0,0,0 }));     
        public static string Histogram(int[] results)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = results.Max(); i >= 0; i--)
            {
                string b = i == 0 ? "  " : i >= 10 ? i.ToString() : i.ToString("# ");
                string temp =
                    $"{(i - results[0] == 0 ? b : i - results[0] > 0 ? "  " : "# ")}" +
                    $"{(i - results[1] == 0 ? b : i - results[1] > 0 ? "  " : "# ")}" +
                    $"{(i - results[2] == 0 ? b : i - results[2] > 0 ? "  " : "# ")}" +
                    $"{(i - results[3] == 0 ? b : i - results[3] > 0 ? "  " : "# ")}" +
                    $"{(i - results[4] == 0 ? b : i - results[4] > 0 ? "  " : "# ")}" +
                    $"{(i - results[5] == 0 ? b : i - results[5] > 0 ? " " : "#")}";
                if (temp.TrimEnd().Length != 0)
                    sb.AppendLine(temp.TrimEnd());
            }
            sb.AppendLine("-----------");
            sb.AppendLine("1 2 3 4 5 6");

            return sb.ToString();
        }

    }
}

