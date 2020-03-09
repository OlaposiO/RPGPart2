using System;
using System.Collections.Generic;
using System.Text;

namespace RPGPart2
{
    abstract class Character
    {
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Dex { get; set; }
        public int Intelligence { get; set; }
        public int Armor { get; set; }

        public Character(int hitPoints, int strength, int dex, int intelligence, int armor)
        {
            HitPoints = hitPoints;
            Strength = strength;
            Dex = dex;
            Intelligence = intelligence;
            Armor = armor;
        }
    }
}
