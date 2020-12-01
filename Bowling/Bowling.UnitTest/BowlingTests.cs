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

        [Fact]
        public void ReturnRestPins_Entering10_Return0()
        {
            var Round = new Round();

            int actual = Round.Roll(10);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void ReturnRestPins_Entering11_ThrowArgumentException()
        {
            var Round = new Round();

            Assert.Throws<ArgumentException>(() => Round.Roll(11));
        }

        [Fact]
        public void ReturnRestPins_EnteringMinus1_ThrowArgumentException()
        {
            var Round = new Round();

            Assert.Throws<ArgumentException>(() => Round.Roll(-1));
        }



    }
}
