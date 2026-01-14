using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity.Modules
{
    public class EnergyModuleEntity : ModuleEntity
    {
        public List<Hero> heroList = new List<Hero>();
        public int horosMaxCount = 4;
        public int times = 60; // В секундах
    }
}
