using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDbContext.DbEntity.Modules;

namespace WebDbContext.Repository
{
    public class ModulesRepository
    {
        private readonly AppDbContext _context;

        public ModulesRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

    }
}
