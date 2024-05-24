using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleMonGame
{
    internal class Skill
    {
        public int damage = 10;
        public int energycost = 10;
        string name = "kip";

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energycost);
            target.TakeDamage(damage);
        }
    }

    
}
