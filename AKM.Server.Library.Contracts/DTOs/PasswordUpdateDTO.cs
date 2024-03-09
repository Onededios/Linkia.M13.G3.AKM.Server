namespace AKM.Server.Library.Contracts.DTOs
{
    public class PasswordUpdateDTO
    {
        public required string id { get; set; }
        public string? app { get; set; }
        public string? password { get; set; }
        public string? description { get; set; }
        public string? expiracy_date { get; set; }
    }
}
