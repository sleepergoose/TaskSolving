using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TaskSolving.String;

namespace TaskSolving.Test.String
{
    public class TasksTest
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal("Right side wins!", Tasks.AlphabetWar("z"));
            Assert.Equal("Let's fight again!", Tasks.AlphabetWar("zdqmwpbs"));
            Assert.Equal("Right side wins!", Tasks.AlphabetWar("zzzzs"));
            Assert.Equal("Left side wins!", Tasks.AlphabetWar("wwwwwwz"));
        }
    }
}
