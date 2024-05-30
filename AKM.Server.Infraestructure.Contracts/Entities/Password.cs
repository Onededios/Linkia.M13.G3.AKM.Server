using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class Password : Entity
    {
        public string? alias { get; set; }
        [JsonIgnore]
        public Guid id_user { get; set; }
        public App? app { get; set; }
        public IEnumerable<Tag>? tags { get; set; }
        public string? username { get; set; }
        public string password { get; set; }
        public string? description { get; set; }
        public DateTime? date_expiration { get; set; }
    }
}
