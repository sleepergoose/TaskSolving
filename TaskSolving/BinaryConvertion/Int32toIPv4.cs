using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace TaskSolving.BinaryConvertion
{
    public static class Int32toIPv4
    {
        public static string GetIPv4(UInt32 number)
        {
            byte first = (byte)(number >> 24);
            byte second = (byte)(number >> 16);
            byte third = (byte)(number >> 8);
            byte fourth = (byte)(number & 0xFF);

            return $"{first}.{second}.{third}.{fourth}";

            // But there is another way:
           // System.Net.IPAddress iPAddress = new System.Net.IPAddress(32);

          //  return string.Join(".", iPAddress.ToString().Split(".").Reverse());

        }

        public static long IpsBetween(string start, string end)
        {
            // My solving
            int[] IP1 = start.Split(".").Select(p => int.Parse(p)).ToArray();
            long IP1Long = (IP1[0] << 24) | (IP1[1] << 16) | (IP1[2] << 8) | (IP1[3] & 0xFF);

            int[] IP2 = end.Split(".").Select(p => int.Parse(p)).ToArray();
            long IP2Long = (IP2[0] << 24) | (IP2[1] << 16) | (IP2[2] << 8) | (IP2[3] & 0xFF);

            return IP2Long - IP1Long;

            // From Codewars
            Func<string, long> func = (str) => str.Split(".").Reverse().Select((p, i) => Convert.ToInt64(p) << (8 * i)).Sum();
            return func(end) - func(start);

            return (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(end).Address) -
                (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(start).Address);
        }
    }
}
