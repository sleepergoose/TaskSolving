using System;
using System.Collections.Generic;
using System.Text;
using TaskSolving.String;
using Xunit;

namespace TaskSolving.Test.String
{
    public class FireBoatTest
    {
        // [Fact]
        public static void FireFightTest()
        {
            Assert.Equal("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast", FireBoat.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));
            Assert.Equal("Mast Deck Engine Water ~~", FireBoat.FireFight("Mast Deck Engine Water Fire"));
            Assert.Equal("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain", FireBoat.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
        }
    }
}
