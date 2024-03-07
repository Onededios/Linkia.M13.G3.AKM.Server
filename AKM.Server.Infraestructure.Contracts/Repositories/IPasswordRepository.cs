﻿using AKM.Server.Infrastructure.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
