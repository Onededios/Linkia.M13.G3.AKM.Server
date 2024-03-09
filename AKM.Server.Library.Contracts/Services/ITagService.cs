using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Library.Contracts.DTOs;

namespace AKM.Server.Library.Contracts.Services
{
    public interface ITagService
    {
        Task<Tag?> GetTagAsync(Guid id);
        Task<List<Tag>?> GetTagsByUserAsync(Guid id);
        Task<bool> CreateTagAsync(TagDTO dto);
        Task<bool> UpdateTagAsync(TagDTO dto);
    }
}
