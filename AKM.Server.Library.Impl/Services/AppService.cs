using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;
using AKM.Server.Library.Impl.Helpers;

namespace AKM.Server.Library.Impl.Services
{
    public class AppService : IAppService
    {
        private readonly IAppRepository _appRepository;
        public AppService(IAppRepository appRepository) => _appRepository = appRepository;
        public async Task<App?> GetAppAsync(Guid id) => await _appRepository.GetAppAsync(id);
        public async Task<List<App>?> GetAllAppsAsync() => await _appRepository.GetAllAppsAsync();
        public async Task<bool> CreateAppAsync(AppCreateDTO dto)
        {
            if (dto.name == null) return false;
            try
            {
                var newApp = new App()
                {
                    id = Guid.NewGuid(),
                    name = dto.name,
                    icon = dto.icon
                };
                return await _appRepository.CreateAppAsync(newApp);
            }
            catch (Exception) { return false; }
        }

        public async Task<bool> UpdateAppAsync(AppUpdateDTO dto)
        {
            if (Validators.isValidUpdateDTO(dto)) return false;
            try
            {
                var existingApp = await _appRepository.GetAppAsync(Guid.Parse(dto.id));
                if (existingApp == null) return false;

                existingApp.name = dto.name != null ? dto.name : existingApp.name;
                existingApp.icon = dto.icon != null ? dto.icon : existingApp.icon;

                return await _appRepository.UpdateAppAsync(existingApp);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
