using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;

namespace AKM.Server.Library.Impl.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) => _userRepository = userRepository;
        public async Task<User?> SignInAsync(UserSignInDTO signInObj)
        {
            var username = signInObj.username;
            var password = signInObj.password;
            if (username == null || password == null) return null;
            return await _userRepository.SignInAsync(username, password);
        }

        public async Task<bool> SignUpAsync(UserSignUpDTO dto)
        {
            try
            {
                var newUser = new User()
                {
                    id = Guid.NewGuid(),
                    first_name = dto.first_name,
                    last_name = dto.last_name,
                    username = dto.username,
                    password = dto.password,
                    email = dto.email,
                    telephone = dto.telephone,
                    country_code = dto.county_code
                };
                return await _userRepository.CreateUserAsync(newUser);
            }
            catch (Exception) { return false; }
        }

        public async Task<bool> UpdateUserAsync(UserUpdateDTO dto)
        {
            if (dto.GetType().GetProperties().All(prop => prop.GetValue(dto) != null)) return false;
            try
            {
                var existingUser = await _userRepository.GetUserAsync(Guid.Parse(dto.id));
                if (existingUser == null) return false;
                existingUser.first_name = dto.first_name != null ? dto.first_name : existingUser.first_name;
                existingUser.last_name = dto.last_name != null ? dto.last_name : existingUser.last_name;
                existingUser.email = dto.email != null ? dto.email : existingUser.email;
                existingUser.password = dto.password != null ? dto.password : existingUser.password;
                existingUser.telephone = dto.telephone != null ? dto.telephone : existingUser.telephone;
                existingUser.country_code = dto.county_code != null ? dto.county_code : existingUser.country_code;

                return await _userRepository.UpdateUserAsync(existingUser);
            }
            catch (Exception) { return false; }
        }
    }
}
