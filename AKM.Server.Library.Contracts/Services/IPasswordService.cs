using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Library.Contracts.DTOs;

namespace AKM.Server.Library.Contracts.Services
{
    public interface IPasswordService
    {
        Task<Password?> GetPasswordAsync(Guid id);
        Task<List<Password>?> GetPasswordsByUserAsync(Guid id);
        Task<bool> CreatePasswordAsync(PasswordCreateDTO dto);
        Task<bool> UpdatePasswordAsync(PasswordUpdateDTO dto);
        Task<bool> DeletePasswordAsync(Guid id);
    }
}
