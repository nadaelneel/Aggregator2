using Microsoft.EntityFrameworkCore;
using UserApp.Data;

namespace UserApp.Infrastracture.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}
