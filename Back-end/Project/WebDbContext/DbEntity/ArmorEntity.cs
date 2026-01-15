using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity
{
    public class ArmorEntity : ItemEntity
    {
        public int addHp { get; set; }
        public int minAgility { get; set; } = 1;
        public string itemType = "armor";
    }
}
