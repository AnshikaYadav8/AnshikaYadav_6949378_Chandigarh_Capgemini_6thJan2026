using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterSystem
{
    internal class Mage: Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} casts a fireball!");
        }
    }
}
