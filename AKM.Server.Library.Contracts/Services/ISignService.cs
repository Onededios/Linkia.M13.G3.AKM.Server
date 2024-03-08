using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Library.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Library.Contracts.Services
{
    public interface ISignService
    {
        Task<User?> SignIn(SignInDTO signInObj);
        Task<bool> SignUp(SignUpDTO signUpObj);
    }
}
