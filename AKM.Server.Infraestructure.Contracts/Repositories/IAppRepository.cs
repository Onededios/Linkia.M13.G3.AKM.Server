using AKM.Server.Infrastructure.Contracts.Entities;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface IAppRepository
    {
        Task<List<App>?> GetAllAppsAsync();
    }
}
