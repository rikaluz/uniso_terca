using BootcampApplication.model;
using Microsoft.EntityFrameworkCore;

namespace BootcampApplication
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        // adicionar aq o dbSet para entidades dpss

        public DbSet<User> Users { get; set; }
        public DbSet<Bootcamp> Bootcamps { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
