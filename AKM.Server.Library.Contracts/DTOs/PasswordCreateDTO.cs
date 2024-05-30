using AKM.Server.Infrastructure.Contracts.Entities;

namespace AKM.Server.Library.Contracts.DTOs
{
    public class PasswordCreateDTO
    {
        public Guid userId {  get; set; }
        public string? alias { get; set; }
        public Guid? appId { get; set; }
        public string? username { get; set; }
        public string password { get; set; }
        public IEnumerable<Guid>? tags { get; set; }
        public string? description { get; set; }
    }
}
