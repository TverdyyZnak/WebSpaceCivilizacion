using Entities.Classes;
using Entities.Enams;

namespace Application.Services
{
    public interface IPlayerService
    {
        Task<Guid> CreateNewPlayer(Player player);
        Task<Guid> DeletePlayer(Guid id);
        Task<List<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(Guid id);
        Task<List<Player>> GetPlayersByFraction(GameFraction fraction);
        Task<Guid> UpdatePlayer(Guid id, string name, string baseName, GameFraction fraction, int lvl, int xp, int money);
    }
}