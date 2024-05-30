using System.Text.Json.Serialization;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class Tag : Entity
    {
        public string name { get; set; }
        [JsonIgnore]
        public Guid id_user { get; set; }
        [JsonIgnore]
        public IEnumerable<Password>? passwords { get; set; }
    }
}
