using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;

namespace AKM.Server.Library.Impl.Services
{
    public class SignService : ISignService
    {
        private readonly ISignRepository _signRepository;
        public SignService(ISignRepository signRepository) => _signRepository = signRepository;
        public async Task<User?> SignIn(SignInDTO signInObj)
        {
            var username = signInObj.username;
            var password = signInObj.password;
            if (username == null || password == null) return null;
            return await _signRepository.GetUserAsync(username, password);
        }

        public async Task<bool> SignUp(SignUpDTO signUpObj)
        {
            try
            {
                var newUser = new User()
                {
                    id = Guid.NewGuid(),
                    first_name = signUpObj.first_name,
                    last_name = signUpObj.last_name,
                    username = signUpObj.username,
                    password = signUpObj.password,
                    email = signUpObj.email,
                    telephone = signUpObj.telephone,
                    country_code = signUpObj.county_code
                };
                return await _signRepository.CreateUserAsync(newUser);
            }
            catch (Exception) { return false; }
        }
    }
}
