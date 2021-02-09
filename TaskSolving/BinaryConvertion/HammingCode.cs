using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskSolving.BinaryConvertion
{
    public static class HammingCode
    {
        public static string encode(string text)
        {
            var result = string.Join("", Encoding.ASCII.GetBytes(text)
                            .SelectMany(p => Convert.ToString(p, 2)
                            .PadLeft(8, '0')
                            .ToCharArray()
                            .Select(c => "".PadRight(3, c))));
            return result;
        }
        public static string decode(string bits)
        {
            string checked_str = "";
            for (int i = 0, k = bits.Length / 3; i < k; i++)
            {
                char[] temp = bits.ToCharArray(i * 3, 3);

                if (temp.Sum(p => (int)p) <= 145)
                    checked_str += "0";
                else if (temp.Sum(p => (int)p) >= 146)
                    checked_str += "1";
            }

            int n = checked_str.Length / 8;
            string[] bytes = new string[n];
            for (int i = 0; i < n; i++)
            {
                bytes[i] = checked_str.Substring(i * 8, 8);
            }

            string result = string.Concat(Encoding.ASCII.GetChars(bytes.Select(p => 
                                                                        Convert.ToByte(p, 2)).ToArray()));

            return result;
        }
    }
}
