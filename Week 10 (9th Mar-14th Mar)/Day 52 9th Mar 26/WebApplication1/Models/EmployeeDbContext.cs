using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeModel> employees { get; set; }
    }
}
