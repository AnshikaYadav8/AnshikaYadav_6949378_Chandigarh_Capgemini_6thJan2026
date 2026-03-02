using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterSystem
{
    internal class Character
    {
        public string Name { get; set; }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacks!");
        }

        public void LevelUp()
        {
            Console.WriteLine($"{Name} leveled up!");
        }
    }
}
