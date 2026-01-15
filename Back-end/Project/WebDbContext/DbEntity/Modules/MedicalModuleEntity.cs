using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity.Modules
{
    public class MedicalModuleEntity : ModuleEntity
    {
        public List<HeroEntity> heroList { get; set; } = new List<HeroEntity>();
        public int herosMaxCount = 4;
        public int time = 120; //В секундах
    }
}
