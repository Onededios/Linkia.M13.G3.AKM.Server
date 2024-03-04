using AKM.Server.Infrastructure.Contracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface IEFRepository<TEntity> where TEntity : Entity
    {
        DbSet<TEntity> DbSet { get; set; }
        Task<TEntity?> GetById(Guid id);
    }
}
