using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public abstract class EFRepository<TEntity> : IEFRepository<TEntity> where TEntity : Entity, new()
    {
        private readonly DatabaseContext _context;

        public DbSet<TEntity> DbSet { get; set; }

        protected EFRepository(DatabaseContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id) => await DbSet.FindAsync(id);
        public async Task<List<TEntity>?> GetAllAsync() => await DbSet.ToListAsync();
        public async Task<List<TEntity>?> GetMultipleByConditionAsync(Expression<Func<TEntity, bool>> condition) => await DbSet.Where(predicate: condition).ToListAsync();

        public async Task<TEntity> GetByConditionAsync(Expression<Func<TEntity, bool>> condition) => await DbSet.SingleOrDefaultAsync(predicate: condition);

        public async Task<bool> CheckAttrAsync(Expression<Func<TEntity, bool>> condition) => await DbSet.AnyAsync(predicate: condition);

        public async Task<bool> InsertAsync(TEntity entity)
        {
            try
            {
                await DbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in InsertAsync: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateAsync: {ex.Message}");
                return false;
            }
        }

        public async Task <bool> DeleteByIdAsync(Guid id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                if (entity == null) return false;

                DbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteByIdAsync: {ex.Message}");
                return false;
            }
        }
    }
}
