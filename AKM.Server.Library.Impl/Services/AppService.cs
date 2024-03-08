using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.Services;

namespace AKM.Server.Library.Impl.Services
{
    public class AppService : IAppService
    {
        private readonly IAppRepository _appRepository;
        public AppService(IAppRepository appRepository) => _appRepository = appRepository;
        public Task<List<App>?> GetAllAppsAsync() => _appRepository.GetAllAppsAsync();
    }
}
