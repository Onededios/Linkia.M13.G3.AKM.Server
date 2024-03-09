using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class AppRepository : EFRepository<App>, IAppRepository
    {
        public AppRepository(DatabaseContext context) : base(context) { }
        public async Task<App?> GetAppAsync(Guid id) => await GetByIdAsync(id);
        public async Task<List<App>?> GetAllAppsAsync() => await GetAllAsync();
        public async Task<bool> CreateAppAsync(App app) => await InsertAsync(app);
        public async Task<bool> UpdateAppAsync(App app) => await UpdateAsync(app);
    }
}
