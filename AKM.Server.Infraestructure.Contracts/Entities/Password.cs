using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class Password : Entity
    {
        public Guid id {  get; set; }
        [JsonIgnore]
        public Guid id_user { get; set; }
        [ForeignKey("id_app")]
        public App? app { get; set; }
        [NotMapped]
        public IEnumerable<string>? tags { get => tagsInfo?.Select(tag => tag.name); }
        [JsonIgnore]
        public IEnumerable<Tag>? tagsInfo { get; set; }
        public string password { get; set; }
        public string? description { get; set; }
        public DateTime? date_expiration { get; set; }
    }
}
