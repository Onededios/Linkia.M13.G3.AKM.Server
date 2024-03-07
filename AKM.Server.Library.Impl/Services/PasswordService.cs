using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;
using AKM.Server.Library.Impl.Helpers;

namespace AKM.Server.Library.Impl.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IPasswordRepository _passwordRepository;
        private readonly DateTime lastAvailableDate = DateTime.Parse("9999/12/31");

        public PasswordService(IPasswordRepository passwordRepository) => _passwordRepository = passwordRepository;

        public async Task<Password?> GetPasswordAsync(Guid id) => await _passwordRepository.GetPasswordAsync(id);
        public async Task<List<Password>?> GetPasswordsByUserAsync(Guid userId) => await _passwordRepository.GetPasswordsByUserAsync(userId);
        public async Task<bool> CreatePasswordAsync(CreatePasswordDTO passwordObj)
        {
            try
            {
                var newPassword = new Password()
                {
                    id = Guid.NewGuid(),
                    id_user = Guid.Parse(passwordObj.user),
                    id_app = passwordObj.app != null ? Guid.Parse(passwordObj.app) : null,
                    id_tag = passwordObj.app != null ? Guid.Parse(passwordObj.tag) : null,
                    password = passwordObj.password,
                    date_creation = DateTime.UtcNow,
                    date_updated = DateTime.UtcNow,
                    date_expiration = Helper.parseDate(passwordObj.expiracy_date)
                };
                return await _passwordRepository.CreatePasswordAsync(newPassword);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public async Task<bool> UpdatePasswordAsync(UpdatePasswordDTO passwordObj)
        {
            try
            {
                var existingPassword = await _passwordRepository.GetPasswordAsync(Guid.Parse(passwordObj.id));

                if (existingPassword == null) return false;

                existingPassword.id_app = passwordObj.app != null ? Guid.Parse(passwordObj.app) : existingPassword.id_app;
                existingPassword.id_tag = passwordObj.tag != null ? Guid.Parse(passwordObj.tag) : existingPassword.id_tag;
                existingPassword.password = passwordObj.password;
                existingPassword.date_updated = DateTime.UtcNow;
                existingPassword.date_expiration = Helper.parseDate(passwordObj.expiracy_date);

                return await _passwordRepository.UpdatePasswordAsync(existingPassword);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdatePasswordAsync: {ex.Message}");
                return false;
            }
        }

    }
}
