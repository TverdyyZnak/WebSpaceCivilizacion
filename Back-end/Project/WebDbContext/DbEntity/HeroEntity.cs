using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity
{
    public class HeroEntity
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public int maxHp { get; set; } = 100;
        public int currentHp { get; set; }
        public int strong { get; set; } = 1;
        public int agility { get; set; } = 1;
        public int intelect { get; set; } = 1;
        public int charisma { get; set; } = 1;
        public bool isAlive { get; set; } = true; // Живой или мёртвый
        public bool inModule { get; set; } = false;
        public ArmorEntity? armor { get; set; }
        public WeaponEntity? weapon { get; set; }
    }
}
