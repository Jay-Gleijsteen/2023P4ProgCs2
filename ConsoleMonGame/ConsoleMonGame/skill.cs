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
        public int damage { get; set; }
        public int energycost { get; set; }
        public string name { get; set; }

        internal Element element;
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energycost);
            target.TakeDamage(damage);
            if (target.weakness == element)
            {
                target.TakeDamage(damage);
            }
        }
    }

    
}
