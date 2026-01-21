using Entities.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDbContext.DbEntity;
using WebDbContext.DbEntity.Modules;

namespace WebDbContext.Repository
{
    public class BaseRepository
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<List<Base>> GetAllBases()
        {
            var basesEntities = await _context.baseEntityDbSet.AsNoTracking().ToListAsync();
            List<Base> bases = basesEntities.Select(b => Base.CreateNewBase(b.playerId, b.name, b.description).basePlayer).ToList();
            return bases;
        }

        
    }
}
