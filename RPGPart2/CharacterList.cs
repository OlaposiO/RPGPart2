using System;
using System.Collections.Generic;
using System.Text;



namespace RPGPart2
{
    public class CharacterList
    {
        List<Character> heroes = new List<Character>(); // list of heros

        string name, job;
        int hitPoints, strength, dexterity, intelligence, armor;
        Arsenal weakenesMod = Arsenal.None;

        public void Name(string x)
        {
            name = x;
        }
        public void ChooseJob(int x) //precondition has to be one of these options, we must check the input before we pass the int into this method
        {
            if (x == 1)
            {
                heroes.Add(new Warrior(name, hitPoints, strength, dexterity, intelligence, armor, Arsenal.GreatSword, weakenesMod, true, true));
            }
            else if (x == 2)
            {
                heroes.Add(new Rouge(name, hitPoints, strength, dexterity, intelligence, armor, Arsenal.Dagger, weakenesMod, true, true));
            }
            else if (x == 3)
            {
                heroes.Add(new Mage(name, hitPoints, strength, dexterity, intelligence, armor, Arsenal.Staff, weakenesMod, true, true));
            }
        }

        public void StatRoll()
        {
            if (true)
            {



            }
        }

        public void ManualInput()
        {



        }
    }
}