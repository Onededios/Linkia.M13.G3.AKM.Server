using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class TagRepository : EFRepository<Tag>, ITagRepository
    {
        public TagRepository(DatabaseContext context) : base(context) { }
    }
}
