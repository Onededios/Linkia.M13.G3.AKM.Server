using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Library.Contracts.DTOs
{
    public class SignInDTO
    {
        public required string username { get; set; }
        public required string password { get; set; }
    }
}
