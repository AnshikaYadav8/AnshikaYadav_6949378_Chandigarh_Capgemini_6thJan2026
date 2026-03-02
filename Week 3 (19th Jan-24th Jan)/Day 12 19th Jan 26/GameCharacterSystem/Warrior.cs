using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterSystem
{
    internal class Warrior: Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} swings a sword!");
        }
    }
}
