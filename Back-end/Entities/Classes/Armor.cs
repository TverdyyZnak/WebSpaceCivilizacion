using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Armor : Item
    {
        public int addHp { get; set; }
        public int minAgility { get; set; } = 1;
        public string itemType = "armor";

        public Armor(string name, int addHp, int minAgility, string desc)
        {
            id = Guid.NewGuid();
            this.name = name;
            this.addHp = addHp;
            this.minAgility = minAgility;
            description = desc;
        }
    }
}
