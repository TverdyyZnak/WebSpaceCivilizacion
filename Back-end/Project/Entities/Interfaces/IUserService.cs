using Entities.Classes;

namespace Application.Services
{
    public interface IUserService
    {
        Task<Guid> CreateUser(User user);
        Task<Guid> DeleteUser(Guid id);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(Guid id);
        Task<User> GetUserByLogin(string login);
        Task<Guid> UpdateUser(Guid id, string login, string email, bool isAdmin);
    }
}