using System;
using System.Collections.Generic;
using System.Text;

namespace RPGPart2
{
    class Warrior : Character

    {
        private string weapon;

        public string Weapon { get => weapon; set => weapon = value; }

        public Warrior(int hitPoints, int strength, int dex, int intelligence, int armor, string weapon)
            :base(hitPoints, strength, dex, intelligence, armor)
        {
            this.weapon = weapon;
        }
    }
}
