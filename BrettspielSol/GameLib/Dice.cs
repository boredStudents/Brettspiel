using System;
using System.Collections.Generic;
using System.Text;

namespace GameLib
{
    public class Dice
    {
        private static Random rnd;

        public int Size { get; set; }

        public Dice(int Size)
        {
            this.Size = Size;
        }

        public int Roll()
        {
            return rnd.Next(0, Size);
        }

    }
}
