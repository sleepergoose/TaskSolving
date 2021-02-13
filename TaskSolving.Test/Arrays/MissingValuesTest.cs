using System;
using System.Collections.Generic;
using System.Text;

using TaskSolving.Arrays;
using Xunit;

namespace TaskSolving.Test.Arrays
{
    public class MissingValuesTest
    {
        [Fact]
        public void ArrayMissingValuesTest()
        {
            Assert.Equal(18, MissingValues.ArrayMissingValues(new int[] { 1, 1, 1, 2, 2, 3 }));
            Assert.Equal(12096, MissingValues.ArrayMissingValues(new int[] { 96, 56, 24, 46, 75, 46, 75, 21, 46, 21, 75, 96, 56, 96, 56 }));
            Assert.Equal(28431, MissingValues.ArrayMissingValues(new int[] { 27, 65, 44, 39, 44, 21, 21, 44, 65, 39, 21, 65 }));
            Assert.Equal(18411, MissingValues.ArrayMissingValues(new int[] { 66, 4, 80, 66, 4, 83, 97, 81, 19, 4, 80, 51, 83, 81, 83, 66, 51, 80, 97, 81, 97 }));
            Assert.Equal(249704, MissingValues.ArrayMissingValues(new int[] { 60, 76, 86, 76, 86, 53, 60, 88, 71, 71, 71, 86, 88, 76, 88, 17, 60, 26, 17, 17, 26, 53, 98, 53 }));
            Assert.Equal(192375, MissingValues.ArrayMissingValues(new int[] { 42, 23, 45, 33, 33, 19, 42, 79, 79, 23, 95, 95, 79, 19, 42, 33, 19, 23 }));
            Assert.Equal(5915, MissingValues.ArrayMissingValues(new int[] { 4, 74, 41, 41, 41, 88, 63, 35, 35, 4, 88, 13, 63, 74, 63, 88, 4, 74 }));
        }
    }
}
