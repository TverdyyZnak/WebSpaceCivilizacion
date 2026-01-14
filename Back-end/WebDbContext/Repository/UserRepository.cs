using Entities.Classes;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebDbContext.DbEntity;

namespace WebDbContext.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<Guid> Create(User user)
        {
            var hPass = Convert.ToHexString(SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(user.hPassword)));
            var userEntity = new UserEntity
            {
                id = user.id,
                login = user.login,
                hPassword = user.hPassword,
                email = user.email,
                isAdmin = user.isAdmin
            };

            await _context.AddAsync(userEntity);
            await _context.SaveChangesAsync();

            return userEntity.id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.userDbSet.Where(u => u.id == id).ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var userEntity = await _context.userDbSet.AsNoTracking().ToListAsync();
            var users = userEntity.Select(u => User.CreateNewUser(u.id, u.login, u.hPassword, u.email, u.isAdmin).user).ToList();
            return users;
        }

        public async Task<User> GetById(Guid id)
        {
            var userEntity = await _context.userDbSet.AsNoTracking().ToListAsync();
            var users = userEntity.Select(u => User.CreateNewUser(u.id, u.login, u.hPassword, u.email, u.isAdmin).user).Where(u => u.id == id).ToList();
            return users[0];
        }

        public async Task<User> GetByLogin(string login)
        {
            var userEntity = await _context.userDbSet.AsNoTracking().ToListAsync();
            var users = userEntity.Select(u => User.CreateNewUser(u.id, u.login, u.hPassword, u.email, u.isAdmin).user).Where(u => u.login == login).ToList();
            return users[0];
        }

        public async Task<Guid> Update(Guid id, string login, string email, bool isAdmin)
        {
            await _context.userDbSet.Where(u => u.id == id).ExecuteUpdateAsync(s => s
                .SetProperty(u => u.login, u => login)
                .SetProperty(u => u.email, u => email)
                .SetProperty(u => u.isAdmin, u => isAdmin)
            );

            return id;
        }
    }
}
