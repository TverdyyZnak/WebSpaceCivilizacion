using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Weapon : Item
    {
        public int addDmg { get; set; }
        public int minStrong { get; set; } = 1;
        public string itemType = "weapon";

        public Weapon(string name, int addDmg, int minStrong, string desc)
        {
            id = Guid.NewGuid();
            this.name = name;
            this.addDmg = addDmg;
            this.minStrong = minStrong;
            description = desc;
        }
    }
}
