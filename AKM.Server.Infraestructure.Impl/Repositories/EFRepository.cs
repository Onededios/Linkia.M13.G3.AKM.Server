using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;
using Microsoft.EntityFrameworkCore;

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

        public async Task<TEntity?> GetById(Guid id) => await DbSet.FindAsync(id); 
    }
}
