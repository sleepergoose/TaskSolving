using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            System.Net.IPAddress iPAddress = new System.Net.IPAddress(32);

            return string.Join(".", iPAddress.ToString().Split(".").Reverse());

        }
    }
}
