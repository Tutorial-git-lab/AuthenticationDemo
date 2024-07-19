using AuthenticationDemo.Model;
using AuthenticationDemo.Module;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> states { get; set; }

        public DbSet<District> Districts { get; set; }

        
    }
}
