using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.String
{
    public static class WhoLikesIt
    {
        public static string whoLikesIt(string[] names)
        {

            return names.Length switch
            {
                0 => "no one likes this",
                1 => $"{names[0]} likes this",
                2 => $"{names[0]} and {names[1]} like this",
                3 => $"{names[0]}, {names[1]} and {names[2]} like this",
                _ => $"{names[0]}, {names[1]} and {names.Length - 2} others like this"

            };

            if (names.Length == 0)
                return "no one likes this";
            else if (names.Length == 1)
                return $"{names[0]} likes this";
            else if (names.Length == 2)
                return $"{names[0]} and {names[1]} like this";
            else if (names.Length == 3)
                return $"{names[0]}, {names[1]} and {names[2]} like this";
            else
                return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
        }
    }
}


