using Entities.Classes;
using Entities.Enams;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(Guid id);
        Task<List<Player>> GetPlayersByFraction(GameFraction fraction);
        Task<Guid> DeletePlayer(Guid id);
        Task<Guid> UpdatePlayer(Guid id, string name, string baseName, GameFraction fraction, int lvl, int xp, int money);
        Task<Guid> CreateNewPlayer(Player player);
    }
}
