using Entities.Classes;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<Guid> CreateUser(User user)
        {
            await _userRepository.Create(user);
            return user.id;
        }
        public async Task<User> GetUserById(Guid id)
        {
            return await _userRepository.GetById(id);
        }
        public async Task<User> GetUserByLogin(string login)
        {
            return await _userRepository.GetByLogin(login);
        }
        public async Task<Guid> UpdateUser(Guid id, string login, string email, bool isAdmin)
        {
            await _userRepository.Update(id, login, email, isAdmin);
            return id;
        }
        public async Task<Guid> DeleteUser(Guid id)
        {
            await _userRepository.Delete(id);
            return id;
        }
    }
}
