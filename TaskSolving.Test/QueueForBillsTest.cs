using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TaskSolving.Other;
using System.Collections;

namespace TaskSolving.Test
{
    public class QueueForBillsTest
    {
        //[Theory]
        //[ClassData(typeof(ThereIsChangeDataClass))]
        public void ThereIsChange(int[] array)
        {
            // arrange

            // acts
            string actual = QueueForBills.ThereIsChange(array);

            // asserts
            Assert.Equal("YES", actual);
        }
    }

    class ThereIsChangeDataClass : IEnumerable<object[]>
    {
        IEnumerator<object[]> IEnumerable<object[]>.GetEnumerator()
        {
            yield return new object[] { new int[] { 25, 25, 50 } };
            yield return new object[] { new int[] { 25, 100 } };
            yield return new object[] { new int[] { 25, 25, 50, 50, 100 } };
        }
        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
