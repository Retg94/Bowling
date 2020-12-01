using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Round
    {
        public int Roll(int pins)
        {
            if (pins > 10 || pins < 0)
                throw new ArgumentException();
            int restPins = 10 - pins;
            return restPins;
        }
    }
}
