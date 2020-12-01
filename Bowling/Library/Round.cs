using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Round
    {
        private List<int> framePoints = new List<int>();
        public int Roll(int ballOne, int ballTwo)
        {
            int totalPins = ballOne + ballTwo;
            if (totalPins > 10 || totalPins < 0 || ballOne<0 || ballOne > 10 || ballTwo <0 || ballTwo > 10)
                throw new ArgumentException();

            int tmpFramePoint = totalPins;
            framePoints.Add(tmpFramePoint);
            return tmpFramePoint;
        }
    }
}
