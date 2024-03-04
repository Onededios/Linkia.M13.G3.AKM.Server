using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public abstract class Entity
    {
        public Guid id { get; set; }
        protected Entity() => id = Guid.NewGuid();
    }
}
