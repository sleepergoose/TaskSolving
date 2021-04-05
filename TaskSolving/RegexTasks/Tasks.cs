using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskSolving.RegexTasks
{
    class Tasks
    {
        public static bool Alphanumeric(string str) => Regex.IsMatch(str, "^[a-zA-Z0-9]+$");
        // return str.All(c => Char.IsLetterOrDigit(c)) && !string.IsNullOrEmpty(str);
        // return str.Length > 0 && str.All(x => IsDigit(x) || IsLetter(x));


        // ROT13
        /* 
         public static string Rot13(string input) =>
         Regex.Replace(input, "[a-zA-Z]", new MatchEvaluator(c => ((char)(c.Value[0] + (Char.ToLower(c.Value[0]) >= 'n' ? -13 : 13))).ToString()));
         */

        public static string ToCamelCase(string str)
        {
            // The Best
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
            string temp = Regex.Replace(str, @"[_-]\w", ch => ch.ToString().ToUpper());
        }


        public static string BreakCamelCase1(string str) => new Regex("([A-Z])").Replace(str, " $1");


        public static string PigIt(string str)
        {
            return Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");
        }


        // Strip Comments
        public static string StripComments(string text, string[] commentSymbols)
        {
            Regex regex = new Regex(@$"\s*[{string.Join("", commentSymbols)}].*", RegexOptions.ECMAScript);
            return regex.Replace(text, string.Empty);
        }


        // Validate my Password
        public static string validator(string password)
        {
            var temp = Regex.Replace(password, @"[a-zA-Z0-9]", string.Empty);
            if (Regex.Replace(password, @"[a-zA-Z0-9]", string.Empty).Length != 0)
                return "INVALID";
            if (Regex.IsMatch(password, @"(?=^(.){4,19}$)(?=.*[a-zA-Z])(?=.*[0-9])"))
                return "VALID";
            return "INVALID";
        }
    }
}
