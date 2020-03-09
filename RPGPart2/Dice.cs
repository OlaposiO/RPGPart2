using System;
using System.Collections.Generic;
using System.Text;

namespace RPGPart2
{
    public class Dice
    {
        static Random rand = new Random();
        public static int D20()
        {
            return rand.Next(1, 21);
        }


        public static int D8()
        {
            return rand.Next(1, 9);
        }

        public static int D6()
        {

            return rand.Next(1, 7);
        }

        public static int D4()
        {
            return rand.Next(1, 5);
        }
    }
}
