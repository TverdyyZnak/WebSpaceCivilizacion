using Entities.Classes;
using Entities.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity.Modules
{
    public class BusterModuleEntity : ModuleEntity
    {
        public List<HeroEntity> heroList = new List<HeroEntity>();
        public int heroMaxCount = 2;
        public int time = 240; //В СЕКУНДАХ ПОТОМ ПОМЕНЯЯЯЯЙ
        public CharTypes charType;
    }
}
