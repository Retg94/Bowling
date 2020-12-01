using System;
using Xunit;
using Library;

namespace Bowling.UnitTest
{
    public class BowlingTests
    {
        [Fact]
        public void ReturnFramePoint_Entering1and1_Return2()
        {
            var Round = new Round();

            int actual = Round.Roll(1,1);

            Assert.Equal(2, actual);
        }

        [Fact]
        public void ReturnRestPins_Entering0and0_Return0()
        {
            var Round = new Round();

            int actual = Round.Roll(0,0);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void ReturnRestPins_Entering9and2_ThrowArgumentException()
        {
            var Round = new Round();

            Assert.Throws<ArgumentException>(() => Round.Roll(9,2));
        }

        [Fact]
        public void ReturnRestPins_EnteringMinusValues_ThrowArgumentException()
        {
            var Round = new Round();

            Assert.Throws<ArgumentException>(() => Round.Roll(-1, 2));
        }



    }
}
