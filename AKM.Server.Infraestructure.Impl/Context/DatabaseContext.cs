using AKM.Server.Infrastructure.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace AKM.Server.Infrastructure.Impl.Context
{
    public class DatabaseContext : DbContext
    {
        private readonly bool _isRelationalDb;
        private readonly IConfiguration _configuration;

        public DbSet<Password> passwords { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration, bool isRelationalDb = true)
        {
            _isRelationalDb = isRelationalDb;
            _configuration = configuration;
        }

        public bool IsRelationalDb => _isRelationalDb;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            if (_isRelationalDb)
            {
                var connectionString = _configuration.GetConnectionString("PostgreSQLConnection");
                optionsBuilder.UseNpgsql(connectionString);
            }
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}
