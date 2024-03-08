using AKM.Server.Infrastructure.Contracts.Entities;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface IPasswordRepository
    {
        Task<Password?> GetPasswordAsync(Guid id);
        Task<List<Password>?> GetPasswordsByUserAsync(Guid userId);
        Task<bool> CreatePasswordAsync(Password password);
        Task<bool> UpdatePasswordAsync(Password password);
    }
}
