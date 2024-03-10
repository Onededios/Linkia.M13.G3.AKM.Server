namespace AKM.Server.Library.Contracts.DTOs
{
    public class UserSignUpDTO
    {
        public required string first_name { get; set; }
        public required string last_name { get; set; }
        public required string email { get; set; }
        public required string username { get; set; }
        public required string password { get; set; }
        public required string telephone { get; set; }
        public required string county_code { get; set; }
    }
}
