using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GameCharacterSystem
{
    internal class Archer: Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} shoots an arrow!");
        }
    }
}
