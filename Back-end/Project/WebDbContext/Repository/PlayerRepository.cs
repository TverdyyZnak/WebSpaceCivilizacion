using Entities.Classes;
using Entities.Enams;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDbContext.DbEntity;

namespace WebDbContext.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly AppDbContext _context;

        public PlayerRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<List<Player>> GetAllPlayers()
        {
            var playerEntities = await _context.playerDbSet.AsNoTracking().ToListAsync();
            var players = playerEntities.Select(p => Player.CreateNewPlayer(p.id, p.name, p.baseName, p.gameFraction, p.lvl, p.xp, p.money).player).ToList();

            return players;
        }

        public async Task<Player> GetPlayerById (Guid id)
        {
            var playerEntities = await _context.playerDbSet.AsNoTracking().ToListAsync();
            var player = playerEntities.Select(p => Player.CreateNewPlayer(p.id, p.name, p.baseName, p.gameFraction, p.lvl, p.xp, p.money).player).Where(p => p.id == id).ToList();

            return player[0];
        }

        public async Task<List<Player>> GetPlayersByFraction(GameFraction fraction)
        {
            var playerEntities = await _context.playerDbSet.AsNoTracking().ToListAsync();
            var player = playerEntities.Select(p => Player.CreateNewPlayer(p.id, p.name, p.baseName, p.gameFraction, p.lvl, p.xp, p.money).player).Where(p => p.gameFraction == fraction).ToList();

            return player;
        }

        public async Task<Guid> DeletePlayer(Guid id)
        {
            await _context.playerDbSet.Where(p => p.id == id).ExecuteDeleteAsync();

            return id;
        }

        public async Task<Guid> UpdatePlayer(Guid id, string name, string baseName, GameFraction fraction, int lvl, int xp, int money)
        {
            await _context.playerDbSet.Where(p => p.id == id).ExecuteUpdateAsync(s => s
                .SetProperty(p => p.name, p => name)
                .SetProperty(p => p.baseName, p => baseName)
                .SetProperty(p => p.gameFraction, p => fraction)
                .SetProperty(p => p.lvl, p => lvl)
                .SetProperty(p => p.xp, p => xp)
                .SetProperty(p => p.money, p => money)
            );

            return id;
        }

        public async Task<Guid> CreateNewPlayer(Player player)
        {
            var playerEntity = new PlayerEntity
            {
                id = player.id,
                name = player.name,
                baseName = player.baseName,
                gameFraction = player.gameFraction,
                lvl = player.lvl,
                xp = player.xp,
                money = player.money
            };

            await _context.playerDbSet.AddAsync(playerEntity);
            await _context.SaveChangesAsync();

            return playerEntity.id;
        }
    }
}
