using AKM.Server.Infrastructure.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AKM.Server.Library.Contracts.DTOs
{
    public class SignUpDTO
    {
        public required string first_name {  get; set; }
        public required string last_name { get; set; }
        public required string email {  get; set; }
        public required string username {  get; set; }
        public required string password { get; set; }
        public required string telephone { get; set; }
        public required string county_code { get; set; }
    }
}
