namespace AKM.Server.Library.Contracts.DTOs
{
    public class PasswordCreateDTO
    {
        public required string user { get; set; }
        public string? app { get; set; }
        public required string password { get; set; }
        public string? description { get; set; }
        public string? expiracy_date { get; set; }
    }
}
