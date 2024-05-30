using AKM.Server.Infrastructure.Contracts.Entities;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<User?> SignInAsync(string username, string password);
        Task<bool> CreateUserAsync(User user);
        Task<bool> UpdateUserAsync(User user);
        Task<User?> GetUserAsync(Guid id);
        Task<bool> CheckUsernameAsync(string inp);
        Task<bool> CheckMailAsync(string inp);
    }
}
