using Microsoft.EntityFrameworkCore;
using Departments.Data;

namespace Departments.Infrastracture.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
    }
}
