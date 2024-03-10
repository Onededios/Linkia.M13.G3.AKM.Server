using AKM.Server.Infrastructure.Contracts.Entities;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface IAppRepository
    {
        Task<App?> GetAppAsync(Guid id);
        Task<List<App>?> GetAllAppsAsync();
        Task<bool> CreateAppAsync(App app);
        Task<bool> UpdateAppAsync(App app);
    }
}
