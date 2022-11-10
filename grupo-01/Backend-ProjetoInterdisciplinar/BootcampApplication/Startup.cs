using Microsoft.EntityFrameworkCore;

namespace BootcampApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //PARA USAR SQL SERVER
            // services.AddDbContext<ApplicationDbContext>(options =>
            //  options.UseMySql(Configuration.GetConnectionString("LocalConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("SQLiteConnection")));
        }
    }
}