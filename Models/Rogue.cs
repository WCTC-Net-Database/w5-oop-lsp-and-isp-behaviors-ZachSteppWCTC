using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Rogue : IEntity, IThievish
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} sneaks up to {target.Name} and attacks them.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves through the shadows undetected.");
        }

        public void StealFrom(IEntity target)
        {
            Console.WriteLine($"{Name} steals something from {target.Name} without them noticing.");
        }
    }
}
