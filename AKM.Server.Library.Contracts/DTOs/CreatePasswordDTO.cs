﻿using AKM.Server.Infrastructure.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Library.Contracts.DTOs
{
    public class CreatePasswordDTO
    {
        public required string user { get; set; }
        public required string password { get; set; }
        public string? expiracy_date { get; set; }
        public string? app { get; set; }
        public string? tag {  get; set; }
    }
}