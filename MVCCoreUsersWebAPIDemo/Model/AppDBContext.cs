using Microsoft.EntityFrameworkCore;

namespace MVCCoreUsersWebAPIDemo.Model
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
        }
        public DbSet<User> Users { get; set; }


    }
}
