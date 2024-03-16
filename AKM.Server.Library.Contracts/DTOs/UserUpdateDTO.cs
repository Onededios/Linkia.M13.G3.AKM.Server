namespace AKM.Server.Library.Contracts.DTOs
{
    public class UserUpdateDTO
    {
        public required string id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? email { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? telephone { get; set; }
        public string? country_code { get; set; }
    }
}
