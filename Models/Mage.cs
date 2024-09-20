using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Mage : IEntity, IFlyable, ICastable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a fireball.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies around on their broomstick.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} steps forward carefully.");
        }

        public void CastSpell(string spell, IEntity target)
        {
            Console.WriteLine($"{Name} casts {spell} on {target.Name}.");
        }
    }
}
