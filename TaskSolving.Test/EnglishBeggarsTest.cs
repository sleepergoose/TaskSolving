using System;
using System.Collections.Generic;
using System.Text;

using TaskSolving.Other;
using Xunit;

namespace TaskSolving.Test
{
    public class EnglishBeggarsTest
    {
        //[Fact]
        public void EnglishBeggars1()
        {
            Assert.Equal(new int[] { 9, 6 }, TaskSolving.Other.EnglishBeggars.GotOffers(new int[] { 1, 2, 3, 4, 5 }, 2));
        }

        //[Fact]
        public void EnglishBeggars2()
        {
            Assert.Equal(new int[] { 5, 7, 3 }, TaskSolving.Other.EnglishBeggars.GotOffers(new int[] { 1, 2, 3, 4, 5 }, 3));
        }
    }
}
