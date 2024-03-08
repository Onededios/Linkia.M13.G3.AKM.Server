using AKM.Server.Infrastructure.Contracts.Entities;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface ISignRepository
    {
        Task<User?> GetUserAsync(string username, string password);
        Task<bool> CreateUserAsync(User user);
    }
}
