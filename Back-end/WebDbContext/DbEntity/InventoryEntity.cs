using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity
{
    public class InventoryEntity
    {
        public Guid PlayerId { get; set; }
        public List<ItemEntity> Items = new List<ItemEntity>();
    }
}
