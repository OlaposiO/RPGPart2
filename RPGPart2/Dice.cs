using System;
using System.Collections.Generic;
using System.Text;

namespace RPGPart2
{
    public class Dice
    {
        Random rand = new Random();
        public int D20()
        {
            return rand.Next(1, 21);
        }


        public int D8()
        {
            return rand.Next(1, 9);
        }

        public int D6()
        {
            return rand.Next(1, 7);
        }

        public int D4()
        {
            return rand.Next(1, 5);
        }
    }
}
