using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TaskSolving.BinaryConvertion;

namespace TaskSolving.Test
{
    public class BinaryConvertionTest
    {
        //[Fact]
        public void SampleTest()
        {
            Assert.Equal("10", TaskForBinary.EvensAndOdds(2));
            Assert.Equal("d", TaskForBinary.EvensAndOdds(13));
        }
    }
}
