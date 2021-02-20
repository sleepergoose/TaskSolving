using Xunit;
using tasks = TaskSolving.Linq;

namespace TaskSolving.Test.Level8th
{
    public class Tests
    {
        //[Fact]
        public void GrowTests()
        {
            Assert.Equal(6, TaskSolving.Linq.Level8th.Grow(new[] { 1, 2, 3 }));
            Assert.Equal(16, TaskSolving.Linq.Level8th.Grow(new[] { 4, 1, 1, 1, 4 }));
            Assert.Equal(64, TaskSolving.Linq.Level8th.Grow(new[] { 2, 2, 2, 2, 2, 2 }));
        }

        //[Fact]
        public void MapsTests()
        {
            Assert.Equal(new[] { 2, 4, 6 }, TaskSolving.Linq.Level8th.Maps(new[] { 1, 2, 3 }));
            Assert.Equal(new[] { 8, 2, 2, 2, 8 }, TaskSolving.Linq.Level8th.Maps(new[] { 4, 1, 1, 1, 4 }));
            Assert.Equal(new[] { 4, 4, 4, 4, 4, 4 }, TaskSolving.Linq.Level8th.Maps(new[] { 2, 2, 2, 2, 2, 2 }));
        }

        //[Fact]
        public static void RentalCarCostTest()
        {
            Assert.Equal(40, tasks.Level8th.RentalCarCost(1));
            Assert.Equal(100, tasks.Level8th.RentalCarCost(3));
            Assert.Equal(230, tasks.Level8th.RentalCarCost(7));
        }

        // [Fact]
        public void СenturyFromYearTest()
        {
            Assert.Equal(18, tasks.Level8th.СenturyFromYear(1705));
            Assert.Equal(19, tasks.Level8th.СenturyFromYear(1900));
            Assert.Equal(17, tasks.Level8th.СenturyFromYear(1601));
            Assert.Equal(20, tasks.Level8th.СenturyFromYear(2000));
            Assert.Equal(1, tasks.Level8th.СenturyFromYear(1));
            Assert.Equal(21, tasks.Level8th.СenturyFromYear(2001));
        }

        // [Fact]
        public void NitPickingTest()
        {
            Assert.Equal("pit nicking", tasks.Level8th.Spoonerize("nit picking"));
            Assert.Equal("bedding wells", tasks.Level8th.Spoonerize("wedding bells"));
            Assert.Equal("belly jeans", tasks.Level8th.Spoonerize("jelly beans"));
            Assert.Equal("cop porn", tasks.Level8th.Spoonerize("pop corn"));
        }

        // [Fact]
        public void Vowel2IndexTest()
        {
            Assert.Equal("th3s 6s my str15ng", tasks.Level8th.Vowel2Index("this is my string"));
            Assert.Equal("C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld", tasks.Level8th.Vowel2Index("Codewars is the best site in the world"));
            Assert.Equal("T2m4rr7w 10s g1415ng t20 b23 r2627n29ng", tasks.Level8th.Vowel2Index("Tomorrow is going to be raining"));
            Assert.Equal("", tasks.Level8th.Vowel2Index(""));
        }

        [Fact]
        public void SevenTest()
        {
            Assert.Equal(new long[] { 10, 2 }, tasks.Level8th.Seven(1021));
            Assert.Equal(new long[] { 7, 2 }, tasks.Level8th.Seven(1603));
            Assert.Equal(new long[] { 35, 1 }, tasks.Level8th.Seven(371));
            Assert.Equal(new long[] { 42, 1 }, tasks.Level8th.Seven(483));
        }
    }
}
