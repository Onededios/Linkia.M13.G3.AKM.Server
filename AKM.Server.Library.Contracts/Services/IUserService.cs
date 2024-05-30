using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Library.Contracts.DTOs;

namespace AKM.Server.Library.Contracts.Services
{
    public interface IUserService
    {
        Task<User?> SignInAsync(UserSignInDTO signInObj);
        Task<bool> SignUpAsync(UserSignUpDTO signUpObj);
        Task<bool> UpdateUserAsync(UserUpdateDTO userUpdateObj);
        Task<bool> SearchMailAsync(string inp);
        Task<bool> SearchUsernameAsync(string inp);
    }
}
