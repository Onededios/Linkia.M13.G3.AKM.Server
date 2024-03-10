using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;
using AKM.Server.Library.Impl.Helpers;

namespace AKM.Server.Library.Impl.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        public TagService(ITagRepository tagRepository) => _tagRepository = tagRepository;
        public async Task<Tag?> GetTagAsync(Guid id) => await _tagRepository.GetTagAsync(id);
        public async Task<List<Tag>?> GetTagsByUserAsync(Guid id) => await _tagRepository.GetTagsByUserAsync(id);
        public async Task<bool> CreateTagAsync(TagDTO dto)
        {
            if (dto.name == null || dto.id == null) return false;
            var userId = Guid.Parse(dto.id);
            try
            {
                var newTag = new Tag()
                {
                    id = Guid.NewGuid(),
                    name = dto.name,
                    id_user = userId
                };
                return await _tagRepository.CreateTagAsync(newTag);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateTagAsync(TagDTO dto)
        {
            if (Validators.isValidUpdateDTO(dto)) return false;
            var parsedId = Guid.Parse(dto.id);
            try
            {
                var existingTag = await _tagRepository.GetTagAsync(parsedId);
                if (existingTag == null) return false;

                existingTag.id = parsedId;
                existingTag.name = dto.name;

                return await _tagRepository.UpdateTagAsync(existingTag);
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
