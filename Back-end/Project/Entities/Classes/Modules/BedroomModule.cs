using Entities.Classes.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes.Modules
{
    public class BedroomModule : Module
    {
        public int addMaxHeros { get; }

        public BedroomModule(string name, string desc, int lvl = 1)
        {
            id = Guid.NewGuid();
            this.name = name;
            description = desc;
            this.lvl = lvl;
            addMaxHeros = lvl * 2;
        }
    }
}
