namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class Tag : Entity
    {
        public string name { get; set; }
        public Guid id_user { get; set; }
    }
}
