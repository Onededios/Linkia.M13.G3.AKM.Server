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

        public PasswordService(IPasswordRepository passwordRepository) => _passwordRepository = passwordRepository;
        public async Task<Password?> GetPasswordAsync(Guid id) => await _passwordRepository.GetPasswordAsync(id);
        public async Task<List<Password>?> GetPasswordsByUserAsync(Guid id) => await _passwordRepository.GetPasswordsByUserAsync(id);
        public async Task<bool> CreatePasswordAsync(PasswordCreateDTO dto)
        {
            if (dto.user == null || dto.password == null || dto.description == null) return false;
            try
            {
                var newPassword = new Password()
                {
                    id = Guid.NewGuid(),
                    id_user = Guid.Parse(dto.user),
                    id_app = dto.app != null ? Guid.Parse(dto.app) : null,
                    password = dto.password,
                    description = dto.description,
                    date_expiration = Helper.parseDate(dto.expiracy_date)
                };
                return await _passwordRepository.CreatePasswordAsync(newPassword);
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<bool> UpdatePasswordAsync(PasswordUpdateDTO dto)
        {
            if (Validators.isValidUpdateDTO(dto)) return false;
            try
            {
                var existingPassword = await _passwordRepository.GetPasswordAsync(Guid.Parse(dto.id));

                if (existingPassword == null) return false;

                existingPassword.id_app = dto.app != null ? Guid.Parse(dto.app) : existingPassword.id_app;
                existingPassword.password = dto.password;
                existingPassword.description = dto.description;
                existingPassword.date_expiration = Helper.parseDate(dto.expiracy_date);

                return await _passwordRepository.UpdatePasswordAsync(existingPassword);
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
