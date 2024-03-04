using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts;
using AKM.Server.Library.Contracts.Services;

namespace AKM.Server.Library.Impl.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IPasswordRepository _passwordRepository;

        public PasswordService(IPasswordRepository passwordRepository) => _passwordRepository = passwordRepository;

        public async Task<Password> GetPasswordAsync(Guid id)
        {
            var password = await _passwordRepository.GetPasswordAsync(id);
            return password;
        }

    }
}
