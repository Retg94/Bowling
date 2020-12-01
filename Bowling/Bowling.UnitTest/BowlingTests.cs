using System;
using Xunit;
using Library;

namespace Bowling.UnitTest
{
    public class BowlingTests
    {
        [Fact]
        public void ReturnRestPins_Entering1_Return9()
        {
            var Round = new Round();

            int actual = Round.Roll(1);

            Assert.Equal(9, actual);
        }
    }
}
