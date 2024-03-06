using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts;
using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;

namespace AKM.Server.Library.Impl.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IPasswordRepository _passwordRepository;

        public PasswordService(IPasswordRepository passwordRepository) => _passwordRepository = passwordRepository;

        public async Task<Password?> GetPasswordAsync(Guid id) => await _passwordRepository.GetPasswordAsync(id);
        public async Task<List<Password>?> GetPasswordsByUserAsync(Guid userId) => await _passwordRepository.GetPasswordsByUserAsync(userId);
        public async Task<bool> CreatePasswordAsync(CreatePassword passwordObj)
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
                    date_expiration = passwordObj.expiracy_date != null ? DateTime.Parse(passwordObj.expiracy_date).ToUniversalTime() : null
                };
                return await _passwordRepository.CreatePasswordAsync(newPassword);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
