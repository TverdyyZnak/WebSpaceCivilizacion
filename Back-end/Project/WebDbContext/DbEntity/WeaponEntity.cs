using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity
{
    public class WeaponEntity : ItemEntity
    {
        public int addDmg { get; set; }
        public int minStrong { get; set; } = 1;
        public string itemType = "weapon";
    }
}
