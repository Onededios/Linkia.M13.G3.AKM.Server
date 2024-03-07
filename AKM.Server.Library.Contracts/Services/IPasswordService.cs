using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Library.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Library.Contracts.Services
{
    public interface IPasswordService
    {
        Task<Password> GetPasswordAsync(Guid id);
        Task<List<Password>?> GetPasswordsByUserAsync(Guid userId);
        Task<bool> CreatePasswordAsync(CreatePasswordDTO passwordObj);
        Task<bool> UpdatePasswordAsync(UpdatePasswordDTO passwordObj);
    }
}
