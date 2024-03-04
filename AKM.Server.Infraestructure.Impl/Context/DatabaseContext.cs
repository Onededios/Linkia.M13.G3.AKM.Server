using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Infrastructure.Impl.Context
{
    public class DatabaseContext : DbContext
    {
        private readonly bool _isRelationalDb = false;
        private readonly IConfiguration _configuration;

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration, bool isRelationalDb = true)
        {
            _isRelationalDb = isRelationalDb;
            _configuration = configuration;
        }
        public bool IsRelationalDb { get { return _isRelationalDb; } }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            if (_isRelationalDb)
            {
                var connectionString = _configuration.GetConnectionString("PostgreSQLConnection");
                optionsBuilder.LogTo(message => Debug.WriteLine(message));
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
