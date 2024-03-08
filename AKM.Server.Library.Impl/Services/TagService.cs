using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Library.Impl.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        public TagService(ITagRepository _tagRepository) => _tagRepository = _tagRepository;
    }
}
