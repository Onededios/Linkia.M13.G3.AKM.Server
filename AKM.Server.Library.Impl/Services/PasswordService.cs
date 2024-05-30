using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;
using AKM.Server.Library.Impl.Helpers;

namespace AKM.Server.Library.Impl.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IPasswordRepository _passwordRepository;
        private readonly IAppRepository _appRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITagRepository _tagRepository;
        public PasswordService(IPasswordRepository passwordRepository, IAppRepository appRepository, ITagRepository tagRepository, IUserRepository userRepository) 
        {
            _passwordRepository = passwordRepository;
            _appRepository = appRepository;
            _tagRepository = tagRepository;
            _userRepository = userRepository;
        }

        public async Task<Password?> GetPasswordAsync(Guid id) => await _passwordRepository.GetPasswordAsync(id);
        public async Task<List<Password>?> GetPasswordsByUserAsync(Guid id) => await _passwordRepository.GetPasswordsByUserAsync(id);
        public async Task<bool> CreatePasswordAsync(PasswordCreateDTO dto)
        {
            if (dto.password == null || dto.description == null) return false;
            try
            {
                var user = await _userRepository.GetUserAsync(dto.userId);
                if (user == null) return false;
                
                var app = dto.appId != null ? await _appRepository.GetAppAsync(dto.appId.GetValueOrDefault()) : null;
                
                var tagList = new List<Tag>();
                if (dto.tags != null)
                {
                    foreach (var tag in dto.tags) tagList.Append(await _tagRepository.GetTagAsync(tag));
                }

                var today = DateTime.UtcNow;

                var newPassword = new Password()
                {
                    id = Guid.NewGuid(),
                    id_user = user.id,
                    app = app,
                    username = dto.username,
                    alias = dto.alias,
                    tags = tagList,
                    password = dto.password,
                    description = dto.description,
                    date_expiration = today.AddMonths(1)
                };
                return await _passwordRepository.CreatePasswordAsync(newPassword);
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<bool> UpdatePasswordAsync(PasswordUpdateDTO dto)
        {
            if (Validators.isValidUpdateDTO(dto)) return false;
            try
            {
                var guid = dto.id.ToString();
                if (guid == null) return false;

                var existingPassword = await _passwordRepository.GetPasswordAsync(Guid.Parse(guid));

                if (existingPassword == null) return false;

                var app = dto.appId != null ? await _appRepository.GetAppAsync(dto.appId.GetValueOrDefault()) : null;

                var tagList = new List<Tag>();
                if (dto.tags != null)
                {
                    foreach (var tag in dto.tags) tagList.Append(await _tagRepository.GetTagAsync(tag));
                }

                existingPassword.tags = tagList;

                existingPassword.password = dto.password;
                existingPassword.username = dto.username;
                existingPassword.description = dto.description;
                existingPassword.date_expiration = Helper.parseDate(dto.date_expiration);

                return await _passwordRepository.UpdatePasswordAsync(existingPassword);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePasswordAsync(Guid id) => await _passwordRepository.DeletePasswordAsync(id);
    }
}
