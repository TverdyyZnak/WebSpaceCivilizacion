using Entities.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity
{
    public class MaterialEntity : ItemEntity
    {
        public MaterialType materialType { get; set; }
        public int countOfMaterials { get; set; } = 1;
        public string itemType = "material";
    }
}
