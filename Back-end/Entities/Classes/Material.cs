using Entities.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Material : Item
    {
        public MaterialType materialType { get; set; }
        public int countOfMaterials { get; set; } = 1;

        public Material(string name, MaterialType materialType, int count, string desc)
        {
            id = Guid.NewGuid();
            this.name = name;
            this.materialType = materialType;
            countOfMaterials = count;
            description = desc;
        }

    }
}
