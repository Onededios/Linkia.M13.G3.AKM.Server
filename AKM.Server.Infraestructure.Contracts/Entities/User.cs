﻿namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class User : Entity
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string country_code { get; set; }
        public string telephone { get; set; }
    }
}
