using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Infrastructure.Contracts.Entities
{
    public class App : Entity
    {
        public string name { get; set; }
        public string icon { get; set; }
    }
}
