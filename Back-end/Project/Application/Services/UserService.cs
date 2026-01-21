using Application.Functions;
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
        private readonly JwtCreator _jwtCreator;

        public UserService(IUserRepository userRepository, JwtCreator jwtCreator)
        {
            _userRepository = userRepository;
            _jwtCreator = jwtCreator;
           
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<Guid> CreateUser(User user) //Регистрация
        {
            user.hPassword = HashPassword.CreateHashPass(user.hPassword);
            await _userRepository.Create(user);
            return user.id;
        }

        public async Task<string> Login(string login, string password)
        {
            var userInDb = await _userRepository.GetByLogin(login);
            if (userInDb == null)
            {
                return "Неверный логин или пароль";
            }

            if(HashPassword.VerifyPassword(password, userInDb.hPassword))
            {
                return _jwtCreator.CreateJwt(userInDb);
            }
            else
            {
                return "Неверный логин или пароль";
            }
            
        }


        public async Task<User> GetUserById(Guid id)
        {
            return await _userRepository.GetById(id);
        }
        public async Task<User?> GetUserByLogin(string login)
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
