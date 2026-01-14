using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDbContext.DbEntity.Modules;

namespace WebDbContext.DbEntity
{
    public class BaseEntity
    {
        public Guid id { get; set; }
        public Guid playerId { get; set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public List<HeroEntity> heroList = new List<HeroEntity>();
        public List<ModuleEntity> moduleList = new List<ModuleEntity>();
    }
}
