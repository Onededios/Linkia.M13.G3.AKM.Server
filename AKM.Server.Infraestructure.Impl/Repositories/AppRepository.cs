using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class AppRepository : EFRepository<App>, IAppRepository
    {
        public AppRepository(DatabaseContext context) : base(context) { }
        public async Task<List<App>?> GetAllAppsAsync() => await GetAllAsync();
    }
}
