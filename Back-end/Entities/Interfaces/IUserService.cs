using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetById(int id);
        Task<User> GetByLogin(string login);
        Task<User> Create(User user);
        Task<User> Update(Guid id, string login, string email, bool isAdmin);
        Task<User> Delete(Guid id);
    }
}
