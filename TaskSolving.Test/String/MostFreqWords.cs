using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TaskSolving.Test.String
{
    public class MostFreqWords
    {
        [Fact]
        public void SampleTests()
        {
            Assert.Equal(new List<string> { "e", "d", "a" }, Program.Top3("a a a  b  c c  d d d d  e e e e e"));
            Assert.Equal(new List<string> { "e", "ddd", "aa" }, Program.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
            Assert.Equal(new List<string> { "won't", "wont" }, Program.Top3("  //wont won't won't "));
            Assert.Equal(new List<string> { "e" }, Program.Top3("  , e   .. "));
            Assert.Equal(new List<string> { }, Program.Top3("  ...  "));
            Assert.Equal(new List<string> { }, Program.Top3("  '  "));
            Assert.Equal(new List<string> { }, Program.Top3("  '''  "));
            Assert.Equal(new List<string> { "a", "of", "on" }, Program.Top3(
                string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                  "mind, there lived not long since one of those gentlemen that keep a lance",
                  "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                  "coursing. An olla of rather more beef than mutton, a salad on most",
                  "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                  "on Sundays, made away with three-quarters of his income." })));
        }
    }
}
