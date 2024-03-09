namespace AKM.Server.Library.Contracts.DTOs
{
    public class AppUpdateDTO
    {
        public required string id { get; set; }
        public string? name { get; set; }
        public string? icon { get; set; }
    }
}
