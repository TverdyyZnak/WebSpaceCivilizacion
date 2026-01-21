using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetById(Guid id);
        Task<User?> GetByLogin(string login);
        Task<Guid> Create(User user);
        Task<Guid> Update(Guid id, string login, string email, bool isAdmin);
        Task<Guid> Delete(Guid id);
    }
}
