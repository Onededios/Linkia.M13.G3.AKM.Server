using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class PasswordRepository : EFRepository<Password>, IPasswordRepository
    {
        public PasswordRepository(DatabaseContext context) : base(context) { }
        public async Task<Password?> GetPasswordAsync(Guid id) => await GetById(id);
        public async Task<List<Password>?> GetPasswordsByUserAsync(Guid userId) => await GetByConditionAsync(p => p.id_user == userId);

        public async Task<bool> CreatePasswordAsync(Password password) => await InsertAsync(password);
    }
}