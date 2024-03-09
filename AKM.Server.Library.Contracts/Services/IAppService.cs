using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Library.Contracts.DTOs;

namespace AKM.Server.Library.Contracts.Services
{
    public interface IAppService
    {
        Task<App?> GetAppAsync(Guid id);
        Task<List<App>?> GetAllAppsAsync();
        Task<bool> CreateAppAsync(AppCreateDTO dto);
        Task<bool> UpdateAppAsync(AppUpdateDTO dto);
    }
}
