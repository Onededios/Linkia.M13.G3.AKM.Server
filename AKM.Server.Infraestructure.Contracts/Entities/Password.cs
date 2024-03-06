using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class Password : Entity
    {
        public Guid id { get; set; }
        public Guid id_user { get; set; }
        public Guid? id_app { get; set; }
        public Guid? id_tag { get; set; }
        public string password { get; set; }
        public DateTime date_creation { get; set; }
        public DateTime date_updated { get; set;}
        public DateTime? date_expiration { get; set;}
    }
}
