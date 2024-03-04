using AKM.Server.Infrastructure.Impl.Context;
using Microsoft.EntityFrameworkCore;

namespace AKM.Server.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddDbContext<DatabaseContext>((serviceProvider, options) =>
            {
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                options.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection"));
            });
        }
    }
}
