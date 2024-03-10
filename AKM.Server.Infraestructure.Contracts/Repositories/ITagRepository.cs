using AKM.Server.Infrastructure.Contracts.Entities;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface ITagRepository
    {
        Task<Tag> GetTagAsync(Guid id);
        Task<List<Tag>?> GetTagsByUserAsync(Guid id);
        Task<bool> CreateTagAsync(Tag tag);
        Task<bool> UpdateTagAsync(Tag tag);
    }
}
