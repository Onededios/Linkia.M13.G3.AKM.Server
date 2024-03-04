using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class PasswordRepository : EFRepository<Password>, IPasswordRepository
    {
        public PasswordRepository(DatabaseContext context) : base(context) { }
        //public async Task GetPasswords() => await DbSet.Select(x => new Password(x.user, x.apps, x.tags, x.password, x.date_creation, x.date_updated, x.date_expiration)).ToListAsync();
        public async Task<Password?> GetPasswordAsync(Guid id) => await GetById(id);
    }
}
