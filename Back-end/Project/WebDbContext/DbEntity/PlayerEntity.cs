using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity
{
    public class PlayerEntity
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string baseName { get; set; } = string.Empty;
        public Entities.Enams.GameFraction gameFraction { get; set; }
        public int lvl { get; set; } = 1;
        public int xp { get; set; } = 0;
        public int money { get; set; } = 0;
        public List<ItemEntity> items { get; set; } = new List<ItemEntity>();
    }
}
