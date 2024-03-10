using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class TagRepository : EFRepository<Tag>, ITagRepository
    {
        public TagRepository(DatabaseContext context) : base(context) { }
        public async Task<Tag> GetTagAsync(Guid id) => await GetByIdAsync(id);
        public async Task<List<Tag>?> GetTagsByUserAsync(Guid id) => await GetMultipleByConditionAsync(t => t.id_user == id);
        public async Task<bool> CreateTagAsync(Tag tag) => await InsertAsync(tag);
        public async Task<bool> UpdateTagAsync(Tag tag) => await UpdateAsync(tag);
    }
}
