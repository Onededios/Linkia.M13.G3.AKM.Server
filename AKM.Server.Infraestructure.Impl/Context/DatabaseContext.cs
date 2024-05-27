using AKM.Server.Infrastructure.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AKM.Server.Infrastructure.Impl.Context
{
    public class DatabaseContext : DbContext
    {
        private readonly bool _isRelationalDb;
        private readonly IConfiguration _configuration;

        public DbSet<Password> passwords { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<App> apps { get; set; }
        public DbSet<Tag> tags { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration, bool isRelationalDb = true) : base(options)
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
            optionsBuilder.LogTo(Console.WriteLine);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Password>()
                .HasMany(p => p.tagsInfo)
                .WithMany(t => t.passwords)
                .UsingEntity(
                    "passwords_has_tags",
                    r => r.HasOne(typeof(Tag)).WithMany().HasForeignKey("id_tag").HasPrincipalKey(nameof(Tag.id)),
                    l => l.HasOne(typeof(Password)).WithMany().HasForeignKey("id_password").HasPrincipalKey(nameof(Password.id)),
                    j => j.HasKey("id_password", "id_tag")
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
