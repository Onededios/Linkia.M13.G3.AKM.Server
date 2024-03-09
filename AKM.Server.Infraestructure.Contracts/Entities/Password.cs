namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class Password : Entity
    {
        public Guid id { get; set; }
        public Guid id_user { get; set; }
        public Guid? id_app { get; set; }
        public string password { get; set; }
        public string description { get; set; }
        public DateTime? date_expiration { get; set; }
    }
}
