using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;
using Microsoft.EntityFrameworkCore;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class PasswordRepository : EFRepository<Password>, IPasswordRepository
    {
        public PasswordRepository(DatabaseContext context) : base(context) { }
        public async Task<Password?> GetPasswordAsync(Guid id)
        {
            return await DbSet
                .Include(p => p.app)
                .Include(p => p.tagsInfo)
                .FirstOrDefaultAsync(p => p.id == id);
        }
        public async Task<List<Password>?> GetPasswordsByUserAsync(Guid userId) 
        {
            return await DbSet.Where(p => p.id_user == userId)
                .Include(p => p.app)
                .Include(p => p.tagsInfo)
                .ToListAsync();
        }
        public async Task<bool> CreatePasswordAsync(Password password) => await InsertAsync(password);
        public async Task<bool> UpdatePasswordAsync(Password password) => await UpdateAsync(password);
    }
}