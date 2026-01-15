using Entities.Classes;
using Entities.Enams;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<List<Player>> GetAllPlayers()
        {
            return await _playerRepository.GetAllPlayers();
        }
        public async Task<Player> GetPlayerById(Guid id)
        {
            return await _playerRepository.GetPlayerById(id);
        }
        public async Task<List<Player>> GetPlayersByFraction(GameFraction fraction)
        {
            return await _playerRepository.GetPlayersByFraction(fraction);
        }
        public async Task<Guid> DeletePlayer(Guid id)
        {
            await _playerRepository.DeletePlayer(id);
            return id;
        }
        public async Task<Guid> UpdatePlayer(Guid id, string name, string baseName, GameFraction fraction, int lvl, int xp, int money)
        {
            await _playerRepository.UpdatePlayer(id, name, baseName, fraction, lvl, xp, money);
            return id;
        }
        public async Task<Guid> CreateNewPlayer(Player player)
        {
            await _playerRepository.CreateNewPlayer(player);
            return player.id;
        }
    }
}
