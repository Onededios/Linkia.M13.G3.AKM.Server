using AKM.Server.Infrastructure.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AKM.Server.Infrastructure.Contracts.Repositories
{
    public interface IEFRepository<TEntity> where TEntity : Entity
    {
        DbSet<TEntity> DbSet { get; set; }
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<List<TEntity>?> GetMultipleByConditionAsync(Expression<Func<TEntity, bool>> condition);
        Task<TEntity> GetByConditionAsync(Expression<Func<TEntity, bool>> condition);
        Task<bool> InsertAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> CheckAttrAsync(Expression<Func<TEntity, bool>> condition);
    }
}
