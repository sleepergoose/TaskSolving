using System;
using System.Collections.Generic;
using System.Text;
using TaskSolving.String;
using Xunit;

namespace TaskSolving.Test.String
{
    public class ScrambleTest
    {
        private static void testing(bool actual, bool expected)
        {
            Assert.Equal(expected, actual);
        }

        //[Fact]
        public static void test1()
        {
            testing(Scramblies.Scramble("rkqodlw", "world"), true);
            testing(Scramblies.Scramble("cedewaraaossoqqyt", "codewars"), true);
            testing(Scramblies.Scramble("katas", "steak"), false);
            testing(Scramblies.Scramble("scriptjavx", "javascript"), false);
            testing(Scramblies.Scramble("scriptingjava", "javascript"), true);
            testing(Scramblies.Scramble("scriptsjava", "javascripts"), true);
            testing(Scramblies.Scramble("javscripts", "javascript"), false);
            testing(Scramblies.Scramble("aabbcamaomsccdd", "commas"), true);
            testing(Scramblies.Scramble("commas", "commas"), true);
            testing(Scramblies.Scramble("sammoc", "commas"), true);

            testing(Scramblies.Scramble("c", "c"), true);
            testing(Scramblies.Scramble("", ""), true);
            testing(Scramblies.Scramble("", ""), false);
        }
    }
}
