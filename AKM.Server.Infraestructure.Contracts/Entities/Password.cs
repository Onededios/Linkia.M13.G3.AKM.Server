using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class Password : Entity
    {
        public Guid user { get; set; }
        public List<App> apps { get; set; }
        public List<Tag> tags { get; set; }
        public string password { get; set; }
        public DateTime date_creation { get; set; }
        public DateTime date_updated { get; set;}
        public DateTime date_expiration { get; set;}
    }
}
